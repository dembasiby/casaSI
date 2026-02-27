namespace CasaEcologie.WinForms.Formulaires;

public partial class FrmAccueil : Form
{
    private readonly ServiceContainer _services;
    private readonly string _role;

    public FrmAccueil(ServiceContainer services, string role)
    {
        _services = services;
        _role = role;
        InitializeComponent();
    }

    private void AddControlsToPanel(Control c)
    {
        pnlPrincipal.Controls.Clear();
        c.Dock = DockStyle.Fill;
        pnlPrincipal.Controls.Add(c);
    }

    private bool SuperAdmin()
    {
        return _role == "super admin";
    }

    private void BtnPersonnel_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_Personnel(_services));
    }

    private void BtnNouvelleVente_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_NouvelleVente(_services));
    }

    private void BtnEtatsFinanciers_Click(object sender, EventArgs e)
    {
        // TODO: AddControlsToPanel(new Pages.UC_EtatsFinanciers(_services));
    }

    private void BtnAchatMatierePremiere_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_AchatMatierePremiere(_services));
    }

    private void BtnAcquisitionServicesFournitures_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_AcquisitionServicesFournitures(_services));
    }

    private void BtnAchatEquipementInfrastructure_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_AchatEquipementInfrastructure(_services));
    }

    private void BtnNouvelEncaissement_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_NouvelEncaissement(_services));
    }

    private void BtnNouveauDecaissement_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_NouveauDecaissement(_services));
    }

    private void BtnMouvementCAC_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_MouvementCompteACompte(_services));
    }

    private void BtnNouveauCompteTresorerie_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_NouveauCompteTresorerie(_services));
    }

    private void BtnAutreEncaissement_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_AutreEncaissementDeFonds(_services));
    }

    private void BtnReceptionDonMatierePremiere_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_ReceptionDonMatierePremiere(_services));
    }

    private void BtnSortieDechetsMatierePremiere_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_SortieDechetsMatierePremiere(_services));
    }

    private void BtnDechetsEtDonsProduitsFinis_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_DechetsEtDonsProduitsFinis(_services));
    }

    private void BtnTransvasage_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_Transvasage(_services));
    }

    private void BtnJournalVentes_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_JournalVentes(_services));
    }

    private void BtnJournalDepenses_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_JournalDepenses(_services));
    }

    private void BtnJournalApprovisionnements_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_JournalApprovisionnements(_services));
    }

    private void BtnJournalProduction_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_JournalProduction(_services));
    }

    private void BtnJournalTresorerie_Click(object sender, EventArgs e)
    {
        AddControlsToPanel(new Pages.UC_JournalTresorerie(_services));
    }

    private void BtnUtilisateurs_Click(object sender, EventArgs e)
    {
        if (!SuperAdmin())
        {
            MessageBox.Show("Vous n'avez pas accès à cette page.");
            return;
        }
        AddControlsToPanel(new Pages.UC_Utilisateurs(_services));
    }

    private void BtnQuitter_Click(object sender, EventArgs e)
    {
        Close();
    }
}
