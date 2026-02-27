using System.Data;
using CasaEcologie.WinForms.Helpers;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_StocksProduitsFinis : UserControl
{
    private readonly ServiceContainer _services;

    public UC_StocksProduitsFinis(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_StocksProduitsFinis_Load(object sender, EventArgs e)
    {
        var liste = _services.Db.ResStockProduitsFinis
            .OrderBy(p => p.NomProduit)
            .Select(p => p.NomProduit)
            .ToList();
        lbxListeProduitsFinis.DataSource = liste;

        if (lbxListeProduitsFinis.Items.Count > 0)
            AfficherJournal();
    }

    private void LbxListeProduitsFinis_SelectedIndexChanged(object sender, EventArgs e)
    {
        AfficherJournal();
    }

    private void AfficherJournal()
    {
        var nomProduit = lbxListeProduitsFinis.GetItemText(lbxListeProduitsFinis.SelectedItem);
        lblNomProduit.Text = $"( {nomProduit} )";
        AfficherJournalCorrespondant(nomProduit);
    }

    private void AfficherJournalCorrespondant(string nomProduit)
    {
        var stockInitial = _services.Db.ResStockProduitsFinis
            .Where(pf => pf.NomProduit == nomProduit)
            .Select(pf => pf.StockProduit)
            .FirstOrDefault();

        var entrees = (from pf in _services.Db.ResStockProduitsFinis
                       join ppf in _services.Db.EveProductionStockProduitsFinis on pf.CodeProduit equals ppf.CodeProduitFini
                       join prod in _services.Db.EveProductions on ppf.CodeProduction equals prod.CodeProduction
                       where pf.NomProduit == nomProduit
                       select new
                       {
                           prod.Date,
                           Description = "Production",
                           Entree = ppf.QuantiteProduitFini,
                           Sortie = 0,
                           Solde = 0
                       });

        var entreesTransvasage = (from etrv in _services.Db.EveTransvasements
                                  join pf in _services.Db.ResStockProduitsFinis on etrv.CodeProduitFinal equals pf.CodeProduit
                                  where pf.NomProduit == nomProduit
                                  select new
                                  {
                                      Date = etrv.DateOperation,
                                      Description = "Transvasage",
                                      Entree = (int)etrv.QuantiteATransvaser,
                                      Sortie = 0,
                                      Solde = 0
                                  });

        var sorties = (from pf in _services.Db.ResStockProduitsFinis
                       join vpf in _services.Db.EveVenteStockProduitsFinis on pf.CodeProduit equals vpf.CodeProduitFini
                       join v in _services.Db.EveVentes on vpf.CodeVente equals v.CodeVente
                       where pf.NomProduit == nomProduit
                       select new
                       {
                           Date = v.DateVente,
                           Description = "Vente",
                           Entree = 0,
                           Sortie = vpf.QuantiteProduitFini,
                           Solde = 0
                       });

        var sortiesTransvasage = (from etrv in _services.Db.EveTransvasements
                                  join pf in _services.Db.ResStockProduitsFinis on etrv.CodeProduitInitial equals pf.CodeProduit
                                  where pf.NomProduit == nomProduit
                                  select new
                                  {
                                      Date = etrv.DateOperation,
                                      Description = "Transvasage",
                                      Entree = 0,
                                      Sortie = (int)etrv.QuantiteATransvaser,
                                      Solde = 0
                                  });

        var sortiesDonsDechets = (from sdd in _services.Db.EveSortieDonsOuDechetsProduitsFinis
                                  join pf in _services.Db.ResStockProduitsFinis on sdd.CodeProduitFini equals pf.CodeProduit
                                  where pf.NomProduit == nomProduit
                                  select new
                                  {
                                      Date = sdd.DateSortie,
                                      sdd.Description,
                                      Entree = 0,
                                      Sortie = (int)sdd.QuantiteProduitFini,
                                      Solde = 0
                                  });

        var resultat = entrees
            .Concat(entreesTransvasage)
            .Concat(sorties)
            .Concat(sortiesTransvasage)
            .Concat(sortiesDonsDechets)
            .OrderByDescending(d => d.Date)
            .ToList();

        var dt = DataTableHelper.ConvertirEnTableDeDonnees(resultat);

        var dr = dt.NewRow();
        dt.Rows.InsertAt(dr, dt.Rows.Count);
        dr["Entree"] = 0;
        dr["Sortie"] = 0;
        dr["Description"] = "Stock initial";

        dgvJournal.DataSource = dt;
        FormatterTableauStock(stockInitial);
    }

    private void FormatterTableauStock(int stockInitial)
    {
        FormatColumn("Entree", "N0");
        FormatColumn("Sortie", "N0");
        FormatColumn("Solde", "N0");
        dgvJournal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        if (dgvJournal.Columns.Contains("Description"))
            dgvJournal.Columns["Description"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        for (int i = dgvJournal.Rows.Count - 1; i >= 0; i--)
        {
            if (i < dgvJournal.Rows.Count - 1)
            {
                dgvJournal.Rows[i].Cells[4].Value =
                    Convert.ToInt32(dgvJournal.Rows[i + 1].Cells[4].Value)
                    + Convert.ToInt32(dgvJournal.Rows[i].Cells[2].Value)
                    - Convert.ToInt32(dgvJournal.Rows[i].Cells[3].Value);
            }
            else
            {
                dgvJournal.Rows[i].Cells[4].Value =
                    stockInitial
                    + Convert.ToInt32(dgvJournal.Rows[i].Cells[2].Value)
                    - Convert.ToInt32(dgvJournal.Rows[i].Cells[3].Value);
            }
        }

        if (dgvJournal.Columns.Contains("Entree"))
            dgvJournal.Columns["Entree"]!.HeaderText = "Entrée (unité)";
        if (dgvJournal.Columns.Contains("Sortie"))
            dgvJournal.Columns["Sortie"]!.HeaderText = "Sortie (unité)";
        if (dgvJournal.Columns.Contains("Solde"))
            dgvJournal.Columns["Solde"]!.HeaderText = "Solde (unité)";
    }

    private void FormatColumn(string column, string format)
    {
        if (dgvJournal.Columns.Contains(column))
            dgvJournal.Columns[column]!.DefaultCellStyle.Format = format;
    }
}
