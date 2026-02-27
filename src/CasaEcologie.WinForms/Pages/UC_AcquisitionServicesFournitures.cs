using CasaEcologie.Domain.Entities;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_AcquisitionServicesFournitures : UserControl
{
    private readonly ServiceContainer _services;

    public UC_AcquisitionServicesFournitures(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_AcquisitionServicesFournitures_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    private void LoadData()
    {
        cbxNomServFourniture.DisplayMember = "NomServiceFourniture";
        cbxNomServFourniture.ValueMember = "CodeServiceFourniture";
        cbxNomServFourniture.DataSource = _services.Db.ResServicesFournitures
            .OrderBy(sf => sf.NomServiceFourniture).ToList();

        cbxComptePaiement.DisplayMember = "NomCompte";
        cbxComptePaiement.ValueMember = "CodeCompte";
        cbxComptePaiement.DataSource = _services.Db.ResComptesTresoreries
            .OrderBy(ct => ct.NomCompte).ToList();

        cbxNomFournServFourn.DisplayMember = "NomFournisseurServiceFourniture";
        cbxNomFournServFourn.ValueMember = "CodeFournisseurServiceFourniture";
        cbxNomFournServFourn.DataSource = _services.Db.AgeFournisseursServicesFournitures
            .OrderBy(f => f.NomFournisseurServiceFourniture).ToList();

        ChargerListeEmployes();
        AfficherSoldeTresorerie();
    }

    private void ChargerListeEmployes()
    {
        var employesPresents = ListeEmployesPresents(dtpDateAchatServFourn.Value.Date);
        var noms = employesPresents.OrderBy(em => em.PrenomNom).Select(em => em.PrenomNom).ToList();

        cbxRespServFourn.DataSource = new List<string>(noms);
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

    private void BtnNouveauFournisseurServ_Click(object sender, EventArgs e)
    {
        try
        {
            var fsf = new AgeFournisseursServicesFourniture
            {
                NomFournisseurServiceFourniture = txtNomFournServ.Text,
                Localite = txtLocaliteFournServ.Text,
                SoldeDette = int.Parse(txtSoldeInitialeDetteFournServ.Text)
            };

            _services.Db.AgeFournisseursServicesFournitures.Add(fsf);
            _services.Db.SaveChanges();
            MessageBox.Show("Une nouveau fournisseur de services ou de fournitures a été ajouté avec succès");
            txtNomFournServ.Clear();
            txtLocaliteFournServ.Clear();
            txtSoldeInitialeDetteFournServ.Text = "00";
            LoadData();
        }
        catch (Exception)
        {
            MessageBox.Show("Veuillez vérifier les données à enregistrer.");
        }
    }

    private void BtnAchatServiceFourniture_Click(object sender, EventArgs e)
    {
        try
        {
            var emp = _services.Db.AgeEmployes.First(em => em.PrenomNom == cbxRespServFourn.Text);
            var fsf = _services.Db.AgeFournisseursServicesFournitures
                .First(fs => fs.NomFournisseurServiceFourniture == cbxNomFournServFourn.Text);
            var cpte = _services.Db.ResComptesTresoreries.First(c => c.NomCompte == cbxComptePaiement.Text);
            var sf = _services.Db.ResServicesFournitures.First(s => s.NomServiceFourniture == cbxNomServFourniture.Text);

            var validation = _services.Validation.VerifierChampsMontant(txtMontantServFourn.Text);
            if (validation.IsValid)
            {
                var asf = new EveAcquisitionServicesFourniture
                {
                    Date = dtpDateAchatServFourn.Value.Date,
                    Description = txtDescription.Text,
                    Montant = int.Parse(txtMontantServFourn.Text),
                    CodeServiceFourniture = sf.CodeServiceFourniture,
                    CodeFournisseurServiceFourniture = fsf.CodeFournisseurServiceFourniture,
                    CodeEmploye = emp.CodeEmploye,
                };

                _services.Db.EveAcquisitionServicesFournitures.Add(asf);
                _services.Db.SaveChanges();

                int montantPaye = 0;
                int.TryParse(txtMontantPayeServFourn.Text, out montantPaye);

                if (montantPaye > 0)
                {
                    if (_services.Tresorerie.IlYaAssezDeFondsDansLeCompte(cpte.NomCompte, montantPaye))
                    {
                        var tresoriere = _services.Db.AgeEmployes.First(em => em.PrenomNom == cbxTresoriere.Text);

                        var decaiss = new EveDecaissement
                        {
                            CodeAcquisitionServiceFourniture = asf.CodeAcquisitionServiceFourniture,
                            Description = sf.NomServiceFourniture,
                            DateDecaissement = asf.Date,
                            CodeEmploye = tresoriere.CodeEmploye,
                            CodeCompte = cpte.CodeCompte,
                            Montant = montantPaye,
                            CodeFournisseurService = fsf.CodeFournisseurServiceFourniture,
                        };
                        _services.Db.EveDecaissements.Add(decaiss);
                        _services.Db.SaveChanges();
                    }
                }

                MessageBox.Show("Le nouvel achat de service ou de fourniture a été enregistré avec succès!");
                txtMontantServFourn.Clear();
                txtMontantPayeServFourn.Clear();
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Erreur: La transaction n'a pas été enregistré.");
        }
    }

    private void CbxComptePaiement_SelectedIndexChanged(object sender, EventArgs e)
    {
        AfficherSoldeTresorerie();
    }

    private void DtpDateAchatServFourn_ValueChanged(object sender, EventArgs e)
    {
        ChargerListeEmployes();
    }
}
