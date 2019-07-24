using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ageEmployesBindingSource.DataSource = db.AgeEmployes
                                                    .Where(em => em.Actif == true)
                                                    .OrderBy(em => em.PrenomNom)
                                                    .ToList();

            ageEmployesBindingSource1.DataSource = db.AgeEmployes
                                                    .Where(em => em.Actif == true)
                                                    .OrderBy(em => em.PrenomNom)
                                                    .ToList();

            Conversion.AfficherSoldeTresorerie(cbxComptePaiement, txtSoldeCompte);
        }

        private void BtnNewServFourniture_Click(object sender, EventArgs e)
        {
            ResServicesFourniture sf = new ResServicesFourniture
            {
                NomServiceFourniture = txtNomServFourniture.Text,
            };

            db.ResServicesFournitures.Add(sf);
            db.SaveChanges();
            MessageBox.Show("Un nouveau service ou de fourniture a été ajouté avec succès");
            txtNomServFourniture.Text = "";
            LoadData();                  
       }

        private void BtnNouveauFournisseurServ_Click(object sender, EventArgs e)
        {
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
                    if (Conversion.IlYaAssezDeFondsDansLeCompte(cbxComptePaiement, txtMontantPayeServFourn))
                    {
                        EveDecaissement decaiss = new EveDecaissement
                        {
                            CodeAcquisitionServiceFourniture = asf.CodeAcquisitionServiceFourniture,
                            Description = "Achat de " + sf.NomServiceFourniture,
                            DateDecaissement = asf.Date,
                            CodeEmploye = tresoriere.CodeEmploye,
                            CodeCompte = cpte.CodeCompte,
                            Montant = int.Parse(txtMontantPayeServFourn.Text),
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
            Conversion.AfficherSoldeTresorerie(cbxComptePaiement, txtSoldeCompte);
        }
    }
}
