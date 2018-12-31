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
    public partial class UC_NouveauCompteTresorerie : UserControl
    {
        public UC_NouveauCompteTresorerie()
        {
            InitializeComponent();
        }

        private bool VerifierChampsSoldeInitial()
        {
            if (string.IsNullOrEmpty(txtSoldeCompte.Text))
            {
                MessageBox.Show("Ce champs doit être renseigné.");
                return false;
            }


            try
            {
                int temp = Convert.ToInt32(txtSoldeCompte.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ce champs doit contenir uniquement des nombres.");
                return false;
            }

            return true;
        }

        private void BtnAjouterNouveauCompte_Click(object sender, EventArgs e)
        {
            using (CasaDBEntities2 db = new CasaDBEntities2())
            {
                if (VerifierChampsSoldeInitial() && txtNomCompte.Text.Trim().Length > 0)
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
            }
                
            
        }
    }
}
