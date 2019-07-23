using Squirrel;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace CasaEcologieSysInfo
{
    public partial class frmConnexion : Form
    {
        CasaDBEntities db = new CasaDBEntities();

        public frmConnexion()
        {
            InitializeComponent();

            
            Conversion.AjouterNumeroVersion(labelConn);
        }

        
        private async Task VerifierMiseAJour()
        {
            try
            {
                using (var mgr = new UpdateManager("https://github.com/dembasiby/casaSI/releases/latest"))
                {
                    await mgr.UpdateApp();
                }

                MessageBox.Show("Une nouvelle mise à jour est disponible et sera installée au prochain démarrage.");
            }
            catch (Exception)
            {

                MessageBox.Show("Aucune mise à jour disponible pour le moment.");
            }
            
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
            try
            {
                var user = (from usr in db.Utilisateurs
                            where usr.NomUtilisateur == txtNomUtilisateur.Text
                            where usr.AgeEmploye.Actif == true
                            where usr.MotDePasse == txtMotDePasse.Text
                            select usr.Role).FirstOrDefault();

                if (!user.Equals(null))
                {
                    using (frmAccueil fn = new frmAccueil(user))
                    {
                        this.Hide();
                        fn.ShowDialog();
                    }
                }              
            }
            catch (Exception)
            {
                MessageBox.Show("Votre nom d'utilisateur et/ou mot de passe sont incorrects.");
                return;
            }
        }
    }
}
