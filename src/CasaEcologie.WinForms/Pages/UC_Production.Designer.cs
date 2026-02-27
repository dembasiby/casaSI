namespace CasaEcologie.WinForms.Pages;

partial class UC_Production
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
        dtpDateProduction = new DateTimePicker();
        lblDate = new Label();

        // Responsables
        grpResponsables = new GroupBox();
        lblRespProd = new Label();
        cbxResponsableProduction = new ComboBox();
        lblRespMatPrem = new Label();
        cbxRespMatPrem = new ComboBox();
        lblRespStockPF = new Label();
        cbxResponsableStockProduitFinis = new ComboBox();

        // Matières premières
        grpMatieresPremieres = new GroupBox();
        cbxNomMatiereP = new ComboBox();
        lblStockMP = new Label();
        txtStockMatierePremiereDispo = new TextBox();
        txtQuantiteMatiereP = new TextBox();
        btnAjouterMatierePProduction = new Button();
        lvwListeMatieresP = new ListView();
        colMP = new ColumnHeader();
        colQteMP = new ColumnHeader();

        // Produits semi-finis
        grpProduitsSemiFinis = new GroupBox();
        cbxNomProduitSemiFini = new ComboBox();
        lblStockPSF = new Label();
        txtStockProduitSFini = new TextBox();
        txtQuantiteProduitSemiFiniUtilise = new TextBox();
        btnAjouterPSemiFiniProduction = new Button();
        lvwListProduitsSemiFinisUtilises = new ListView();
        colPSF = new ColumnHeader();
        colQtePSF = new ColumnHeader();

        // Employés
        grpEmployes = new GroupBox();
        clbEmployes = new CheckedListBox();

        // Produit à produire
        grpExtrant = new GroupBox();
        rbtnProduitsFinis = new RadioButton();
        rbtnProduitsSemiFinis = new RadioButton();
        cbxProduitsProduits = new ComboBox();
        lblQuantiteProduite = new Label();
        txtQuantiteProduitProduit = new TextBox();
        cbxEmballage = new ComboBox();
        lblEmballage = new Label();
        txtEmballagesDisponibles = new TextBox();
        cbxEtiquettes = new ComboBox();
        lblEtiquette = new Label();
        txtEtiquettesDisponibles = new TextBox();
        cbxUtiliserEtiquette = new CheckBox();
        rbtnAvecSucre = new RadioButton();
        rbtnSansSucre = new RadioButton();
        txtQuantiteSucre = new TextBox();
        lblSucre = new Label();
        cbxProdSansFruits = new CheckBox();

        btnNouvelleProduction = new Button();

        grpResponsables.SuspendLayout();
        grpMatieresPremieres.SuspendLayout();
        grpProduitsSemiFinis.SuspendLayout();
        grpEmployes.SuspendLayout();
        grpExtrant.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(380, 5);
        lblTitre.Text = "Production";
        //
        // Date
        //
        lblDate.AutoSize = true;
        lblDate.Location = new Point(10, 42);
        lblDate.Text = "Date :";
        dtpDateProduction.Format = DateTimePickerFormat.Short;
        dtpDateProduction.Location = new Point(55, 38);
        dtpDateProduction.Size = new Size(130, 27);
        dtpDateProduction.ValueChanged += DtpDateProduction_ValueChanged;
        //
        // grpResponsables
        //
        grpResponsables.Text = "Responsables";
        grpResponsables.Location = new Point(10, 70);
        grpResponsables.Size = new Size(960, 55);
        lblRespProd.AutoSize = true;
        lblRespProd.Location = new Point(10, 22);
        lblRespProd.Text = "Resp. production :";
        cbxResponsableProduction.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxResponsableProduction.Location = new Point(140, 18);
        cbxResponsableProduction.Size = new Size(180, 27);
        lblRespMatPrem.AutoSize = true;
        lblRespMatPrem.Location = new Point(340, 22);
        lblRespMatPrem.Text = "Resp. mat. prem. :";
        cbxRespMatPrem.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxRespMatPrem.Location = new Point(475, 18);
        cbxRespMatPrem.Size = new Size(180, 27);
        lblRespStockPF.AutoSize = true;
        lblRespStockPF.Location = new Point(670, 22);
        lblRespStockPF.Text = "Resp. stock PF :";
        cbxResponsableStockProduitFinis.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxResponsableStockProduitFinis.Location = new Point(790, 18);
        cbxResponsableStockProduitFinis.Size = new Size(160, 27);
        grpResponsables.Controls.Add(lblRespProd);
        grpResponsables.Controls.Add(cbxResponsableProduction);
        grpResponsables.Controls.Add(lblRespMatPrem);
        grpResponsables.Controls.Add(cbxRespMatPrem);
        grpResponsables.Controls.Add(lblRespStockPF);
        grpResponsables.Controls.Add(cbxResponsableStockProduitFinis);
        //
        // grpMatieresPremieres
        //
        grpMatieresPremieres.Text = "Matières premières utilisées";
        grpMatieresPremieres.Location = new Point(10, 130);
        grpMatieresPremieres.Size = new Size(310, 220);
        cbxNomMatiereP.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxNomMatiereP.Location = new Point(10, 25);
        cbxNomMatiereP.Size = new Size(180, 27);
        cbxNomMatiereP.SelectedIndexChanged += CbxNomMatiereP_SelectedIndexChanged;
        lblStockMP.AutoSize = true;
        lblStockMP.Location = new Point(200, 28);
        lblStockMP.Text = "Stock :";
        txtStockMatierePremiereDispo.Location = new Point(245, 25);
        txtStockMatierePremiereDispo.Size = new Size(50, 27);
        txtStockMatierePremiereDispo.ReadOnly = true;
        txtQuantiteMatiereP.Location = new Point(10, 60);
        txtQuantiteMatiereP.Size = new Size(100, 27);
        txtQuantiteMatiereP.PlaceholderText = "Quantité";
        btnAjouterMatierePProduction.Text = "Ajouter";
        btnAjouterMatierePProduction.Location = new Point(120, 58);
        btnAjouterMatierePProduction.Size = new Size(80, 30);
        btnAjouterMatierePProduction.BackColor = Color.FromArgb(40, 92, 41);
        btnAjouterMatierePProduction.ForeColor = Color.White;
        btnAjouterMatierePProduction.FlatStyle = FlatStyle.Flat;
        btnAjouterMatierePProduction.Click += BtnAjouterMatierePProduction_Click;
        lvwListeMatieresP.Location = new Point(10, 95);
        lvwListeMatieresP.Size = new Size(285, 115);
        lvwListeMatieresP.View = View.Details;
        colMP.Text = "Matière";
        colMP.Width = 180;
        colQteMP.Text = "Qté";
        colQteMP.Width = 80;
        lvwListeMatieresP.Columns.Add(colMP);
        lvwListeMatieresP.Columns.Add(colQteMP);
        grpMatieresPremieres.Controls.Add(cbxNomMatiereP);
        grpMatieresPremieres.Controls.Add(lblStockMP);
        grpMatieresPremieres.Controls.Add(txtStockMatierePremiereDispo);
        grpMatieresPremieres.Controls.Add(txtQuantiteMatiereP);
        grpMatieresPremieres.Controls.Add(btnAjouterMatierePProduction);
        grpMatieresPremieres.Controls.Add(lvwListeMatieresP);
        //
        // grpProduitsSemiFinis
        //
        grpProduitsSemiFinis.Text = "Produits semi-finis utilisés";
        grpProduitsSemiFinis.Location = new Point(330, 130);
        grpProduitsSemiFinis.Size = new Size(310, 220);
        cbxNomProduitSemiFini.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxNomProduitSemiFini.Location = new Point(10, 25);
        cbxNomProduitSemiFini.Size = new Size(180, 27);
        cbxNomProduitSemiFini.SelectedIndexChanged += CbxNomProduitSemiFini_SelectedIndexChanged;
        lblStockPSF.AutoSize = true;
        lblStockPSF.Location = new Point(200, 28);
        lblStockPSF.Text = "Stock :";
        txtStockProduitSFini.Location = new Point(245, 25);
        txtStockProduitSFini.Size = new Size(50, 27);
        txtStockProduitSFini.ReadOnly = true;
        txtQuantiteProduitSemiFiniUtilise.Location = new Point(10, 60);
        txtQuantiteProduitSemiFiniUtilise.Size = new Size(100, 27);
        txtQuantiteProduitSemiFiniUtilise.PlaceholderText = "Quantité";
        btnAjouterPSemiFiniProduction.Text = "Ajouter";
        btnAjouterPSemiFiniProduction.Location = new Point(120, 58);
        btnAjouterPSemiFiniProduction.Size = new Size(80, 30);
        btnAjouterPSemiFiniProduction.BackColor = Color.FromArgb(40, 92, 41);
        btnAjouterPSemiFiniProduction.ForeColor = Color.White;
        btnAjouterPSemiFiniProduction.FlatStyle = FlatStyle.Flat;
        btnAjouterPSemiFiniProduction.Click += BtnAjouterPSemiFiniProduction_Click;
        lvwListProduitsSemiFinisUtilises.Location = new Point(10, 95);
        lvwListProduitsSemiFinisUtilises.Size = new Size(285, 115);
        lvwListProduitsSemiFinisUtilises.View = View.Details;
        colPSF.Text = "Produit SF";
        colPSF.Width = 180;
        colQtePSF.Text = "Qté";
        colQtePSF.Width = 80;
        lvwListProduitsSemiFinisUtilises.Columns.Add(colPSF);
        lvwListProduitsSemiFinisUtilises.Columns.Add(colQtePSF);
        grpProduitsSemiFinis.Controls.Add(cbxNomProduitSemiFini);
        grpProduitsSemiFinis.Controls.Add(lblStockPSF);
        grpProduitsSemiFinis.Controls.Add(txtStockProduitSFini);
        grpProduitsSemiFinis.Controls.Add(txtQuantiteProduitSemiFiniUtilise);
        grpProduitsSemiFinis.Controls.Add(btnAjouterPSemiFiniProduction);
        grpProduitsSemiFinis.Controls.Add(lvwListProduitsSemiFinisUtilises);
        //
        // grpEmployes
        //
        grpEmployes.Text = "Employés présents";
        grpEmployes.Location = new Point(650, 130);
        grpEmployes.Size = new Size(320, 220);
        clbEmployes.Location = new Point(10, 22);
        clbEmployes.Size = new Size(300, 185);
        clbEmployes.CheckOnClick = true;
        grpEmployes.Controls.Add(clbEmployes);
        //
        // grpExtrant
        //
        grpExtrant.Text = "Produit à produire";
        grpExtrant.Location = new Point(10, 360);
        grpExtrant.Size = new Size(960, 220);
        rbtnProduitsFinis.AutoSize = true;
        rbtnProduitsFinis.Checked = true;
        rbtnProduitsFinis.Location = new Point(10, 22);
        rbtnProduitsFinis.Text = "Produit fini";
        rbtnProduitsFinis.CheckedChanged += RbtnProduitsFinis_CheckedChanged;
        rbtnProduitsSemiFinis.AutoSize = true;
        rbtnProduitsSemiFinis.Location = new Point(130, 22);
        rbtnProduitsSemiFinis.Text = "Produit semi-fini";
        rbtnProduitsSemiFinis.CheckedChanged += RbtnProduitsSemiFinis_CheckedChanged;
        cbxProdSansFruits.AutoSize = true;
        cbxProdSansFruits.Location = new Point(290, 22);
        cbxProdSansFruits.Text = "Production sans fruits";
        cbxProduitsProduits.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxProduitsProduits.Location = new Point(10, 52);
        cbxProduitsProduits.Size = new Size(200, 27);
        lblQuantiteProduite.AutoSize = true;
        lblQuantiteProduite.Location = new Point(220, 55);
        lblQuantiteProduite.Text = "Quantité :";
        txtQuantiteProduitProduit.Location = new Point(290, 52);
        txtQuantiteProduitProduit.Size = new Size(80, 27);
        // Emballage
        lblEmballage.AutoSize = true;
        lblEmballage.Location = new Point(10, 90);
        lblEmballage.Text = "Emballage :";
        cbxEmballage.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxEmballage.Location = new Point(90, 87);
        cbxEmballage.Size = new Size(180, 27);
        cbxEmballage.SelectedIndexChanged += CbxEmballage_SelectedIndexChanged;
        txtEmballagesDisponibles.Location = new Point(280, 87);
        txtEmballagesDisponibles.Size = new Size(60, 27);
        txtEmballagesDisponibles.ReadOnly = true;
        // Etiquette
        cbxUtiliserEtiquette.AutoSize = true;
        cbxUtiliserEtiquette.Location = new Point(10, 120);
        cbxUtiliserEtiquette.Text = "Étiquette :";
        cbxUtiliserEtiquette.CheckedChanged += CbxUtiliserEtiquette_CheckedChanged;
        cbxEtiquettes.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxEtiquettes.Location = new Point(110, 117);
        cbxEtiquettes.Size = new Size(160, 27);
        cbxEtiquettes.Enabled = false;
        cbxEtiquettes.SelectedIndexChanged += CbxEtiquettes_SelectedIndexChanged;
        txtEtiquettesDisponibles.Location = new Point(280, 117);
        txtEtiquettesDisponibles.Size = new Size(60, 27);
        txtEtiquettesDisponibles.ReadOnly = true;
        // Sucre
        rbtnSansSucre.AutoSize = true;
        rbtnSansSucre.Checked = true;
        rbtnSansSucre.Location = new Point(400, 90);
        rbtnSansSucre.Text = "Sans sucre";
        rbtnAvecSucre.AutoSize = true;
        rbtnAvecSucre.Location = new Point(520, 90);
        rbtnAvecSucre.Text = "Avec sucre";
        lblSucre.AutoSize = true;
        lblSucre.Location = new Point(400, 120);
        lblSucre.Text = "Quantité sucre :";
        txtQuantiteSucre.Location = new Point(520, 117);
        txtQuantiteSucre.Size = new Size(80, 27);
        // Bouton enregistrer
        btnNouvelleProduction.Text = "Enregistrer la production";
        btnNouvelleProduction.Location = new Point(10, 160);
        btnNouvelleProduction.Size = new Size(250, 40);
        btnNouvelleProduction.BackColor = Color.FromArgb(40, 92, 41);
        btnNouvelleProduction.ForeColor = Color.White;
        btnNouvelleProduction.FlatStyle = FlatStyle.Flat;
        btnNouvelleProduction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnNouvelleProduction.Click += BtnNouvelleProduction_Click;

        grpExtrant.Controls.Add(rbtnProduitsFinis);
        grpExtrant.Controls.Add(rbtnProduitsSemiFinis);
        grpExtrant.Controls.Add(cbxProdSansFruits);
        grpExtrant.Controls.Add(cbxProduitsProduits);
        grpExtrant.Controls.Add(lblQuantiteProduite);
        grpExtrant.Controls.Add(txtQuantiteProduitProduit);
        grpExtrant.Controls.Add(lblEmballage);
        grpExtrant.Controls.Add(cbxEmballage);
        grpExtrant.Controls.Add(txtEmballagesDisponibles);
        grpExtrant.Controls.Add(cbxUtiliserEtiquette);
        grpExtrant.Controls.Add(cbxEtiquettes);
        grpExtrant.Controls.Add(txtEtiquettesDisponibles);
        grpExtrant.Controls.Add(rbtnSansSucre);
        grpExtrant.Controls.Add(rbtnAvecSucre);
        grpExtrant.Controls.Add(lblSucre);
        grpExtrant.Controls.Add(txtQuantiteSucre);
        grpExtrant.Controls.Add(btnNouvelleProduction);
        //
        // UC_Production
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        Controls.Add(lblTitre);
        Controls.Add(lblDate);
        Controls.Add(dtpDateProduction);
        Controls.Add(grpResponsables);
        Controls.Add(grpMatieresPremieres);
        Controls.Add(grpProduitsSemiFinis);
        Controls.Add(grpEmployes);
        Controls.Add(grpExtrant);
        Name = "UC_Production";
        Size = new Size(983, 635);
        Load += UC_Production_Load;
        grpResponsables.ResumeLayout(false);
        grpResponsables.PerformLayout();
        grpMatieresPremieres.ResumeLayout(false);
        grpMatieresPremieres.PerformLayout();
        grpProduitsSemiFinis.ResumeLayout(false);
        grpProduitsSemiFinis.PerformLayout();
        grpEmployes.ResumeLayout(false);
        grpExtrant.ResumeLayout(false);
        grpExtrant.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblDate;
    private DateTimePicker dtpDateProduction;

    private GroupBox grpResponsables;
    private Label lblRespProd;
    private ComboBox cbxResponsableProduction;
    private Label lblRespMatPrem;
    private ComboBox cbxRespMatPrem;
    private Label lblRespStockPF;
    private ComboBox cbxResponsableStockProduitFinis;

    private GroupBox grpMatieresPremieres;
    private ComboBox cbxNomMatiereP;
    private Label lblStockMP;
    private TextBox txtStockMatierePremiereDispo;
    private TextBox txtQuantiteMatiereP;
    private Button btnAjouterMatierePProduction;
    private ListView lvwListeMatieresP;
    private ColumnHeader colMP;
    private ColumnHeader colQteMP;

    private GroupBox grpProduitsSemiFinis;
    private ComboBox cbxNomProduitSemiFini;
    private Label lblStockPSF;
    private TextBox txtStockProduitSFini;
    private TextBox txtQuantiteProduitSemiFiniUtilise;
    private Button btnAjouterPSemiFiniProduction;
    private ListView lvwListProduitsSemiFinisUtilises;
    private ColumnHeader colPSF;
    private ColumnHeader colQtePSF;

    private GroupBox grpEmployes;
    private CheckedListBox clbEmployes;

    private GroupBox grpExtrant;
    private RadioButton rbtnProduitsFinis;
    private RadioButton rbtnProduitsSemiFinis;
    private CheckBox cbxProdSansFruits;
    private ComboBox cbxProduitsProduits;
    private Label lblQuantiteProduite;
    private TextBox txtQuantiteProduitProduit;
    private Label lblEmballage;
    private ComboBox cbxEmballage;
    private TextBox txtEmballagesDisponibles;
    private CheckBox cbxUtiliserEtiquette;
    private ComboBox cbxEtiquettes;
    private Label lblEtiquette;
    private TextBox txtEtiquettesDisponibles;
    private RadioButton rbtnAvecSucre;
    private RadioButton rbtnSansSucre;
    private Label lblSucre;
    private TextBox txtQuantiteSucre;
    private Button btnNouvelleProduction;
}
