namespace CasaEcologie.WinForms.Pages;

partial class UC_Utilisateurs
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitre = new Label();
        grpListeUtilisateurs = new GroupBox();
        dgvListeUtilisateurs = new DataGridView();
        grpNouvelUtilisateur = new GroupBox();
        cbxListeEmployes = new ComboBox();
        txtPasswordConfirm = new TextBox();
        txtPassword = new TextBox();
        txtUsername = new TextBox();
        btnNouvelUtilisateur = new Button();
        lblConfirmerMdp = new Label();
        lblMotDePasse = new Label();
        lblNomUtilisateur = new Label();
        lblEmployes = new Label();
        grpGestionUtilisateurs = new GroupBox();
        lblNomEmploye = new Label();
        lblUserNom = new Label();
        lblAncienMdp = new Label();
        lblNouveauMdp = new Label();
        btnModifierUser = new Button();
        btnChargerListe = new Button();
        btnSupprimerUser = new Button();
        txtAncienMotDePasse = new TextBox();
        txtNouveauMotDePasse = new TextBox();
        txtUserAModifier = new TextBox();
        cbxListeAChanger = new ComboBox();
        grpListeUtilisateurs.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvListeUtilisateurs).BeginInit();
        grpNouvelUtilisateur.SuspendLayout();
        grpGestionUtilisateurs.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(372, 18);
        lblTitre.Name = "lblTitre";
        lblTitre.Size = new Size(242, 32);
        lblTitre.Text = "Gestion des utilisateurs";
        //
        // grpListeUtilisateurs
        //
        grpListeUtilisateurs.Controls.Add(dgvListeUtilisateurs);
        grpListeUtilisateurs.Location = new Point(15, 78);
        grpListeUtilisateurs.Name = "grpListeUtilisateurs";
        grpListeUtilisateurs.Size = new Size(391, 199);
        grpListeUtilisateurs.Text = "Liste des utilisateurs";
        //
        // dgvListeUtilisateurs
        //
        dgvListeUtilisateurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvListeUtilisateurs.Location = new Point(7, 27);
        dgvListeUtilisateurs.Name = "dgvListeUtilisateurs";
        dgvListeUtilisateurs.ReadOnly = true;
        dgvListeUtilisateurs.RowHeadersVisible = false;
        dgvListeUtilisateurs.Size = new Size(378, 166);
        //
        // grpNouvelUtilisateur
        //
        grpNouvelUtilisateur.Controls.Add(cbxListeEmployes);
        grpNouvelUtilisateur.Controls.Add(txtPasswordConfirm);
        grpNouvelUtilisateur.Controls.Add(txtPassword);
        grpNouvelUtilisateur.Controls.Add(txtUsername);
        grpNouvelUtilisateur.Controls.Add(btnNouvelUtilisateur);
        grpNouvelUtilisateur.Controls.Add(lblConfirmerMdp);
        grpNouvelUtilisateur.Controls.Add(lblMotDePasse);
        grpNouvelUtilisateur.Controls.Add(lblNomUtilisateur);
        grpNouvelUtilisateur.Controls.Add(lblEmployes);
        grpNouvelUtilisateur.Location = new Point(455, 78);
        grpNouvelUtilisateur.Name = "grpNouvelUtilisateur";
        grpNouvelUtilisateur.Size = new Size(494, 199);
        grpNouvelUtilisateur.Text = "Créer un nouvel utilisateur";
        //
        // lblEmployes
        //
        lblEmployes.AutoSize = true;
        lblEmployes.Location = new Point(17, 31);
        lblEmployes.Name = "lblEmployes";
        lblEmployes.Size = new Size(82, 20);
        lblEmployes.Text = "Employés";
        //
        // cbxListeEmployes
        //
        cbxListeEmployes.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxListeEmployes.FormattingEnabled = true;
        cbxListeEmployes.Location = new Point(214, 30);
        cbxListeEmployes.Name = "cbxListeEmployes";
        cbxListeEmployes.Size = new Size(274, 28);
        //
        // lblNomUtilisateur
        //
        lblNomUtilisateur.AutoSize = true;
        lblNomUtilisateur.Location = new Point(17, 65);
        lblNomUtilisateur.Name = "lblNomUtilisateur";
        lblNomUtilisateur.Size = new Size(140, 20);
        lblNomUtilisateur.Text = "Nom d'utilisateur";
        //
        // txtUsername
        //
        txtUsername.Location = new Point(214, 65);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(274, 27);
        //
        // lblMotDePasse
        //
        lblMotDePasse.AutoSize = true;
        lblMotDePasse.Location = new Point(17, 95);
        lblMotDePasse.Name = "lblMotDePasse";
        lblMotDePasse.Size = new Size(115, 20);
        lblMotDePasse.Text = "Mot de passe";
        //
        // txtPassword
        //
        txtPassword.Location = new Point(214, 98);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(274, 27);
        //
        // lblConfirmerMdp
        //
        lblConfirmerMdp.AutoSize = true;
        lblConfirmerMdp.Location = new Point(17, 132);
        lblConfirmerMdp.Name = "lblConfirmerMdp";
        lblConfirmerMdp.Size = new Size(195, 20);
        lblConfirmerMdp.Text = "Confirmer Mot de passe";
        //
        // txtPasswordConfirm
        //
        txtPasswordConfirm.Location = new Point(214, 132);
        txtPasswordConfirm.Name = "txtPasswordConfirm";
        txtPasswordConfirm.PasswordChar = '*';
        txtPasswordConfirm.Size = new Size(274, 27);
        //
        // btnNouvelUtilisateur
        //
        btnNouvelUtilisateur.BackColor = Color.FromArgb(7, 31, 20);
        btnNouvelUtilisateur.FlatAppearance.BorderSize = 0;
        btnNouvelUtilisateur.FlatStyle = FlatStyle.Flat;
        btnNouvelUtilisateur.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnNouvelUtilisateur.ForeColor = Color.WhiteSmoke;
        btnNouvelUtilisateur.Location = new Point(260, 165);
        btnNouvelUtilisateur.Name = "btnNouvelUtilisateur";
        btnNouvelUtilisateur.Size = new Size(228, 31);
        btnNouvelUtilisateur.Text = "Enregistrer";
        btnNouvelUtilisateur.UseVisualStyleBackColor = false;
        btnNouvelUtilisateur.Click += BtnNouvelUtilisateur_Click;
        //
        // grpGestionUtilisateurs
        //
        grpGestionUtilisateurs.Controls.Add(lblNomEmploye);
        grpGestionUtilisateurs.Controls.Add(lblUserNom);
        grpGestionUtilisateurs.Controls.Add(lblAncienMdp);
        grpGestionUtilisateurs.Controls.Add(lblNouveauMdp);
        grpGestionUtilisateurs.Controls.Add(btnModifierUser);
        grpGestionUtilisateurs.Controls.Add(btnChargerListe);
        grpGestionUtilisateurs.Controls.Add(btnSupprimerUser);
        grpGestionUtilisateurs.Controls.Add(txtAncienMotDePasse);
        grpGestionUtilisateurs.Controls.Add(txtNouveauMotDePasse);
        grpGestionUtilisateurs.Controls.Add(txtUserAModifier);
        grpGestionUtilisateurs.Controls.Add(cbxListeAChanger);
        grpGestionUtilisateurs.Location = new Point(37, 306);
        grpGestionUtilisateurs.Name = "grpGestionUtilisateurs";
        grpGestionUtilisateurs.Size = new Size(465, 271);
        grpGestionUtilisateurs.Text = "Gestion des utilisateurs";
        //
        // btnChargerListe
        //
        btnChargerListe.BackColor = Color.Silver;
        btnChargerListe.FlatAppearance.BorderSize = 0;
        btnChargerListe.FlatStyle = FlatStyle.Flat;
        btnChargerListe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnChargerListe.ForeColor = Color.Black;
        btnChargerListe.Location = new Point(216, 26);
        btnChargerListe.Name = "btnChargerListe";
        btnChargerListe.Size = new Size(243, 31);
        btnChargerListe.Text = "Charger la liste";
        btnChargerListe.UseVisualStyleBackColor = false;
        btnChargerListe.Click += BtnChargerListe_Click;
        //
        // lblNomEmploye
        //
        lblNomEmploye.AutoSize = true;
        lblNomEmploye.Location = new Point(18, 72);
        lblNomEmploye.Name = "lblNomEmploye";
        lblNomEmploye.Size = new Size(149, 20);
        lblNomEmploye.Text = "Nom de l'employé";
        //
        // cbxListeAChanger
        //
        cbxListeAChanger.FormattingEnabled = true;
        cbxListeAChanger.Location = new Point(216, 72);
        cbxListeAChanger.Name = "cbxListeAChanger";
        cbxListeAChanger.Size = new Size(243, 28);
        cbxListeAChanger.SelectedIndexChanged += CbxListeAChanger_SelectedIndexChanged;
        //
        // lblUserNom
        //
        lblUserNom.AutoSize = true;
        lblUserNom.Location = new Point(18, 112);
        lblUserNom.Name = "lblUserNom";
        lblUserNom.Size = new Size(140, 20);
        lblUserNom.Text = "Nom d'utilisateur";
        //
        // txtUserAModifier
        //
        txtUserAModifier.Location = new Point(216, 112);
        txtUserAModifier.Name = "txtUserAModifier";
        txtUserAModifier.Size = new Size(243, 27);
        //
        // lblAncienMdp
        //
        lblAncienMdp.AutoSize = true;
        lblAncienMdp.Location = new Point(18, 145);
        lblAncienMdp.Name = "lblAncienMdp";
        lblAncienMdp.Size = new Size(175, 20);
        lblAncienMdp.Text = "Ancien mot de passe";
        //
        // txtAncienMotDePasse
        //
        txtAncienMotDePasse.Location = new Point(216, 145);
        txtAncienMotDePasse.Name = "txtAncienMotDePasse";
        txtAncienMotDePasse.PasswordChar = '*';
        txtAncienMotDePasse.Size = new Size(243, 27);
        //
        // lblNouveauMdp
        //
        lblNouveauMdp.AutoSize = true;
        lblNouveauMdp.Location = new Point(18, 184);
        lblNouveauMdp.Name = "lblNouveauMdp";
        lblNouveauMdp.Size = new Size(192, 20);
        lblNouveauMdp.Text = "Nouveau mot de passe";
        //
        // txtNouveauMotDePasse
        //
        txtNouveauMotDePasse.Location = new Point(216, 184);
        txtNouveauMotDePasse.Name = "txtNouveauMotDePasse";
        txtNouveauMotDePasse.PasswordChar = '*';
        txtNouveauMotDePasse.Size = new Size(243, 27);
        //
        // btnModifierUser
        //
        btnModifierUser.BackColor = Color.FromArgb(7, 31, 20);
        btnModifierUser.FlatAppearance.BorderSize = 0;
        btnModifierUser.FlatStyle = FlatStyle.Flat;
        btnModifierUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnModifierUser.ForeColor = Color.WhiteSmoke;
        btnModifierUser.Location = new Point(22, 228);
        btnModifierUser.Name = "btnModifierUser";
        btnModifierUser.Size = new Size(188, 31);
        btnModifierUser.Text = "Modifier";
        btnModifierUser.UseVisualStyleBackColor = false;
        btnModifierUser.Click += BtnModifierUser_Click;
        //
        // btnSupprimerUser
        //
        btnSupprimerUser.BackColor = Color.DarkRed;
        btnSupprimerUser.FlatAppearance.BorderSize = 0;
        btnSupprimerUser.FlatStyle = FlatStyle.Flat;
        btnSupprimerUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnSupprimerUser.ForeColor = Color.WhiteSmoke;
        btnSupprimerUser.Location = new Point(231, 228);
        btnSupprimerUser.Name = "btnSupprimerUser";
        btnSupprimerUser.Size = new Size(228, 31);
        btnSupprimerUser.Text = "Supprimer l'utilisateur";
        btnSupprimerUser.UseVisualStyleBackColor = false;
        btnSupprimerUser.Click += BtnSupprimerUser_Click;
        //
        // UC_Utilisateurs
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(grpGestionUtilisateurs);
        Controls.Add(grpNouvelUtilisateur);
        Controls.Add(grpListeUtilisateurs);
        Controls.Add(lblTitre);
        Name = "UC_Utilisateurs";
        Size = new Size(983, 635);
        Load += UC_Utilisateurs_Load;
        grpListeUtilisateurs.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvListeUtilisateurs).EndInit();
        grpNouvelUtilisateur.ResumeLayout(false);
        grpNouvelUtilisateur.PerformLayout();
        grpGestionUtilisateurs.ResumeLayout(false);
        grpGestionUtilisateurs.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private GroupBox grpListeUtilisateurs;
    private DataGridView dgvListeUtilisateurs;
    private GroupBox grpNouvelUtilisateur;
    private ComboBox cbxListeEmployes;
    private TextBox txtPasswordConfirm;
    private TextBox txtPassword;
    private TextBox txtUsername;
    private Button btnNouvelUtilisateur;
    private Label lblConfirmerMdp;
    private Label lblMotDePasse;
    private Label lblNomUtilisateur;
    private Label lblEmployes;
    private GroupBox grpGestionUtilisateurs;
    private Label lblNomEmploye;
    private Label lblUserNom;
    private Label lblAncienMdp;
    private Label lblNouveauMdp;
    private Button btnModifierUser;
    private Button btnChargerListe;
    private Button btnSupprimerUser;
    private TextBox txtAncienMotDePasse;
    private TextBox txtNouveauMotDePasse;
    private TextBox txtUserAModifier;
    private ComboBox cbxListeAChanger;
}
