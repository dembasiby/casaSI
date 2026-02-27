using CasaEcologie.Domain.Entities;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_AchatMatierePremiere : UserControl
{
    private readonly ServiceContainer _services;

    public UC_AchatMatierePremiere(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_AchatMatierePremiere_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    private void LoadData()
    {
        cbxFournisseurMPrem.DisplayMember = "Nom";
        cbxFournisseurMPrem.ValueMember = "CodeFournisseurMatierePremiere";
        cbxFournisseurMPrem.DataSource = _services.Db.AgeFournisseursMatieresPremieres
            .OrderBy(f => f.Nom).ToList();

        cbxNomMatierePremiere.DisplayMember = "NomMatiere";
        cbxNomMatierePremiere.ValueMember = "CodeMatierePremiere";
        cbxNomMatierePremiere.DataSource = _services.Db.ResStockMatieresPremieres
            .OrderBy(m => m.NomMatiere).ToList();

        ChargerListeEmployes();

        cbxComptePaiement.DisplayMember = "NomCompte";
        cbxComptePaiement.ValueMember = "CodeCompte";
        cbxComptePaiement.DataSource = _services.Db.ResComptesTresoreries
            .OrderBy(ct => ct.NomCompte).ToList();

        cbxTypesMatieres.DisplayMember = "NomType";
        cbxTypesMatieres.ValueMember = "CodeTypeMatiere";
        cbxTypesMatieres.DataSource = _services.Db.TypesMatieres
            .OrderBy(tm => tm.NomType).ToList();

        AfficherSoldeTresorerie();
    }

    private void ChargerListeEmployes()
    {
        var employesPresents = ListeEmployesPresents(dtpDateApprovisionnement.Value.Date);
        var noms = employesPresents.OrderBy(em => em.PrenomNom).Select(em => em.PrenomNom).ToList();

        cbxRespStocks.DataSource = new List<string>(noms);
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

    private void BtnAjouterNouvelleMatierePremiere_Click(object sender, EventArgs e)
    {
        bool produitExisteDeja = _services.Db.ResStockMatieresPremieres
            .Any(mp => mp.NomMatiere.ToLower() == txtNomMatierePremiere.Text.ToLower());

        try
        {
            if (!produitExisteDeja)
            {
                var matierePremiere = new ResStockMatieresPremiere
                {
                    NomMatiere = txtNomMatierePremiere.Text,
                    CodeTypeMatiere = Convert.ToInt32(cbxTypesMatieres.SelectedValue),
                    CoutUnitaire = int.Parse(txtCoutUnitaire.Text),
                    StockMatiere = float.Parse(txtStockInitial.Text)
                };

                _services.Db.ResStockMatieresPremieres.Add(matierePremiere);
                _services.Db.SaveChanges();
                txtNomMatierePremiere.Clear();
                txtStockInitial.Text = "0";
                txtCoutUnitaire.Text = "0";
                MessageBox.Show("Une nouvelle matière première a été ajoutée avec succès");
                LoadData();
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Merci de renseigner les champs vides");
        }
    }

    private EveReceptionMatieresPremiere AjouterNouvelleAchatMatierePremiere()
    {
        var matPrem = _services.Db.ResStockMatieresPremieres.First(mp => mp.NomMatiere == cbxNomMatierePremiere.Text);
        var fournMp = _services.Db.AgeFournisseursMatieresPremieres.First(fmp => fmp.Nom == cbxFournisseurMPrem.Text);
        var resStocks = _services.Db.AgeEmployes.First(em => em.PrenomNom == cbxRespStocks.Text);

        var achatMatiere = new EveReceptionMatieresPremiere
        {
            CodeMatierePremiere = matPrem.CodeMatierePremiere,
            DateReception = dtpDateApprovisionnement.Value.Date,
            Quantite = float.Parse(txtQuantite.Text),
            Montant = int.Parse(txtMontant.Text),
            TransportMatierePremiere = int.Parse(txtTransportMatierePremiere.Text),
            CodeFournisseurMatierePremiere = fournMp.CodeFournisseurMatierePremiere,
            CodeEmploye = resStocks.CodeEmploye,
        };

        _services.Db.EveReceptionMatieresPremieres.Add(achatMatiere);
        _services.Db.SaveChanges();
        return achatMatiere;
    }

    private void AjouterDecaissementTransportMatierePremiere(EveReceptionMatieresPremiere recep)
    {
        var matPrem = _services.Db.ResStockMatieresPremieres.First(mp => mp.NomMatiere == cbxNomMatierePremiere.Text);
        var tresoriere = _services.Db.AgeEmployes.First(em => em.PrenomNom == cbxTresoriere.Text);
        var tres = _services.Db.ResComptesTresoreries.First(tr => tr.NomCompte == cbxComptePaiement.Text);

        int transport = int.Parse(txtTransportMatierePremiere.Text);
        if (transport > 0 && _services.Tresorerie.IlYaAssezDeFondsDansLeCompte(tres.NomCompte, transport))
        {
            var decaiss = new EveDecaissement
            {
                CodeReceptionMatierePremiere = recep.CodeReceptionMatierePremiere,
                Description = "Transport de " + matPrem.NomMatiere,
                DateDecaissement = recep.DateReception,
                CodeEmploye = tresoriere.CodeEmploye,
                CodeCompte = tres.CodeCompte,
                Montant = transport,
            };

            _services.Db.EveDecaissements.Add(decaiss);
            _services.Db.SaveChanges();
        }
    }

    private void AjouterPaiementFournisseur(EveReceptionMatieresPremiere recep)
    {
        var matPrem = _services.Db.ResStockMatieresPremieres.First(mp => mp.NomMatiere == cbxNomMatierePremiere.Text);
        var fournMp = _services.Db.AgeFournisseursMatieresPremieres.First(fmp => fmp.Nom == cbxFournisseurMPrem.Text);
        var tresoriere = _services.Db.AgeEmployes.First(em => em.PrenomNom == cbxTresoriere.Text);
        var tres = _services.Db.ResComptesTresoreries.First(tr => tr.NomCompte == cbxComptePaiement.Text);

        int montantPaye = int.Parse(txtMontantPaye.Text);
        if (montantPaye > 0 && _services.Tresorerie.IlYaAssezDeFondsDansLeCompte(tres.NomCompte, montantPaye))
        {
            var decaiss = new EveDecaissement
            {
                CodeReceptionMatierePremiere = recep.CodeReceptionMatierePremiere,
                CodeFournisseurMatierePremiere = fournMp.CodeFournisseurMatierePremiere,
                Description = "Achat de " + matPrem.NomMatiere,
                DateDecaissement = recep.DateReception,
                CodeEmploye = tresoriere.CodeEmploye,
                CodeCompte = tres.CodeCompte,
                Montant = montantPaye,
            };

            _services.Db.EveDecaissements.Add(decaiss);
            _services.Db.SaveChanges();
        }
    }

    private void BtnEnregistrerAchatMatierePremiere_Click(object sender, EventArgs e)
    {
        if (float.Parse(txtQuantite.Text) > 0 && int.Parse(txtMontant.Text) > 0)
        {
            if (cbxComptePaiement.SelectedItem is ResComptesTresorerie compte &&
                _services.Tresorerie.IlYaAssezDeFondsDansLeCompte(compte.NomCompte, int.Parse(txtMontant.Text)))
            {
                try
                {
                    var recep = AjouterNouvelleAchatMatierePremiere();
                    AjouterDecaissementTransportMatierePremiere(recep);
                    AjouterPaiementFournisseur(recep);
                    MessageBox.Show("Un nouvel achat de matière première a été enregistré avec succès");
                    AfficherSoldeTresorerie();
                    txtQuantite.Text = "0";
                    txtMontant.Text = "0";
                    txtMontantPaye.Text = "0";
                    txtTransportMatierePremiere.Text = "0";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        else
        {
            MessageBox.Show("Veuillez renseigner correctement les champs montant et quantité");
        }
    }

    private void CbxComptePaiement_SelectedIndexChanged(object sender, EventArgs e)
    {
        AfficherSoldeTresorerie();
    }

    private void BtnNouveauFournisseur_Click(object sender, EventArgs e)
    {
        bool fournisseurExiste = _services.Db.AgeFournisseursMatieresPremieres
            .Any(f => f.Nom == txtNomFournisseurMP.Text && f.Localite == txtLocaliteFournisseur.Text);

        if (fournisseurExiste)
        {
            MessageBox.Show("Ce fournisseur existe déjà dans la base de données. Merci de le choisir dans la liste déroulante.");
        }
        else
        {
            var validation = _services.Validation.VerifierChampsMontant(txtSoldeInitialeDette.Text);
            if (validation.IsValid)
            {
                var fmp = new AgeFournisseursMatieresPremiere
                {
                    Nom = txtNomFournisseurMP.Text,
                    Localite = txtLocaliteFournisseur.Text,
                    SoldeDette = int.Parse(txtSoldeInitialeDette.Text)
                };

                _services.Db.AgeFournisseursMatieresPremieres.Add(fmp);
                _services.Db.SaveChanges();
                MessageBox.Show("Le nouveau fournisseur a été ajouté avec succès.");
                LoadData();
                txtNomFournisseurMP.Clear();
                txtLocaliteFournisseur.Clear();
                txtSoldeInitialeDette.Text = "0";
            }
        }
    }

    private void DtpDateApprovisionnement_ValueChanged(object sender, EventArgs e)
    {
        ChargerListeEmployes();
    }
}
