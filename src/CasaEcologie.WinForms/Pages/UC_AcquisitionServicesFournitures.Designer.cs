namespace CasaEcologie.WinForms.Pages;

partial class UC_AcquisitionServicesFournitures
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
        // Nouveau fournisseur
        grpNouveauFournisseur = new GroupBox();
        lblNomFournServ = new Label();
        txtNomFournServ = new TextBox();
        lblLocaliteFournServ = new Label();
        txtLocaliteFournServ = new TextBox();
        lblSoldeInitialeDetteFournServ = new Label();
        txtSoldeInitialeDetteFournServ = new TextBox();
        btnNouveauFournisseurServ = new Button();
        // Achat
        grpAchat = new GroupBox();
        lblServiceFourniture = new Label();
        cbxNomServFourniture = new ComboBox();
        lblFournisseur = new Label();
        cbxNomFournServFourn = new ComboBox();
        lblDate = new Label();
        dtpDateAchatServFourn = new DateTimePicker();
        lblDescription = new Label();
        txtDescription = new TextBox();
        lblMontant = new Label();
        txtMontantServFourn = new TextBox();
        lblMontantPaye = new Label();
        txtMontantPayeServFourn = new TextBox();
        lblRespServFourn = new Label();
        cbxRespServFourn = new ComboBox();
        lblTresoriere = new Label();
        cbxTresoriere = new ComboBox();
        lblComptePaiement = new Label();
        cbxComptePaiement = new ComboBox();
        lblSoldeCompte = new Label();
        txtSoldeCompte = new TextBox();
        btnAchatServiceFourniture = new Button();
        grpNouveauFournisseur.SuspendLayout();
        grpAchat.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(250, 10);
        lblTitre.Text = "Acquisition de services et fournitures";
        //
        // grpNouveauFournisseur
        //
        grpNouveauFournisseur.Controls.Add(lblNomFournServ);
        grpNouveauFournisseur.Controls.Add(txtNomFournServ);
        grpNouveauFournisseur.Controls.Add(lblLocaliteFournServ);
        grpNouveauFournisseur.Controls.Add(txtLocaliteFournServ);
        grpNouveauFournisseur.Controls.Add(lblSoldeInitialeDetteFournServ);
        grpNouveauFournisseur.Controls.Add(txtSoldeInitialeDetteFournServ);
        grpNouveauFournisseur.Controls.Add(btnNouveauFournisseurServ);
        grpNouveauFournisseur.Location = new Point(10, 50);
        grpNouveauFournisseur.Size = new Size(950, 130);
        grpNouveauFournisseur.Text = "Nouveau fournisseur de services/fournitures";
        //
        lblNomFournServ.AutoSize = true;
        lblNomFournServ.Location = new Point(10, 30);
        lblNomFournServ.Text = "Nom";
        txtNomFournServ.Location = new Point(100, 27);
        txtNomFournServ.Size = new Size(200, 27);
        lblLocaliteFournServ.AutoSize = true;
        lblLocaliteFournServ.Location = new Point(310, 30);
        lblLocaliteFournServ.Text = "Localité";
        txtLocaliteFournServ.Location = new Point(380, 27);
        txtLocaliteFournServ.Size = new Size(200, 27);
        lblSoldeInitialeDetteFournServ.AutoSize = true;
        lblSoldeInitialeDetteFournServ.Location = new Point(590, 30);
        lblSoldeInitialeDetteFournServ.Text = "Solde dette";
        txtSoldeInitialeDetteFournServ.Location = new Point(690, 27);
        txtSoldeInitialeDetteFournServ.Size = new Size(150, 27);
        txtSoldeInitialeDetteFournServ.Text = "00";
        btnNouveauFournisseurServ.BackColor = Color.FromArgb(40, 92, 41);
        btnNouveauFournisseurServ.FlatStyle = FlatStyle.Flat;
        btnNouveauFournisseurServ.FlatAppearance.BorderSize = 0;
        btnNouveauFournisseurServ.ForeColor = Color.WhiteSmoke;
        btnNouveauFournisseurServ.Location = new Point(100, 65);
        btnNouveauFournisseurServ.Size = new Size(300, 35);
        btnNouveauFournisseurServ.Text = "Ajouter le fournisseur";
        btnNouveauFournisseurServ.UseVisualStyleBackColor = false;
        btnNouveauFournisseurServ.Click += BtnNouveauFournisseurServ_Click;
        //
        // grpAchat
        //
        grpAchat.Controls.Add(lblServiceFourniture);
        grpAchat.Controls.Add(cbxNomServFourniture);
        grpAchat.Controls.Add(lblFournisseur);
        grpAchat.Controls.Add(cbxNomFournServFourn);
        grpAchat.Controls.Add(lblDate);
        grpAchat.Controls.Add(dtpDateAchatServFourn);
        grpAchat.Controls.Add(lblDescription);
        grpAchat.Controls.Add(txtDescription);
        grpAchat.Controls.Add(lblMontant);
        grpAchat.Controls.Add(txtMontantServFourn);
        grpAchat.Controls.Add(lblMontantPaye);
        grpAchat.Controls.Add(txtMontantPayeServFourn);
        grpAchat.Controls.Add(lblRespServFourn);
        grpAchat.Controls.Add(cbxRespServFourn);
        grpAchat.Controls.Add(lblTresoriere);
        grpAchat.Controls.Add(cbxTresoriere);
        grpAchat.Controls.Add(lblComptePaiement);
        grpAchat.Controls.Add(cbxComptePaiement);
        grpAchat.Controls.Add(lblSoldeCompte);
        grpAchat.Controls.Add(txtSoldeCompte);
        grpAchat.Controls.Add(btnAchatServiceFourniture);
        grpAchat.Location = new Point(10, 200);
        grpAchat.Size = new Size(950, 420);
        grpAchat.Text = "Enregistrer un achat de service/fourniture";
        //
        lblServiceFourniture.AutoSize = true;
        lblServiceFourniture.Location = new Point(10, 30);
        lblServiceFourniture.Text = "Service/Fourniture";
        cbxNomServFourniture.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxNomServFourniture.Location = new Point(180, 27);
        cbxNomServFourniture.Size = new Size(280, 28);
        lblFournisseur.AutoSize = true;
        lblFournisseur.Location = new Point(10, 60);
        lblFournisseur.Text = "Fournisseur";
        cbxNomFournServFourn.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxNomFournServFourn.Location = new Point(180, 57);
        cbxNomFournServFourn.Size = new Size(280, 28);
        lblDate.AutoSize = true;
        lblDate.Location = new Point(10, 90);
        lblDate.Text = "Date";
        dtpDateAchatServFourn.Location = new Point(180, 87);
        dtpDateAchatServFourn.Size = new Size(280, 27);
        dtpDateAchatServFourn.ValueChanged += DtpDateAchatServFourn_ValueChanged;
        lblDescription.AutoSize = true;
        lblDescription.Location = new Point(10, 120);
        lblDescription.Text = "Description";
        txtDescription.Location = new Point(180, 117);
        txtDescription.Size = new Size(280, 27);
        lblMontant.AutoSize = true;
        lblMontant.Location = new Point(10, 150);
        lblMontant.Text = "Montant";
        txtMontantServFourn.Location = new Point(180, 147);
        txtMontantServFourn.Size = new Size(280, 27);
        lblMontantPaye.AutoSize = true;
        lblMontantPaye.Location = new Point(10, 180);
        lblMontantPaye.Text = "Montant payé";
        txtMontantPayeServFourn.Location = new Point(180, 177);
        txtMontantPayeServFourn.Size = new Size(280, 27);
        // Right column
        lblRespServFourn.AutoSize = true;
        lblRespServFourn.Location = new Point(500, 30);
        lblRespServFourn.Text = "Responsable";
        cbxRespServFourn.Location = new Point(640, 27);
        cbxRespServFourn.Size = new Size(280, 28);
        lblTresoriere.AutoSize = true;
        lblTresoriere.Location = new Point(500, 60);
        lblTresoriere.Text = "Trésorière";
        cbxTresoriere.Location = new Point(640, 57);
        cbxTresoriere.Size = new Size(280, 28);
        lblComptePaiement.AutoSize = true;
        lblComptePaiement.Location = new Point(500, 90);
        lblComptePaiement.Text = "Compte";
        cbxComptePaiement.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxComptePaiement.Location = new Point(640, 87);
        cbxComptePaiement.Size = new Size(280, 28);
        cbxComptePaiement.SelectedIndexChanged += CbxComptePaiement_SelectedIndexChanged;
        lblSoldeCompte.AutoSize = true;
        lblSoldeCompte.Location = new Point(500, 120);
        lblSoldeCompte.Text = "Solde compte";
        txtSoldeCompte.Location = new Point(640, 117);
        txtSoldeCompte.ReadOnly = true;
        txtSoldeCompte.Size = new Size(280, 27);
        //
        btnAchatServiceFourniture.BackColor = Color.FromArgb(40, 92, 41);
        btnAchatServiceFourniture.FlatStyle = FlatStyle.Flat;
        btnAchatServiceFourniture.FlatAppearance.BorderSize = 0;
        btnAchatServiceFourniture.ForeColor = Color.WhiteSmoke;
        btnAchatServiceFourniture.Location = new Point(640, 370);
        btnAchatServiceFourniture.Size = new Size(280, 40);
        btnAchatServiceFourniture.Text = "Enregistrer l'achat";
        btnAchatServiceFourniture.UseVisualStyleBackColor = false;
        btnAchatServiceFourniture.Click += BtnAchatServiceFourniture_Click;
        //
        // UC_AcquisitionServicesFournitures
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(grpNouveauFournisseur);
        Controls.Add(grpAchat);
        Name = "UC_AcquisitionServicesFournitures";
        Size = new Size(983, 635);
        Load += UC_AcquisitionServicesFournitures_Load;
        grpNouveauFournisseur.ResumeLayout(false);
        grpNouveauFournisseur.PerformLayout();
        grpAchat.ResumeLayout(false);
        grpAchat.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private GroupBox grpNouveauFournisseur;
    private Label lblNomFournServ;
    private TextBox txtNomFournServ;
    private Label lblLocaliteFournServ;
    private TextBox txtLocaliteFournServ;
    private Label lblSoldeInitialeDetteFournServ;
    private TextBox txtSoldeInitialeDetteFournServ;
    private Button btnNouveauFournisseurServ;
    private GroupBox grpAchat;
    private Label lblServiceFourniture;
    private ComboBox cbxNomServFourniture;
    private Label lblFournisseur;
    private ComboBox cbxNomFournServFourn;
    private Label lblDate;
    private DateTimePicker dtpDateAchatServFourn;
    private Label lblDescription;
    private TextBox txtDescription;
    private Label lblMontant;
    private TextBox txtMontantServFourn;
    private Label lblMontantPaye;
    private TextBox txtMontantPayeServFourn;
    private Label lblRespServFourn;
    private ComboBox cbxRespServFourn;
    private Label lblTresoriere;
    private ComboBox cbxTresoriere;
    private Label lblComptePaiement;
    private ComboBox cbxComptePaiement;
    private Label lblSoldeCompte;
    private TextBox txtSoldeCompte;
    private Button btnAchatServiceFourniture;
}
