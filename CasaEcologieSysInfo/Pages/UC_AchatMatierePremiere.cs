using CasaEcologieSysInfo.Classes;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    public partial class UC_AchatMatierePremiere : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_AchatMatierePremiere()
        {
            InitializeComponent();
        }

        private void LoadData()
        {

            ageFournisseursMatieresPremieresBindingSource.DataSource = db.AgeFournisseursMatieresPremieres.OrderBy(f => f.Nom).ToList();
            resStockMatieresPremieresBindingSource.DataSource = db.ResStockMatieresPremieres.OrderBy(m => m.NomMatiere).ToList();
            ChargerListeEmployes();
            resComptesTresorerieBindingSource.DataSource = db.ResComptesTresoreries.ToList();
            //cbxTypesMatieres.DataSource = (from mp in db.ResStockMatieresPremieres select mp.TypeMatiere).Distinct().ToList();
            Tresorerie.AfficherSoldeTresorerie(cbxComptePaiement, txtSoldeCompte);
        }

        private void ChargerListeEmployes()
        {
            ageEmployesBindingSource.DataSource = Conversion.ListeEmployesPresents(dtpDateApprovisionnement)
                                                    .OrderBy(em => em.PrenomNom)
                                                    .Select(em => em.PrenomNom)
                                                    .ToList();
            ageEmployesBindingSource1.DataSource = Conversion.ListeEmployesPresents(dtpDateApprovisionnement)
                                                    .OrderBy(em => em.PrenomNom)
                                                    .Select(em => em.PrenomNom)
                                                    .ToList();
        }

        private void UC_AchatMatierePremiere_Load(object sender, EventArgs e)
        {
            DateTimePicker myPicker = new DateTimePicker
            {
                Value = DateTime.Now
            };
            LoadData();            
        }

        private void BtnAjouterNouvelleMatierePremiere_Click(object sender, EventArgs e)
        {
            bool produitExisteDeja = db.ResStockMatieresPremieres.Any(mp => mp.NomMatiere.ToLower() == txtNomMatierePremiere.Text.ToLower());

            try
            {
                bool nomValide = !Validation.ChampsVide(txtNomMatierePremiere.Text);
                bool coutValide = Validation.EstUnChiffre(txtCoutUnitaire.Text);
                bool stockValide = Validation.EstUnChiffre(txtStockInitial.Text);

                if (!produitExisteDeja)
                {
                    ResStockMatieresPremiere matierePremiere = new ResStockMatieresPremiere
                    {
                        NomMatiere = txtNomMatierePremiere.Text,
                        TypeMatiere = cbxTypesMatieres.GetItemText(cbxTypesMatieres.SelectedItem),
                        CoutUnitaire = int.Parse(txtCoutUnitaire.Text),
                        StockMatiere = float.Parse(txtStockInitial.Text)
                    };

                    db.ResStockMatieresPremieres.Add(matierePremiere);
                    db.SaveChanges();
                    txtNomMatierePremiere.Clear();
                    txtStockInitial.Text = "0";
                    txtCoutUnitaire.Text = "0";
                    MessageBox.Show("Une nouvelle matière première a été ajoutée avec succès");
                    LoadData();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Merci de renseigner les champs vides");
                return;
            }
            
        }

        
        private EveReceptionMatieresPremiere AjouterNouvelleAchatMatierePremiere()
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
                TransportMatierePremiere = int.Parse(txtTransportMatierePremiere.Text),
                CodeFournisseurMatierePremiere = fournMp.CodeFournisseurMatierePremiere,
                CodeEmploye = resStocks.CodeEmploye,
            };
            
            db.EveReceptionMatieresPremieres.Add(achatMatiere);
            db.SaveChanges();
            return achatMatiere;
        }

        private void AjouterDecaissementTransportMatierePremiere(EveReceptionMatieresPremiere recep)
        {
            ResStockMatieresPremiere matPrem = db.ResStockMatieresPremieres.FirstOrDefault(mp => mp.NomMatiere == cbxNomMatierePremiere.Text);
            AgeEmploye tresoriere = db.AgeEmployes.FirstOrDefault(em => em.PrenomNom == cbxTresoriere.Text);
            ResComptesTresorerie tres = db.ResComptesTresoreries.FirstOrDefault(tr => tr.NomCompte == cbxComptePaiement.Text);

            if (int.Parse(txtTransportMatierePremiere.Text) > 0 && Tresorerie.IlYaAssezDeFondsDansLeCompte(cbxComptePaiement, txtTransportMatierePremiere))
            {
                EveDecaissement decaiss = new EveDecaissement
                {
                    CodeReceptionMatierePremiere = recep.CodeReceptionMatierePremiere,
                    Description = "Transport de " + matPrem.NomMatiere,
                    DateDecaissement = recep.DateReception,
                    CodeEmploye = tresoriere.CodeEmploye,
                    CodeCompte = tres.CodeCompte,
                    Montant = int.Parse(txtTransportMatierePremiere.Text),
                };

                db.EveDecaissements.Add(decaiss);
                db.SaveChanges();
            }
        }

        private void AjouterPaiementFournisseur(EveReceptionMatieresPremiere recep)
        {
            ResStockMatieresPremiere matPrem = db.ResStockMatieresPremieres.FirstOrDefault(mp => mp.NomMatiere == cbxNomMatierePremiere.Text);
            AgeFournisseursMatieresPremiere fournMp = db.AgeFournisseursMatieresPremieres.FirstOrDefault(fmp => fmp.Nom == cbxFournisseurMPrem.Text);
            AgeEmploye tresoriere = db.AgeEmployes.FirstOrDefault(em => em.PrenomNom == cbxTresoriere.Text);
            ResComptesTresorerie tres = db.ResComptesTresoreries.FirstOrDefault(tr => tr.NomCompte == cbxComptePaiement.Text);

           if (int.Parse(txtMontantPaye.Text) > 0 && Tresorerie.IlYaAssezDeFondsDansLeCompte(cbxComptePaiement, txtMontantPaye))
            {
                EveDecaissement decaiss = new EveDecaissement
                {
                    CodeReceptionMatierePremiere = recep.CodeReceptionMatierePremiere,
                    CodeFournisseurMatierePremiere = fournMp.CodeFournisseurMatierePremiere,
                    Description = "Achat de " + matPrem.NomMatiere,
                    DateDecaissement = recep.DateReception,
                    CodeEmploye = tresoriere.CodeEmploye,
                    CodeCompte = tres.CodeCompte,
                    Montant = int.Parse(txtMontantPaye.Text),
                };

                db.EveDecaissements.Add(decaiss);
                db.SaveChanges();
            }
        }

        private void BtnEnregistrerAchatMatierePremiere_Click(object sender, EventArgs e)
        {
            if (float.Parse(txtQuantite.Text) > 0 && int.Parse(txtMontant.Text) > 0)
            {
                if (Tresorerie.IlYaAssezDeFondsDansLeCompte(cbxComptePaiement, txtMontant))
                {
                    try
                    {
                        var recep = AjouterNouvelleAchatMatierePremiere();
                        AjouterDecaissementTransportMatierePremiere(recep);
                        AjouterPaiementFournisseur(recep);
                        MessageBox.Show("Un nouvel achat de matière première a été enregistré avec succès");
                        Tresorerie.AfficherSoldeTresorerie(cbxComptePaiement, txtSoldeCompte);
                        txtQuantite.Text = "0";
                        txtMontant.Text = "0";
                        txtMontantPaye.Text = "0";
                        txtTransportMatierePremiere.Text = "0";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }              
            }
            else
            {
                MessageBox.Show("Veuillez renseigner correctement les champs montant et quantité");
            }
           
        }

        private void CbxComptePaiement_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tresorerie.AfficherSoldeTresorerie(cbxComptePaiement, txtSoldeCompte);
        }

        private void BtnNouveauFournisseur_Click(object sender, EventArgs e)
        {
            if (FournisseurExisteDeja(txtNomFournisseurMP.Text, txtLocalite.Text))
            {
                MessageBox.Show("Ce fournisseur existe déjà dans la base de données. Merci de le choisir dans la liste déroulante.");
            }
            else if (Validation.VerifierChampsMontant(txtSoldeInitialeDette.Text))
           
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
                txtSoldeInitialeDette.Text = "0";
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

        private void DtpDateApprovisionnement_ValueChanged(object sender, EventArgs e)
        {
            ChargerListeEmployes();
        }
    }
}
