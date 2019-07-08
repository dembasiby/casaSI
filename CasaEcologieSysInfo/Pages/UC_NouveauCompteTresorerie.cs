using System;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_NouveauCompteTresorerie : UserControl
    {
        public UC_NouveauCompteTresorerie()
        {
            InitializeComponent();
            txtSoldeCompte.Text = "00";
        }  

        private void BtnAjouterNouveauCompte_Click(object sender, EventArgs e)
        {
            using (CasaDBEntities db = new CasaDBEntities())
            {
                if (Validation.VerifierChampsMontant(txtSoldeCompte.Text) && txtNomCompte.Text.Trim().Length > 0)
                {
                    ResComptesTresorerie c = new ResComptesTresorerie()
                    {
                        NomCompte = txtNomCompte.Text,
                        SoldeCompte = decimal.Parse(txtSoldeCompte.Text)
                    };

                    db.ResComptesTresoreries.Add(c);
                    db.SaveChanges();
                    MessageBox.Show("Le nouveau compte a été ajouté avec succès.");
                    txtNomCompte.Clear();
                    txtSoldeCompte.Clear();
                }
                else
                {
                    MessageBox.Show("Le nouveau compte n'a pas été créé. Vérifiez que tous les champs sont correctement remplis.");
                }
            }
                
            
        }
    }
}
