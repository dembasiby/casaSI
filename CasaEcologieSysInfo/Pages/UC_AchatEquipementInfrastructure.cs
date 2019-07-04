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
    public partial class UC_AchatEquipementInfrastructure : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_AchatEquipementInfrastructure()
        {
            InitializeComponent();
        }

        private void LoadData()
        {          
            ageAutreFournisseursBindingSource.DataSource = db.AgeAutreFournisseurs.ToList();
            ageEmployesBindingSource.DataSource = db.AgeEmployes
                                                    .Where(em => em.Actif == true)
                                                    .OrderBy(em => em.PrenomNom)
                                                    .ToList();
            ageEmployesBindingSource1.DataSource = db.AgeEmployes
                                                    .Where(em => em.Actif == true)
                                                    .OrderBy(em => em.PrenomNom)
                                                    .ToList();
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.ToList();         
        }

        private void UC_AchatEquipementInfrastructure_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnNouveauFournisseurImmo_Click(object sender, EventArgs e)
        {
         
            AgeAutreFournisseur af = new AgeAutreFournisseur
            {
                NomAutreFournisseur = txtNomFournisseurImmo.Text,
                Localite = txtLocaliteFournisseurImmo.Text,
                SoldeInitialDetteFournisseur = int.Parse(txtSoldeInitialeDetteFournisseurImmo.Text)
            };

            db.AgeAutreFournisseurs.Add(af);
            db.SaveChanges();
            txtNomFournisseurImmo.Text = "";
            txtLocaliteFournisseurImmo.Text = "";
            txtSoldeInitialeDetteFournisseurImmo.Text = "00";
            MessageBox.Show("Une nouveau fournisseur d'équipement ou d'infrastructure a été ajoutée avec succès");
            LoadData();
             
        }

        private void BtnEqInfrExistant_Click(object sender, EventArgs e)
        {
            bool checkboxValue = cbxUtilisePourProduction.Checked;


            if (Validation.VerifierChampsMontant(txtMontant2.Text) && Validation.VerifierChampsMontant(txtQuantiteExistant.Text))
            {
                ResEquipementsInfrastructure einfr = new ResEquipementsInfrastructure()
                {
                    Nom = txtNomEqInfr2.Text,
                    DateAcquisition = DateTime.Parse(dtpAchatEqInfr2.Text),
                    DureeDeVie = int.Parse(txtDuree2.Text),
                    Quantite = int.Parse(txtQuantiteExistant.Text),
                    MaterielDeProduction = checkboxValue,
                    Montant = int.Parse(txtMontant2.Text)
                };

                db.ResEquipementsInfrastructures.Add(einfr);
                db.SaveChanges();
                txtNomEqInfr2.Text = "";
                txtDuree2.Text = "";
                txtMontant2.Text = "";
                txtQuantiteExistant.Text = "";
                MessageBox.Show("Un équipement ou infrastructure existant a été ajouté avec succès"); 
            }
            
        }

        private void BtnEnregistrerAchatEquipementInfrastructure_Click(object sender, EventArgs e)
        {
            AgeAutreFournisseur afourIm = db.AgeAutreFournisseurs.FirstOrDefault(af => af.NomAutreFournisseur == cbxFournisseurImmo.Text);
            AgeEmploye emp = db.AgeEmployes.FirstOrDefault(em=> em.PrenomNom == cbxRespImmo.Text);
            AgeEmploye tresoriere = db.AgeEmployes.FirstOrDefault(em=> em.PrenomNom == cbxTresoriere.Text);
            ResComptesTresorerie cpte = db.ResComptesTresoreries.FirstOrDefault(c => c.NomCompte == cbxComptePaiement.Text);

            if (Validation.VerifierChampsMontant(txtMontant1.Text) && Validation.VerifierChampsMontant(txtQuantite.Text))
            {
                ResEquipementsInfrastructure einfr = new ResEquipementsInfrastructure()
                {
                    Nom = txtNomEqInfr1.Text,
                    DateAcquisition = DateTime.Parse(dtpAchatEqInfr1.Text),
                    DureeDeVie = int.Parse(txtDuree1.Text),
                    MaterielDeProduction = cbxImmobilisationLieeAProduction.Checked,
                    Montant = int.Parse(txtMontant1.Text),
                    Quantite = int.Parse(txtQuantite.Text)
                };

                db.ResEquipementsInfrastructures.Add(einfr);
                db.SaveChanges();

                EveReceptionEquipementsInfrastructure reinfr = new EveReceptionEquipementsInfrastructure()
                {
                    CodeEquipementInfrastructure = einfr.CodeEquipementInfrastructure,
                    CodeAutreFournisseur = afourIm.CodeAutreFournisseur,
                    CodeEmploye = emp.CodeEmploye,
                };

                db.EveReceptionEquipementsInfrastructures.Add(reinfr);
                db.SaveChanges();

                // Décaissement effectué lors de l'acquisition de l'équipement ou de l'infrastructure
                // Il s'agit ici du montant au moment d'enregistrer la transaction. Souvent, il s'agit du 
                // premier accompte.

                if (int.Parse(txtMontantPaye.Text) > 0)
                {
                    EveDecaissement decaiss = new EveDecaissement
                    {
                        CodeReceptionEquipementInfrastructure = reinfr.CodeReceptionEquipementInfrastructure,
                        CodeAutreFournisseur = afourIm.CodeAutreFournisseur,
                        Description = "Acquisition de " + einfr.Nom,
                        DateDecaissement = einfr.DateAcquisition,
                        CodeEmploye = tresoriere.CodeEmploye,
                        CodeCompte = cpte.CodeCompte,
                        Montant = int.Parse(txtMontantPaye.Text),
                    };
                    db.EveDecaissements.Add(decaiss);
                    db.SaveChanges();
                }

                MessageBox.Show("Le nouvel achat ou acquisition d'équipement ou d'infrastructure a été enregistré avec succès!");
                txtNomEqInfr1.Text = "";
                txtDuree1.Text = "";
                txtMontant1.Text = "";
                txtQuantite.Text = "1";
                txtMontantPaye.Text = "";
            }

        }
    }
}
