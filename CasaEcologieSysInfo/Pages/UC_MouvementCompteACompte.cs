using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CasaEcologieSysInfo.Classes;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_MouvementCompteACompte : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_MouvementCompteACompte()
        {
            InitializeComponent();
        }

        private void UC_MouvementCompteACompte_Load(object sender, EventArgs e)
        {
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.OrderBy(ct => ct.NomCompte).ToList();
            resComptesTresorerieBindingSource1.DataSource = db.ResComptesTresoreries.OrderBy(ct => ct.NomCompte).ToList();
            ChargerListeEmployes();

            Tresorerie.AfficherSoldeTresorerie(cbxCompteDebit, txtSoldeCompte);
        }

        private bool ComptesDifferents(int cpte1, int cpte2)
        {
            if (cpte1 != cpte2)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Le transfert ne peut s'effectuer qu'avec deux comptes différents.");
                return false;
            }
        }

        private void BtnEnregistrerTransfert_Click(object sender, EventArgs e)
        {
            var codeCpteDebiteur = int.Parse(cbxCompteDebit.SelectedValue.ToString());
            var codeCpteCrediteur = int.Parse(cbxCompteCredit.SelectedValue.ToString());

            var employe = cbxEmploye.GetItemText(cbxEmploye.SelectedItem);
            var codeEmploye = (from em in db.AgeEmployes
                               where em.PrenomNom == employe
                               select em.CodeEmploye).FirstOrDefault();

            if (Validation.MontantEstValide(txtMontant.Text))
            {
                if (ComptesDifferents(codeCpteDebiteur, codeCpteCrediteur))
                {
                    if (Tresorerie.IlYaAssezDeFondsDansLeCompte(cbxCompteDebit, txtMontant))
                    {
                        if (txtDescription.Text.Trim().Length > 0)
                        {
                            EveDecaissement decaissement = new EveDecaissement
                            {
                                DateDecaissement = dtpDateOperation.Value.Date,
                                Description = txtDescription.Text,
                                Montant = int.Parse(txtMontant.Text),
                                DecaissementInterne = true,
                                CodeEmploye = codeEmploye,
                                CodeCompte = codeCpteDebiteur
                            };

                            db.EveDecaissements.Add(decaissement);
                            db.SaveChanges();

                            EveEncaissement encaissement = new EveEncaissement
                            {
                                CodeCompte = codeCpteCrediteur,
                                CodeEmploye = codeEmploye,
                            };

                            db.EveEncaissements.Add(encaissement);
                            db.SaveChanges();

                            EveEncaissementsAutre autreEnc = new EveEncaissementsAutre
                            {
                                CodeEncaissement = encaissement.CodeEncaissement,
                                DateEncaissement = dtpDateOperation.Value.Date,
                                Description = txtDescription.Text,
                                MontantEncaisse = int.Parse(txtMontant.Text)
                            };

                            db.EveEncaissementsAutres.Add(autreEnc);
                            db.SaveChanges();

                            var cpteDebiteur = cbxCompteDebit.GetItemText(cbxCompteDebit.SelectedText);
                            var cpteCrediteur = cbxCompteCredit.GetItemText(cbxCompteCredit.SelectedText);

                            MessageBox.Show($"Le transfert de fonds du compte {cpteDebiteur} au compte {cpteCrediteur} a été enregistré avec succès.");
                            txtDescription.Clear();
                            txtMontant.Clear();

                            Tresorerie.AfficherSoldeTresorerie(cbxCompteDebit, txtSoldeCompte);
                        }
                        else
                        {
                            MessageBox.Show("Veuillez ajouter une description à ce mouvement de compte à compte.");
                            return;
                        }
                    }
                }
            }
        }

        private void CbxCompteDebit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tresorerie.AfficherSoldeTresorerie(cbxCompteDebit, txtSoldeCompte);
        }

        private void DtpDateOperation_ValueChanged(object sender, EventArgs e)
        {
            ChargerListeEmployes();
        }
        
        private void ChargerListeEmployes()
        {
            cbxEmploye.DataSource = Conversion.ListeEmployesPresents(dtpDateOperation).OrderBy(em => em.PrenomNom).Select(em => em.PrenomNom).ToList();
        }
        
    }
}
