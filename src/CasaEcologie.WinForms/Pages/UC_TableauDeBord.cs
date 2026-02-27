using System.Data;
using CasaEcologie.WinForms.Helpers;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_TableauDeBord : UserControl
{
    private readonly ServiceContainer _services;

    public UC_TableauDeBord(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_TableauDeBord_Load(object sender, EventArgs e)
    {
        AfficherTableaux();
    }

    private void DtpDebut_ValueChanged(object sender, EventArgs e)
    {
        AfficherTableaux();
    }

    private void DtpFin_ValueChanged(object sender, EventArgs e)
    {
        AfficherTableaux();
    }

    private void AfficherTableaux()
    {
        AfficherQuantiteAcheteeParMatierePremiere();
        AfficherTop10DesProduitsVendus();
        AfficherCadeauxEtValeur();
        AfficherTop10DesClients();
    }

    private void AfficherQuantiteAcheteeParMatierePremiere()
    {
        var debut = dtpDebut.Value.Date;
        var fin = dtpFin.Value.Date;

        var liste = (from rmp in _services.Db.EveReceptionMatieresPremieres
                     where rmp.DateReception >= debut && rmp.DateReception <= fin
                     group rmp by rmp.ResStockMatieresPremiere.NomMatiere into g
                     orderby g.Sum(r => r.Quantite) descending
                     select new
                     {
                         Matiere = g.Key,
                         Quantite = g.Sum(r => r.Quantite)
                     }).ToList();

        var dt = DataTableHelper.ConvertirEnTableDeDonnees(liste);
        dgvAchatsMP.DataSource = dt;
        FormatterDonneesTableau(dgvAchatsMP);
        if (dgvAchatsMP.Columns.Contains("Quantite"))
            dgvAchatsMP.Columns["Quantite"]!.HeaderText = "Quantité (kg)";
    }

    private void AfficherTop10DesProduitsVendus()
    {
        var debut = dtpDebut.Value.Date;
        var fin = dtpFin.Value.Date;

        var liste = (from vpf in _services.Db.EveVenteStockProduitsFinis
                     join v in _services.Db.EveVentes on vpf.CodeVente equals v.CodeVente
                     where v.DateVente >= debut && v.DateVente <= fin
                     group vpf by vpf.ResStockProduitsFini.NomProduit into g
                     orderby g.Sum(x => x.Montant) descending
                     select new
                     {
                         Produit = g.Key,
                         Ventes = g.Sum(x => x.Montant),
                         Quantite = g.Sum(x => x.QuantiteProduitFini)
                     })
                    .Take(10)
                    .ToList();

        var dt = DataTableHelper.ConvertirEnTableDeDonnees(liste);
        dgvProduitsLesPlusVendus.DataSource = dt;
        FormatterDonneesTableau(dgvProduitsLesPlusVendus);
        if (dgvProduitsLesPlusVendus.Columns.Contains("Quantite"))
            dgvProduitsLesPlusVendus.Columns["Quantite"]!.HeaderText = "Unités";
    }

    private void AfficherTop10DesClients()
    {
        var debut = dtpDebut.Value.Date;
        var fin = dtpFin.Value.Date;

        var liste = (from v in _services.Db.EveVentes
                     where v.DateVente >= debut && v.DateVente <= fin
                     join vpf in _services.Db.EveVenteStockProduitsFinis on v.CodeVente equals vpf.CodeVente
                     group vpf by new { v.AgeClient.NomClient, v.AgeClient.Localite } into g
                     orderby g.Sum(x => x.Montant) descending
                     select new
                     {
                         Clients = g.Key.NomClient + ", " + g.Key.Localite,
                         Ventes = g.Sum(x => x.Montant)
                     })
                    .Take(10)
                    .ToList();

        var dt = DataTableHelper.ConvertirEnTableDeDonnees(liste);
        dgvTop10Clients.DataSource = dt;
        FormatterDonneesTableau(dgvTop10Clients);
    }

    private void AfficherCadeauxEtValeur()
    {
        var debut = dtpDebut.Value.Date;
        var fin = dtpFin.Value.Date;

        var liste = (from don in _services.Db.EveSortieDonsOuDechetsProduitsFinis
                     where don.DateSortie >= debut && don.DateSortie <= fin
                     join pf in _services.Db.ResStockProduitsFinis on don.CodeProduitFini equals pf.CodeProduit
                     group new { don, pf } by pf.NomProduit into g
                     orderby g.Sum(x => x.don.QuantiteProduitFini) descending
                     select new
                     {
                         Produit = g.Key,
                         Quantite = g.Sum(x => x.don.QuantiteProduitFini),
                         Valeur = g.Sum(x => x.don.QuantiteProduitFini) * g.First().pf.PrixDeVenteStandard
                     }).ToList();

        if (liste.Count > 0)
        {
            var dt = DataTableHelper.ConvertirEnTableDeDonnees(liste);
            dgvCadeaux.DataSource = dt;
            FormatterDonneesTableau(dgvCadeaux);
            if (dgvCadeaux.Columns.Contains("Quantite"))
                dgvCadeaux.Columns["Quantite"]!.HeaderText = "Unités";
        }
        else
        {
            dgvCadeaux.DataSource = null;
        }
    }

    private static void FormatterDonneesTableau(DataGridView grid)
    {
        for (int i = 0; i < grid.Columns.Count; i++)
        {
            grid.Columns[i].DefaultCellStyle.Format = "N0";
            if (i > 0)
                grid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}
