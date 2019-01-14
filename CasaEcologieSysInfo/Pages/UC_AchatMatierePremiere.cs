﻿using System;
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
    public partial class UC_AchatMatierePremiere : UserControl
    {
        CasaDBEntities2 db = new CasaDBEntities2();

        public UC_AchatMatierePremiere()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
           
            ageFournisseursMatieresPremieresBindingSource.DataSource = db.AgeFournisseursMatieresPremieres
                .ToList()
                .OrderBy(f => f.Nom);
            resStockMatieresPremieresBindingSource.DataSource = db.ResStockMatieresPremieres.ToList().OrderBy(m => m.NomMatiere);
            ageEmployesBindingSource.DataSource = db.AgeEmployes.ToList();
            ageEmployesBindingSource1.DataSource = db.AgeEmployes.ToList();
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.ToList();
           
        }

        private void UC_AchatMatierePremiere_Load(object sender, EventArgs e)
        {
            DateTimePicker myPicker = new DateTimePicker
            {
                Value = DateTime.Now
            };
            LoadData();
            AfficherSoldeCompte();
            
        }

        private void BtnAjouterNouvelleMatierePremiere_Click(object sender, EventArgs e)
        {
           
            ResStockMatieresPremiere matierePremiere = new ResStockMatieresPremiere
            {
                NomMatiere = txtNomMatierePremiere.Text,
                StockMatiere = int.Parse(txtStockInitial.Text)
            };

            db.ResStockMatieresPremieres.Add(matierePremiere);
            db.SaveChanges();
            txtNomMatierePremiere.Text = "";
            txtStockInitial.Text = "00";
            MessageBox.Show("Une nouvelle matière première a été ajoutée avec succès");
            LoadData();
            
        }

        private void AjouterNouvelleAchatMatierePremiere()
        {          
            ResStockMatieresPremiere matPrem = db.ResStockMatieresPremieres.FirstOrDefault(mp => mp.NomMatiere == cbxNomMatierePremiere.Text);
            AgeFournisseursMatieresPremiere fournMp = db.AgeFournisseursMatieresPremieres.FirstOrDefault(fmp => fmp.Nom == cbxFournisseurMPrem.Text);
            AgeEmploye resStocks = db.AgeEmployes.FirstOrDefault(em => em.PrenomNom == cbxRespStocks.Text);
            AgeEmploye tresoriere = db.AgeEmployes.FirstOrDefault(em => em.PrenomNom == cbxTresoriere.Text);
            ResComptesTresorerie tres = db.ResComptesTresoreries.FirstOrDefault(tr => tr.NomCompte == cbxComptePaiement.Text);


            EveReceptionMatieresPremiere achatMatiere = new EveReceptionMatieresPremiere
            {
                CodeMatierePremiere = matPrem.CodeMatierePremiere,
                DateReception = DateTime.Parse(dtpDateApprovisionnement.Text),
                Quantite = float.Parse(txtQuantite.Text),
                Montant = int.Parse(txtMontant.Text),
                CodeFournisseurMatierePremiere = fournMp.CodeFournisseurMatierePremiere,
                CodeEmploye = resStocks.CodeEmploye,
            };
     
            if (int.Parse(txtMontantPaye.Text) > 0)
            {
                EveDecaissement decaiss = new EveDecaissement
                {
                    CodeReceptionMatierePremiere = achatMatiere.CodeReceptionMatierePremiere,
                    CodeFournisseurMatierePremiere = fournMp.CodeFournisseurMatierePremiere,
                    Description = "Achat de " + matPrem.NomMatiere,
                    DateDecaissement = achatMatiere.DateReception,
                    CodeEmploye = tresoriere.CodeEmploye,
                    CodeCompte = tres.CodeCompte,
                    Montant = int.Parse(txtMontantPaye.Text),
                };

                db.EveDecaissements.Add(decaiss);
            }
            db.EveReceptionMatieresPremieres.Add(achatMatiere);
            db.SaveChanges();
            AfficherSoldeCompte();
        }

        private void BtnEnregistrerAchatMatierePremiere_Click(object sender, EventArgs e)
        {
            if (VerifierSoldeCompteTresorerie())
            {
                try
                {
                    AjouterNouvelleAchatMatierePremiere();
                    MessageBox.Show("Un nouvel achat de matière première a été enregistré avec succès");
                    txtQuantite.Text = "";
                    txtMontant.Text = "";
                    txtMontantPaye.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur {0}", ex.Message);
                }
            }
           
        }

        private void cbxComptePaiement_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherSoldeCompte();
        }

        private decimal SoldeDuCompteSelectionne()
        {
            var compte = cbxComptePaiement.GetItemText(cbxComptePaiement.SelectedItem);
            return Conversion.SoldeDisponibleDuCompteDeTresorerie(compte);
        }
        private void AfficherSoldeCompte()
        {
            txtSoldeCompte.Text = SoldeDuCompteSelectionne().ToString("c0");
        }

        private bool VerifierSoldeCompteTresorerie()
        {
            try
            {
                bool verif = decimal.Parse(txtMontantPaye.Text) < SoldeDuCompteSelectionne();
            }
            catch (Exception)
            {
                MessageBox.Show("Il n'y a pas assez de fonds dans le compte séléctionné pour effectuer ce paiement. Veuillez changer de compte ou diminuer le montant.");
                return false;
            }

            return true;
        }

        private void BtnNouveauFournisseur_Click(object sender, EventArgs e)
        {
            if (FournisseurExisteDeja(txtNomFournisseurMP.Text, txtLocalite.Text))
            {
                MessageBox.Show("Ce fournisseur existe déjà dans la base de données. Merci de le choisir dans la liste déroulante.");
            }
            else if (VerifierChampsMontant(txtSoldeInitialeDette.Text))
           
            {
                AgeFournisseursMatieresPremiere fmp = new AgeFournisseursMatieresPremiere
                {
                    Nom = txtNomFournisseurMP.Text,
                    Localite = txtLocalite.Text,
                    SoldeDette = int.Parse(txtSoldeInitialeDette.Text)
                };

                db.AgeFournisseursMatieresPremieres.Add(fmp);
                db.SaveChanges();
                MessageBox.Show("Le nouveau fournisseur a été ajouté avec succès.");
                LoadData();
                txtNomFournisseurMP.Clear();
                txtLocalite.Clear();
                txtSoldeInitialeDette.Text = "00";
            }
            
        }

        private bool FournisseurExisteDeja(string nomFournisseur, string localiteFournisseur)
        {
            try
            {
                var fournisseur = (from f in db.AgeFournisseursMatieresPremieres
                                   where f.Nom == txtNomFournisseurMP.Text
                                   where f.Localite == txtLocalite.Text
                                   select f).First();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        private bool VerifierChampsMontant(string nomChamps)
        {
            if (string.IsNullOrEmpty(nomChamps))
            {
                MessageBox.Show("Ce champs doit être renseigné.");
                return false;
            }

            try
            {
                int temp = Convert.ToInt32(nomChamps);
            }
            catch (Exception)
            {
                MessageBox.Show("Ce champs doit contenir uniquement des nombres.");
                return false;
            }

            return true;
        }
    }
}
