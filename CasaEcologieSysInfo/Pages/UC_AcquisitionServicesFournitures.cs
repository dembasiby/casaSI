using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CasaEcologieSysInfo.Classes;

namespace CasaEcologieSysInfo
{
    public partial class UC_AcquisitionServicesFournitures : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_AcquisitionServicesFournitures()
        {
            InitializeComponent();
        }

        private void LoadData()
        {         
            resServicesFournituresBindingSource.DataSource = db.ResServicesFournitures.OrderBy(sf => sf.NomServiceFourniture).ToList();
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.OrderBy(ct => ct.NomCompte).ToList();
            ageFournisseursServicesFournituresBindingSource.DataSource = db.AgeFournisseursServicesFournitures.OrderBy(f => f.NomFournisseurServiceFourniture).ToList();
            ChargerListeEmployes();

            Tresorerie.AfficherSoldeTresorerie(cbxComptePaiement, txtSoldeCompte);
        }

        private void ChargerListeEmployes()
        {
            ageEmployesBindingSource.DataSource = Conversion.ListeEmployesPresents(dtpDateAchatServFourn)
                                                    .OrderBy(em => em.PrenomNom)
                                                    .Select(em => em.PrenomNom)
                                                    .ToList();

            ageEmployesBindingSource1.DataSource = Conversion.ListeEmployesPresents(dtpDateAchatServFourn)
                                                    .OrderBy(em => em.PrenomNom)
                                                    .Select(em => em.PrenomNom)
                                                    .ToList();
        }

        // CE BOUTON A ETE FINALEMENT DESACTIVE.
        private void BtnNewServFourniture_Click(object sender, EventArgs e)
        {
            try
            {
                bool nomValide = Validation.ChampsVide(txtNomNewServFourniture.Text);
                bool serviceExiste = !db.ResServicesFournitures.Any(serf => serf.NomServiceFourniture == txtNomNewServFourniture.Text);

                ResServicesFourniture sf = new ResServicesFourniture
                {
                    NomServiceFourniture = txtNomNewServFourniture.Text,
                };

                db.ResServicesFournitures.Add(sf);
                db.SaveChanges();
                MessageBox.Show("Un nouveau service ou de fourniture a été ajouté avec succès");
                txtNomNewServFourniture.Clear();
                LoadData();
            }
            catch (Exception)
            {

                MessageBox.Show("Ce service existe déjà.");
            }                
        }

        private void BtnNouveauFournisseurServ_Click(object sender, EventArgs e)
        {
            try
            {
                bool fournisseurExiste = !db.AgeFournisseursServicesFournitures
                    .Any(serf => serf.NomFournisseurServiceFourniture == txtNomFournServ.Text
                    && serf.Localite == txtLocaliteFournServ.Text);

                bool nomValide = Validation.ChampsVide(txtNomFournServ.Text);
                bool localiteValide = Validation.ChampsVide(txtLocaliteFournServ.Text);
                bool soldeValide = Validation.EstUnChiffre(txtSoldeInitialeDetteFournServ.Text);

                AgeFournisseursServicesFourniture fsf = new AgeFournisseursServicesFourniture
                {
                    NomFournisseurServiceFourniture = txtNomFournServ.Text,
                    Localite = txtLocaliteFournServ.Text,
                    SoldeDette = int.Parse(txtSoldeInitialeDetteFournServ.Text)
                };

                db.AgeFournisseursServicesFournitures.Add(fsf);
                db.SaveChanges();
                MessageBox.Show("Une nouveau fournisseur de services ou de fournitures a été ajouté avec succès");
                txtNomFournServ.Text = "";
                txtLocaliteFournServ.Text = "";
                txtSoldeInitialeDetteFournServ.Text = "00";
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez vérifier les données à enregistrer.");
            }   
        }

        private void UC_AcquisitionServicesFournitures_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnAchatServiceFourniture_Click(object sender, EventArgs e)
        {
            try
            {
                bool respAchatPresent = db.AgeEmployes.Any(em => em.PrenomNom == cbxRespServFourn.Text);
                bool fournPresent = db.AgeFournisseursServicesFournitures
                    .Any(fs => fs.NomFournisseurServiceFourniture == cbxNomFournServFourn.Text);
                bool descriptionAjoutee = !string.IsNullOrEmpty(txtDescription.Text);

                AgeEmploye tresoriere;

                if (int.Parse(txtMontantPayeServFourn.Text) > 0)
                {
                    bool montantValide = Validation.VerifierChampsMontant(txtMontantPayeServFourn.Text);
                    bool tresorierePresente = db.AgeEmployes.Any(em => em.PrenomNom == cbxTresoriere.Text);
                }

                AgeEmploye emp = db.AgeEmployes.First(em => em.PrenomNom == cbxRespServFourn.Text);

                AgeFournisseursServicesFourniture fsf = db.AgeFournisseursServicesFournitures.First
                    (
                    fs => fs.NomFournisseurServiceFourniture == cbxNomFournServFourn.Text
                    );
                ResComptesTresorerie cpte = db.ResComptesTresoreries.FirstOrDefault(c => c.NomCompte == cbxComptePaiement.Text);
                ResServicesFourniture sf = db.ResServicesFournitures.FirstOrDefault(s => s.NomServiceFourniture == cbxNomServFourniture.Text);

                if (Validation.VerifierChampsMontant(txtMontantServFourn.Text))
                {
                    EveAcquisitionServicesFourniture asf = new EveAcquisitionServicesFourniture
                    {
                        Date = DateTime.Parse(dtpDateAchatServFourn.Text),
                        Description = txtDescription.Text,
                        Montant = int.Parse(txtMontantServFourn.Text),
                        CodeServiceFourniture = sf.CodeServiceFourniture,
                        CodeFournisseurServiceFourniture = fsf.CodeFournisseurServiceFourniture,
                        CodeEmploye = emp.CodeEmploye,
                    };

                    db.EveAcquisitionServicesFournitures.Add(asf);
                    db.SaveChanges();

                    if (int.Parse(txtMontantPayeServFourn.Text) > 0 && Validation.VerifierChampsMontant(txtMontantPayeServFourn.Text))
                    {
                        if (Tresorerie.IlYaAssezDeFondsDansLeCompte(cbxComptePaiement, txtMontantPayeServFourn))
                        {
                            tresoriere = db.AgeEmployes.First(em => em.PrenomNom == cbxTresoriere.Text);

                            EveDecaissement decaiss = new EveDecaissement
                            {
                                CodeAcquisitionServiceFourniture = asf.CodeAcquisitionServiceFourniture,
                                Description = sf.NomServiceFourniture,
                                DateDecaissement = asf.Date,
                                CodeEmploye = tresoriere.CodeEmploye,
                                CodeCompte = cpte.CodeCompte,
                                Montant = int.Parse(txtMontantPayeServFourn.Text),
                                CodeFournisseurService = fsf.CodeFournisseurServiceFourniture,
                            };
                            db.EveDecaissements.Add(decaiss);
                            db.SaveChanges();
                        }
                    }

                    MessageBox.Show("Le nouvel achat de service ou de fourniture a été enregistré avec succès!");
                    txtMontantServFourn.Text = "";
                    txtMontantPayeServFourn.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur: La transaction n'a pas été enregistré.");
            }                
        }

        private void CbxComptePaiement_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Tresorerie.AfficherSoldeTresorerie(cbxComptePaiement, txtSoldeCompte);
        }

        private void DtpDateAchatServFourn_ValueChanged(object sender, EventArgs e)
        {
            ChargerListeEmployes();
        }
    }
}
