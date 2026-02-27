namespace CasaEcologie.WinForms.Pages;

partial class UC_NouveauDecaissement
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
        grpDecaissement = new GroupBox();
        lblTypeFournisseur = new Label();
        cbxTypeFournisseur = new ComboBox();
        lblNomFournisseur = new Label();
        cbxNomFournisseur = new ComboBox();
        lblDetteFournisseur = new Label();
        txtDetteFournisseur = new TextBox();
        lblDate = new Label();
        dtpDateDecaissement = new DateTimePicker();
        lblTresoriere = new Label();
        cbxTresoriere = new ComboBox();
        lblCompte = new Label();
        cbxCompte = new ComboBox();
        lblSoldeCompte = new Label();
        txtSoldeCompte = new TextBox();
        lblMontant = new Label();
        txtMontantPaye = new TextBox();
        btnEnregistrerDecaissement = new Button();
        grpDecaissement.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(280, 10);
        lblTitre.Text = "Paiement dettes fournisseurs";
        //
        // grpDecaissement
        //
        grpDecaissement.Controls.Add(lblTypeFournisseur);
        grpDecaissement.Controls.Add(cbxTypeFournisseur);
        grpDecaissement.Controls.Add(lblNomFournisseur);
        grpDecaissement.Controls.Add(cbxNomFournisseur);
        grpDecaissement.Controls.Add(lblDetteFournisseur);
        grpDecaissement.Controls.Add(txtDetteFournisseur);
        grpDecaissement.Controls.Add(lblDate);
        grpDecaissement.Controls.Add(dtpDateDecaissement);
        grpDecaissement.Controls.Add(lblTresoriere);
        grpDecaissement.Controls.Add(cbxTresoriere);
        grpDecaissement.Controls.Add(lblCompte);
        grpDecaissement.Controls.Add(cbxCompte);
        grpDecaissement.Controls.Add(lblSoldeCompte);
        grpDecaissement.Controls.Add(txtSoldeCompte);
        grpDecaissement.Controls.Add(lblMontant);
        grpDecaissement.Controls.Add(txtMontantPaye);
        grpDecaissement.Controls.Add(btnEnregistrerDecaissement);
        grpDecaissement.Location = new Point(10, 50);
        grpDecaissement.Size = new Size(950, 350);
        grpDecaissement.Text = "Décaissement";
        //
        lblTypeFournisseur.AutoSize = true;
        lblTypeFournisseur.Location = new Point(10, 30);
        lblTypeFournisseur.Text = "Type de fournisseur";
        cbxTypeFournisseur.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxTypeFournisseur.Items.AddRange(new object[]
        {
            "Fournisseur de matière première",
            "Fournisseur d'équipement ou entrepreneur",
            "Fournisseur de services ou fournitures"
        });
        cbxTypeFournisseur.Location = new Point(200, 27);
        cbxTypeFournisseur.Size = new Size(300, 28);
        cbxTypeFournisseur.SelectedIndexChanged += CbxTypeFournisseur_SelectedIndexChanged;
        //
        lblNomFournisseur.AutoSize = true;
        lblNomFournisseur.Location = new Point(10, 65);
        lblNomFournisseur.Text = "Nom du fournisseur";
        cbxNomFournisseur.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxNomFournisseur.Location = new Point(200, 62);
        cbxNomFournisseur.Size = new Size(300, 28);
        cbxNomFournisseur.SelectedIndexChanged += CbxNomFournisseur_SelectedIndexChanged;
        //
        lblDetteFournisseur.AutoSize = true;
        lblDetteFournisseur.Location = new Point(10, 100);
        lblDetteFournisseur.Text = "Dette du fournisseur";
        txtDetteFournisseur.Location = new Point(200, 97);
        txtDetteFournisseur.Size = new Size(300, 27);
        txtDetteFournisseur.ReadOnly = true;
        //
        lblDate.AutoSize = true;
        lblDate.Location = new Point(10, 135);
        lblDate.Text = "Date";
        dtpDateDecaissement.Location = new Point(200, 132);
        dtpDateDecaissement.Size = new Size(300, 27);
        dtpDateDecaissement.ValueChanged += DtpDateDecaissement_ValueChanged;
        //
        lblTresoriere.AutoSize = true;
        lblTresoriere.Location = new Point(10, 170);
        lblTresoriere.Text = "Trésorière";
        cbxTresoriere.Location = new Point(200, 167);
        cbxTresoriere.Size = new Size(300, 28);
        //
        lblCompte.AutoSize = true;
        lblCompte.Location = new Point(10, 205);
        lblCompte.Text = "Compte";
        cbxCompte.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxCompte.Location = new Point(200, 202);
        cbxCompte.Size = new Size(300, 28);
        cbxCompte.SelectedIndexChanged += CbxCompte_SelectedIndexChanged;
        //
        lblSoldeCompte.AutoSize = true;
        lblSoldeCompte.Location = new Point(10, 240);
        lblSoldeCompte.Text = "Solde du compte";
        txtSoldeCompte.Location = new Point(200, 237);
        txtSoldeCompte.Size = new Size(300, 27);
        txtSoldeCompte.ReadOnly = true;
        //
        lblMontant.AutoSize = true;
        lblMontant.Location = new Point(10, 275);
        lblMontant.Text = "Montant payé";
        txtMontantPaye.Location = new Point(200, 272);
        txtMontantPaye.Size = new Size(300, 27);
        //
        btnEnregistrerDecaissement.BackColor = Color.FromArgb(40, 92, 41);
        btnEnregistrerDecaissement.FlatStyle = FlatStyle.Flat;
        btnEnregistrerDecaissement.FlatAppearance.BorderSize = 0;
        btnEnregistrerDecaissement.ForeColor = Color.WhiteSmoke;
        btnEnregistrerDecaissement.Location = new Point(200, 307);
        btnEnregistrerDecaissement.Size = new Size(300, 35);
        btnEnregistrerDecaissement.Text = "Enregistrer le paiement";
        btnEnregistrerDecaissement.UseVisualStyleBackColor = false;
        btnEnregistrerDecaissement.Click += BtnEnregistrerDecaissement_Click;
        //
        // UC_NouveauDecaissement
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(grpDecaissement);
        Name = "UC_NouveauDecaissement";
        Size = new Size(983, 635);
        Load += UC_NouveauDecaissement_Load;
        grpDecaissement.ResumeLayout(false);
        grpDecaissement.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private GroupBox grpDecaissement;
    private Label lblTypeFournisseur;
    private ComboBox cbxTypeFournisseur;
    private Label lblNomFournisseur;
    private ComboBox cbxNomFournisseur;
    private Label lblDetteFournisseur;
    private TextBox txtDetteFournisseur;
    private Label lblDate;
    private DateTimePicker dtpDateDecaissement;
    private Label lblTresoriere;
    private ComboBox cbxTresoriere;
    private Label lblCompte;
    private ComboBox cbxCompte;
    private Label lblSoldeCompte;
    private TextBox txtSoldeCompte;
    private Label lblMontant;
    private TextBox txtMontantPaye;
    private Button btnEnregistrerDecaissement;
}
