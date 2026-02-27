using System.Data;
using CasaEcologie.WinForms.Helpers;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_StockProduitsSemiFinis : UserControl
{
    private readonly ServiceContainer _services;

    public UC_StockProduitsSemiFinis(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_StockProduitsSemiFinis_Load(object sender, EventArgs e)
    {
        var listeProduitsSemiFinis = _services.Db.ResStockProduitsSemiFinis
            .Select(psf => psf.Description)
            .ToList();

        lbxListeProduitsSemiFinis.DataSource = listeProduitsSemiFinis;

        if (lbxListeProduitsSemiFinis.Items.Count > 0)
        {
            var description = lbxListeProduitsSemiFinis.GetItemText(lbxListeProduitsSemiFinis.SelectedItem);
            AfficherJournalCorrespondant(description);
        }
    }

    private void LbxListeProduitsSemiFinis_SelectedIndexChanged(object sender, EventArgs e)
    {
        var description = lbxListeProduitsSemiFinis.GetItemText(lbxListeProduitsSemiFinis.SelectedItem);
        AfficherJournalCorrespondant(description);
    }

    private void AfficherJournalCorrespondant(string description)
    {
        var entrees = (from psf in _services.Db.ResStockProduitsSemiFinis
                       where psf.Description == description
                       join ppsf in _services.Db.EveProductionProduitsSemiFinis on psf.CodeProduitSemiFini equals ppsf.CodeProduitSemiFini
                       join prod in _services.Db.EveProductions on ppsf.CodeProduction equals prod.CodeProduction
                       select new
                       {
                           prod.Date,
                           Description = "Production de " + psf.Description,
                           Entree = ppsf.QuantiteProduitSemiFini,
                           Sortie = 0d,
                           Solde = 0d
                       });

        var sorties = (from psf in _services.Db.ResStockProduitsSemiFinis
                       where psf.Description == description
                       join upsf in _services.Db.EveUtilisationProduitsSemiFinis on psf.CodeProduitSemiFini equals upsf.CodeProduitSemiFini
                       join prod in _services.Db.EveProductions on upsf.CodeUtilisationRessource equals prod.CodeUtilisationRessources
                       select new
                       {
                           prod.Date,
                           Description = "Utilisation de " + psf.Description,
                           Entree = 0d,
                           Sortie = upsf.QuantiteProduitSemiFini,
                           Solde = 0d
                       });

        var resultat = entrees.Concat(sorties)
            .OrderByDescending(d => d.Date)
            .ToList();

        var stockInitial = _services.Db.ResStockProduitsSemiFinis
            .Where(psf => psf.Description == description)
            .Select(psf => psf.Quantite)
            .FirstOrDefault();

        var dt = DataTableHelper.ConvertirEnTableDeDonnees(resultat);

        var dr = dt.NewRow();
        dt.Rows.InsertAt(dr, dt.Rows.Count);
        dr["Entree"] = 0;
        dr["Sortie"] = 0;
        dr["Description"] = "Stock initial";

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
