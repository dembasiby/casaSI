using Squirrel;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaEcologieSysInfo
{
    public partial class frmConnexion : Form
    {
        CasaDBEntities db = new CasaDBEntities();

        public frmConnexion()
        {
            InitializeComponent();

            VerifierMiseAJour();
        }

        private async Task VerifierMiseAJour()
        {
            using (var mgr = new UpdateManager("https://github.com/dembasiby/casaSI/Releases"))
            {
                await mgr.UpdateApp();
            }
        }

        private bool UtilisateurAutorise(string nomUtilisateur, string motDePasse)
        {
            /*
            var user

            if (user.Equals(null))
            {
                return false;
            }
            else
            {
                return true;
            }
            */
            return true;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Connexion_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            using (frmAccueil fn = new frmAccueil())
            {
                this.Hide();
                fn.ShowDialog();
            }         
                
        }
    }
}
