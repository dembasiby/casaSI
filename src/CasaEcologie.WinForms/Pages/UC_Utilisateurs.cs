using CasaEcologie.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CasaEcologie.WinForms.Pages;

public partial class UC_Utilisateurs : UserControl
{
    private readonly ServiceContainer _services;

    public UC_Utilisateurs(ServiceContainer services)
    {
        _services = services;
        InitializeComponent();
    }

    private void UC_Utilisateurs_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    private void LoadData()
    {
        var employesActifs = _services.Db.AgeEmployes
            .Where(em => em.Actif)
            .OrderBy(em => em.PrenomNom)
            .ToList();

        cbxListeEmployes.DisplayMember = "PrenomNom";
        cbxListeEmployes.ValueMember = "CodeEmploye";
        cbxListeEmployes.DataSource = employesActifs;

        var users = _services.Db.Utilisateurs
            .Where(u => u.Role != "super admin")
            .Where(u => u.AgeEmploye.Actif)
            .Select(u => new
            {
                Nom = u.AgeEmploye.PrenomNom,
                u.NomUtilisateur
            })
            .ToList();

        dgvListeUtilisateurs.DataSource = users;
        dgvListeUtilisateurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        if (dgvListeUtilisateurs.Columns.Count > 0)
            dgvListeUtilisateurs.Columns[0].FillWeight = 200;
    }

    private void LoadUserData()
    {
        try
        {
            if (cbxListeAChanger.SelectedValue == null) return;

            var codeEmploye = Convert.ToInt32(cbxListeAChanger.SelectedValue);
            var user = _services.Db.Utilisateurs
                .FirstOrDefault(u => u.CodeEmploye == codeEmploye);

            if (user != null)
                txtUserAModifier.Text = user.NomUtilisateur;
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
            int userCode = Convert.ToInt32(cbxListeEmployes.SelectedValue);

            if (ValidateNewUserInfo())
            {
                string password = _services.Auth.HasherMotDePasse(txtPassword.Text);

                var user = new Utilisateur
                {
                    CodeEmploye = userCode,
                    NomUtilisateur = txtUsername.Text,
                    MotDePasse = password,
                    Role = "utilisateur"
                };

                _services.Db.Utilisateurs.Add(user);
                _services.Db.SaveChanges();

                MessageBox.Show("Le nouvel utilisateur a été enregistré.");
                txtUsername.Clear();
                txtPassword.Clear();
                txtPasswordConfirm.Clear();
                LoadUserData();
                LoadData();
            }
        }
        catch (Exception)
        {
            MessageBox.Show("L'utilisateur n'a pas été enregistré.");
        }
    }

    private void ChargerLaListe()
    {
        var employesAvecCompte = (from em in _services.Db.AgeEmployes
                                  join u in _services.Db.Utilisateurs on em.CodeEmploye equals u.CodeEmploye
                                  select em).ToList();

        cbxListeAChanger.DisplayMember = "PrenomNom";
        cbxListeAChanger.ValueMember = "CodeEmploye";
        cbxListeAChanger.DataSource = employesAvecCompte;
        LoadUserData();
    }

    private void BtnChargerListe_Click(object sender, EventArgs e)
    {
        ChargerLaListe();
    }

    private void CbxListeAChanger_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadUserData();
    }

    private void BtnModifierUser_Click(object sender, EventArgs e)
    {
        if (cbxListeAChanger.SelectedValue == null) return;

        int id = Convert.ToInt32(cbxListeAChanger.SelectedValue);
        var user = _services.Db.Utilisateurs.Find(id);

        if (user == null) return;

        if (_services.Auth.VerifierMotDePasse(txtAncienMotDePasse.Text, user.MotDePasse))
        {
            if (txtUserAModifier.Text.Trim().Length >= 4)
            {
                user.NomUtilisateur = txtUserAModifier.Text;

                if (!string.IsNullOrEmpty(txtNouveauMotDePasse.Text) && txtNouveauMotDePasse.Text.Length >= 6)
                {
                    string password = _services.Auth.HasherMotDePasse(txtNouveauMotDePasse.Text);
                    user.MotDePasse = password;
                }
                else
                {
                    MessageBox.Show("Le nouveau mot de passe n'est pas valide.");
                }

                _services.Db.SaveChanges();
                LoadData();
                MessageBox.Show("Les données de l'utilisateur ont été modifiées.");
            }
            else
            {
                MessageBox.Show("Merci de fournir un nom d'utilisateur valide (au moins 4 charactères).");
            }
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
            if (cbxListeAChanger.SelectedValue == null) return;

            int id = Convert.ToInt32(cbxListeAChanger.SelectedValue);
            var user = _services.Db.Utilisateurs.Find(id);

            if (user == null) return;

            if (user.Role != "super admin")
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _services.Db.Utilisateurs.Remove(user);
                    _services.Db.SaveChanges();
                    ChargerLaListe();
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez supprimer l'administrateur.");
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Impossible de terminer l'opération.");
        }
    }
}
