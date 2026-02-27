namespace CasaEcologie.WinForms.Pages;

partial class UC_AchatEquipementInfrastructure
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
        lblNouveauFournisseurImmo = new Label();
        txtNouveauFournisseurImmo = new TextBox();
        lblLocaliteFournisseurImmo = new Label();
        txtLocaliteFournisseurImmo = new TextBox();
        lblSoldeInitialeDetteFournisseurImmo = new Label();
        txtSoldeInitialeDetteFournisseurImmo = new TextBox();
        btnNouveauFournisseurImmo = new Button();
        // Equipement existant
        grpExistant = new GroupBox();
        lblNomEqInfr2 = new Label();
        txtNomEqInfr2 = new TextBox();
        lblDateExistant = new Label();
        dtpEquInfrExistant = new DateTimePicker();
        lblDuree2 = new Label();
        txtDuree2 = new TextBox();
        lblQuantiteExistant = new Label();
        txtQuantiteExistant = new TextBox();
        lblMontant2 = new Label();
        txtMontant2 = new TextBox();
        cbxUtilisePourProduction = new CheckBox();
        btnEqInfrExistant = new Button();
        // Nouvel achat
        grpNouvelAchat = new GroupBox();
        lblNomEqInfr1 = new Label();
        txtNomEqInfr1 = new TextBox();
        lblFournisseur = new Label();
        cbxFournisseurImmo = new ComboBox();
        lblDate = new Label();
        dtpAchatNouveauEqInf = new DateTimePicker();
        lblDuree1 = new Label();
        txtDuree1 = new TextBox();
        lblQuantite = new Label();
        txtQuantite = new TextBox();
        lblMontant1 = new Label();
        txtMontant1 = new TextBox();
        lblMontantPaye = new Label();
        txtMontantPaye = new TextBox();
        cbxImmobilisationLieeAProduction = new CheckBox();
        lblRespImmo = new Label();
        cbxRespImmo = new ComboBox();
        lblTresoriere = new Label();
        cbxTresoriere = new ComboBox();
        lblComptePaiement = new Label();
        cbxComptePaiement = new ComboBox();
        lblSoldeCompte = new Label();
        txtSoldeCompte = new TextBox();
        btnEnregistrerAchatEquipementInfrastructure = new Button();
        grpNouveauFournisseur.SuspendLayout();
        grpExistant.SuspendLayout();
        grpNouvelAchat.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(250, 10);
        lblTitre.Text = "Achat d'équipements et infrastructures";
        //
        // grpNouveauFournisseur
        //
        grpNouveauFournisseur.Controls.Add(lblNouveauFournisseurImmo);
        grpNouveauFournisseur.Controls.Add(txtNouveauFournisseurImmo);
        grpNouveauFournisseur.Controls.Add(lblLocaliteFournisseurImmo);
        grpNouveauFournisseur.Controls.Add(txtLocaliteFournisseurImmo);
        grpNouveauFournisseur.Controls.Add(lblSoldeInitialeDetteFournisseurImmo);
        grpNouveauFournisseur.Controls.Add(txtSoldeInitialeDetteFournisseurImmo);
        grpNouveauFournisseur.Controls.Add(btnNouveauFournisseurImmo);
        grpNouveauFournisseur.Location = new Point(10, 50);
        grpNouveauFournisseur.Size = new Size(950, 100);
        grpNouveauFournisseur.Text = "Nouveau fournisseur";
        //
        lblNouveauFournisseurImmo.AutoSize = true;
        lblNouveauFournisseurImmo.Location = new Point(10, 30);
        lblNouveauFournisseurImmo.Text = "Nom";
        txtNouveauFournisseurImmo.Location = new Point(60, 27);
        txtNouveauFournisseurImmo.Size = new Size(200, 27);
        lblLocaliteFournisseurImmo.AutoSize = true;
        lblLocaliteFournisseurImmo.Location = new Point(270, 30);
        lblLocaliteFournisseurImmo.Text = "Localité";
        txtLocaliteFournisseurImmo.Location = new Point(330, 27);
        txtLocaliteFournisseurImmo.Size = new Size(150, 27);
        lblSoldeInitialeDetteFournisseurImmo.AutoSize = true;
        lblSoldeInitialeDetteFournisseurImmo.Location = new Point(490, 30);
        lblSoldeInitialeDetteFournisseurImmo.Text = "Solde dette";
        txtSoldeInitialeDetteFournisseurImmo.Location = new Point(580, 27);
        txtSoldeInitialeDetteFournisseurImmo.Size = new Size(120, 27);
        txtSoldeInitialeDetteFournisseurImmo.Text = "00";
        btnNouveauFournisseurImmo.BackColor = Color.FromArgb(40, 92, 41);
        btnNouveauFournisseurImmo.FlatStyle = FlatStyle.Flat;
        btnNouveauFournisseurImmo.FlatAppearance.BorderSize = 0;
        btnNouveauFournisseurImmo.ForeColor = Color.WhiteSmoke;
        btnNouveauFournisseurImmo.Location = new Point(720, 22);
        btnNouveauFournisseurImmo.Size = new Size(210, 35);
        btnNouveauFournisseurImmo.Text = "Ajouter";
        btnNouveauFournisseurImmo.UseVisualStyleBackColor = false;
        btnNouveauFournisseurImmo.Click += BtnNouveauFournisseurImmo_Click;
        //
        // grpExistant
        //
        grpExistant.Controls.Add(lblNomEqInfr2);
        grpExistant.Controls.Add(txtNomEqInfr2);
        grpExistant.Controls.Add(lblDateExistant);
        grpExistant.Controls.Add(dtpEquInfrExistant);
        grpExistant.Controls.Add(lblDuree2);
        grpExistant.Controls.Add(txtDuree2);
        grpExistant.Controls.Add(lblQuantiteExistant);
        grpExistant.Controls.Add(txtQuantiteExistant);
        grpExistant.Controls.Add(lblMontant2);
        grpExistant.Controls.Add(txtMontant2);
        grpExistant.Controls.Add(cbxUtilisePourProduction);
        grpExistant.Controls.Add(btnEqInfrExistant);
        grpExistant.Location = new Point(10, 160);
        grpExistant.Size = new Size(460, 230);
        grpExistant.Text = "Équipement/Infrastructure existant";
        //
        lblNomEqInfr2.AutoSize = true;
        lblNomEqInfr2.Location = new Point(10, 30);
        lblNomEqInfr2.Text = "Nom";
        txtNomEqInfr2.Location = new Point(130, 27);
        txtNomEqInfr2.Size = new Size(310, 27);
        lblDateExistant.AutoSize = true;
        lblDateExistant.Location = new Point(10, 60);
        lblDateExistant.Text = "Date acquisition";
        dtpEquInfrExistant.Location = new Point(130, 57);
        dtpEquInfrExistant.Size = new Size(310, 27);
        lblDuree2.AutoSize = true;
        lblDuree2.Location = new Point(10, 90);
        lblDuree2.Text = "Durée de vie";
        txtDuree2.Location = new Point(130, 87);
        txtDuree2.Size = new Size(310, 27);
        lblQuantiteExistant.AutoSize = true;
        lblQuantiteExistant.Location = new Point(10, 120);
        lblQuantiteExistant.Text = "Quantité";
        txtQuantiteExistant.Location = new Point(130, 117);
        txtQuantiteExistant.Size = new Size(310, 27);
        lblMontant2.AutoSize = true;
        lblMontant2.Location = new Point(10, 150);
        lblMontant2.Text = "Montant";
        txtMontant2.Location = new Point(130, 147);
        txtMontant2.Size = new Size(310, 27);
        cbxUtilisePourProduction.Location = new Point(130, 177);
        cbxUtilisePourProduction.Text = "Utilisé pour la production";
        cbxUtilisePourProduction.Size = new Size(250, 25);
        btnEqInfrExistant.BackColor = Color.FromArgb(40, 92, 41);
        btnEqInfrExistant.FlatStyle = FlatStyle.Flat;
        btnEqInfrExistant.FlatAppearance.BorderSize = 0;
        btnEqInfrExistant.ForeColor = Color.WhiteSmoke;
        btnEqInfrExistant.Location = new Point(130, 200);
        btnEqInfrExistant.Size = new Size(310, 30);
        btnEqInfrExistant.Text = "Enregistrer existant";
        btnEqInfrExistant.UseVisualStyleBackColor = false;
        btnEqInfrExistant.Click += BtnEqInfrExistant_Click;
        //
        // grpNouvelAchat
        //
        grpNouvelAchat.Controls.Add(lblNomEqInfr1);
        grpNouvelAchat.Controls.Add(txtNomEqInfr1);
        grpNouvelAchat.Controls.Add(lblFournisseur);
        grpNouvelAchat.Controls.Add(cbxFournisseurImmo);
        grpNouvelAchat.Controls.Add(lblDate);
        grpNouvelAchat.Controls.Add(dtpAchatNouveauEqInf);
        grpNouvelAchat.Controls.Add(lblDuree1);
        grpNouvelAchat.Controls.Add(txtDuree1);
        grpNouvelAchat.Controls.Add(lblQuantite);
        grpNouvelAchat.Controls.Add(txtQuantite);
        grpNouvelAchat.Controls.Add(lblMontant1);
        grpNouvelAchat.Controls.Add(txtMontant1);
        grpNouvelAchat.Controls.Add(lblMontantPaye);
        grpNouvelAchat.Controls.Add(txtMontantPaye);
        grpNouvelAchat.Controls.Add(cbxImmobilisationLieeAProduction);
        grpNouvelAchat.Controls.Add(lblRespImmo);
        grpNouvelAchat.Controls.Add(cbxRespImmo);
        grpNouvelAchat.Controls.Add(lblTresoriere);
        grpNouvelAchat.Controls.Add(cbxTresoriere);
        grpNouvelAchat.Controls.Add(lblComptePaiement);
        grpNouvelAchat.Controls.Add(cbxComptePaiement);
        grpNouvelAchat.Controls.Add(lblSoldeCompte);
        grpNouvelAchat.Controls.Add(txtSoldeCompte);
        grpNouvelAchat.Controls.Add(btnEnregistrerAchatEquipementInfrastructure);
        grpNouvelAchat.Location = new Point(10, 400);
        grpNouvelAchat.Size = new Size(950, 230);
        grpNouvelAchat.Text = "Nouvel achat d'équipement/infrastructure";
        //
        lblNomEqInfr1.AutoSize = true;
        lblNomEqInfr1.Location = new Point(10, 25);
        lblNomEqInfr1.Text = "Nom";
        txtNomEqInfr1.Location = new Point(130, 22);
        txtNomEqInfr1.Size = new Size(300, 27);
        lblFournisseur.AutoSize = true;
        lblFournisseur.Location = new Point(10, 55);
        lblFournisseur.Text = "Fournisseur";
        cbxFournisseurImmo.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxFournisseurImmo.Location = new Point(130, 52);
        cbxFournisseurImmo.Size = new Size(300, 28);
        lblDate.AutoSize = true;
        lblDate.Location = new Point(10, 85);
        lblDate.Text = "Date";
        dtpAchatNouveauEqInf.Location = new Point(130, 82);
        dtpAchatNouveauEqInf.Size = new Size(300, 27);
        dtpAchatNouveauEqInf.ValueChanged += DtpAchatNouveauEqInf_ValueChanged;
        lblDuree1.AutoSize = true;
        lblDuree1.Location = new Point(10, 115);
        lblDuree1.Text = "Durée de vie";
        txtDuree1.Location = new Point(130, 112);
        txtDuree1.Size = new Size(300, 27);
        lblQuantite.AutoSize = true;
        lblQuantite.Location = new Point(10, 145);
        lblQuantite.Text = "Quantité";
        txtQuantite.Location = new Point(130, 142);
        txtQuantite.Size = new Size(300, 27);
        txtQuantite.Text = "1";
        lblMontant1.AutoSize = true;
        lblMontant1.Location = new Point(10, 175);
        lblMontant1.Text = "Montant";
        txtMontant1.Location = new Point(130, 172);
        txtMontant1.Size = new Size(300, 27);
        cbxImmobilisationLieeAProduction.Location = new Point(130, 200);
        cbxImmobilisationLieeAProduction.Text = "Lié à la production";
        cbxImmobilisationLieeAProduction.Size = new Size(200, 25);
        // Right column
        lblMontantPaye.AutoSize = true;
        lblMontantPaye.Location = new Point(480, 25);
        lblMontantPaye.Text = "Montant payé";
        txtMontantPaye.Location = new Point(620, 22);
        txtMontantPaye.Size = new Size(300, 27);
        lblRespImmo.AutoSize = true;
        lblRespImmo.Location = new Point(480, 55);
        lblRespImmo.Text = "Responsable";
        cbxRespImmo.Location = new Point(620, 52);
        cbxRespImmo.Size = new Size(300, 28);
        lblTresoriere.AutoSize = true;
        lblTresoriere.Location = new Point(480, 85);
        lblTresoriere.Text = "Trésorière";
        cbxTresoriere.Location = new Point(620, 82);
        cbxTresoriere.Size = new Size(300, 28);
        lblComptePaiement.AutoSize = true;
        lblComptePaiement.Location = new Point(480, 115);
        lblComptePaiement.Text = "Compte";
        cbxComptePaiement.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxComptePaiement.Location = new Point(620, 112);
        cbxComptePaiement.Size = new Size(300, 28);
        cbxComptePaiement.SelectedIndexChanged += CbxComptePaiement_SelectedIndexChanged;
        lblSoldeCompte.AutoSize = true;
        lblSoldeCompte.Location = new Point(480, 145);
        lblSoldeCompte.Text = "Solde compte";
        txtSoldeCompte.Location = new Point(620, 142);
        txtSoldeCompte.ReadOnly = true;
        txtSoldeCompte.Size = new Size(300, 27);
        //
        btnEnregistrerAchatEquipementInfrastructure.BackColor = Color.FromArgb(40, 92, 41);
        btnEnregistrerAchatEquipementInfrastructure.FlatStyle = FlatStyle.Flat;
        btnEnregistrerAchatEquipementInfrastructure.FlatAppearance.BorderSize = 0;
        btnEnregistrerAchatEquipementInfrastructure.ForeColor = Color.WhiteSmoke;
        btnEnregistrerAchatEquipementInfrastructure.Location = new Point(620, 180);
        btnEnregistrerAchatEquipementInfrastructure.Size = new Size(300, 40);
        btnEnregistrerAchatEquipementInfrastructure.Text = "Enregistrer l'achat";
        btnEnregistrerAchatEquipementInfrastructure.UseVisualStyleBackColor = false;
        btnEnregistrerAchatEquipementInfrastructure.Click += BtnEnregistrerAchatEquipementInfrastructure_Click;
        //
        // UC_AchatEquipementInfrastructure
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(grpNouveauFournisseur);
        Controls.Add(grpExistant);
        Controls.Add(grpNouvelAchat);
        Name = "UC_AchatEquipementInfrastructure";
        Size = new Size(983, 635);
        Load += UC_AchatEquipementInfrastructure_Load;
        grpNouveauFournisseur.ResumeLayout(false);
        grpNouveauFournisseur.PerformLayout();
        grpExistant.ResumeLayout(false);
        grpExistant.PerformLayout();
        grpNouvelAchat.ResumeLayout(false);
        grpNouvelAchat.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private GroupBox grpNouveauFournisseur;
    private Label lblNouveauFournisseurImmo;
    private TextBox txtNouveauFournisseurImmo;
    private Label lblLocaliteFournisseurImmo;
    private TextBox txtLocaliteFournisseurImmo;
    private Label lblSoldeInitialeDetteFournisseurImmo;
    private TextBox txtSoldeInitialeDetteFournisseurImmo;
    private Button btnNouveauFournisseurImmo;
    private GroupBox grpExistant;
    private Label lblNomEqInfr2;
    private TextBox txtNomEqInfr2;
    private Label lblDateExistant;
    private DateTimePicker dtpEquInfrExistant;
    private Label lblDuree2;
    private TextBox txtDuree2;
    private Label lblQuantiteExistant;
    private TextBox txtQuantiteExistant;
    private Label lblMontant2;
    private TextBox txtMontant2;
    private CheckBox cbxUtilisePourProduction;
    private Button btnEqInfrExistant;
    private GroupBox grpNouvelAchat;
    private Label lblNomEqInfr1;
    private TextBox txtNomEqInfr1;
    private Label lblFournisseur;
    private ComboBox cbxFournisseurImmo;
    private Label lblDate;
    private DateTimePicker dtpAchatNouveauEqInf;
    private Label lblDuree1;
    private TextBox txtDuree1;
    private Label lblQuantite;
    private TextBox txtQuantite;
    private Label lblMontant1;
    private TextBox txtMontant1;
    private Label lblMontantPaye;
    private TextBox txtMontantPaye;
    private CheckBox cbxImmobilisationLieeAProduction;
    private Label lblRespImmo;
    private ComboBox cbxRespImmo;
    private Label lblTresoriere;
    private ComboBox cbxTresoriere;
    private Label lblComptePaiement;
    private ComboBox cbxComptePaiement;
    private Label lblSoldeCompte;
    private TextBox txtSoldeCompte;
    private Button btnEnregistrerAchatEquipementInfrastructure;
}
