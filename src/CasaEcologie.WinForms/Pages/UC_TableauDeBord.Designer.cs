namespace CasaEcologie.WinForms.Pages;

partial class UC_TableauDeBord
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
        lblAchatsMP = new Label();
        dgvAchatsMP = new DataGridView();
        lblProduitsVendus = new Label();
        dgvProduitsLesPlusVendus = new DataGridView();
        lblTop10Clients = new Label();
        dgvTop10Clients = new DataGridView();
        lblCadeaux = new Label();
        dgvCadeaux = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvAchatsMP).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvProduitsLesPlusVendus).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvTop10Clients).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvCadeaux).BeginInit();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(350, 5);
        lblTitre.Text = "Tableau de Bord";
        //
        // Date pickers
        //
        lblDebut.AutoSize = true;
        lblDebut.Location = new Point(10, 42);
        lblDebut.Text = "Du";
        dtpDebut.Format = DateTimePickerFormat.Short;
        dtpDebut.Location = new Point(35, 38);
        dtpDebut.Size = new Size(130, 27);
        dtpDebut.Value = new DateTime(2019, 1, 1);
        dtpDebut.ValueChanged += DtpDebut_ValueChanged;
        //
        lblFin.AutoSize = true;
        lblFin.Location = new Point(180, 42);
        lblFin.Text = "Au";
        dtpFin.Format = DateTimePickerFormat.Short;
        dtpFin.Location = new Point(205, 38);
        dtpFin.Size = new Size(130, 27);
        dtpFin.ValueChanged += DtpFin_ValueChanged;
        //
        // Top-left: Achats MP
        //
        lblAchatsMP.AutoSize = true;
        lblAchatsMP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblAchatsMP.Location = new Point(10, 70);
        lblAchatsMP.Text = "Achats par matière première";
        dgvAchatsMP.AllowUserToAddRows = false;
        dgvAchatsMP.ReadOnly = true;
        dgvAchatsMP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvAchatsMP.RowHeadersVisible = false;
        dgvAchatsMP.Location = new Point(10, 90);
        dgvAchatsMP.Size = new Size(470, 250);
        //
        // Top-right: Top 10 produits vendus
        //
        lblProduitsVendus.AutoSize = true;
        lblProduitsVendus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblProduitsVendus.Location = new Point(500, 70);
        lblProduitsVendus.Text = "Top 10 produits vendus";
        dgvProduitsLesPlusVendus.AllowUserToAddRows = false;
        dgvProduitsLesPlusVendus.ReadOnly = true;
        dgvProduitsLesPlusVendus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProduitsLesPlusVendus.RowHeadersVisible = false;
        dgvProduitsLesPlusVendus.Location = new Point(500, 90);
        dgvProduitsLesPlusVendus.Size = new Size(470, 250);
        //
        // Bottom-left: Top 10 clients
        //
        lblTop10Clients.AutoSize = true;
        lblTop10Clients.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTop10Clients.Location = new Point(10, 350);
        lblTop10Clients.Text = "Top 10 clients";
        dgvTop10Clients.AllowUserToAddRows = false;
        dgvTop10Clients.ReadOnly = true;
        dgvTop10Clients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTop10Clients.RowHeadersVisible = false;
        dgvTop10Clients.Location = new Point(10, 370);
        dgvTop10Clients.Size = new Size(470, 250);
        //
        // Bottom-right: Cadeaux/Dons
        //
        lblCadeaux.AutoSize = true;
        lblCadeaux.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCadeaux.Location = new Point(500, 350);
        lblCadeaux.Text = "Cadeaux et dons";
        dgvCadeaux.AllowUserToAddRows = false;
        dgvCadeaux.ReadOnly = true;
        dgvCadeaux.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvCadeaux.RowHeadersVisible = false;
        dgvCadeaux.Location = new Point(500, 370);
        dgvCadeaux.Size = new Size(470, 250);
        //
        // UC_TableauDeBord
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        Controls.Add(lblTitre);
        Controls.Add(lblDebut);
        Controls.Add(dtpDebut);
        Controls.Add(lblFin);
        Controls.Add(dtpFin);
        Controls.Add(lblAchatsMP);
        Controls.Add(dgvAchatsMP);
        Controls.Add(lblProduitsVendus);
        Controls.Add(dgvProduitsLesPlusVendus);
        Controls.Add(lblTop10Clients);
        Controls.Add(dgvTop10Clients);
        Controls.Add(lblCadeaux);
        Controls.Add(dgvCadeaux);
        Name = "UC_TableauDeBord";
        Size = new Size(983, 635);
        Load += UC_TableauDeBord_Load;
        ((System.ComponentModel.ISupportInitialize)dgvAchatsMP).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvProduitsLesPlusVendus).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvTop10Clients).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvCadeaux).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblDebut;
    private DateTimePicker dtpDebut;
    private Label lblFin;
    private DateTimePicker dtpFin;
    private Label lblAchatsMP;
    private DataGridView dgvAchatsMP;
    private Label lblProduitsVendus;
    private DataGridView dgvProduitsLesPlusVendus;
    private Label lblTop10Clients;
    private DataGridView dgvTop10Clients;
    private Label lblCadeaux;
    private DataGridView dgvCadeaux;
}
