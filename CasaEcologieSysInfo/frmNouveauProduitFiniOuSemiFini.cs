using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    public partial class frmNouveauProduitFiniOuSemiFini : Form
    {
        CasaDBEntities2 db = new CasaDBEntities2();
        UC_Production prod = new UC_Production();

        public frmNouveauProduitFiniOuSemiFini()
        {
            InitializeComponent();
        }

        private void BtnAjouterNouveauProduitFiniOuSFini_Click(object sender, EventArgs e)
        {
            prod.VerifierChampsQuantite(txtStockInitialProduitFini.Text);
           

            if ((txtNomProduitFini.Text != "" && txtNomProduitSemiFini.Text != "") ||
                (txtNomProduitFini.Text == "" && txtNomProduitSemiFini.Text == "")
                )
            {
                MessageBox.Show("Les deux champs 'Produit fini' et 'Produit semi-fini' ne peuvent contenir des characteres en même temps. Veuillez remplir l'un ou l'autre.");
                return;
            }

            if (txtNomProduitFini.Text != "")
            {
                CreerNouveauProduitFini(txtNomProduitFini.Text, txtStockInitialProduitFini.Text);
            }
            else
            {
                CreerNouveauProduitSemiFini(txtNomProduitSemiFini.Text, txtStockInitialProduitFini.Text);
            }

            prod.LoadData();
        }

        private void CreerNouveauProduitSemiFini(string text1, string text2)
        {
            var nomMatierPremiere = cbxNomMatiereP.GetItemText(cbxNomMatiereP.SelectedItem);
            ResStockMatieresPremiere mp = db.ResStockMatieresPremieres.FirstOrDefault(n => n.NomMatiere == nomMatierPremiere);
            prod.VerifierChampsQuantite(txtStockInitialProduitFini.Text);

            try
            {
                ResStockProduitsSemiFini semiF = new ResStockProduitsSemiFini
                {
                    Description = txtNomProduitSemiFini.Text,
                    Quantite = int.Parse(txtStockInitialProduitFini.Text),
                    CodeMatierePremiere = mp.CodeMatierePremiere,
                };

                ;
                db.ResStockProduitsSemiFinis.Add(semiF);
                db.SaveChanges();

                MessageBox.Show("Le nouveau produit a été enregistré avec succès.");
                txtStockInitialProduitFini.Text = "00";
                txtNomProduitSemiFini.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le nouveau produit semi-fini n'a pas pu être enregistré.", ex.Message);
            }
        }

        private void CreerNouveauProduitFini(string nomProduit, string quantite)
        {
            try
            {
                prod.VerifierChampsQuantite(txtPrixDeVente.Text);

                ResStockProduitsFini pf = new ResStockProduitsFini
                {
                    NomProduit = nomProduit,
                    StockProduit = int.Parse(txtStockInitialProduitFini.Text),
                    PrixDeVenteStandard = int.Parse(txtPrixDeVente.Text)
                };

                db.ResStockProduitsFinis.Add(pf);
                db.SaveChanges();

                MessageBox.Show("Le nouveau produit fini a été enregistré avec succès.");
                txtPrixDeVente.Text = "00";
                txtStockInitialProduitFini.Text = "00";
                txtNomProduitFini.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le nouveau produit fini n'a pas pu être enregistré.", ex.Message);
            }
        }

        private void frmNouveauProduitFiniOuSemiFini_Load(object sender, EventArgs e)
        {
            resStockMatieresPremiereBindingSource.DataSource = db.ResStockMatieresPremieres.ToList();
        }
    }
}
