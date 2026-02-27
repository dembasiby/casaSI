namespace CasaEcologie.WinForms.Pages;

partial class UC_StocksInventaireEtValorisation
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
        dtpDate = new DateTimePicker();
        rbtnMatieresPremieres = new RadioButton();
        rbtnProduitsSemiFinis = new RadioButton();
        rbtnProduitsFinis = new RadioButton();
        dgvTableauAffichageStocks = new DataGridView();
        lblStockMPLabel = new Label();
        txtStockMatieresPremieres = new TextBox();
        lblStockPSFLabel = new Label();
        txtStockProduitsSemiFinis = new TextBox();
        lblStockPFLabel = new Label();
        txtStocksProduitsFinis = new TextBox();
        lblValeurTotaleLabel = new Label();
        txtValeurTotaleStocks = new TextBox();
        ((System.ComponentModel.ISupportInitialize)dgvTableauAffichageStocks).BeginInit();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(250, 10);
        lblTitre.Text = "Inventaire et Valorisation des Stocks";
        //
        // dtpDate
        //
        dtpDate.Format = DateTimePickerFormat.Short;
        dtpDate.Location = new Point(10, 50);
        dtpDate.Size = new Size(150, 27);
        dtpDate.ValueChanged += DtpDate_ValueChanged;
        //
        // rbtnMatieresPremieres
        //
        rbtnMatieresPremieres.AutoSize = true;
        rbtnMatieresPremieres.Checked = true;
        rbtnMatieresPremieres.Location = new Point(180, 52);
        rbtnMatieresPremieres.Text = "Matières premières";
        rbtnMatieresPremieres.CheckedChanged += RbtnMatieresPremieres_CheckedChanged;
        //
        // rbtnProduitsSemiFinis
        //
        rbtnProduitsSemiFinis.AutoSize = true;
        rbtnProduitsSemiFinis.Location = new Point(380, 52);
        rbtnProduitsSemiFinis.Text = "Produits semi-finis";
        rbtnProduitsSemiFinis.CheckedChanged += RbtnProduitsSemiFinis_CheckedChanged;
        //
        // rbtnProduitsFinis
        //
        rbtnProduitsFinis.AutoSize = true;
        rbtnProduitsFinis.Location = new Point(560, 52);
        rbtnProduitsFinis.Text = "Produits finis";
        rbtnProduitsFinis.CheckedChanged += RbtnProduitsFinis_CheckedChanged;
        //
        // dgvTableauAffichageStocks
        //
        dgvTableauAffichageStocks.AllowUserToAddRows = false;
        dgvTableauAffichageStocks.AllowUserToDeleteRows = false;
        dgvTableauAffichageStocks.ReadOnly = true;
        dgvTableauAffichageStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTableauAffichageStocks.Location = new Point(10, 85);
        dgvTableauAffichageStocks.Size = new Size(700, 440);
        dgvTableauAffichageStocks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        //
        // Summary section
        //
        lblStockMPLabel.AutoSize = true;
        lblStockMPLabel.Location = new Point(730, 85);
        lblStockMPLabel.Text = "Stock matières premières";
        txtStockMatieresPremieres.Location = new Point(730, 105);
        txtStockMatieresPremieres.Size = new Size(240, 27);
        txtStockMatieresPremieres.ReadOnly = true;
        //
        lblStockPSFLabel.AutoSize = true;
        lblStockPSFLabel.Location = new Point(730, 145);
        lblStockPSFLabel.Text = "Stock produits semi-finis";
        txtStockProduitsSemiFinis.Location = new Point(730, 165);
        txtStockProduitsSemiFinis.Size = new Size(240, 27);
        txtStockProduitsSemiFinis.ReadOnly = true;
        //
        lblStockPFLabel.AutoSize = true;
        lblStockPFLabel.Location = new Point(730, 205);
        lblStockPFLabel.Text = "Stock produits finis";
        txtStocksProduitsFinis.Location = new Point(730, 225);
        txtStocksProduitsFinis.Size = new Size(240, 27);
        txtStocksProduitsFinis.ReadOnly = true;
        //
        lblValeurTotaleLabel.AutoSize = true;
        lblValeurTotaleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblValeurTotaleLabel.Location = new Point(730, 275);
        lblValeurTotaleLabel.Text = "Valeur totale des stocks";
        txtValeurTotaleStocks.Location = new Point(730, 295);
        txtValeurTotaleStocks.Size = new Size(240, 27);
        txtValeurTotaleStocks.ReadOnly = true;
        txtValeurTotaleStocks.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        //
        // UC_StocksInventaireEtValorisation
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(dtpDate);
        Controls.Add(rbtnMatieresPremieres);
        Controls.Add(rbtnProduitsSemiFinis);
        Controls.Add(rbtnProduitsFinis);
        Controls.Add(dgvTableauAffichageStocks);
        Controls.Add(lblStockMPLabel);
        Controls.Add(txtStockMatieresPremieres);
        Controls.Add(lblStockPSFLabel);
        Controls.Add(txtStockProduitsSemiFinis);
        Controls.Add(lblStockPFLabel);
        Controls.Add(txtStocksProduitsFinis);
        Controls.Add(lblValeurTotaleLabel);
        Controls.Add(txtValeurTotaleStocks);
        Name = "UC_StocksInventaireEtValorisation";
        Size = new Size(983, 635);
        Load += UC_StocksInventaireEtValorisation_Load;
        ((System.ComponentModel.ISupportInitialize)dgvTableauAffichageStocks).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private DateTimePicker dtpDate;
    private RadioButton rbtnMatieresPremieres;
    private RadioButton rbtnProduitsSemiFinis;
    private RadioButton rbtnProduitsFinis;
    private DataGridView dgvTableauAffichageStocks;
    private Label lblStockMPLabel;
    private TextBox txtStockMatieresPremieres;
    private Label lblStockPSFLabel;
    private TextBox txtStockProduitsSemiFinis;
    private Label lblStockPFLabel;
    private TextBox txtStocksProduitsFinis;
    private Label lblValeurTotaleLabel;
    private TextBox txtValeurTotaleStocks;
}
