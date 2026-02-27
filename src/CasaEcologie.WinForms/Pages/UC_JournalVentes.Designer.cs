namespace CasaEcologie.WinForms.Pages;

partial class UC_JournalVentes
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
        lblDebut = new Label();
        dtpDebut = new DateTimePicker();
        lblFin = new Label();
        dtpFin = new DateTimePicker();
        lblClient = new Label();
        cbxClients = new ComboBox();
        lblProduit = new Label();
        cbxProduits = new ComboBox();
        btnFiltrer = new Button();
        dgvJournalVentes = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvJournalVentes).BeginInit();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(350, 10);
        lblTitre.Text = "Journal des Ventes";
        //
        // Filters row
        //
        lblDebut.AutoSize = true;
        lblDebut.Location = new Point(10, 55);
        lblDebut.Text = "Début";
        dtpDebut.Format = DateTimePickerFormat.Short;
        dtpDebut.Location = new Point(60, 52);
        dtpDebut.Size = new Size(120, 27);
        dtpDebut.Value = new DateTime(2019, 1, 1);
        dtpDebut.ValueChanged += DtpDebut_ValueChanged;
        //
        lblFin.AutoSize = true;
        lblFin.Location = new Point(190, 55);
        lblFin.Text = "Fin";
        dtpFin.Format = DateTimePickerFormat.Short;
        dtpFin.Location = new Point(220, 52);
        dtpFin.Size = new Size(120, 27);
        dtpFin.ValueChanged += DtpFin_ValueChanged;
        //
        lblClient.AutoSize = true;
        lblClient.Location = new Point(350, 55);
        lblClient.Text = "Client";
        cbxClients.Location = new Point(400, 52);
        cbxClients.Size = new Size(180, 28);
        cbxClients.SelectedIndexChanged += CbxClients_SelectedIndexChanged;
        cbxClients.TextChanged += CbxClients_TextChanged;
        //
        lblProduit.AutoSize = true;
        lblProduit.Location = new Point(590, 55);
        lblProduit.Text = "Produit";
        cbxProduits.Location = new Point(650, 52);
        cbxProduits.Size = new Size(180, 28);
        cbxProduits.SelectedIndexChanged += CbxProduits_SelectedIndexChanged;
        cbxProduits.TextChanged += CbxProduits_TextChanged;
        //
        btnFiltrer.Location = new Point(850, 50);
        btnFiltrer.Size = new Size(100, 30);
        btnFiltrer.Text = "Filtrer";
        btnFiltrer.Click += BtnFiltrer_Click;
        //
        // dgvJournalVentes
        //
        dgvJournalVentes.AllowUserToAddRows = false;
        dgvJournalVentes.AllowUserToDeleteRows = false;
        dgvJournalVentes.ReadOnly = true;
        dgvJournalVentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvJournalVentes.Location = new Point(10, 90);
        dgvJournalVentes.Size = new Size(960, 530);
        dgvJournalVentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        //
        // UC_JournalVentes
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(lblDebut);
        Controls.Add(dtpDebut);
        Controls.Add(lblFin);
        Controls.Add(dtpFin);
        Controls.Add(lblClient);
        Controls.Add(cbxClients);
        Controls.Add(lblProduit);
        Controls.Add(cbxProduits);
        Controls.Add(btnFiltrer);
        Controls.Add(dgvJournalVentes);
        Name = "UC_JournalVentes";
        Size = new Size(983, 635);
        Load += UC_JournalVentes_Load;
        ((System.ComponentModel.ISupportInitialize)dgvJournalVentes).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblDebut;
    private DateTimePicker dtpDebut;
    private Label lblFin;
    private DateTimePicker dtpFin;
    private Label lblClient;
    private ComboBox cbxClients;
    private Label lblProduit;
    private ComboBox cbxProduits;
    private Button btnFiltrer;
    private DataGridView dgvJournalVentes;
}
