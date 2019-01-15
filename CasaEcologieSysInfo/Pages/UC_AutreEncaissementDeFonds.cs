using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_AutreEncaissementDeFonds : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();

        public UC_AutreEncaissementDeFonds()
        {
            InitializeComponent();
        }

        private bool ChampDescriptionEstRempli()
        {
            if (txtDescription.Text.Trim().Length < 5)
            {
                MessageBox.Show("Le champ 'Description' doit être renseigné.");
                return false;
            }
            return true;
        }

        private void EnregistrerEncaissement()
        {
            var employe = cbxResponsableTransaction.GetItemText(cbxResponsableTransaction.SelectedItem);
            var compte = cbxCompteCrediteur.GetItemText(cbxCompteCrediteur.SelectedItem);

            if (Conversion.MontantEstValide(txtMontantEncaisse.Text) && ChampDescriptionEstRempli())
            {
                EveEncaissement enc = new EveEncaissement
                {
                    CodeEmploye = (from emp in db.AgeEmployes where emp.PrenomNom == employe select emp.CodeEmploye).FirstOrDefault(),
                    CodeCompte = (from cpte in db.ResComptesTresoreries where cpte.NomCompte == compte select cpte.CodeCompte).FirstOrDefault()

                };

                db.EveEncaissements.Add(enc);
                db.SaveChanges();

                EveEncaissementsAutre autreEnc = new EveEncaissementsAutre
                {
                    CodeEncaissement = enc.CodeEncaissement,
                    DateEncaissement = dtpDateEncaissement.Value.Date,
                    Description = txtDescription.Text,
                    MontantEncaisse = int.Parse(txtMontantEncaisse.Text)
                };

                db.EveEncaissementsAutres.Add(autreEnc);
                db.SaveChanges();
                MessageBox.Show("L'encaissement de fonds à été enregistré avec succès.");
                txtDescription.Clear();
                txtMontantEncaisse.Clear();
            }
        }

        private void UC_AutreEncaissementDeFonds_Load(object sender, EventArgs e)
        {
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.ToList();
            ageEmployeBindingSource.DataSource = db.AgeEmployes.OrderBy(n => n.PrenomNom).ToList();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            EnregistrerEncaissement();
        }

    }
}
