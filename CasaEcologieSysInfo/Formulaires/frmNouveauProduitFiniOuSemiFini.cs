using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    public partial class frmNouveauProduitFiniOuSemiFini : Form
    {
        CasaDBEntities db = new CasaDBEntities();
        UC_Production prod = new UC_Production();

        public frmNouveauProduitFiniOuSemiFini()
        {
            InitializeComponent();
        }

        private void BtnAjouterNouveauProduitFiniOuSFini_Click(object sender, EventArgs e)
        {
            prod.VerifierChampsQuantite(txtStockInitial.Text);
           

            if ((txtNomProduitFini.Text != "" && txtNomProduitSemiFini.Text != "") ||
                (txtNomProduitFini.Text == "" && txtNomProduitSemiFini.Text == "")
                )
            {
                MessageBox.Show("Les deux champs 'Produit fini' et 'Produit semi-fini' ne peuvent contenir des characteres en même temps. Veuillez remplir l'un ou l'autre.");
                return;
            }

            if (txtNomProduitFini.Text != "")
            {
                CreerNouveauProduitFini();
            }
            else
            {
                CreerNouveauProduitSemiFini();
            }

            prod.ChargerDonneesInitiales();
        }

        private void CreerNouveauProduitSemiFini()
        {
            var nomMatierPremiere = cbxNomMatiereP.GetItemText(cbxNomMatiereP.SelectedItem);
            ResStockMatieresPremiere mp = db.ResStockMatieresPremieres.FirstOrDefault(n => n.NomMatiere == nomMatierPremiere); 

            try
            {
                bool stockValide = prod.VerifierChampsQuantite(txtStockInitial.Text);
                bool coutUValide = prod.VerifierChampsQuantite(txtCoutUnitaire.Text);

                ResStockProduitsSemiFini semiF = new ResStockProduitsSemiFini
                {
                    Description = txtNomProduitSemiFini.Text,
                    Quantite = int.Parse(txtStockInitial.Text),
                    CodeMatierePremiere = mp.CodeMatierePremiere,
                    CoutUnitaire = int.Parse(txtCoutUnitaire.Text)
                };

                ;
                db.ResStockProduitsSemiFinis.Add(semiF);
                db.SaveChanges();

                MessageBox.Show("Le nouveau produit a été enregistré avec succès.");
                txtStockInitial.Text = "00";
                txtCoutUnitaire.Text = "00";
                txtNomProduitSemiFini.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le nouveau produit semi-fini n'a pas pu être enregistré.", ex.Message);
            }
        }

        private void CreerNouveauProduitFini()
        {
            try
            {
                bool prixValide = prod.VerifierChampsQuantite(txtPrixDeVente.Text);
                bool stockValide = prod.VerifierChampsQuantite(txtStockInitial.Text);
                bool coutUValide = prod.VerifierChampsQuantite(txtCoutUnitaire.Text);
                bool nomvalide = Validation.ChampsVide(txtNomProduitFini.Text);

                ResStockProduitsFini pf = new ResStockProduitsFini
                {
                    NomProduit = txtNomProduitFini.Text,
                    StockProduit = int.Parse(txtStockInitial.Text),
                    PrixDeVenteStandard = int.Parse(txtPrixDeVente.Text),
                    CoutUnitaire = int.Parse(txtCoutUnitaire.Text)
                    
                };

                db.ResStockProduitsFinis.Add(pf);
                db.SaveChanges();

                MessageBox.Show("Le nouveau produit fini a été enregistré avec succès.");
                txtPrixDeVente.Text = "00";
                txtStockInitial.Text = "00";
                txtCoutUnitaire.Text = "00";
                txtNomProduitFini.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le nouveau produit fini n'a pas pu être enregistré.", ex.Message);
            }
        }

        private void FrmNouveauProduitFiniOuSemiFini_Load(object sender, EventArgs e)
        {
            resStockMatieresPremiereBindingSource.DataSource = db.ResStockMatieresPremieres.OrderBy(mp => mp.NomMatiere).ToList();
        }
    }
}
