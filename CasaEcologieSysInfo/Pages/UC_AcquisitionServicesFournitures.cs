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
            resServicesFournituresBindingSource.DataSource = db.ResServicesFournitures.ToList();
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.ToList();
            ageFournisseursServicesFournituresBindingSource.DataSource = db.AgeFournisseursServicesFournitures.ToList();
            ageEmployesBindingSource.DataSource = Conversion.ListeEmployesPresents(dtpDateAchatServFourn)
                                                    .OrderBy(em => em.PrenomNom)
                                                    .Select(em => em.PrenomNom)
                                                    .ToList();

            ageEmployesBindingSource1.DataSource = Conversion.ListeEmployesPresents(dtpDateAchatServFourn)
                                                    .OrderBy(em => em.PrenomNom)
                                                    .Select(em => em.PrenomNom)
                                                    .ToList();

            Tresorerie.AfficherSoldeTresorerie(cbxComptePaiement, txtSoldeCompte);
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
            AgeEmploye emp = db.AgeEmployes.FirstOrDefault(em => em.PrenomNom == cbxRespServFourn.Text);
            AgeEmploye tresoriere = db.AgeEmployes.FirstOrDefault(em => em.PrenomNom == cbxTresoriere.Text);
            AgeFournisseursServicesFourniture fsf = db.AgeFournisseursServicesFournitures.FirstOrDefault
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

        private void CbxComptePaiement_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Tresorerie.AfficherSoldeTresorerie(cbxComptePaiement, txtSoldeCompte);
        }
    }
}
