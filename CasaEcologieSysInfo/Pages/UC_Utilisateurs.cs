using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CasaEcologieSysInfo.Pages
{
    public partial class UC_Utilisateurs : UserControl
    {
        CasaDBEntities db = new CasaDBEntities();

        public UC_Utilisateurs()
        {
            InitializeComponent();
        }

        private void UC_Utilisateurs_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            ageEmployeBindingSource.DataSource = db.AgeEmployes.Where(em => em.Actif == true).OrderBy(em => em.PrenomNom).ToList();
            var users = (from user in db.Utilisateurs
                         where user.Role != "super admin"
                         where user.AgeEmploye.Actif == true
                         select new
                         {
                             Nom = user.AgeEmploye.PrenomNom,
                             user.NomUtilisateur
                         }).ToList();

            dgvListeUtilisateurs.DataSource = users;
            dgvListeUtilisateurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListeUtilisateurs.Columns[0].FillWeight = 200;
        }

        private void BtnNouvelUtilisateur_Click(object sender, EventArgs e)
        {
            try
            {
                int userCode = Convert.ToInt32(cbxListeEmployes.SelectedValue.ToString());
                bool usernameNotEmpty = txtUsername.Text.Trim().Length > 0;
                bool passwordAdequateLength = txtPassword.Text.Trim().Length > 0;

                if (txtUsername.Text.Trim().Length < 4)
                {
                    MessageBox.Show("Le nom d'utilisateur doit avoir au moins quatre (4) caractères.");
                    return;
                }
                else if (txtPassword.Text.Trim().Length < 6)
                {
                    MessageBox.Show("Le mot de passe doit avoir au moins six (6) caractères.");
                    return;
                }
                else if (txtPassword.Text != txtPasswordConfirm.Text)
                {
                    MessageBox.Show("Le mot de passe n'est pas identique dans les deux champs 'mot de passe' et 'confirmation mot de passe'.");
                    return;
                }
                else
                {
                    Utilisateur user = new Utilisateur
                    {
                        CodeEmploye = userCode,
                        NomUtilisateur = txtUsername.Text,
                        MotDePasse = txtPassword.Text,
                        Role = "utilisateur"
                    };

                    db.Utilisateurs.Add(user);
                    db.SaveChanges();

                    MessageBox.Show("Le nouvel utilisateur a été enregistré.");

                    LoadData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("L'utilisateur n'a pas été enregistré.");
            }
           
            
        }
    }
}
