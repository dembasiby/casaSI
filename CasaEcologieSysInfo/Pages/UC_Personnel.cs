using CasaEcologieSysInfo.Classes;
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
                                  where p.Actif == true
                                  select new { Nom = p.PrenomNom, p.Poste }).ToList();

            dgvListePersonnel.DataSource = listePersonnel;

            cbxTempsEtRemun.DisplayMember = "PrenomNom";
            cbxTempsEtRemun.ValueMember = "CodeEmploye";
            cbxTempsEtRemun.DataSource = db.AgeEmployes
                                           .Where(em => em.Actif == true)
                                           .Where(em => !em.Poste.StartsWith("Stagiaire"))
                                           .OrderBy(c => c.PrenomNom)
                                           .ToList();

            ageEmployeBindingSource1.DataSource = db.AgeEmployes
                                                    .Where(em => em.Actif == true)
                                                    .OrderBy(em => em.PrenomNom)
                                                    .ToList();
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.OrderBy(ct => ct.NomCompte).ToList();
            cbxTimeSheetNomEmploye.DataSource = db.AgeEmployes
                                                  .Where(em => em.Actif == true)
                                                  .Where(em => !em.Poste.StartsWith("Stagiaire"))
                                                  .OrderBy(c => c.PrenomNom)
                                                  .ToList();
            cbxTimeSheetNomEmploye.DisplayMember = "PrenomNom";
            cbxTimeSheetNomEmploye.ValueMember = "CodeEmploye";

            cbxTresoriere.DataSource = Conversion.ListeEmployesPresents(dtpDatePaiement)
                                         .Where(em => !em.Poste.StartsWith("Stagiaire"))
                                         .OrderBy(c => c.PrenomNom)
                                         .ToList();
            cbxTresoriere.DisplayMember = "PrenomNom";
            cbxTresoriere.ValueMember = "CodeEmploye";

            cbxStagiaires.DisplayMember = "PrenomNom";
            cbxStagiaires.ValueMember = "CodeEmploye";
            cbxStagiaires.DataSource = db.AgeEmployes
                                         .Where(em => em.Actif == true)
                                         .Where(em => em.Poste.StartsWith("Stagiaire"))
                                         .OrderBy(c => c.PrenomNom)
                                         .ToList();

            cbxComptePaiementStagiare.DataSource = db.ResComptesTresoreries.OrderBy(ct => ct.NomCompte).ToList();
            cbxComptePaiementStagiare.ValueMember = "CodeCompte";
            cbxPaiementFaitPar.DataSource = Conversion.ListeEmployesPresents(dtpDatePaiement)
                                             .Where(em => !em.Poste.StartsWith("Stagiaire"))
                                             .OrderBy(c => c.PrenomNom)
                                             .ToList();
            cbxPaiementFaitPar.DisplayMember = "PrenomNom";
            cbxPaiementFaitPar.ValueMember = "CodeEmploye";


            AfficherPresenceEtRemunerationEmploye(dtpDebut.Value.Date,dtpFin.Value.Date);
            Tresorerie.AfficherSoldeTresorerie(cbxComptePaiement, txtSoldeCompte);
        }

        private void AfficherPresenceEtRemunerationEmploye(DateTime debut, DateTime fin)
        {
            var employe = cbxTempsEtRemun.GetItemText(cbxTempsEtRemun.SelectedItem);
            var codeEmploye = Convert.ToInt32(cbxTempsEtRemun.SelectedValue.ToString());

            var liste = (from pe in db.EvePresenceEmployes
                         where pe.AgeEmploye.PrenomNom == employe
                         where pe.CodeEmploye == codeEmploye
                         where pe.Date >= debut.Date
                         where pe.Date <= fin.Date

                         select new
                         {
                             pe.Date,
                             Description = "Present",
                             Remuneration = pe.RemunerationJournaliere
                         })
                         .OrderBy(d => d.Date)
                         .ToList();

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
            bool employeEnregistre = db.AgeEmployes.Any(em => em.PrenomNom.ToLower() == txtPrenomNom.Text.ToLower());

            if (txtPosteEmploye.Text.Trim().Length > 0 && txtPrenomNom.Text.Trim().Length > 0)
            {
                if (!employeEnregistre)
                {
                    AgeEmploye emp = new AgeEmploye()
                    {
                        PrenomNom = txtPrenomNom.Text,
                        Poste = txtPosteEmploye.Text,
                        Actif = true
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
                    MessageBox.Show("Cet employé a déjà été enregistré.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Les champs 'Prenom et Nom' et 'Poste' ne peuvent pas être vides.");
            }
        }

        private void BtnPresenceEmploye_Click(object sender, EventArgs e)
        {
            var employe = cbxTimeSheetNomEmploye.GetItemText(cbxTimeSheetNomEmploye.SelectedItem);
            var codeEmploye = Convert.ToInt32(cbxTimeSheetNomEmploye.SelectedValue.ToString());

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
            AfficherPresenceEtRemunerationEmploye(dtpDebut.Value.Date, dtpFin.Value.Date);
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AfficherPresenceEtRemunerationEmploye(dtpDebut.Value.Date, dtpFin.Value.Date);
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            AfficherPresenceEtRemunerationEmploye(dtpFin.Value.Date, dtpDebut.Value.Date);
        }

        private void BtnPayerEmploye_Click(object sender, EventArgs e)
        {
            var employe = cbxTempsEtRemun.GetItemText(cbxTempsEtRemun.SelectedItem);
            var codeEmploye = Convert.ToInt32(cbxTempsEtRemun.SelectedValue.ToString());

            PayerPersonnel(employe, codeEmploye, dtpDebut.Text, dtpFin.Text, dtpDatePaiement.Text, cbxComptePaiement,
                cbxTresoriere.SelectedValue.ToString(), txtRemunerationPeriod);            
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

        private void BtnPayerIndemnite_Click(object sender, EventArgs e)
        { 
            var stagiaire = cbxStagiaires.GetItemText(cbxStagiaires.SelectedItem);
            var codeStagiaire = Convert.ToInt32(cbxStagiaires.SelectedValue.ToString());

            PayerPersonnel(stagiaire, codeStagiaire, dtpDeStagiaire.Text, dtpAStagiaire.Text, dtpDatePaiementIndemStagiaires.Text, cbxComptePaiementStagiare,
                cbxPaiementFaitPar.SelectedValue.ToString(), txtMontantIndemnite);
        }

        private void PayerPersonnel(string employe, int codeEmploye, string debut, string fin, string date, ComboBox cptePaiement,
                string tresoriere, TextBox montant)
        {
            string cptePaie = cptePaiement.GetItemText(cptePaiement.SelectedItem);
            int codeCompte = Convert.ToInt32(cptePaiement.SelectedValue.ToString());

            if (Validation.VerifierChampsMontant(montant.Text))
            {
                if (RemunerationPasEncorePayePourLaPeriod(codeEmploye))
                {
                    if (Tresorerie.IlYaAssezDeFondsDansLeCompte(cptePaiement, montant))
                    {
                        EvePaiementEmploye paiement = new EvePaiementEmploye
                        {
                            CodeEmployePaye = codeEmploye,
                            DeCetteDate = DateTime.Parse(debut),
                            ACetteDate = DateTime.Parse(fin)
                        };

                        db.EvePaiementEmployes.Add(paiement);
                        db.SaveChanges();

                        EveDecaissement decaiss = new EveDecaissement
                        {
                            DateDecaissement = DateTime.Parse(date),
                            CodePaiementEmploye = paiement.CodePaiementEmploye,
                            CodeCompte = codeCompte,
                            Description = "Paiment rémunération de " + employe + " pour la période du " + debut + " au " + fin,
                            CodeEmploye = int.Parse(tresoriere),
                            Montant = int.Parse(montant.Text)
                        };

                        db.EveDecaissements.Add(decaiss);
                        db.SaveChanges();

                        MessageBox.Show($"Le paiement de {employe} a été enregistré pour la période du {debut} au {fin}.");
                    }
                   
                }
                else
                {
                    MessageBox.Show($"{employe} a déjà été payé pour la période selectionnée.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Le montant entré n'est pas valide.");
                return;
            }
        }

        private void CbxComptePaiement_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tresorerie.AfficherSoldeTresorerie(cbxComptePaiement, txtSoldeCompte);
        }

        private void DtpDatePaiement_ValueChanged(object sender, EventArgs e)
        {
            cbxTresoriere.DataSource = Conversion.ListeEmployesPresents(dtpDatePaiement)
                                         .Where(em => !em.Poste.StartsWith("Stagiaire"))
                                         .OrderBy(c => c.PrenomNom)
                                         .ToList();
        }
    }
}
