using Squirrel;
using System;
using System.Windows.Forms;
using System.Linq;

namespace CasaEcologieSysInfo
{
    public partial class frmConnexion : Form
    {
        CasaDBEntities db = new CasaDBEntities();
        private UpdateManager updateManager;

        public frmConnexion()
        {
            InitializeComponent();

            Conversion.AjouterNumeroVersion(labelConn);
            VerifierMiseAJour();
        }
       
        private async void VerifierMiseAJour()
        {
            try
            {
                using (var mgr = await UpdateManager.GitHubUpdateManager("https://github.com/dembasiby/casaSI"))
                {
                    updateManager = mgr;
                    var release = await mgr.UpdateApp();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message + Environment.NewLine;
                if (ex.InnerException != null)
                {
                    message += ex.InnerException.Message;
                }

                MessageBox.Show(message);
            }          
        }
        
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                            select usr).FirstOrDefault();

                string utilisateur = null;

                if (Hashing.ValidatePassword(txtMotDePasse.Text, user.MotDePasse))
                {
                    utilisateur = user.Role;
                }

                if (!utilisateur.Equals(null))
                {
                    using (FrmAccueil fn = new FrmAccueil(utilisateur))
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
