using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages.Corrections
{
    public partial class UC_UpdateAchatMatPremiere : UserControl
    {
        private int _codeTransaction;

        public UC_UpdateAchatMatPremiere()
        {
            InitializeComponent();
        }

        private void DgvListeAchatsMatieres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListeAchatsMatieres.Rows[e.RowIndex];
            int codeTransaction = int.Parse(row.Cells["Code"].Value.ToString());
            _codeTransaction = codeTransaction;
            ClearData();
            LoadDetailsTransaction(_codeTransaction);
        }

        private void DtpDebut_ValueChanged(object sender, EventArgs e)
        {
            LoadListeTransactions();
        }

        private void DtpFin_ValueChanged(object sender, EventArgs e)
        {
            LoadListeTransactions();
        }

        private void BtnSupprimerTransaction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer cette transaction?", "Message de confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SupprimerTransaction();
                ClearData();
                LoadListeTransactions();
            }
        }

        private void BtnMettreTransactionAJour_Click(object sender, EventArgs e)
        {
            MettreTransactionAJour();
        }

        private void MettreTransactionAJour()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    var transaction = db.EveReceptionMatieresPremieres.Where(rmp => rmp.CodeReceptionMatierePremiere == _codeTransaction).FirstOrDefault();
                    bool montantValide = Validation.QuantiteSuperieurAZero(Conversion.EnleverEspaces(txtMontantAchat.Text));
                    bool quantiteValide = Validation.QuantiteSuperieurAZero(Conversion.EnleverEspaces(txtQuantite.Text));

                    // La date a changé
                    if (transaction.DateReception != dtpDateApprovisionnement.Value)
                    {
                        transaction.DateReception = dtpDateApprovisionnement.Value.Date;
                    }

                    // Le fournisseur a changé
                    if (cbxFournisseurMPrem.Text != transaction.AgeFournisseursMatieresPremiere.Nom)
                    {
                        transaction.CodeFournisseurMatierePremiere = int.Parse(cbxFournisseurMPrem.SelectedValue.ToString());
                    }

                    // Le nom de la matière première, de l'emballage ou de l'étiquette a changé
                    if (cbxNomMatierePremiere.Text != transaction.ResStockMatieresPremiere.NomMatiere)
                    {
                        transaction.CodeMatierePremiere = int.Parse(cbxNomMatierePremiere.SelectedValue.ToString());
                    }
                    // La quantité a changé

                    if (int.Parse(transaction.Quantite.ToString()) != int.Parse(Conversion.EnleverEspaces(txtQuantite.Text)))
                    {
                        transaction.Quantite = int.Parse(Conversion.EnleverEspaces(txtQuantite.Text));
                    }

                    // Le montant de la transaction a changé
                    if (decimal.Parse(transaction.Montant.ToString()) != decimal.Parse(Conversion.EnleverEspaces(txtMontantAchat.Text)))
                    {
                        transaction.Montant = decimal.Parse(Conversion.EnleverEspaces(txtMontantAchat.Text));
                    }

                    // Le montant du transport a changé
                    if (decimal.Parse(transaction.TransportMatierePremiere.ToString()) != decimal.Parse(Conversion.EnleverEspaces(txtTransportMatierePremiere.Text)))
                    {
                        transaction.TransportMatierePremiere = decimal.Parse(Conversion.EnleverEspaces(txtTransportMatierePremiere.Text));
                    }

                    var decaissement = transaction.EveDecaissements.FirstOrDefault();

                    // S'Il y'avait un décaissement au moment de l'enregistrement de la transaction
                    if (decaissement != null)
                    {
                        int.TryParse(Conversion.EnleverEspaces(txtMontantPaye.Text), out int montantPaye);
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
                        if (!string.IsNullOrEmpty(txtMontantPaye.Text))
                        {
                            int.TryParse(Conversion.EnleverEspaces(txtMontantPaye.Text), out int montantPaye);
                            int.TryParse(cbxComptePaiement.SelectedValue.ToString(), out int codeCompte);
                            int codeTresoriere = int.Parse(cbxTresoriere.SelectedValue.ToString());

                            var newDecaissement = new EveDecaissement
                            {
                                CodeReceptionMatierePremiere = transaction.CodeReceptionMatierePremiere,
                                Montant = montantPaye,
                                CodeCompte = codeCompte,
                                CodeFournisseurMatierePremiere = transaction.CodeFournisseurMatierePremiere,
                                CodeEmploye = codeTresoriere,
                                Description = $"Achat de {transaction.ResStockMatieresPremiere.NomMatiere}"
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
            try
            {
                using (CasaDBEntities db = new CasaDBEntities())
                {
                    var transaction = db.EveReceptionMatieresPremieres.Where(rmp => rmp.CodeReceptionMatierePremiere == _codeTransaction).FirstOrDefault();
                    var decaissement = transaction.EveDecaissements.FirstOrDefault();

                    if (decaissement != null)
                    {
                        db.EveDecaissements.Remove(decaissement);
                    }

                    db.EveReceptionMatieresPremieres.Remove(transaction);
                    db.SaveChanges();
                    MessageBox.Show("La transaction a été supprimée.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur: La transaction n'a pas été supprimée.");
            }
        }

        private void LoadListeTransactions()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var achatMatieresPremieres = (from rmp in db.EveReceptionMatieresPremieres
                                              where rmp.DateReception >= dtpDebut.Value.Date && rmp.DateReception <= dtpFin.Value.Date
                                              join fourn in db.AgeFournisseursMatieresPremieres on rmp.CodeFournisseurMatierePremiere equals fourn.CodeFournisseurMatierePremiere
                                              select new
                                              {
                                                  Code = rmp.CodeReceptionMatierePremiere,
                                                  rmp.DateReception,
                                                  Fournisseur = fourn.Nom
                                              }).OrderBy(d => d.DateReception).ToList();

                DataTable dt = Conversion.ConvertirEnTableDeDonnees(achatMatieresPremieres);
                dgvListeAchatsMatieres.DataSource = dt;
            }
        }

        private void ClearData()
        {
            cbxNomMatierePremiere.SelectedIndex = -1;
            cbxFournisseurMPrem.SelectedIndex = -1;
            cbxComptePaiement.SelectedIndex = -1;
            cbxRespStocks.SelectedIndex = -1;
            cbxTresoriere.SelectedIndex = -1;
            dtpDateApprovisionnement.Value = DateTime.Today;
            txtQuantite.Clear();
            txtMontantAchat.Clear();
            txtTransportMatierePremiere.Clear();
            txtMontantPaye.Clear();
        }

        private void LoadDetailsTransaction(int codeTransaction)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                var transaction = db.EveReceptionMatieresPremieres.Where(rmp => rmp.CodeReceptionMatierePremiere == codeTransaction).FirstOrDefault();

                cbxNomMatierePremiere.DataSource = db.ResStockMatieresPremieres.OrderBy(mp => mp.NomMatiere).ToList();
                cbxFournisseurMPrem.DataSource = db.AgeFournisseursMatieresPremieres.OrderBy(f => f.Nom).ToList();
                cbxComptePaiement.DataSource = db.ResComptesTresoreries.OrderBy(c => c.NomCompte).ToList();
                dtpDateApprovisionnement.Value = transaction.DateReception;
                ageEmployeBindingSource.DataSource = Conversion.ListeEmployesPresents(dtpDateApprovisionnement);
                ageEmployeBindingSource1.DataSource = Conversion.ListeEmployesPresents(dtpDateApprovisionnement);


                txtMontantAchat.Text = transaction.Montant.ToString("n0");
                var decaissement = transaction.EveDecaissements.FirstOrDefault();

                if (decaissement != null)
                {
                    txtMontantPaye.Text = decaissement.Montant.ToString("n0");
                    cbxComptePaiement.SelectedValue = decaissement.CodeCompte;
                    cbxTresoriere.SelectedValue = decaissement.CodeEmploye;

                }
                else
                {
                    cbxComptePaiement.SelectedValue = -1;
                }
                cbxNomMatierePremiere.SelectedValue = transaction.CodeMatierePremiere;
                cbxFournisseurMPrem.SelectedValue = transaction.CodeFournisseurMatierePremiere;
                cbxRespStocks.SelectedValue = transaction.CodeEmploye;
                txtQuantite.Text = transaction.Quantite.ToString();
                txtTransportMatierePremiere.Text = transaction.TransportMatierePremiere.ToString();
                txtLocaliteFournisseur.Text = transaction.AgeFournisseursMatieresPremiere.Localite.ToString();
            }
        }

    }
}
