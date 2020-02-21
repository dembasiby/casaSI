using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages.Corrections
{
    public partial class UC_UpdatePersonnel : UserControl
    {
        private int _codeTransaction;

        public UC_UpdatePersonnel()
        {
            InitializeComponent();
        }
        private void UC_UpdatePersonnel_Load(object sender, EventArgs e)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                cbxEmployeAChanger.DataSource = db.AgeEmployes.OrderBy(em => em.PrenomNom).ToList();
                LoadDetailsPersonnel();
            }
        }

        private void CbxEmployeAChanger_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDetailsPersonnel();
        }

        private void DgvListePaiementsEmployes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DgvListePaiementsEmployes.Rows[e.RowIndex];
            int codeTransaction = int.Parse(row.Cells["Code"].Value.ToString());
            _codeTransaction = codeTransaction;
            ClearData();
            LoadDetailsTransaction(_codeTransaction);
        }

        private void BtnMettreDonneesPersoAJour_Click(object sender, EventArgs e)
        {
            MettreDetailsPersonnelAJour();
        }

        private void BtnMettreTransactionAJour_Click(object sender, EventArgs e)
        {
            MettreComptePaiementAJour();
        }
        
        private void BtnSupprimerTransaction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous supprimer cette transaction?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (CasaDBEntities db = new CasaDBEntities())
                {
                    try
                    {
                        var transaction = db.EvePaiementEmployes.Where(pe => pe.CodePaiementEmploye == _codeTransaction).FirstOrDefault();
                        var decaissement = transaction.EveDecaissements.FirstOrDefault();
                        db.EveDecaissements.Remove(decaissement);
                        db.EvePaiementEmployes.Remove(transaction);
                        db.SaveChanges();

                        MessageBox.Show("Erreur: La transaction n'a pas été supprimée.");
                        ClearData();
                        LoadListeTransactions();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erreur: La transaction n'a pas été supprimée.");
                    }
                }
            }
        }

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            LoadListeTransactions();
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            LoadListeTransactions();
        }

        private void ClearData()
        {
            CbxNomEmploye.SelectedIndex = -1;
            CbxTresoriere.SelectedIndex = -1;
            CbxCompteDePaiment.SelectedIndex = -1;
            dtpDatePaiement.Value = DateTime.Today;
            txtMontantPaye.Clear();
            txtPeriodePayee.Clear();
        }

        private void LoadListeTransactions()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var paiementsEmployes = (from dec in db.EveDecaissements
                                              where dec.DateDecaissement >= dtpDebut.Value.Date && dec.DateDecaissement <= dtpFin.Value.Date
                                              join pem in db.EvePaiementEmployes on dec.CodePaiementEmploye equals pem.CodePaiementEmploye
                                              select new
                                              {
                                                  Code = pem.CodePaiementEmploye,
                                                  dec.DateDecaissement,
                                                  Employe = pem.AgeEmploye.PrenomNom
                                              }).OrderBy(d => d.DateDecaissement).ToList();

                DataTable dt = Conversion.ConvertirEnTableDeDonnees(paiementsEmployes);
                DgvListePaiementsEmployes.DataSource = dt;
            }
        }

        private void LoadDetailsTransaction(int codeTransaction)
        {
            try
            {
                using (CasaDBEntities db = new CasaDBEntities())
                {
                    var transaction = db.EvePaiementEmployes.Where(pe => pe.CodePaiementEmploye == codeTransaction).FirstOrDefault();

                    CbxNomEmploye.DataSource = db.AgeEmployes.OrderBy(e => e.PrenomNom).ToList();
                    CbxCompteDePaiment.DataSource = db.ResComptesTresoreries.OrderBy(c => c.NomCompte).ToList();
                    var decaissement = transaction.EveDecaissements.FirstOrDefault();

                    dtpDatePaiement.Value = decaissement.DateDecaissement;
                    CbxTresoriere.DataSource = Conversion.ListeEmployesPresents(dtpDatePaiement).ToList();

                    txtMontantPaye.Text = decaissement.Montant.ToString("n0");
                    txtPosteOccupe.Text = transaction.AgeEmploye.Poste;
                    txtPeriodePayee.Text = $"Du {transaction.DeCetteDate.ToShortDateString()} au {transaction.ACetteDate.ToShortDateString()}";
                    CbxNomEmploye.SelectedValue = transaction.CodeEmployePaye;
                    CbxTresoriere.SelectedValue = decaissement.CodeEmploye;
                    CbxCompteDePaiment.SelectedValue = decaissement.CodeCompte;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur d'affichage.");
            }
        }
       
        private void LoadDetailsPersonnel()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                int codeEmploye = int.Parse(cbxEmployeAChanger.SelectedValue.ToString());

                var employe = db.AgeEmployes.Where(em => em.CodeEmploye == codeEmploye).FirstOrDefault();
                txtPosteAChanger.Text = employe.Poste;
                txtNomAChanger.Text = employe.PrenomNom;
                if (employe.Actif)
                {
                    cbxOui.Checked = true;
                }
                else
                {
                    cbxNon.Checked = true;
                }
            }
        }

        private void MettreDetailsPersonnelAJour()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                bool employeEnregistre = db.AgeEmployes.Any(em => em.PrenomNom.ToLower() == txtNomAChanger.Text.ToLower());

                try
                {
                    int.TryParse(cbxEmployeAChanger.SelectedValue.ToString(), out int codeEmploye);
                    var employe = db.AgeEmployes.Where(em => em.CodeEmploye == codeEmploye).FirstOrDefault();

                    if (!string.IsNullOrEmpty(txtPosteAChanger.Text) && txtPosteAChanger.Text != employe.Poste)
                    {
                        employe.Poste = txtPosteAChanger.Text;
                    }

                    if (!string.IsNullOrEmpty(txtNomAChanger.Text) && txtNomAChanger.Text != employe.PrenomNom && !employeEnregistre)
                    {
                        employe.PrenomNom = txtNomAChanger.Text;
                    }
                     
                    if (employe.Actif && cbxNon.Checked)
                    {
                        employe.Actif = false;
                    }
                    else if(employe.Actif == false && cbxOui.Checked)
                    {
                        employe.Actif = true;
                    }

                    db.SaveChanges();
                    MessageBox.Show("Les détails de l'employé / membre ont été mis à jour.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur: Les détails de l'employé n'ont pas été mis à jour.");
                }
            }
        }

        private void MettreComptePaiementAJour()
        {
            try
            {
                using (CasaDBEntities db = new CasaDBEntities())
                {
                    var transaction = db.EvePaiementEmployes.Where(pe => pe.CodePaiementEmploye == _codeTransaction).FirstOrDefault();
                    int.TryParse(CbxCompteDePaiment.SelectedValue.ToString(), out int codeCompte);
                    var decaissement = transaction.EveDecaissements.FirstOrDefault();

                    // Le compte de trésorerie utilisé pour le paiment a changé
                    if (decaissement.CodeCompte != codeCompte)
                    {
                        decaissement.CodeCompte = codeCompte;
                    }

                    db.SaveChanges();
                    MessageBox.Show("Le compte de paiement a été mis à jour.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur: Le compte de paiement n'a pas été mis à jour.");
            }
        }

    }
}
