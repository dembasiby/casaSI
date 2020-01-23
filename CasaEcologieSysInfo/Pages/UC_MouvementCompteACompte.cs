﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.ToList();
            resComptesTresorerieBindingSource1.DataSource = db.ResComptesTresoreries.ToList();
            ChargerListeEmployes();

            Tresorerie.AfficherSoldeTresorerie(cbxCompteDebit, txtSoldeCompte);
        }

        private bool ComptesDifferents(string cpte1, string cpte2)
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
            var cpteDebiteur = cbxCompteDebit.GetItemText(cbxCompteDebit.SelectedItem);
            var cpteCrediteur = cbxCompteCredit.GetItemText(cbxCompteCredit.SelectedItem);
            var employe = cbxEmploye.GetItemText(cbxEmploye.SelectedItem);
            var codeEmploye = (from em in db.AgeEmployes
                               where em.PrenomNom == employe
                               select em.CodeEmploye).FirstOrDefault();

            if (Validation.MontantEstValide(txtMontant.Text))
            {
                if (ComptesDifferents(cpteDebiteur, cpteCrediteur))
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
                                CodeEmploye = codeEmploye,
                                CodeCompte = (from cpte in db.ResComptesTresoreries
                                              where cpte.NomCompte == cpteDebiteur
                                              select cpte.CodeCompte).FirstOrDefault(),
                            };

                            db.EveDecaissements.Add(decaissement);
                            db.SaveChanges();

                            EveEncaissement encaissement = new EveEncaissement
                            {
                                CodeCompte = (from cpte in db.ResComptesTresoreries
                                              where cpte.NomCompte == cpteCrediteur
                                              select cpte.CodeCompte).FirstOrDefault(),
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
            ChargerListeEmployes();
        }
    }
}
