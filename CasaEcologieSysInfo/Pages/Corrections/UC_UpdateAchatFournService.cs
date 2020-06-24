using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages.Corrections
{
    public partial class UC_UpdateAchatFournService : UserControl
    {
        private int _codeTransaction;

        public UC_UpdateAchatFournService()
        {
            InitializeComponent();
        }

        private void UC_UpdateAchatFournService_Load(object sender, EventArgs e)
        {
            LoadListeTransactions();
        }

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            LoadListeTransactions();

        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            LoadListeTransactions();
        }

        private void DgvListeTransactionsServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListeTransactionsServices.Rows[e.RowIndex];
            int codeTransaction = int.Parse(row.Cells["Code"].Value.ToString());
            _codeTransaction = codeTransaction;
            ClearData();
            LoadDetailsTransaction(_codeTransaction);
        }


        private void BtnMettreTransactionAJour_Click(object sender, EventArgs e)
        {
            MettreTransactionAJour();
        }

        private void BtnSupprimerTransaction_Click(object sender, EventArgs e)
        {
            SupprimerTransaction();
        }

        /********************************************
          HELPERS
         *********************************************/

        private void MettreTransactionAJour()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    var transaction = db.EveAcquisitionServicesFournitures.Where(afs => afs.CodeAcquisitionServiceFourniture == _codeTransaction).FirstOrDefault();
                    bool montantValide = Validation.QuantiteSuperieurAZero(Conversion.EnleverEspaces(txtMontantServFourn.Text));

                    // La date a changé
                    if (transaction.Date != dtpDateAchatServFourn.Value)
                    {
                        transaction.Date = dtpDateAchatServFourn.Value.Date;
                    }

                    // Le fournisseur a changé
                    if (cbxNomFournServFourn.Text != transaction.AgeFournisseursServicesFourniture.NomFournisseurServiceFourniture)
                    {
                        transaction.CodeFournisseurServiceFourniture = int.Parse(cbxNomFournServFourn.SelectedValue.ToString());
                    }

                    // Le nom du service/fourniture a changé
                    if (cbxNomServFourniture.Text != transaction.ResServicesFourniture.NomServiceFourniture)
                    {
                        transaction.CodeServiceFourniture = int.Parse(cbxNomServFourniture.SelectedValue.ToString());
                    }
                    // La description a changé

                    if (!string.IsNullOrEmpty(txtDescription.Text) && transaction.Description != txtDescription.Text)
                    {
                        transaction.Description = txtDescription.Text;
                    }

                    // Le montant de la transaction a changé
                    if (transaction.Montant.ToString() != Conversion.EnleverEspaces(txtMontantServFourn.Text))
                    {
                        transaction.Montant = decimal.Parse(Conversion.EnleverEspaces(txtMontantServFourn.Text));
                    }

                    int codeFournisseur = transaction.AgeFournisseursServicesFourniture.CodeFournisseurServiceFourniture;
                    var decaissement = transaction.EveDecaissements.Where(f => f.CodeFournisseurService == codeFournisseur).FirstOrDefault();

                    // S'Il y'avait un décaissement au moment de l'enregistrement de la transaction
                    if (decaissement != null)
                    {
                        int.TryParse(Conversion.EnleverEspaces(txtMontantPayeServFourn.Text), out int montantPaye);
                        int.TryParse(cbxComptePaiement.SelectedValue.ToString(), out int codeCompte);

                        // Le montant payé a changé
                        if (decaissement.Montant != montantPaye)
                        {
                            decaissement.Montant = montantPaye;
                        }

                        // Le compte de trésorerie utilisé pour le paiment a changé
                        if (decaissement.CodeCompte != codeCompte)
                        {
                            decaissement.CodeCompte = codeCompte;
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(txtMontantPayeServFourn.Text))
                        {
                            int.TryParse(Conversion.EnleverEspaces(txtMontantPayeServFourn.Text), out int montantPaye);
                            int.TryParse(cbxComptePaiement.SelectedValue.ToString(), out int codeCompte);
                            int codeTresoriere = int.Parse(cbxTresorieres.SelectedValue.ToString());

                            var newDecaissement = new EveDecaissement
                            {
                                CodeAcquisitionServiceFourniture = transaction.CodeAcquisitionServiceFourniture,
                                Montant = montantPaye,
                                CodeCompte = codeCompte,
                                CodeFournisseurService = transaction.CodeFournisseurServiceFourniture,
                                CodeEmploye = codeTresoriere,
                                Description = txtDescription.Text
                            };

                            db.EveDecaissements.Add(newDecaissement);
                        }
                    }
                   
                    db.SaveChanges();
                    MessageBox.Show("La transaction a été mise à jour.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur: La transaction n'a pas été mise à jour.");
                }
            }
        }

        private void SupprimerTransaction()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                if (MessageBox.Show("Voulez-vous réellement supprimer cette transaction?", "Message de confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        var transaction = db.EveAcquisitionServicesFournitures.Where(afs => afs.CodeAcquisitionServiceFourniture == _codeTransaction).FirstOrDefault();

                        var decaissements = transaction.EveDecaissements.ToList();

                        // S'Il y'avait un décaissement au moment de l'enregistrement de la transaction
                        if (decaissements != null)
                        {
                            foreach (var decaissement in decaissements)
                            {
                                db.EveDecaissements.Remove(decaissement);
                            }
                        }

                        db.EveAcquisitionServicesFournitures.Remove(transaction);
                        db.SaveChanges();
                        MessageBox.Show("La transaction a été supprimée.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erreur: La transaction n'a pas été supprimée.");
                    }
                }
            }
        }

        /********************************************
          AFFICHAGE DES DONNEES
         * ******************************************/
        private void ReloadAll()
        {
            ClearData();
            LoadListeTransactions();
        }

        private void LoadListeTransactions()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var achatServicesFournitures = (from afs in db.EveAcquisitionServicesFournitures
                              where afs.Date >= dtpDebut.Value.Date && afs.Date <= dtpFin.Value.Date
                              join fourn in db.AgeFournisseursServicesFournitures on afs.CodeFournisseurServiceFourniture equals fourn.CodeFournisseurServiceFourniture
                              select new
                              {
                                  Code = afs.CodeAcquisitionServiceFourniture,
                                  afs.Date,
                                  Fournisseur = fourn.NomFournisseurServiceFourniture
                              }).OrderBy(d => d.Date).ToList();

                DataTable dt = Conversion.ConvertirEnTableDeDonnees(achatServicesFournitures);
                dgvListeTransactionsServices.DataSource = dt;
            }
        }

        private void ClearData()
        {
            cbxNomFournServFourn.SelectedIndex = -1;
            cbxNomServFourniture.SelectedIndex = -1;
            cbxComptePaiement.SelectedIndex = -1;
            dtpDateAchatServFourn.Value = DateTime.Today;
            txtMontantServFourn.Clear();
            txtMontantPayeServFourn.Clear();
            txtDescription.Clear();
        }

        private void LoadDetailsTransaction(int codeTransaction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var transaction = db.EveAcquisitionServicesFournitures.Where(afs => afs.CodeAcquisitionServiceFourniture == codeTransaction).FirstOrDefault();

                cbxNomFournServFourn.DataSource = db.AgeFournisseursServicesFournitures.OrderBy(f => f.NomFournisseurServiceFourniture).ToList();
                cbxNomServFourniture.DataSource = db.ResServicesFournitures.OrderBy(sf => sf.NomServiceFourniture).ToList();
                cbxComptePaiement.DataSource = db.ResComptesTresoreries.OrderBy(c => c.NomCompte).ToList();
                dtpDateAchatServFourn.Value = transaction.Date;
                ageEmployeBindingSource.DataSource = Conversion.ListeEmployesPresents(dtpDateAchatServFourn);
                ageEmployeBindingSource1.DataSource = Conversion.ListeEmployesPresents(dtpDateAchatServFourn);


                txtMontantServFourn.Text = transaction.Montant.ToString("n0");
                var decaissement = transaction.EveDecaissements.FirstOrDefault();

                if (decaissement != null)
                {
                    txtMontantPayeServFourn.Text = decaissement.Montant.ToString("n0");
                    cbxComptePaiement.SelectedValue = decaissement.CodeCompte;
                    cbxTresorieres.SelectedValue = decaissement.CodeEmploye;
                }
                else
                {
                    cbxComptePaiement.SelectedValue = -1;
                }
                cbxNomFournServFourn.SelectedValue = transaction.CodeFournisseurServiceFourniture;
                cbxNomServFourniture.SelectedValue = transaction.CodeServiceFourniture;
                cbxRespServFournitures.SelectedValue = transaction.CodeEmploye;
                txtDescription.Text = transaction.Description;
            }
        }
    }
}
