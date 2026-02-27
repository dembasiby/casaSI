namespace CasaEcologie.WinForms.Pages;

public partial class UC_EtatsFinanciers : UserControl
{
    private readonly ServiceContainer _services;

    public UC_EtatsFinanciers(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_EtatsFinanciers_Load(object sender, EventArgs e)
    {
        // Ne pas afficher automatiquement au chargement
    }

    private void DtpDebut_ValueChanged(object sender, EventArgs e)
    {
        AfficherEtatsFinanciers();
    }

    private void DtpFin_ValueChanged(object sender, EventArgs e)
    {
        AfficherEtatsFinanciers();
    }

    private void AfficherEtatsFinanciers()
    {
        AfficherCompteDeResultat();
        AfficherTableauDeTresorerie();
        AfficherTableauBilan();
    }

    private void AfficherCompteDeResultat()
    {
        dgvCpteResultats.Rows.Clear();
        var data = _services.CompteDeResultat.GenererCompteDeResultat(dtpDebut.Value.Date, dtpFin.Value.Date);

        dgvCpteResultats.Rows.Add("Chiffre d'affaires", data.ChiffreDAffaires.ToString("N0"));
        dgvCpteResultats.Rows.Add("Coût des produits vendus", data.CoutDesProduitsVendus.ToString("N0"));
        dgvCpteResultats.Rows.Add("Marge brute", data.MargeBrute.ToString("N0"));
        dgvCpteResultats.Rows.Add("Autres revenus", data.AutresRevenus.ToString("N0"));
        dgvCpteResultats.Rows.Add("", "");
        dgvCpteResultats.Rows.Add("Salaires", data.Salaires.ToString("N0"));
        dgvCpteResultats.Rows.Add("Services extérieurs", data.ServicesExterieurs.ToString("N0"));
        dgvCpteResultats.Rows.Add("Fournitures", data.Fournitures.ToString("N0"));
        dgvCpteResultats.Rows.Add("Réparations et maintenance", data.ReparationsEtMaintenance.ToString("N0"));
        dgvCpteResultats.Rows.Add("Location", data.Location.ToString("N0"));
        dgvCpteResultats.Rows.Add("Téléphone et internet", data.TelephoneEtInternet.ToString("N0"));
        dgvCpteResultats.Rows.Add("Électricité et eau", data.ElectriciteEtEau.ToString("N0"));
        dgvCpteResultats.Rows.Add("Taxes", data.Taxes.ToString("N0"));
        dgvCpteResultats.Rows.Add("Intérêts payés", data.InteretsPayes.ToString("N0"));
        dgvCpteResultats.Rows.Add("Frais bancaires", data.FraisBancaires.ToString("N0"));
        dgvCpteResultats.Rows.Add("Autres transport", data.AutresTransport.ToString("N0"));
        dgvCpteResultats.Rows.Add("Amortissements", data.Amortissements.ToString("N0"));
        dgvCpteResultats.Rows.Add("Variation des stocks", data.VariationDesStocks.ToString("N0"));
        dgvCpteResultats.Rows.Add("Total charges", data.TotalCharges.ToString("N0"));
        dgvCpteResultats.Rows.Add("", "");
        dgvCpteResultats.Rows.Add("Résultat net", data.ResultatNet.ToString("N0"));
    }

    private void AfficherTableauDeTresorerie()
    {
        dgvTableauTresorerie.Rows.Clear();
        var data = _services.Tresorerie.GenererRapportTresorerie(dtpDebut.Value.Date, dtpFin.Value.Date);

        dgvTableauTresorerie.Rows.Add("Fonds disponibles en début de période", data.FondsDisponibleEnDebutDePeriode);
        dgvTableauTresorerie.Rows.Add("", "");
        dgvTableauTresorerie.Rows.Add("Ventes en cash", data.VentesEnCash);
        dgvTableauTresorerie.Rows.Add("Remboursement créances", data.RemboursementCreances);
        dgvTableauTresorerie.Rows.Add("Prêts et autres fonds reçus", data.PretsEtAutresFondsRecus);
        dgvTableauTresorerie.Rows.Add("Total recettes trésorerie", data.TotalRecettesTresorerie);
        dgvTableauTresorerie.Rows.Add("Total fonds disponibles", data.TotalFondsDisponibles);
        dgvTableauTresorerie.Rows.Add("", "");
        dgvTableauTresorerie.Rows.Add("Achat matières premières", data.AchatMatieresPremieres);
        dgvTableauTresorerie.Rows.Add("Achat emballages", data.AchatEmballages);
        dgvTableauTresorerie.Rows.Add("Salaires", data.Salaires);
        dgvTableauTresorerie.Rows.Add("Services extérieurs", data.ServicesExterieurs);
        dgvTableauTresorerie.Rows.Add("Fournitures", data.Fournitures);
        dgvTableauTresorerie.Rows.Add("Réparations et maintenance", data.ReparationsEtMaintenance);
        dgvTableauTresorerie.Rows.Add("Location", data.Location);
        dgvTableauTresorerie.Rows.Add("Téléphone et internet", data.TelephoneEtInternet);
        dgvTableauTresorerie.Rows.Add("Électricité et eau", data.ElectriciteEtEau);
        dgvTableauTresorerie.Rows.Add("Taxes", data.Taxes);
        dgvTableauTresorerie.Rows.Add("Intérêts payés", data.InteretsPayes);
        dgvTableauTresorerie.Rows.Add("Frais bancaires", data.FraisBancaires);
        dgvTableauTresorerie.Rows.Add("Autres transport", data.AutresTransport);
        dgvTableauTresorerie.Rows.Add("Sous-total dépenses", data.SousTotalDepenses);
        dgvTableauTresorerie.Rows.Add("Paiement principal", data.PaiementPrincipal);
        dgvTableauTresorerie.Rows.Add("Investissements de la période", data.InvestissementsDeLaPeriode);
        dgvTableauTresorerie.Rows.Add("Retrait des propriétaires", data.RetraitDesProprietaires);
        dgvTableauTresorerie.Rows.Add("Total dépenses trésorerie", data.TotalDepensesTresorerie);
        dgvTableauTresorerie.Rows.Add("", "");
        dgvTableauTresorerie.Rows.Add("Trésorerie disponible en fin de période", data.TresorerieDisponibleEnFinDePeriode);
    }

    private void AfficherTableauBilan()
    {
        dgvBilan.Rows.Clear();
        var data = _services.Bilan.GenererBilan(dtpDebut.Value.Date, dtpFin.Value.Date);

        dgvBilan.Rows.Add("ACTIF", "");
        dgvBilan.Rows.Add("Trésorerie", data.Tresorerie.ToString("N0"));
        dgvBilan.Rows.Add("Créances clients", data.CreancesClients.ToString("N0"));
        dgvBilan.Rows.Add("Stocks matières premières", data.StocksMatieresPremieres.ToString("N0"));
        dgvBilan.Rows.Add("Stocks produits finis", data.StocksProduitsFinis.ToString("N0"));
        dgvBilan.Rows.Add("Stocks produits semi-finis", data.StocksProduitsSemiFinis.ToString("N0"));
        dgvBilan.Rows.Add("Total stocks", data.TotalStocks.ToString("N0"));
        dgvBilan.Rows.Add("Total actif circulant", data.TotalActifCirculant.ToString("N0"));
        dgvBilan.Rows.Add("Immobilisations brutes", data.ImmobilisationsBrutes.ToString("N0"));
        dgvBilan.Rows.Add("Amortissements", data.Amortissements.ToString("N0"));
        dgvBilan.Rows.Add("Immobilisations nettes", data.ImmobilisationsNettes.ToString("N0"));
        dgvBilan.Rows.Add("Total actif", data.TotalActif.ToString("N0"));
        dgvBilan.Rows.Add("", "");
        dgvBilan.Rows.Add("PASSIF", "");
        dgvBilan.Rows.Add("Dettes fournisseurs", data.DettesFournisseurs.ToString("N0"));
        dgvBilan.Rows.Add("Autres dettes", data.AutresDettes.ToString("N0"));
        dgvBilan.Rows.Add("Total dettes", data.TotalDettes.ToString("N0"));
        dgvBilan.Rows.Add("Capital", data.Capital.ToString("N0"));
        dgvBilan.Rows.Add("Résultat net", data.ResultatNet.ToString("N0"));
        dgvBilan.Rows.Add("Total capitaux propres", data.TotalCapitauxPropres.ToString("N0"));
        dgvBilan.Rows.Add("Total passif", data.TotalPassif.ToString("N0"));
    }
}
