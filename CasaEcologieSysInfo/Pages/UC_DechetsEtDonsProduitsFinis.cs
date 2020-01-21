using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_DechetsEtDonsProduitsFinis : UserControl
    {
        public UC_DechetsEtDonsProduitsFinis()
        {
            InitializeComponent();
        }

        private void UC_DechetsEtDonsProduitsFinis_Load(object sender, EventArgs e)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                resStockProduitsFiniBindingSource.DataSource = db.ResStockProduitsFinis.OrderBy(pf => pf.NomProduit).ToList();
                ageEmployeBindingSource.DataSource = Conversion.ListeEmployesPresents(dtpDateSortieDechetsOuDons).OrderBy(em => em.PrenomNom).ToList();

                AfficherStockDisponible();              
            }
        }

        private void BtnEnregistrerSortie_Click(object sender, EventArgs e)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                try
                {
                    int codeProduitFini = Convert.ToInt32(cbxProduitsFinis.SelectedValue.ToString());
                    int codeResponsableStock = Convert.ToInt32(cbxResponsableStock.SelectedValue.ToString());
                    bool montantValide = Validation.MontantEstValide(txtQuantite.Text);
                    bool descriptionRens = !Validation.ChampsVide(txtDescription.Text);

                    EveSortieDonsOuDechetsProduitsFini ddpf = new EveSortieDonsOuDechetsProduitsFini()
                    {
                        DateSortie = dtpDateSortieDechetsOuDons.Value.Date,
                        Description = txtDescription.Text,
                        CodeProduitFini = codeProduitFini,
                        QuantiteProduitFini = int.Parse(txtQuantite.Text),
                        CodeResponsableSortie = codeResponsableStock,
                    };

                    db.EveSortieDonsOuDechetsProduitsFinis.Add(ddpf);
                    db.SaveChanges();
                    txtDescription.Clear();
                    txtQuantite.Clear();
                    MessageBox.Show("L'enregistrement a été effectué avec succès.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Merci de vérifier vos données. L'enregistrement n'a pas été effectué.");
                }
            }
        }

        private void AfficherStockDisponible()
        {
            try
            {
                DateTime date = dtpDateSortieDechetsOuDons.Value.Date;
                string prdtFini = cbxProduitsFinis.GetItemText(cbxProduitsFinis.SelectedItem);
                MessageBox.Show("Produit finis: " + prdtFini);
                txtStockDisponible.Text = GestionStocks.CalculerSoldeStockProduitFini(prdtFini, date).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur affichage stock produit fini.");
            }
        }

        private void CbxProduitsFinis_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherStockDisponible();
        }
    }
}
