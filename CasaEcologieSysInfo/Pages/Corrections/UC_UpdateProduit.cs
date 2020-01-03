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

        private void UC_UpdateVentes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                resStockProduitsFiniBindingSource.DataSource = db.ResStockProduitsFinis.OrderBy(prdt => prdt.NomProduit).ToList();
                AfficherDetailsProduit(CodeProduitSelectionne());
            }
        }

        private int CodeProduitSelectionne()
        {
            try
            {
                return int.Parse(cbxListeProduits.SelectedValue.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Code produit non trouvé.");
                return 0;
            }         
        }

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

        private void CbxListeProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherDetailsProduit(CodeProduitSelectionne());
        }

        private void BtnMettreProduitAJour_Click(object sender, EventArgs e)
        {
            MettreProduitAJour();
        }

        private void MettreProduitAJour()
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    int codeProduit = CodeProduitSelectionne();

                    var produit = db.ResStockProduitsFinis.Single(p => p.CodeProduit == codeProduit);

                    if (Validation.EstUnChiffre(txtStockInitial.Text)
                        && Validation.EstUnChiffre(txtStockInitial.Text)
                        && Validation.EstUnChiffre(txtStockInitial.Text)
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
    }
}
