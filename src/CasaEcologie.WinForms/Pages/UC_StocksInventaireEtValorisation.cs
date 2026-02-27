using System.Data;
using CasaEcologie.WinForms.Helpers;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_StocksInventaireEtValorisation : UserControl
{
    private readonly ServiceContainer _services;

    public UC_StocksInventaireEtValorisation(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_StocksInventaireEtValorisation_Load(object sender, EventArgs e)
    {
        AfficherTableaux();
    }

    private void DtpDate_ValueChanged(object sender, EventArgs e)
    {
        AfficherTableaux();
    }

    private void RbtnMatieresPremieres_CheckedChanged(object sender, EventArgs e)
    {
        AfficherTableauStockMatieresPremieres(dtpDate.Value.Date);
    }

    private void RbtnProduitsSemiFinis_CheckedChanged(object sender, EventArgs e)
    {
        AfficherTableauProduitsSemiFinis(dtpDate.Value.Date);
    }

    private void RbtnProduitsFinis_CheckedChanged(object sender, EventArgs e)
    {
        AfficherTableauProduitsFinis(dtpDate.Value.Date);
    }

    private void AfficherTableaux()
    {
        if (rbtnMatieresPremieres.Checked)
            AfficherTableauStockMatieresPremieres(dtpDate.Value.Date);
        else if (rbtnProduitsSemiFinis.Checked)
            AfficherTableauProduitsSemiFinis(dtpDate.Value.Date);
        else
            AfficherTableauProduitsFinis(dtpDate.Value.Date);

        AfficherLaValeurTotalDesStocks();
    }

    private void AfficherTableauStockMatieresPremieres(DateTime date)
    {
        var matieresPremieres = _services.Db.ResStockMatieresPremieres
            .OrderBy(mp => mp.NomMatiere)
            .Select(mp => mp.NomMatiere)
            .ToList();

        var dt = CreerTableau();

        foreach (var matiere in matieresPremieres)
        {
            var stock = _services.Stock.CalculerSoldeStockMatierePremiere(matiere, date);
            var coutU = _services.Stock.CalculerCoutUnitaireMatierePremiere(matiere);

            var dr = dt.NewRow();
            dt.Rows.Add(dr);
            dr["Description"] = matiere;
            dr["Stock"] = stock;
            dr["Coût unitaire"] = coutU;
            dr["Valeur"] = stock * coutU;
        }

        dgvTableauAffichageStocks.DataSource = dt;
        dt.Rows.Add("Total", 0, 0, DataTableHelper.CalculerTotal(dgvTableauAffichageStocks, "Valeur"));
        FormatterTableau(dgvTableauAffichageStocks);
    }

    private void AfficherTableauProduitsSemiFinis(DateTime date)
    {
        var produitsSemiFini = _services.Db.ResStockProduitsSemiFinis
            .OrderBy(psf => psf.Description)
            .Select(psf => psf.Description)
            .ToList();

        var dt = CreerTableau();

        foreach (var psf in produitsSemiFini)
        {
            var stock = _services.Stock.CalculerSoldeStockProduitSemiFini(psf, date);
            var pu = _services.Stock.CoutUnitaireParMatierePremiere(psf);

            var dr = dt.NewRow();
            dt.Rows.Add(dr);
            dr["Description"] = psf;
            dr["Stock"] = stock;
            dr["Coût unitaire"] = pu;
            dr["Valeur"] = stock * pu;
        }

        dgvTableauAffichageStocks.DataSource = dt;
        dt.Rows.Add("Total", 0, 0, DataTableHelper.CalculerTotal(dgvTableauAffichageStocks, "Valeur"));
        FormatterTableau(dgvTableauAffichageStocks);
    }

    private void AfficherTableauProduitsFinis(DateTime date)
    {
        var produitsFinis = _services.Db.ResStockProduitsFinis
            .OrderBy(pf => pf.NomProduit)
            .Select(pf => pf.NomProduit)
            .ToList();

        var dt = CreerTableau();

        foreach (var pf in produitsFinis)
        {
            var stock = _services.Stock.CalculerSoldeStockProduitFini(pf, date);
            var pu = _services.Stock.CoutUnitaireParMatierePremiere(pf);

            var dr = dt.NewRow();
            dt.Rows.Add(dr);
            dr["Description"] = pf;
            dr["Stock"] = stock;
            dr["Coût unitaire"] = pu;
            dr["Valeur"] = stock * pu;
        }

        dgvTableauAffichageStocks.DataSource = dt;
        dt.Rows.Add("Total", 0, 0, DataTableHelper.CalculerTotal(dgvTableauAffichageStocks, "Valeur"));
        FormatterTableau(dgvTableauAffichageStocks);
    }

    private static DataTable CreerTableau()
    {
        var dt = new DataTable();
        dt.Columns.Add("Description", typeof(string));
        dt.Columns.Add("Stock", typeof(float));
        dt.Columns.Add("Coût unitaire", typeof(float));
        dt.Columns.Add("Valeur", typeof(float));
        return dt;
    }

    private static void FormatterTableau(DataGridView grid)
    {
        if (grid.Columns.Contains("Stock"))
        {
            grid.Columns["Stock"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns["Stock"]!.DefaultCellStyle.Format = "N1";
        }
        if (grid.Columns.Contains("Coût unitaire"))
        {
            grid.Columns["Coût unitaire"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns["Coût unitaire"]!.DefaultCellStyle.Format = "N0";
        }
        if (grid.Columns.Contains("Valeur"))
        {
            grid.Columns["Valeur"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns["Valeur"]!.DefaultCellStyle.Format = "N0";
        }
    }

    private void AfficherLaValeurTotalDesStocks()
    {
        var date = dtpDate.Value.Date;
        txtStockMatieresPremieres.Text = _services.Cout.ValeurStockMatieresPremieres(date).ToString("N0") + " FCFA";
        txtStockProduitsSemiFinis.Text = _services.Cout.ValeurStockProduitsSemiFinis(date).ToString("N0") + " FCFA";
        txtStocksProduitsFinis.Text = _services.Cout.ValeurStockProduitsFinis(date).ToString("N0") + " FCFA";
        txtValeurTotaleStocks.Text = _services.Stock.ValeurTotalDesStocks(date).ToString("N0") + " FCFA";
    }
}
