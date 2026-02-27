namespace CasaEcologie.WinForms.Pages;

partial class UC_AchatMatierePremiere
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
        // Nouvelle matière première
        grpNouvelleMatiere = new GroupBox();
        lblNomMatierePremiere = new Label();
        txtNomMatierePremiere = new TextBox();
        lblTypeMatiere = new Label();
        cbxTypesMatieres = new ComboBox();
        lblCoutUnitaire = new Label();
        txtCoutUnitaire = new TextBox();
        lblStockInitial = new Label();
        txtStockInitial = new TextBox();
        btnAjouterNouvelleMatierePremiere = new Button();
        // Nouveau fournisseur
        grpNouveauFournisseur = new GroupBox();
        lblNomFournisseur = new Label();
        txtNomFournisseurMP = new TextBox();
        lblLocaliteFournisseur = new Label();
        txtLocaliteFournisseur = new TextBox();
        lblSoldeInitialeDette = new Label();
        txtSoldeInitialeDette = new TextBox();
        btnNouveauFournisseur = new Button();
        // Achat
        grpAchat = new GroupBox();
        lblMatiere = new Label();
        cbxNomMatierePremiere = new ComboBox();
        lblFournisseur = new Label();
        cbxFournisseurMPrem = new ComboBox();
        lblDate = new Label();
        dtpDateApprovisionnement = new DateTimePicker();
        lblQuantite = new Label();
        txtQuantite = new TextBox();
        lblMontant = new Label();
        txtMontant = new TextBox();
        lblTransport = new Label();
        txtTransportMatierePremiere = new TextBox();
        lblMontantPaye = new Label();
        txtMontantPaye = new TextBox();
        lblRespStocks = new Label();
        cbxRespStocks = new ComboBox();
        lblTresoriere = new Label();
        cbxTresoriere = new ComboBox();
        lblComptePaiement = new Label();
        cbxComptePaiement = new ComboBox();
        lblSoldeCompte = new Label();
        txtSoldeCompte = new TextBox();
        btnEnregistrerAchatMatierePremiere = new Button();
        grpNouvelleMatiere.SuspendLayout();
        grpNouveauFournisseur.SuspendLayout();
        grpAchat.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(280, 10);
        lblTitre.Text = "Achat de matières premières";
        //
        // grpNouvelleMatiere
        //
        grpNouvelleMatiere.Controls.Add(lblNomMatierePremiere);
        grpNouvelleMatiere.Controls.Add(txtNomMatierePremiere);
        grpNouvelleMatiere.Controls.Add(lblTypeMatiere);
        grpNouvelleMatiere.Controls.Add(cbxTypesMatieres);
        grpNouvelleMatiere.Controls.Add(lblCoutUnitaire);
        grpNouvelleMatiere.Controls.Add(txtCoutUnitaire);
        grpNouvelleMatiere.Controls.Add(lblStockInitial);
        grpNouvelleMatiere.Controls.Add(txtStockInitial);
        grpNouvelleMatiere.Controls.Add(btnAjouterNouvelleMatierePremiere);
        grpNouvelleMatiere.Location = new Point(10, 50);
        grpNouvelleMatiere.Size = new Size(460, 190);
        grpNouvelleMatiere.Text = "Nouvelle matière première";
        //
        lblNomMatierePremiere.AutoSize = true;
        lblNomMatierePremiere.Location = new Point(10, 30);
        lblNomMatierePremiere.Text = "Nom";
        txtNomMatierePremiere.Location = new Point(150, 27);
        txtNomMatierePremiere.Size = new Size(290, 27);
        lblTypeMatiere.AutoSize = true;
        lblTypeMatiere.Location = new Point(10, 60);
        lblTypeMatiere.Text = "Type";
        cbxTypesMatieres.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxTypesMatieres.Location = new Point(150, 57);
        cbxTypesMatieres.Size = new Size(290, 28);
        lblCoutUnitaire.AutoSize = true;
        lblCoutUnitaire.Location = new Point(10, 90);
        lblCoutUnitaire.Text = "Coût unitaire";
        txtCoutUnitaire.Location = new Point(150, 87);
        txtCoutUnitaire.Size = new Size(290, 27);
        txtCoutUnitaire.Text = "0";
        lblStockInitial.AutoSize = true;
        lblStockInitial.Location = new Point(10, 120);
        lblStockInitial.Text = "Stock initial";
        txtStockInitial.Location = new Point(150, 117);
        txtStockInitial.Size = new Size(290, 27);
        txtStockInitial.Text = "0";
        //
        btnAjouterNouvelleMatierePremiere.BackColor = Color.FromArgb(40, 92, 41);
        btnAjouterNouvelleMatierePremiere.FlatStyle = FlatStyle.Flat;
        btnAjouterNouvelleMatierePremiere.FlatAppearance.BorderSize = 0;
        btnAjouterNouvelleMatierePremiere.ForeColor = Color.WhiteSmoke;
        btnAjouterNouvelleMatierePremiere.Location = new Point(150, 150);
        btnAjouterNouvelleMatierePremiere.Size = new Size(290, 35);
        btnAjouterNouvelleMatierePremiere.Text = "Ajouter";
        btnAjouterNouvelleMatierePremiere.UseVisualStyleBackColor = false;
        btnAjouterNouvelleMatierePremiere.Click += BtnAjouterNouvelleMatierePremiere_Click;
        //
        // grpNouveauFournisseur
        //
        grpNouveauFournisseur.Controls.Add(lblNomFournisseur);
        grpNouveauFournisseur.Controls.Add(txtNomFournisseurMP);
        grpNouveauFournisseur.Controls.Add(lblLocaliteFournisseur);
        grpNouveauFournisseur.Controls.Add(txtLocaliteFournisseur);
        grpNouveauFournisseur.Controls.Add(lblSoldeInitialeDette);
        grpNouveauFournisseur.Controls.Add(txtSoldeInitialeDette);
        grpNouveauFournisseur.Controls.Add(btnNouveauFournisseur);
        grpNouveauFournisseur.Location = new Point(500, 50);
        grpNouveauFournisseur.Size = new Size(460, 190);
        grpNouveauFournisseur.Text = "Nouveau fournisseur";
        //
        lblNomFournisseur.AutoSize = true;
        lblNomFournisseur.Location = new Point(10, 30);
        lblNomFournisseur.Text = "Nom";
        txtNomFournisseurMP.Location = new Point(150, 27);
        txtNomFournisseurMP.Size = new Size(290, 27);
        lblLocaliteFournisseur.AutoSize = true;
        lblLocaliteFournisseur.Location = new Point(10, 60);
        lblLocaliteFournisseur.Text = "Localité";
        txtLocaliteFournisseur.Location = new Point(150, 57);
        txtLocaliteFournisseur.Size = new Size(290, 27);
        lblSoldeInitialeDette.AutoSize = true;
        lblSoldeInitialeDette.Location = new Point(10, 90);
        lblSoldeInitialeDette.Text = "Solde dette initiale";
        txtSoldeInitialeDette.Location = new Point(150, 87);
        txtSoldeInitialeDette.Size = new Size(290, 27);
        txtSoldeInitialeDette.Text = "0";
        //
        btnNouveauFournisseur.BackColor = Color.FromArgb(40, 92, 41);
        btnNouveauFournisseur.FlatStyle = FlatStyle.Flat;
        btnNouveauFournisseur.FlatAppearance.BorderSize = 0;
        btnNouveauFournisseur.ForeColor = Color.WhiteSmoke;
        btnNouveauFournisseur.Location = new Point(150, 120);
        btnNouveauFournisseur.Size = new Size(290, 35);
        btnNouveauFournisseur.Text = "Ajouter le fournisseur";
        btnNouveauFournisseur.UseVisualStyleBackColor = false;
        btnNouveauFournisseur.Click += BtnNouveauFournisseur_Click;
        //
        // grpAchat
        //
        grpAchat.Controls.Add(lblMatiere);
        grpAchat.Controls.Add(cbxNomMatierePremiere);
        grpAchat.Controls.Add(lblFournisseur);
        grpAchat.Controls.Add(cbxFournisseurMPrem);
        grpAchat.Controls.Add(lblDate);
        grpAchat.Controls.Add(dtpDateApprovisionnement);
        grpAchat.Controls.Add(lblQuantite);
        grpAchat.Controls.Add(txtQuantite);
        grpAchat.Controls.Add(lblMontant);
        grpAchat.Controls.Add(txtMontant);
        grpAchat.Controls.Add(lblTransport);
        grpAchat.Controls.Add(txtTransportMatierePremiere);
        grpAchat.Controls.Add(lblMontantPaye);
        grpAchat.Controls.Add(txtMontantPaye);
        grpAchat.Controls.Add(lblRespStocks);
        grpAchat.Controls.Add(cbxRespStocks);
        grpAchat.Controls.Add(lblTresoriere);
        grpAchat.Controls.Add(cbxTresoriere);
        grpAchat.Controls.Add(lblComptePaiement);
        grpAchat.Controls.Add(cbxComptePaiement);
        grpAchat.Controls.Add(lblSoldeCompte);
        grpAchat.Controls.Add(txtSoldeCompte);
        grpAchat.Controls.Add(btnEnregistrerAchatMatierePremiere);
        grpAchat.Location = new Point(10, 260);
        grpAchat.Size = new Size(950, 360);
        grpAchat.Text = "Enregistrer un achat";
        //
        lblMatiere.AutoSize = true;
        lblMatiere.Location = new Point(10, 30);
        lblMatiere.Text = "Matière première";
        cbxNomMatierePremiere.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxNomMatierePremiere.Location = new Point(150, 27);
        cbxNomMatierePremiere.Size = new Size(280, 28);
        lblFournisseur.AutoSize = true;
        lblFournisseur.Location = new Point(10, 60);
        lblFournisseur.Text = "Fournisseur";
        cbxFournisseurMPrem.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxFournisseurMPrem.Location = new Point(150, 57);
        cbxFournisseurMPrem.Size = new Size(280, 28);
        lblDate.AutoSize = true;
        lblDate.Location = new Point(10, 90);
        lblDate.Text = "Date";
        dtpDateApprovisionnement.Location = new Point(150, 87);
        dtpDateApprovisionnement.Size = new Size(280, 27);
        dtpDateApprovisionnement.ValueChanged += DtpDateApprovisionnement_ValueChanged;
        lblQuantite.AutoSize = true;
        lblQuantite.Location = new Point(10, 120);
        lblQuantite.Text = "Quantité";
        txtQuantite.Location = new Point(150, 117);
        txtQuantite.Size = new Size(280, 27);
        txtQuantite.Text = "0";
        lblMontant.AutoSize = true;
        lblMontant.Location = new Point(10, 150);
        lblMontant.Text = "Montant";
        txtMontant.Location = new Point(150, 147);
        txtMontant.Size = new Size(280, 27);
        txtMontant.Text = "0";
        lblTransport.AutoSize = true;
        lblTransport.Location = new Point(10, 180);
        lblTransport.Text = "Transport";
        txtTransportMatierePremiere.Location = new Point(150, 177);
        txtTransportMatierePremiere.Size = new Size(280, 27);
        txtTransportMatierePremiere.Text = "0";
        lblMontantPaye.AutoSize = true;
        lblMontantPaye.Location = new Point(10, 210);
        lblMontantPaye.Text = "Montant payé";
        txtMontantPaye.Location = new Point(150, 207);
        txtMontantPaye.Size = new Size(280, 27);
        txtMontantPaye.Text = "0";
        // Right column
        lblRespStocks.AutoSize = true;
        lblRespStocks.Location = new Point(480, 30);
        lblRespStocks.Text = "Resp. stocks";
        cbxRespStocks.Location = new Point(620, 27);
        cbxRespStocks.Size = new Size(300, 28);
        lblTresoriere.AutoSize = true;
        lblTresoriere.Location = new Point(480, 60);
        lblTresoriere.Text = "Trésorière";
        cbxTresoriere.Location = new Point(620, 57);
        cbxTresoriere.Size = new Size(300, 28);
        lblComptePaiement.AutoSize = true;
        lblComptePaiement.Location = new Point(480, 90);
        lblComptePaiement.Text = "Compte";
        cbxComptePaiement.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxComptePaiement.Location = new Point(620, 87);
        cbxComptePaiement.Size = new Size(300, 28);
        cbxComptePaiement.SelectedIndexChanged += CbxComptePaiement_SelectedIndexChanged;
        lblSoldeCompte.AutoSize = true;
        lblSoldeCompte.Location = new Point(480, 120);
        lblSoldeCompte.Text = "Solde compte";
        txtSoldeCompte.Location = new Point(620, 117);
        txtSoldeCompte.ReadOnly = true;
        txtSoldeCompte.Size = new Size(300, 27);
        //
        btnEnregistrerAchatMatierePremiere.BackColor = Color.FromArgb(40, 92, 41);
        btnEnregistrerAchatMatierePremiere.FlatStyle = FlatStyle.Flat;
        btnEnregistrerAchatMatierePremiere.FlatAppearance.BorderSize = 0;
        btnEnregistrerAchatMatierePremiere.ForeColor = Color.WhiteSmoke;
        btnEnregistrerAchatMatierePremiere.Location = new Point(620, 310);
        btnEnregistrerAchatMatierePremiere.Size = new Size(300, 40);
        btnEnregistrerAchatMatierePremiere.Text = "Enregistrer l'achat";
        btnEnregistrerAchatMatierePremiere.UseVisualStyleBackColor = false;
        btnEnregistrerAchatMatierePremiere.Click += BtnEnregistrerAchatMatierePremiere_Click;
        //
        // UC_AchatMatierePremiere
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(grpNouvelleMatiere);
        Controls.Add(grpNouveauFournisseur);
        Controls.Add(grpAchat);
        Name = "UC_AchatMatierePremiere";
        Size = new Size(983, 635);
        Load += UC_AchatMatierePremiere_Load;
        grpNouvelleMatiere.ResumeLayout(false);
        grpNouvelleMatiere.PerformLayout();
        grpNouveauFournisseur.ResumeLayout(false);
        grpNouveauFournisseur.PerformLayout();
        grpAchat.ResumeLayout(false);
        grpAchat.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private GroupBox grpNouvelleMatiere;
    private Label lblNomMatierePremiere;
    private TextBox txtNomMatierePremiere;
    private Label lblTypeMatiere;
    private ComboBox cbxTypesMatieres;
    private Label lblCoutUnitaire;
    private TextBox txtCoutUnitaire;
    private Label lblStockInitial;
    private TextBox txtStockInitial;
    private Button btnAjouterNouvelleMatierePremiere;
    private GroupBox grpNouveauFournisseur;
    private Label lblNomFournisseur;
    private TextBox txtNomFournisseurMP;
    private Label lblLocaliteFournisseur;
    private TextBox txtLocaliteFournisseur;
    private Label lblSoldeInitialeDette;
    private TextBox txtSoldeInitialeDette;
    private Button btnNouveauFournisseur;
    private GroupBox grpAchat;
    private Label lblMatiere;
    private ComboBox cbxNomMatierePremiere;
    private Label lblFournisseur;
    private ComboBox cbxFournisseurMPrem;
    private Label lblDate;
    private DateTimePicker dtpDateApprovisionnement;
    private Label lblQuantite;
    private TextBox txtQuantite;
    private Label lblMontant;
    private TextBox txtMontant;
    private Label lblTransport;
    private TextBox txtTransportMatierePremiere;
    private Label lblMontantPaye;
    private TextBox txtMontantPaye;
    private Label lblRespStocks;
    private ComboBox cbxRespStocks;
    private Label lblTresoriere;
    private ComboBox cbxTresoriere;
    private Label lblComptePaiement;
    private ComboBox cbxComptePaiement;
    private Label lblSoldeCompte;
    private TextBox txtSoldeCompte;
    private Button btnEnregistrerAchatMatierePremiere;
}
