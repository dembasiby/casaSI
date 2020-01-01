using CasaEcologieSysInfo.Classes;
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

        private void LoadUserData()
        {
            try
            {
                var codeEmploye = cbxListeAChanger.SelectedValue.ToString();

                var user = (from u in db.Utilisateurs
                            where u.CodeEmploye.ToString() == codeEmploye
                            select u).FirstOrDefault();

                txtUserAModifier.Text = user.NomUtilisateur;
                //txtNouveauMotDePasse.Text = user.MotDePasse;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pas de données utilisateurs disponibles: " + ex.Message);
            }

        }

        private bool ValidateNewUserInfo()
        {
            if (txtUsername.Text.Trim().Length < 4)
            {
                MessageBox.Show("Le nom d'utilisateur doit avoir au moins quatre (4) caractères.");
                return false;
            }
            else if (txtPassword.Text.Trim().Length < 6)
            {
                MessageBox.Show("Le mot de passe doit avoir au moins six (6) caractères.");
                return false;
            }
            else if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                MessageBox.Show("Le mot de passe n'est pas identique dans les deux champs 'mot de passe' et 'confirmation mot de passe'.");
                return false;
            }
           
            return true;
        }

        private void BtnNouvelUtilisateur_Click(object sender, EventArgs e)
        {
            try
            {
                int userCode = Convert.ToInt32(cbxListeEmployes.SelectedValue.ToString());
                bool usernameNotEmpty = txtUsername.Text.Trim().Length > 0;
                bool passwordAdequateLength = txtPassword.Text.Trim().Length > 0;
                string password = "";
               
                if (ValidateNewUserInfo())
                {
                    password = Hashing.HashPassword(txtPassword.Text);
                    MessageBox.Show(password);
                    Utilisateur user = new Utilisateur
                    {
                        CodeEmploye = userCode,
                        NomUtilisateur = txtUsername.Text,
                        MotDePasse = password,
                        Role = "utilisateur"
                    };

                    db.Utilisateurs.Add(user);
                    db.SaveChanges();

                    MessageBox.Show("Le nouvel utilisateur a été enregistré.");
                    LoadUserData();
                    LoadData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("L'utilisateur n'a pas été enregistré.");
            }
           
            
        }

        private void BtnChargerListe_Click(object sender, EventArgs e)
        {
            utilisateurBindingSource.DataSource = (from em in db.AgeEmployes
                                                   join u in db.Utilisateurs on em.CodeEmploye equals u.CodeEmploye
                                                   select em).ToList();

            cbxListeAChanger.DisplayMember = "PrenomNom";
            cbxListeAChanger.ValueMember = "CodeEmploye";
            LoadUserData();

        }

        private void CbxListeAChanger_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void BtnModifierUser_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbxListeAChanger.SelectedValue);
            Utilisateur user = db.Utilisateurs.Find(id);
            string password = Hashing.HashPassword(txtNouveauMotDePasse.Text);

            if (user.MotDePasse == txtAncienMotDePasse.Text)
            {
                user.NomUtilisateur = txtUserAModifier.Text;
                user.MotDePasse = password;

                db.SaveChanges();
                LoadData();
                MessageBox.Show("Les données de l'utilisateur ont été modifiées.");
            }
            else
            {
                MessageBox.Show("Merci de fournir d'abord le mot de passe actuel avant d'en proposer un nouveau.");
            }
        }

        private void BtnSupprimerUser_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cbxListeAChanger.SelectedValue);
                Utilisateur user = db.Utilisateurs.Find(id);

                if (user.Role != "admin")
                {
                    db.Utilisateurs.Remove(user);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez supprimer cet utilisateur.");
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("Impossible de terminer l'opération.");
            }
        }
    }
}
