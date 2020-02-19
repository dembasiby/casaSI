using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages.Corrections
{
    public partial class UC_UpdateProduit : UserControl
    {
        public UC_UpdateProduit()
        {
            InitializeComponent();
        }

        /********************************************
         GESTION DES EVENEMENTS
        *********************************************/

        private void UC_UpdateVentes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void CbxListeProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherDetails();
        }

        private void CbxListeMatieres_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherDetails();
        }

        private void CbxListeProduitsSemiFini_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherDetails();
        }

        private void BtnMettreProduitAJour_Click(object sender, EventArgs e)
        {
            MettreProduitAJour();
        }

        private void BtnMettreMatiereAJour_Click(object sender, EventArgs e)
        {
            MettreMatiereAJour();
        }

        private void BtnMettreProduitSemiFiniAJour_Click(object sender, EventArgs e)
        {
            MettreProduitSemiFiniAJour();
        }

        /********************************************
          AFFICHAGE DES DETAILS
         *********************************************/

        private void AfficherDetails()
        {
            AfficherDetailsProduit(CodeProduitSelectionne(cbxListeProduits));
            AfficherDetailsMatiere(CodeProduitSelectionne(cbxListeMatieres));
            AfficherDetailsProduitSemiFini(CodeProduitSelectionne(cbxListeProduitsSemiFini));
        }

        // Détails produit fini
        private void AfficherDetailsProduit(int codeProduit)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    var produit = (from prdt in db.ResStockProduitsFinis
                                   where prdt.CodeProduit == codeProduit
                                   select prdt).FirstOrDefault();

                    txtNomProduit.Text = produit.NomProduit;
                    txtStockInitial.Text = produit.StockProduit.ToString();
                    txtCoutUnitaire.Text = produit.CoutUnitaire.ToString();
                    txtPrixDeVente.Text = produit.PrixDeVenteStandard.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Code produit non trouvé.");
                    return;
                }         
            }
        }

        // Détails matière première
        private void AfficherDetailsMatiere(int codeMatiere)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    var matiere = (from mtr in db.ResStockMatieresPremieres
                                   where mtr.CodeMatierePremiere == codeMatiere
                                   select mtr).FirstOrDefault();

                    txtMatierePrem.Text = matiere.NomMatiere;
                    txtStockInitialMatiere.Text = matiere.StockMatiere.ToString();
                    txtCoutAchatUnitaire.Text = matiere.CoutUnitaire.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Code matière non trouvé.");
                    return;
                }
            }
        }

        // Détails produit semi fini
        private void AfficherDetailsProduitSemiFini(int codeProduit)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    var produitSF = (from prdt in db.ResStockProduitsSemiFinis
                                   where prdt.CodeProduitSemiFini == codeProduit
                                   select prdt).FirstOrDefault();

                    txtProduitSemiFini.Text = produitSF.Description;
                    txtStockInitialProduitSemiFini.Text = produitSF.Quantite.ToString();
                    txtCoutUnitaireProduitSemiFini.Text = produitSF.CoutUnitaire.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Code produit semi fini non trouvé.");
                    return;
                }
            }
        }

        /********************************************
                HELPERS
        *********************************************/
        private void LoadData()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                resStockProduitsFiniBindingSource.DataSource = db.ResStockProduitsFinis.OrderBy(prdt => prdt.NomProduit).ToList();
                resStockMatieresPremiereBindingSource.DataSource = db.ResStockMatieresPremieres.OrderBy(mp => mp.NomMatiere).ToList();
                resStockProduitsSemiFiniBindingSource.DataSource = db.ResStockProduitsSemiFinis.OrderBy(psf => psf.Description).ToList();
                AfficherDetails();
            }
        }

        private int CodeProduitSelectionne(ComboBox combo)
        {
            try
            {
                return int.Parse(combo.SelectedValue.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Code produit non trouvé.");
                return 0;
            }
        }

        private void MettreProduitAJour()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    int codeProduit = CodeProduitSelectionne(cbxListeProduits);

                    var produit = db.ResStockProduitsFinis.Single(p => p.CodeProduit == codeProduit);

                    if (Validation.EstUnChiffre(txtStockInitial.Text)
                        && Validation.EstUnChiffre(txtPrixDeVente.Text)
                        && Validation.EstUnChiffre(txtCoutUnitaire.Text)
                        && !Validation.ChampsVide(txtNomProduit.Text))
                    {
                        produit.NomProduit = txtNomProduit.Text;
                        produit.StockProduit = int.Parse(txtStockInitial.Text);
                        produit.CoutUnitaire = int.Parse(txtCoutUnitaire.Text);
                        produit.PrixDeVenteStandard = int.Parse(txtPrixDeVente.Text);

                        db.SaveChanges();
                        MessageBox.Show("Le produit a été mis à jour.");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Veuillez vérifier vos données.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Il ya eu une erreur. Le produit n'a pas été mis à jour.");
                    return;
                }
            }
        }

        private void MettreMatiereAJour()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    int codeMatiere = CodeProduitSelectionne(cbxListeMatieres);

                    var matiere = db.ResStockMatieresPremieres.Single(p => p.CodeMatierePremiere == codeMatiere);

                    if (Validation.EstUnChiffre(txtStockInitialMatiere.Text)
                        && Validation.EstUnChiffre(txtCoutAchatUnitaire.Text)
                        && !Validation.ChampsVide(txtMatierePrem.Text))
                    {
                        matiere.NomMatiere = txtMatierePrem.Text;
                        matiere.StockMatiere = int.Parse(txtStockInitialMatiere.Text);
                        matiere.CoutUnitaire = int.Parse(txtCoutAchatUnitaire.Text);

                        db.SaveChanges();
                        MessageBox.Show("Le produit a été mis à jour.");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Veuillez vérifier vos données.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Il ya eu une erreur. La matière n'a pas été mise à jour.");
                    return;
                }
            }
        }
        private void MettreProduitSemiFiniAJour()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    int codeProduitSF = CodeProduitSelectionne(cbxListeProduitsSemiFini);

                    var produitSF = db.ResStockProduitsSemiFinis.Single(p => p.CodeProduitSemiFini == codeProduitSF);

                    if (Validation.EstUnChiffre(txtStockInitialProduitSemiFini.Text)
                        && Validation.EstUnChiffre(txtCoutUnitaireProduitSemiFini.Text)
                        && !Validation.ChampsVide(txtProduitSemiFini.Text))
                    {
                        produitSF.Description = txtProduitSemiFini.Text;
                        produitSF.Quantite = int.Parse(txtStockInitialProduitSemiFini.Text);
                        produitSF.CoutUnitaire = int.Parse(txtCoutUnitaire.Text);

                        db.SaveChanges();
                        MessageBox.Show("Le produit a été mis à jour.");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Veuillez vérifier vos données.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Il ya eu une erreur. Le produit n'a pas été mis à jour.");
                    return;
                }
            }
        }
    }
}
