using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_AutreEncaissementDeFonds : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

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

            if (Validation.MontantEstValide(txtMontantEncaisse.Text) && ChampDescriptionEstRempli())
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
                    MontantEncaisse = int.Parse(txtMontantEncaisse.Text),
                    FondsExternes = true
                };

                db.EveEncaissementsAutres.Add(autreEnc);
                db.SaveChanges();
                MessageBox.Show("L'encaissement de fonds a été enregistré avec succès.");
                txtDescription.Clear();
                txtMontantEncaisse.Clear();
            }
            else
            {
                MessageBox.Show("L'encaissement n'a pas été enregistré.");
            }
        }

        private void UC_AutreEncaissementDeFonds_Load(object sender, EventArgs e)
        {
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.OrderBy(ct => ct.NomCompte).ToList();
            ChargerListeEmployes();
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            EnregistrerEncaissement();
        }

        private void DtpDateEncaissement_ValueChanged(object sender, EventArgs e)
        {
            ChargerListeEmployes();
        }

        private void ChargerListeEmployes()
        {
            ageEmployeBindingSource.DataSource = Conversion.ListeEmployesPresents(dtpDateEncaissement)
                                                    .OrderBy(em => em.PrenomNom)
                                                    .Select(em => em.PrenomNom)
                                                    .ToList();
        }
    }
}
