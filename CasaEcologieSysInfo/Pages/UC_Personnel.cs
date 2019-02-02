using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_Personnel : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_Personnel()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var listePersonnel = (from p in db.AgeEmployes
                                  select new { Nom = p.PrenomNom, p.Poste }).ToList();

            dgvListePersonnel.DataSource = listePersonnel;
            cbxTempsEtRemun.DataSource = listePersonnel.Select(p => p.Nom).ToList();
            ageEmployeBindingSource1.DataSource = db.AgeEmployes.ToList();
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.ToList();
            cbxTimeSheetNomEmploye.DataSource = listePersonnel.Select(p => p.Nom).ToList();
            AfficherPresenceEtRemunerationEmploye(dtpFin.Value.Date);
        }

        private void AfficherPresenceEtRemunerationEmploye(DateTime fin, DateTime debut = default(DateTime))
        {
            var employe = cbxTempsEtRemun.GetItemText(cbxTempsEtRemun.SelectedItem);

            var liste = (from pe in db.EvePresenceEmployes
                         where pe.AgeEmploye.PrenomNom == employe
                         where pe.Date >= debut.Date
                         where pe.Date <= fin.Date

                         select new
                         {
                             pe.Date,
                             Description = "Present",
                             Remuneration = pe.RemunerationJournaliere
                         }).ToList();

            DataTable dt = Conversion.ConvertirEnTableDeDonnees(liste);
            dgvTempsEtRemun.DataSource = dt;
            dt.Rows.Add(DateTime.Now, "Total", Conversion.CalculerTotal(dgvTempsEtRemun, "Remuneration"));

            txtRemunerationPeriod.Text = dgvTempsEtRemun.Rows[dgvTempsEtRemun.Rows.Count - 2].Cells[2].Value.ToString();
        }

        private void UC_Personnel_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnNouvelEmploye_Click(object sender, EventArgs e)
        {
            if (txtPosteEmploye.Text.Trim().Length > 0 && txtPrenomNom.Text.Trim().Length > 0)
            {
                AgeEmploye emp = new AgeEmploye()
                {
                    PrenomNom = txtPrenomNom.Text,
                    Poste = txtPosteEmploye.Text
                };

                db.AgeEmployes.Add(emp);
                db.SaveChanges();
                MessageBox.Show("Le nouvel employé a été ajouté avec succès à la base de données.");
                LoadData();
                txtPrenomNom.Clear();
                txtPosteEmploye.Clear();
            }
            else
            {
                MessageBox.Show("Les champs 'Prenom et Nom' et 'Poste' ne peuvent pas être vides.");
            }
        }

        private void BtnPresenceEmploye_Click(object sender, EventArgs e)
        {
            var employe = cbxTimeSheetNomEmploye.GetItemText(cbxTimeSheetNomEmploye.SelectedItem);
            var codeEmploye = (from em in db.AgeEmployes
                               where em.PrenomNom == employe
                               select em.CodeEmploye).FirstOrDefault();

            if (Validation.VerifierChampsMontant(txtRemunerationJournaliere.Text))
            {
                if (EmployeNonEncoreEnregistrePourCeJour(codeEmploye))
                {
                    EvePresenceEmploye pe = new EvePresenceEmploye()
                    {
                        CodeEmploye = codeEmploye,
                        CodeUtilisationDesRessources = 0,
                        Date = DateTime.Parse(dtpDate.Text),
                        RemunerationJournaliere = Convert.ToInt32(txtRemunerationJournaliere.Text)
                    };

                    db.EvePresenceEmployes.Add(pe);
                    db.SaveChanges();
                    MessageBox.Show("La présence de l'employé a été enregistrée avec succès.");
                    AfficherPresenceEtRemunerationEmploye(dtpFin.Value.Date, dtpDebut.Value.Date);
                }
                else
                {
                    MessageBox.Show($"{employe} a déjà été enregistré pour le {dtpDate.Value.ToShortDateString()}");
                    return;
                } 
            }
        }

        private bool EmployeNonEncoreEnregistrePourCeJour(int codeEmploye)
        {
            try
            {
                var presenceEmploye = (from pe in db.EvePresenceEmployes
                                       where pe.CodeEmploye == codeEmploye
                                       where pe.Date == dtpDate.Value.Date
                                       select pe).First();
                return false;
            }
            catch (Exception)
            {

                return true;
            }
        }

        private void CbxTempsEtRemun_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherPresenceEtRemunerationEmploye(dtpFin.Value.Date, dtpDebut.Value.Date);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AfficherPresenceEtRemunerationEmploye(dtpFin.Value.Date, dtpDebut.Value.Date);
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            AfficherPresenceEtRemunerationEmploye(dtpFin.Value.Date, dtpDebut.Value.Date);
        }

        private void BtnPayerEmploye_Click(object sender, EventArgs e)
        {
            var employe = cbxTempsEtRemun.GetItemText(cbxTempsEtRemun.SelectedItem);
            var codeEmploye = (from em in db.AgeEmployes
                               where em.PrenomNom == employe
                               select em.CodeEmploye).FirstOrDefault();

            if (RemunerationPasEncorePayePourLaPeriod(codeEmploye))
            {
                EvePaiementEmploye paiement = new EvePaiementEmploye
                {
                    CodeEmployePaye = codeEmploye,
                    DeCetteDate = DateTime.Parse(dtpDebut.Text),
                    ACetteDate = DateTime.Parse(dtpFin.Text)
                };

                db.EvePaiementEmployes.Add(paiement);
                db.SaveChanges();

                EveDecaissement decaiss = new EveDecaissement
                {
                    DateDecaissement = DateTime.Parse(dtpDatePaiement.Text),
                    CodePaiementEmploye = paiement.CodePaiementEmploye,
                    CodeCompte = int.Parse(cbxComptePaiement.SelectedValue.ToString()),
                    Description = "Paiment rémunération de " + employe + " pour la période du " + dtpDebut.Value.ToShortDateString() + " au " + dtpFin.Value.ToShortDateString(),
                    CodeEmploye = int.Parse(cbxTresoriere.SelectedValue.ToString()),
                    Montant = int.Parse(txtRemunerationPeriod.Text)
                };

                db.EveDecaissements.Add(decaiss);
                db.SaveChanges();

                MessageBox.Show($"Le paiement de {employe} a été enregistré pour la période du {dtpDebut.Value.ToShortDateString()} au {dtpFin.Value.ToShortDateString()}.");
            }
            else
            {
                MessageBox.Show($"{employe} a déjà été payé pour la période selectionnée.");
                return;
            }
        }

        private bool RemunerationPasEncorePayePourLaPeriod(int codeEmploye)
        {
            var remunere = (from epaye in db.EvePaiementEmployes
                                         where epaye.CodeEmployePaye == codeEmploye
                                         where epaye.DeCetteDate == dtpDebut.Value.Date
                                         where epaye.ACetteDate == dtpFin.Value.Date
                                         select epaye.CodePaiementEmploye).FirstOrDefault();

            if (remunere > 0) return false;
            return true;
        }
    }
}
