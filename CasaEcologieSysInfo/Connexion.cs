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
    public partial class Connexion : Form
    {
        CasaDBEntities2 db = new CasaDBEntities2();

        public Connexion()
        {
            InitializeComponent();
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
           
            using (Accueil fn = new Accueil())
            {
                this.Hide();
                fn.ShowDialog();
            }         
                
        }
    }
}
