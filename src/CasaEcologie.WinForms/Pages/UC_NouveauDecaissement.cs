using CasaEcologie.Domain.Entities;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_NouveauDecaissement : UserControl
{
    private readonly ServiceContainer _services;

    public UC_NouveauDecaissement(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_NouveauDecaissement_Load(object sender, EventArgs e)
    {
        try
        {
            cbxTypeFournisseur.SelectedIndex = 0;
            DefinirListeDesFournisseursAAfficher();
            ChargerListeEmployes();

            cbxCompte.DisplayMember = "NomCompte";
            cbxCompte.ValueMember = "CodeCompte";
            cbxCompte.DataSource = _services.Db.ResComptesTresoreries
                .OrderBy(ct => ct.NomCompte).ToList();

            AfficherSoldeTresorerie();
            AfficherDetteDuFournisseurSelectionne();
        }
        catch (Exception)
        {
            MessageBox.Show("Il n'y a pas de fournisseurs à qui nous devons de l'argent.");
        }
    }

    private void AfficherSoldeTresorerie()
    {
        if (cbxCompte.SelectedItem is ResComptesTresorerie compte)
        {
            var solde = _services.Tresorerie.SoldeDisponibleDuCompteDeTresorerie(compte.NomCompte);
            txtSoldeCompte.Text = solde.ToString("N0");
        }
    }

    private void ChargerListeEmployes()
    {
        var employesPresents = _services.Db.EvePresenceEmployes
            .Where(pe => pe.Date == dtpDateDecaissement.Value.Date)
            .Select(pe => pe.AgeEmploye)
            .OrderBy(em => em.PrenomNom)
            .Select(em => em.PrenomNom)
            .ToList();

        cbxTresoriere.DataSource = employesPresents;
    }

    private void DefinirListeDesFournisseursAAfficher()
    {
        if (cbxTypeFournisseur.Text == "Fournisseur de matière première")
        {
            cbxNomFournisseur.DisplayMember = "Nom";
            cbxNomFournisseur.ValueMember = "CodeFournisseurMatierePremiere";
            cbxNomFournisseur.DataSource = _services.Db.AgeFournisseursMatieresPremieres
                .OrderBy(f => f.Nom).ToList();
        }
        else if (cbxTypeFournisseur.Text == "Fournisseur d'équipement ou entrepreneur")
        {
            cbxNomFournisseur.DisplayMember = "NomAutreFournisseur";
            cbxNomFournisseur.ValueMember = "CodeAutreFournisseur";
            cbxNomFournisseur.DataSource = _services.Db.AgeAutreFournisseurs
                .OrderBy(f => f.NomAutreFournisseur).ToList();
        }
        else if (cbxTypeFournisseur.Text == "Fournisseur de services ou fournitures")
        {
            cbxNomFournisseur.DisplayMember = "NomFournisseurServiceFourniture";
            cbxNomFournisseur.ValueMember = "CodeFournisseurServiceFourniture";
            cbxNomFournisseur.DataSource = _services.Db.AgeFournisseursServicesFournitures
                .OrderBy(f => f.NomFournisseurServiceFourniture).ToList();
        }
    }

    private void AfficherDetteDuFournisseurSelectionne()
    {
        try
        {
            if (cbxNomFournisseur.SelectedValue != null)
            {
                int codeFournisseur = Convert.ToInt32(cbxNomFournisseur.SelectedValue);
                var dette = _services.Tresorerie.CalculerSoldeDetteParFournisseur(codeFournisseur);
                txtDetteFournisseur.Text = dette.ToString("N0");
            }
        }
        catch { }
    }

    private void BtnEnregistrerDecaissement_Click(object sender, EventArgs e)
    {
        var validation = _services.Validation.VerifierChampsMontant(txtMontantPaye.Text);
        if (!validation.IsValid)
        {
            MessageBox.Show(validation.ErrorMessage);
            return;
        }

        int montant = int.Parse(txtMontantPaye.Text);
        if (montant <= 0)
        {
            MessageBox.Show("Le montant doit être supérieur à zéro.");
            return;
        }

        if (cbxCompte.SelectedItem is not ResComptesTresorerie compte)
            return;

        if (!_services.Tresorerie.IlYaAssezDeFondsDansLeCompte(compte.NomCompte, montant))
        {
            MessageBox.Show("Le solde du compte est insuffisant.");
            return;
        }

        var em = _services.Db.AgeEmployes.First(emp => emp.PrenomNom == cbxTresoriere.Text);

        var decaiss = new EveDecaissement
        {
            DateDecaissement = dtpDateDecaissement.Value.Date,
            CodeEmploye = em.CodeEmploye,
            Montant = montant,
            CodeCompte = compte.CodeCompte,
        };

        if (cbxTypeFournisseur.Text == "Fournisseur de matière première")
        {
            var fournisseur = _services.Db.AgeFournisseursMatieresPremieres
                .First(f => f.Nom == cbxNomFournisseur.Text);
            decaiss.CodeFournisseurMatierePremiere = fournisseur.CodeFournisseurMatierePremiere;
            decaiss.Description = "Paiement dette fournisseur matière première";
        }
        else if (cbxTypeFournisseur.Text == "Fournisseur d'équipement ou entrepreneur")
        {
            var fournisseur = _services.Db.AgeAutreFournisseurs
                .First(f => f.NomAutreFournisseur == cbxNomFournisseur.Text);
            decaiss.CodeAutreFournisseur = fournisseur.CodeAutreFournisseur;
            decaiss.Description = "Paiement dette fournisseur équipements et infrastructures";
        }
        else if (cbxTypeFournisseur.Text == "Fournisseur de services ou fournitures")
        {
            var fournisseur = _services.Db.AgeFournisseursServicesFournitures
                .First(f => f.NomFournisseurServiceFourniture == cbxNomFournisseur.Text);
            decaiss.CodeFournisseurService = fournisseur.CodeFournisseurServiceFourniture;
            decaiss.Description = "Paiement dette fournisseur services et fournitures";
        }

        _services.Db.EveDecaissements.Add(decaiss);
        _services.Db.SaveChanges();

        MessageBox.Show("Le paiement du fournisseur a été effectué avec succès.");
        txtMontantPaye.Clear();
        AfficherSoldeTresorerie();
        AfficherDetteDuFournisseurSelectionne();
    }

    private void CbxCompte_SelectedIndexChanged(object sender, EventArgs e)
    {
        AfficherSoldeTresorerie();
    }

    private void CbxNomFournisseur_SelectedIndexChanged(object sender, EventArgs e)
    {
        AfficherDetteDuFournisseurSelectionne();
    }

    private void CbxTypeFournisseur_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DefinirListeDesFournisseursAAfficher();
            AfficherDetteDuFournisseurSelectionne();
        }
        catch (Exception)
        {
            MessageBox.Show("Il n'y a pas de fournisseurs à qui nous devons de l'argent pour cette catégorie.");
        }
    }

    private void DtpDateDecaissement_ValueChanged(object sender, EventArgs e)
    {
        ChargerListeEmployes();
    }
}
