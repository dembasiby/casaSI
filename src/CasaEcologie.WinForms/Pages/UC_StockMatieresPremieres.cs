using System.Data;
using CasaEcologie.WinForms.Helpers;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_StockMatieresPremieres : UserControl
{
    private readonly ServiceContainer _services;

    public UC_StockMatieresPremieres(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_StockMatieresPremieres_Load(object sender, EventArgs e)
    {
        lstMatieres.DataSource = _services.Db.ResStockMatieresPremieres.OrderBy(m => m.NomMatiere).ToList();
        lstMatieres.DisplayMember = "NomMatiere";
        lstMatieres.ValueMember = "NomMatiere";

        if (lstMatieres.Items.Count > 0)
        {
            var nomMatiere = lstMatieres.GetItemText(lstMatieres.SelectedItem);
            AfficherJournalCorrespondant(nomMatiere);
        }
    }

    private void LstMatieres_SelectedIndexChanged(object sender, EventArgs e)
    {
        var nomMatiere = lstMatieres.GetItemText(lstMatieres.SelectedItem);
        AfficherJournalCorrespondant(nomMatiere);
    }

    private void AfficherJournalCorrespondant(string nomMatiere)
    {
        var entreesAchat = (from mp in _services.Db.ResStockMatieresPremieres
                            from rmp in mp.EveReceptionMatieresPremieres
                            where mp.NomMatiere == nomMatiere
                            select new
                            {
                                Date = rmp.DateReception,
                                Description = "Achat de " + mp.NomMatiere,
                                Entree = (double)rmp.Quantite,
                                Sortie = 0d,
                                Solde = 0d,
                            });

        var entreesDon = (from mp in _services.Db.ResStockMatieresPremieres
                          from dmp in mp.EveReceptionDonsMatieresPremieres
                          where mp.NomMatiere == nomMatiere
                          select new
                          {
                              Date = dmp.DateReception,
                              Description = "Don de " + dmp.AgeFournisseursMatieresPremiere.Nom,
                              Entree = dmp.Quantite,
                              Sortie = 0d,
                              Solde = 0d
                          });

        var entreesTransvasage = (from str in _services.Db.EveTransvasements
                                  join mp in _services.Db.ResStockMatieresPremieres on str.CodeEmballageInitial equals mp.CodeMatierePremiere
                                  where mp.NomMatiere == nomMatiere
                                  select new
                                  {
                                      Date = str.DateOperation,
                                      Description = "Transvasage",
                                      Entree = str.QuantiteATransvaser,
                                      Sortie = 0d,
                                      Solde = 0d
                                  });

        var sortiesProduction = (from mp in _services.Db.ResStockMatieresPremieres
                                 from ump in mp.EveUtilisationMatieresPremieres
                                 join ur in _services.Db.EveUtilisationRessources on ump.CodeUtilisationRessource equals ur.CodeUtilisationRessources
                                 join p in _services.Db.EveProductions on ur.CodeUtilisationRessources equals p.CodeUtilisationRessources
                                 where mp.NomMatiere == nomMatiere
                                 select new
                                 {
                                     p.Date,
                                     Description = "Utilisation de " + mp.NomMatiere,
                                     Entree = 0d,
                                     Sortie = (double)ump.QuantiteMatierePremiere,
                                     Solde = 0d
                                 });

        var sortiesTransvasage = (from str in _services.Db.EveTransvasements
                                  join mp in _services.Db.ResStockMatieresPremieres on str.CodeEmballageFinal equals mp.CodeMatierePremiere
                                  where mp.NomMatiere == nomMatiere
                                  select new
                                  {
                                      Date = str.DateOperation,
                                      Description = "Transvasage",
                                      Entree = 0d,
                                      Sortie = str.QuantiteATransvaser,
                                      Solde = 0d
                                  });

        var sortiesAutre = (from mp in _services.Db.ResStockMatieresPremieres
                            from dmp in mp.EveSortieDechetsMatieresPremieres
                            where mp.NomMatiere == nomMatiere
                            select new
                            {
                                Date = dmp.DateSortie,
                                Description = "Perte de " + mp.NomMatiere,
                                Entree = 0d,
                                Sortie = dmp.QuantiteMatierePremiere,
                                Solde = 0d
                            });

        var resultats = entreesAchat
            .Concat(entreesDon)
            .Concat(entreesTransvasage)
            .Concat(sortiesProduction)
            .Concat(sortiesTransvasage)
            .Concat(sortiesAutre)
            .OrderByDescending(d => d.Date)
            .ToList();

        var stockInitial = _services.Db.ResStockMatieresPremieres
            .Where(mp => mp.NomMatiere == nomMatiere)
            .Select(mp => mp.StockMatiere)
            .FirstOrDefault();

        var dt = DataTableHelper.ConvertirEnTableDeDonnees(resultats);

        var dr = dt.NewRow();
        dt.Rows.InsertAt(dr, dt.Rows.Count);
        dr["Entree"] = 0;
        dr["Sortie"] = 0;
        dr["Description"] = "Stock Initial";

        dgvJournal.DataSource = dt;
        FormatterTableauStock(stockInitial);
    }

    private void FormatterTableauStock(double stockInitial)
    {
        FormatColumn("Entree", "N1");
        FormatColumn("Sortie", "N1");
        FormatColumn("Solde", "N1");
        dgvJournal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        if (dgvJournal.Columns.Contains("Description"))
            dgvJournal.Columns["Description"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        // Calculer solde progressif
        for (int i = dgvJournal.Rows.Count - 1; i >= 0; i--)
        {
            if (i < dgvJournal.Rows.Count - 1)
            {
                dgvJournal.Rows[i].Cells[4].Value =
                    Convert.ToDouble(dgvJournal.Rows[i + 1].Cells[4].Value)
                    + Convert.ToDouble(dgvJournal.Rows[i].Cells[2].Value)
                    - Convert.ToDouble(dgvJournal.Rows[i].Cells[3].Value);
            }
            else
            {
                dgvJournal.Rows[i].Cells[4].Value =
                    stockInitial
                    + Convert.ToDouble(dgvJournal.Rows[i].Cells[2].Value)
                    - Convert.ToDouble(dgvJournal.Rows[i].Cells[3].Value);
            }
        }

        if (dgvJournal.Columns.Contains("Entree"))
            dgvJournal.Columns["Entree"]!.HeaderText = "Entrée (kg)";
        if (dgvJournal.Columns.Contains("Sortie"))
            dgvJournal.Columns["Sortie"]!.HeaderText = "Sortie (kg)";
        if (dgvJournal.Columns.Contains("Solde"))
            dgvJournal.Columns["Solde"]!.HeaderText = "Solde (kg)";
    }

    private void FormatColumn(string column, string format)
    {
        if (dgvJournal.Columns.Contains(column))
            dgvJournal.Columns[column]!.DefaultCellStyle.Format = format;
    }
}
