using CasaEcologie.Domain.Entities;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_AchatEquipementInfrastructure : UserControl
{
    private readonly ServiceContainer _services;

    public UC_AchatEquipementInfrastructure(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_AchatEquipementInfrastructure_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    private void LoadData()
    {
        cbxFournisseurImmo.DisplayMember = "NomAutreFournisseur";
        cbxFournisseurImmo.ValueMember = "CodeAutreFournisseur";
        cbxFournisseurImmo.DataSource = _services.Db.AgeAutreFournisseurs
            .OrderBy(af => af.NomAutreFournisseur).ToList();

        ChargerListeEmployes();

        cbxComptePaiement.DisplayMember = "NomCompte";
        cbxComptePaiement.ValueMember = "CodeCompte";
        cbxComptePaiement.DataSource = _services.Db.ResComptesTresoreries
            .OrderBy(ct => ct.NomCompte).ToList();

        AfficherSoldeTresorerie();
    }

    private void ChargerListeEmployes()
    {
        var employesPresents = ListeEmployesPresents(dtpAchatNouveauEqInf.Value.Date);
        var noms = employesPresents.OrderBy(em => em.PrenomNom).Select(em => em.PrenomNom).ToList();

        cbxRespImmo.DataSource = new List<string>(noms);
        cbxTresoriere.DataSource = new List<string>(noms);
    }

    private List<AgeEmploye> ListeEmployesPresents(DateTime date)
    {
        return _services.Db.EvePresenceEmployes
            .Where(pe => pe.Date == date)
            .Select(pe => pe.AgeEmploye)
            .ToList();
    }

    private void AfficherSoldeTresorerie()
    {
        if (cbxComptePaiement.SelectedItem is ResComptesTresorerie compte)
        {
            var solde = _services.Tresorerie.SoldeDisponibleDuCompteDeTresorerie(compte.NomCompte);
            txtSoldeCompte.Text = solde.ToString("N0");
        }
    }

    private void BtnNouveauFournisseurImmo_Click(object sender, EventArgs e)
    {
        try
        {
            var af = new AgeAutreFournisseur
            {
                NomAutreFournisseur = txtNouveauFournisseurImmo.Text,
                Localite = txtLocaliteFournisseurImmo.Text,
                SoldeInitialDetteFournisseur = int.Parse(txtSoldeInitialeDetteFournisseurImmo.Text)
            };

            _services.Db.AgeAutreFournisseurs.Add(af);
            _services.Db.SaveChanges();
            txtNouveauFournisseurImmo.Clear();
            txtLocaliteFournisseurImmo.Clear();
            txtSoldeInitialeDetteFournisseurImmo.Text = "00";
            MessageBox.Show("Une nouveau fournisseur d'équipement ou d'infrastructure a été ajoutée avec succès");
            LoadData();
        }
        catch (Exception)
        {
            MessageBox.Show("Veuillez vérifier les données à enregistrer.");
        }
    }

    private void BtnEqInfrExistant_Click(object sender, EventArgs e)
    {
        var valMontant = _services.Validation.VerifierChampsMontant(txtMontant2.Text);
        var valQuantite = _services.Validation.VerifierChampsMontant(txtQuantiteExistant.Text);

        if (valMontant.IsValid && valQuantite.IsValid)
        {
            var einfr = new ResEquipementsInfrastructure
            {
                Nom = txtNomEqInfr2.Text,
                DateAcquisition = dtpEquInfrExistant.Value.Date,
                DureeDeVie = int.Parse(txtDuree2.Text),
                Quantite = int.Parse(txtQuantiteExistant.Text),
                MaterielDeProduction = cbxUtilisePourProduction.Checked,
                Montant = int.Parse(txtMontant2.Text)
            };

            _services.Db.ResEquipementsInfrastructures.Add(einfr);
            _services.Db.SaveChanges();
            txtNomEqInfr2.Clear();
            txtDuree2.Clear();
            txtMontant2.Clear();
            txtQuantiteExistant.Clear();
            MessageBox.Show("Un équipement ou infrastructure existant a été ajouté avec succès");
        }
    }

    private void BtnEnregistrerAchatEquipementInfrastructure_Click(object sender, EventArgs e)
    {
        var afourIm = _services.Db.AgeAutreFournisseurs.FirstOrDefault(af => af.NomAutreFournisseur == cbxFournisseurImmo.Text);
        var emp = _services.Db.AgeEmployes.FirstOrDefault(em => em.PrenomNom == cbxRespImmo.Text);
        var tresoriere = _services.Db.AgeEmployes.FirstOrDefault(em => em.PrenomNom == cbxTresoriere.Text);
        var cpte = _services.Db.ResComptesTresoreries.FirstOrDefault(c => c.NomCompte == cbxComptePaiement.Text);

        if (afourIm == null || emp == null || tresoriere == null || cpte == null) return;

        var valMontant = _services.Validation.VerifierChampsMontant(txtMontant1.Text);
        var valQuantite = _services.Validation.VerifierChampsMontant(txtQuantite.Text);

        if (valMontant.IsValid && valQuantite.IsValid)
        {
            var einfr = new ResEquipementsInfrastructure
            {
                Nom = txtNomEqInfr1.Text,
                DateAcquisition = dtpAchatNouveauEqInf.Value.Date,
                DureeDeVie = int.Parse(txtDuree1.Text),
                MaterielDeProduction = cbxImmobilisationLieeAProduction.Checked,
                Montant = int.Parse(txtMontant1.Text),
                Quantite = int.Parse(txtQuantite.Text)
            };

            _services.Db.ResEquipementsInfrastructures.Add(einfr);
            _services.Db.SaveChanges();

            var reinfr = new EveReceptionEquipementsInfrastructure
            {
                CodeEquipementInfrastructure = einfr.CodeEquipementInfrastructure,
                CodeAutreFournisseur = afourIm.CodeAutreFournisseur,
                CodeEmploye = emp.CodeEmploye,
            };

            _services.Db.EveReceptionEquipementsInfrastructures.Add(reinfr);
            _services.Db.SaveChanges();

            int montantPaye = 0;
            int.TryParse(txtMontantPaye.Text, out montantPaye);

            if (montantPaye > 0)
            {
                if (_services.Tresorerie.IlYaAssezDeFondsDansLeCompte(cpte.NomCompte, montantPaye))
                {
                    var decaiss = new EveDecaissement
                    {
                        CodeReceptionEquipementInfrastructure = reinfr.CodeReceptionEquipementInfrastructure,
                        CodeAutreFournisseur = afourIm.CodeAutreFournisseur,
                        Description = "Acquisition de " + einfr.Nom,
                        DateDecaissement = einfr.DateAcquisition,
                        CodeEmploye = tresoriere.CodeEmploye,
                        CodeCompte = cpte.CodeCompte,
                        Montant = montantPaye,
                    };
                    _services.Db.EveDecaissements.Add(decaiss);
                    _services.Db.SaveChanges();
                }
            }

            MessageBox.Show("Le nouvel achat ou acquisition d'équipement ou d'infrastructure a été enregistré avec succès!");
            txtNomEqInfr1.Clear();
            txtDuree1.Clear();
            txtMontant1.Clear();
            txtQuantite.Text = "1";
            txtMontantPaye.Clear();
        }
    }

    private void CbxComptePaiement_SelectedIndexChanged(object sender, EventArgs e)
    {
        AfficherSoldeTresorerie();
    }

    private void DtpAchatNouveauEqInf_ValueChanged(object sender, EventArgs e)
    {
        ChargerListeEmployes();
    }
}
