namespace CasaEcologie.WinForms.Pages;

partial class UC_NouvelleVente
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
        // Client section
        grpNouveauClient = new GroupBox();
        lblNomClient = new Label();
        txtNomClient = new TextBox();
        lblLocalite = new Label();
        txtLocalite = new TextBox();
        lblSoldeInitialeCreance = new Label();
        txtSoldeInitialeCreance = new TextBox();
        btnNouveauClient = new Button();
        // Vente section
        grpVente = new GroupBox();
        lblClient = new Label();
        cbxNomClient = new ComboBox();
        lblProduit = new Label();
        cbxNomProduit = new ComboBox();
        lblPU = new Label();
        cbxPUProduit = new ComboBox();
        lblQuantite = new Label();
        txtQuantite = new TextBox();
        lblSoldeStock = new Label();
        txtSoldeStockProduit = new TextBox();
        btnAjouterProduitAuPanier = new Button();
        // Liste / panier
        listView1 = new ListView();
        colProduit = new ColumnHeader();
        colQuantite = new ColumnHeader();
        colPrixUnitaire = new ColumnHeader();
        colMontant = new ColumnHeader();
        btnIncrementQuantite = new Button();
        btnDecrementQuantite = new Button();
        btnRetirer = new Button();
        lblTotalFactureLabel = new Label();
        lblTotalFacture = new Label();
        // Encaissement
        lblDateVente = new Label();
        dtpDateVente = new DateTimePicker();
        lblResponsableStock = new Label();
        cbxResponsableStockPrdtsFinis = new ComboBox();
        lblTresoriere = new Label();
        cbxTres = new ComboBox();
        lblCompte = new Label();
        cbxCompte = new ComboBox();
        lblMontantEncaisse = new Label();
        txtMontantEncaisse = new TextBox();
        btnEnregistrerVente = new Button();
        grpNouveauClient.SuspendLayout();
        grpVente.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(350, 10);
        lblTitre.Size = new Size(200, 32);
        lblTitre.Text = "Nouvelle Vente";
        //
        // grpNouveauClient
        //
        grpNouveauClient.Controls.Add(lblNomClient);
        grpNouveauClient.Controls.Add(txtNomClient);
        grpNouveauClient.Controls.Add(lblLocalite);
        grpNouveauClient.Controls.Add(txtLocalite);
        grpNouveauClient.Controls.Add(lblSoldeInitialeCreance);
        grpNouveauClient.Controls.Add(txtSoldeInitialeCreance);
        grpNouveauClient.Controls.Add(btnNouveauClient);
        grpNouveauClient.Location = new Point(10, 50);
        grpNouveauClient.Size = new Size(350, 180);
        grpNouveauClient.Text = "Nouveau Client";
        //
        // lblNomClient
        //
        lblNomClient.AutoSize = true;
        lblNomClient.Location = new Point(10, 30);
        lblNomClient.Text = "Nom";
        //
        // txtNomClient
        //
        txtNomClient.Location = new Point(120, 27);
        txtNomClient.Size = new Size(210, 27);
        //
        // lblLocalite
        //
        lblLocalite.AutoSize = true;
        lblLocalite.Location = new Point(10, 60);
        lblLocalite.Text = "Localité";
        //
        // txtLocalite
        //
        txtLocalite.Location = new Point(120, 57);
        txtLocalite.Size = new Size(210, 27);
        //
        // lblSoldeInitialeCreance
        //
        lblSoldeInitialeCreance.AutoSize = true;
        lblSoldeInitialeCreance.Location = new Point(10, 90);
        lblSoldeInitialeCreance.Text = "Créance initiale";
        //
        // txtSoldeInitialeCreance
        //
        txtSoldeInitialeCreance.Location = new Point(120, 87);
        txtSoldeInitialeCreance.Size = new Size(210, 27);
        txtSoldeInitialeCreance.Text = "00";
        //
        // btnNouveauClient
        //
        btnNouveauClient.BackColor = Color.FromArgb(40, 92, 41);
        btnNouveauClient.FlatStyle = FlatStyle.Flat;
        btnNouveauClient.FlatAppearance.BorderSize = 0;
        btnNouveauClient.ForeColor = Color.WhiteSmoke;
        btnNouveauClient.Location = new Point(120, 120);
        btnNouveauClient.Size = new Size(210, 35);
        btnNouveauClient.Text = "Ajouter le client";
        btnNouveauClient.UseVisualStyleBackColor = false;
        btnNouveauClient.Click += BtnNouveauClient_Click;
        //
        // grpVente
        //
        grpVente.Controls.Add(lblClient);
        grpVente.Controls.Add(cbxNomClient);
        grpVente.Controls.Add(lblProduit);
        grpVente.Controls.Add(cbxNomProduit);
        grpVente.Controls.Add(lblPU);
        grpVente.Controls.Add(cbxPUProduit);
        grpVente.Controls.Add(lblQuantite);
        grpVente.Controls.Add(txtQuantite);
        grpVente.Controls.Add(lblSoldeStock);
        grpVente.Controls.Add(txtSoldeStockProduit);
        grpVente.Controls.Add(btnAjouterProduitAuPanier);
        grpVente.Location = new Point(380, 50);
        grpVente.Size = new Size(580, 180);
        grpVente.Text = "Produits";
        //
        // lblClient
        //
        lblClient.AutoSize = true;
        lblClient.Location = new Point(10, 30);
        lblClient.Text = "Client";
        //
        // cbxNomClient
        //
        cbxNomClient.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxNomClient.Location = new Point(130, 27);
        cbxNomClient.Size = new Size(200, 28);
        //
        // lblProduit
        //
        lblProduit.AutoSize = true;
        lblProduit.Location = new Point(10, 60);
        lblProduit.Text = "Produit";
        //
        // cbxNomProduit
        //
        cbxNomProduit.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxNomProduit.Location = new Point(130, 57);
        cbxNomProduit.Size = new Size(200, 28);
        cbxNomProduit.SelectedIndexChanged += CbxNomProduit_SelectedIndexChanged;
        //
        // lblPU
        //
        lblPU.AutoSize = true;
        lblPU.Location = new Point(10, 90);
        lblPU.Text = "Prix unitaire";
        //
        // cbxPUProduit
        //
        cbxPUProduit.Location = new Point(130, 87);
        cbxPUProduit.Size = new Size(200, 28);
        //
        // lblQuantite
        //
        lblQuantite.AutoSize = true;
        lblQuantite.Location = new Point(340, 30);
        lblQuantite.Text = "Quantité";
        //
        // txtQuantite
        //
        txtQuantite.Location = new Point(420, 27);
        txtQuantite.Size = new Size(140, 27);
        //
        // lblSoldeStock
        //
        lblSoldeStock.AutoSize = true;
        lblSoldeStock.Location = new Point(340, 60);
        lblSoldeStock.Text = "Stock";
        //
        // txtSoldeStockProduit
        //
        txtSoldeStockProduit.Location = new Point(420, 57);
        txtSoldeStockProduit.ReadOnly = true;
        txtSoldeStockProduit.Size = new Size(140, 27);
        //
        // btnAjouterProduitAuPanier
        //
        btnAjouterProduitAuPanier.BackColor = Color.FromArgb(40, 92, 41);
        btnAjouterProduitAuPanier.FlatStyle = FlatStyle.Flat;
        btnAjouterProduitAuPanier.FlatAppearance.BorderSize = 0;
        btnAjouterProduitAuPanier.ForeColor = Color.WhiteSmoke;
        btnAjouterProduitAuPanier.Location = new Point(340, 90);
        btnAjouterProduitAuPanier.Size = new Size(220, 35);
        btnAjouterProduitAuPanier.Text = "Ajouter au panier";
        btnAjouterProduitAuPanier.UseVisualStyleBackColor = false;
        btnAjouterProduitAuPanier.Click += BtnAjouterProduitAuPanier_Click;
        //
        // listView1
        //
        listView1.Columns.AddRange(new ColumnHeader[] { colProduit, colQuantite, colPrixUnitaire, colMontant });
        listView1.FullRowSelect = true;
        listView1.GridLines = true;
        listView1.Location = new Point(10, 240);
        listView1.Size = new Size(550, 200);
        listView1.View = View.Details;
        //
        // colProduit
        //
        colProduit.Text = "Produit";
        colProduit.Width = 200;
        //
        // colQuantite
        //
        colQuantite.Text = "Quantité";
        colQuantite.Width = 80;
        //
        // colPrixUnitaire
        //
        colPrixUnitaire.Text = "Prix Unitaire";
        colPrixUnitaire.Width = 100;
        //
        // colMontant
        //
        colMontant.Text = "Montant";
        colMontant.Width = 120;
        //
        // btnIncrementQuantite
        //
        btnIncrementQuantite.Location = new Point(570, 240);
        btnIncrementQuantite.Size = new Size(40, 35);
        btnIncrementQuantite.Text = "+";
        btnIncrementQuantite.Click += BtnIncrementQuantite_Click;
        //
        // btnDecrementQuantite
        //
        btnDecrementQuantite.Location = new Point(570, 280);
        btnDecrementQuantite.Size = new Size(40, 35);
        btnDecrementQuantite.Text = "-";
        btnDecrementQuantite.Click += BtnDecrementQuantite_Click;
        //
        // btnRetirer
        //
        btnRetirer.BackColor = Color.DarkRed;
        btnRetirer.FlatStyle = FlatStyle.Flat;
        btnRetirer.FlatAppearance.BorderSize = 0;
        btnRetirer.ForeColor = Color.WhiteSmoke;
        btnRetirer.Location = new Point(570, 320);
        btnRetirer.Size = new Size(80, 35);
        btnRetirer.Text = "Retirer";
        btnRetirer.UseVisualStyleBackColor = false;
        btnRetirer.Click += BtnRetirer_Click;
        //
        // lblTotalFactureLabel
        //
        lblTotalFactureLabel.AutoSize = true;
        lblTotalFactureLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTotalFactureLabel.Location = new Point(10, 450);
        lblTotalFactureLabel.Text = "Total Facture:";
        //
        // lblTotalFacture
        //
        lblTotalFacture.AutoSize = true;
        lblTotalFacture.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTotalFacture.Location = new Point(150, 450);
        lblTotalFacture.Text = "";
        //
        // Encaissement section
        //
        lblDateVente = new Label();
        lblDateVente.AutoSize = true;
        lblDateVente.Location = new Point(660, 250);
        lblDateVente.Text = "Date";
        //
        dtpDateVente.Location = new Point(660, 270);
        dtpDateVente.Size = new Size(280, 27);
        dtpDateVente.ValueChanged += DtpDateVente_ValueChanged;
        //
        lblResponsableStock.AutoSize = true;
        lblResponsableStock.Location = new Point(660, 300);
        lblResponsableStock.Text = "Resp. stock";
        //
        cbxResponsableStockPrdtsFinis.Location = new Point(660, 320);
        cbxResponsableStockPrdtsFinis.Size = new Size(280, 28);
        //
        lblTresoriere.AutoSize = true;
        lblTresoriere.Location = new Point(660, 350);
        lblTresoriere.Text = "Trésorière";
        //
        cbxTres.Location = new Point(660, 370);
        cbxTres.Size = new Size(280, 28);
        //
        lblCompte.AutoSize = true;
        lblCompte.Location = new Point(660, 400);
        lblCompte.Text = "Compte";
        //
        cbxCompte.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxCompte.Location = new Point(660, 420);
        cbxCompte.Size = new Size(280, 28);
        //
        lblMontantEncaisse.AutoSize = true;
        lblMontantEncaisse.Location = new Point(660, 450);
        lblMontantEncaisse.Text = "Montant encaissé";
        //
        txtMontantEncaisse.Location = new Point(660, 470);
        txtMontantEncaisse.Size = new Size(280, 27);
        //
        btnEnregistrerVente.BackColor = Color.FromArgb(40, 92, 41);
        btnEnregistrerVente.FlatStyle = FlatStyle.Flat;
        btnEnregistrerVente.FlatAppearance.BorderSize = 0;
        btnEnregistrerVente.ForeColor = Color.WhiteSmoke;
        btnEnregistrerVente.Location = new Point(660, 510);
        btnEnregistrerVente.Size = new Size(280, 40);
        btnEnregistrerVente.Text = "Enregistrer la vente";
        btnEnregistrerVente.UseVisualStyleBackColor = false;
        btnEnregistrerVente.Click += BtnEnregistrerVente_Click;
        //
        // UC_NouvelleVente
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(grpNouveauClient);
        Controls.Add(grpVente);
        Controls.Add(listView1);
        Controls.Add(btnIncrementQuantite);
        Controls.Add(btnDecrementQuantite);
        Controls.Add(btnRetirer);
        Controls.Add(lblTotalFactureLabel);
        Controls.Add(lblTotalFacture);
        Controls.Add(lblDateVente);
        Controls.Add(dtpDateVente);
        Controls.Add(lblResponsableStock);
        Controls.Add(cbxResponsableStockPrdtsFinis);
        Controls.Add(lblTresoriere);
        Controls.Add(cbxTres);
        Controls.Add(lblCompte);
        Controls.Add(cbxCompte);
        Controls.Add(lblMontantEncaisse);
        Controls.Add(txtMontantEncaisse);
        Controls.Add(btnEnregistrerVente);
        Name = "UC_NouvelleVente";
        Size = new Size(983, 635);
        Load += UC_NouvelleVente_Load;
        grpNouveauClient.ResumeLayout(false);
        grpNouveauClient.PerformLayout();
        grpVente.ResumeLayout(false);
        grpVente.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private GroupBox grpNouveauClient;
    private Label lblNomClient;
    private TextBox txtNomClient;
    private Label lblLocalite;
    private TextBox txtLocalite;
    private Label lblSoldeInitialeCreance;
    private TextBox txtSoldeInitialeCreance;
    private Button btnNouveauClient;
    private GroupBox grpVente;
    private Label lblClient;
    private ComboBox cbxNomClient;
    private Label lblProduit;
    private ComboBox cbxNomProduit;
    private Label lblPU;
    private ComboBox cbxPUProduit;
    private Label lblQuantite;
    private TextBox txtQuantite;
    private Label lblSoldeStock;
    private TextBox txtSoldeStockProduit;
    private Button btnAjouterProduitAuPanier;
    private ListView listView1;
    private ColumnHeader colProduit;
    private ColumnHeader colQuantite;
    private ColumnHeader colPrixUnitaire;
    private ColumnHeader colMontant;
    private Button btnIncrementQuantite;
    private Button btnDecrementQuantite;
    private Button btnRetirer;
    private Label lblTotalFactureLabel;
    private Label lblTotalFacture;
    private Label lblDateVente;
    private DateTimePicker dtpDateVente;
    private Label lblResponsableStock;
    private ComboBox cbxResponsableStockPrdtsFinis;
    private Label lblTresoriere;
    private ComboBox cbxTres;
    private Label lblCompte;
    private ComboBox cbxCompte;
    private Label lblMontantEncaisse;
    private TextBox txtMontantEncaisse;
    private Button btnEnregistrerVente;
}
