namespace CasaEcologie.WinForms.Pages;

partial class UC_CreancesClients
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
        lblListeClients = new Label();
        lblFicheClient = new Label();
        lblNomClient = new Label();
        lbxListeClients = new ListBox();
        dgvDetailsClient = new DataGridView();
        lblTotalCreancesLabel = new Label();
        txtTotalCreances = new TextBox();
        ((System.ComponentModel.ISupportInitialize)dgvDetailsClient).BeginInit();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(325, 10);
        lblTitre.Text = "Créances clients";
        //
        // lblListeClients
        //
        lblListeClients.AutoSize = true;
        lblListeClients.Location = new Point(10, 80);
        lblListeClients.Text = "Liste des clients";
        //
        // lbxListeClients
        //
        lbxListeClients.BorderStyle = BorderStyle.FixedSingle;
        lbxListeClients.Location = new Point(10, 100);
        lbxListeClients.Size = new Size(230, 320);
        lbxListeClients.SelectedValueChanged += LbxListeClients_SelectedValueChanged;
        //
        // lblTotalCreancesLabel
        //
        lblTotalCreancesLabel.AutoSize = true;
        lblTotalCreancesLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTotalCreancesLabel.Location = new Point(10, 430);
        lblTotalCreancesLabel.Text = "Total créances clients";
        //
        // txtTotalCreances
        //
        txtTotalCreances.Location = new Point(10, 455);
        txtTotalCreances.Size = new Size(230, 27);
        txtTotalCreances.ReadOnly = true;
        txtTotalCreances.TextAlign = HorizontalAlignment.Center;
        //
        // lblFicheClient
        //
        lblFicheClient.AutoSize = true;
        lblFicheClient.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblFicheClient.Location = new Point(260, 50);
        lblFicheClient.Text = "Fiche créance client - ";
        //
        // lblNomClient
        //
        lblNomClient.AutoSize = true;
        lblNomClient.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblNomClient.Location = new Point(460, 50);
        //
        // dgvDetailsClient
        //
        dgvDetailsClient.AllowUserToAddRows = false;
        dgvDetailsClient.AllowUserToDeleteRows = false;
        dgvDetailsClient.ReadOnly = true;
        dgvDetailsClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvDetailsClient.Location = new Point(260, 80);
        dgvDetailsClient.Size = new Size(710, 440);
        dgvDetailsClient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        //
        // UC_CreancesClients
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(lblListeClients);
        Controls.Add(lbxListeClients);
        Controls.Add(lblTotalCreancesLabel);
        Controls.Add(txtTotalCreances);
        Controls.Add(lblFicheClient);
        Controls.Add(lblNomClient);
        Controls.Add(dgvDetailsClient);
        Name = "UC_CreancesClients";
        Size = new Size(983, 635);
        Load += UC_CreancesClients_Load;
        ((System.ComponentModel.ISupportInitialize)dgvDetailsClient).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblListeClients;
    private Label lblFicheClient;
    private Label lblNomClient;
    private ListBox lbxListeClients;
    private DataGridView dgvDetailsClient;
    private Label lblTotalCreancesLabel;
    private TextBox txtTotalCreances;
}
