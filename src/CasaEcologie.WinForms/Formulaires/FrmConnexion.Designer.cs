namespace CasaEcologie.WinForms.Formulaires;

partial class FrmConnexion
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
        txtNomUtilisateur = new TextBox();
        txtMotDePasse = new TextBox();
        btnConnexion = new Button();
        btnQuitter = new Button();
        lblNomUtilisateur = new Label();
        lblMotDePasse = new Label();
        lblTitre = new Label();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitre.Location = new Point(100, 30);
        lblTitre.Name = "lblTitre";
        lblTitre.Size = new Size(200, 32);
        lblTitre.Text = "Casa Écologie";
        //
        // lblNomUtilisateur
        //
        lblNomUtilisateur.AutoSize = true;
        lblNomUtilisateur.Location = new Point(50, 90);
        lblNomUtilisateur.Name = "lblNomUtilisateur";
        lblNomUtilisateur.Size = new Size(120, 20);
        lblNomUtilisateur.Text = "Nom d'utilisateur";
        //
        // txtNomUtilisateur
        //
        txtNomUtilisateur.Location = new Point(50, 115);
        txtNomUtilisateur.Name = "txtNomUtilisateur";
        txtNomUtilisateur.Size = new Size(300, 27);
        //
        // lblMotDePasse
        //
        lblMotDePasse.AutoSize = true;
        lblMotDePasse.Location = new Point(50, 155);
        lblMotDePasse.Name = "lblMotDePasse";
        lblMotDePasse.Size = new Size(95, 20);
        lblMotDePasse.Text = "Mot de passe";
        //
        // txtMotDePasse
        //
        txtMotDePasse.Location = new Point(50, 180);
        txtMotDePasse.Name = "txtMotDePasse";
        txtMotDePasse.PasswordChar = '*';
        txtMotDePasse.Size = new Size(300, 27);
        //
        // btnConnexion
        //
        btnConnexion.Location = new Point(50, 230);
        btnConnexion.Name = "btnConnexion";
        btnConnexion.Size = new Size(140, 35);
        btnConnexion.Text = "Se connecter";
        btnConnexion.UseVisualStyleBackColor = true;
        btnConnexion.Click += BtnConnexion_Click;
        //
        // btnQuitter
        //
        btnQuitter.Location = new Point(210, 230);
        btnQuitter.Name = "btnQuitter";
        btnQuitter.Size = new Size(140, 35);
        btnQuitter.Text = "Quitter";
        btnQuitter.UseVisualStyleBackColor = true;
        btnQuitter.Click += BtnQuitter_Click;
        //
        // FrmConnexion
        //
        AcceptButton = btnConnexion;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(400, 300);
        Controls.Add(lblTitre);
        Controls.Add(lblNomUtilisateur);
        Controls.Add(txtNomUtilisateur);
        Controls.Add(lblMotDePasse);
        Controls.Add(txtMotDePasse);
        Controls.Add(btnConnexion);
        Controls.Add(btnQuitter);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "FrmConnexion";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Casa Écologie - Connexion";
        ResumeLayout(false);
        PerformLayout();
    }

    private TextBox txtNomUtilisateur;
    private TextBox txtMotDePasse;
    private Button btnConnexion;
    private Button btnQuitter;
    private Label lblNomUtilisateur;
    private Label lblMotDePasse;
    private Label lblTitre;
}
