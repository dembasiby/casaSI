namespace CasaEcologie.WinForms.Pages;

partial class UC_JournalTresorerie
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
        lblListeComptes = new Label();
        lblInstruction = new Label();
        lstComptes = new ListBox();
        lblJournalDetail = new Label();
        dgvJournalTresorerieDetails = new DataGridView();
        lblSoldesInitiaux = new Label();
        txtSoldesInitiaux = new TextBox();
        lblTotalEncaissements = new Label();
        txtTotalEncaissements = new TextBox();
        lblTotalDecaissements = new Label();
        txtTotalDecaissements = new TextBox();
        lblSoldeDisponible = new Label();
        txtSolde = new TextBox();
        ((System.ComponentModel.ISupportInitialize)dgvJournalTresorerieDetails).BeginInit();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(350, 10);
        lblTitre.Text = "Journal de Trésorerie";
        //
        // Left panel - comptes list
        //
        lblListeComptes.AutoSize = true;
        lblListeComptes.Location = new Point(10, 50);
        lblListeComptes.Text = "Liste des Comptes";
        //
        lblInstruction.AutoSize = true;
        lblInstruction.ForeColor = Color.Red;
        lblInstruction.Location = new Point(10, 70);
        lblInstruction.Text = "Cliquez sur un compte pour voir le détail";
        //
        lstComptes.Location = new Point(10, 95);
        lstComptes.Size = new Size(220, 300);
        lstComptes.BorderStyle = BorderStyle.FixedSingle;
        lstComptes.SelectedValueChanged += LstComptes_SelectedValueChanged;
        //
        // Summary boxes
        //
        lblSoldesInitiaux.AutoSize = true;
        lblSoldesInitiaux.Location = new Point(10, 410);
        lblSoldesInitiaux.Text = "Soldes initiaux";
        txtSoldesInitiaux.Location = new Point(10, 430);
        txtSoldesInitiaux.Size = new Size(220, 27);
        txtSoldesInitiaux.ReadOnly = true;
        //
        lblTotalEncaissements.AutoSize = true;
        lblTotalEncaissements.Location = new Point(10, 465);
        lblTotalEncaissements.Text = "Total encaissements";
        txtTotalEncaissements.Location = new Point(10, 485);
        txtTotalEncaissements.Size = new Size(220, 27);
        txtTotalEncaissements.ReadOnly = true;
        //
        lblTotalDecaissements.AutoSize = true;
        lblTotalDecaissements.Location = new Point(10, 520);
        lblTotalDecaissements.Text = "Total décaissements";
        txtTotalDecaissements.Location = new Point(10, 540);
        txtTotalDecaissements.Size = new Size(220, 27);
        txtTotalDecaissements.ReadOnly = true;
        //
        lblSoldeDisponible.AutoSize = true;
        lblSoldeDisponible.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblSoldeDisponible.Location = new Point(10, 575);
        lblSoldeDisponible.Text = "Solde disponible";
        txtSolde.Location = new Point(10, 595);
        txtSolde.Size = new Size(220, 27);
        txtSolde.ReadOnly = true;
        //
        // Right panel - details grid
        //
        lblJournalDetail.AutoSize = true;
        lblJournalDetail.Location = new Point(250, 50);
        lblJournalDetail.Text = "Journal détaillé par compte";
        //
        dgvJournalTresorerieDetails.AllowUserToAddRows = false;
        dgvJournalTresorerieDetails.AllowUserToDeleteRows = false;
        dgvJournalTresorerieDetails.ReadOnly = true;
        dgvJournalTresorerieDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvJournalTresorerieDetails.Location = new Point(250, 70);
        dgvJournalTresorerieDetails.Size = new Size(720, 550);
        dgvJournalTresorerieDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        //
        // UC_JournalTresorerie
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(lblListeComptes);
        Controls.Add(lblInstruction);
        Controls.Add(lstComptes);
        Controls.Add(lblSoldesInitiaux);
        Controls.Add(txtSoldesInitiaux);
        Controls.Add(lblTotalEncaissements);
        Controls.Add(txtTotalEncaissements);
        Controls.Add(lblTotalDecaissements);
        Controls.Add(txtTotalDecaissements);
        Controls.Add(lblSoldeDisponible);
        Controls.Add(txtSolde);
        Controls.Add(lblJournalDetail);
        Controls.Add(dgvJournalTresorerieDetails);
        Name = "UC_JournalTresorerie";
        Size = new Size(983, 635);
        Load += UC_JournalTresorerie_Load;
        ((System.ComponentModel.ISupportInitialize)dgvJournalTresorerieDetails).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblListeComptes;
    private Label lblInstruction;
    private ListBox lstComptes;
    private Label lblJournalDetail;
    private DataGridView dgvJournalTresorerieDetails;
    private Label lblSoldesInitiaux;
    private TextBox txtSoldesInitiaux;
    private Label lblTotalEncaissements;
    private TextBox txtTotalEncaissements;
    private Label lblTotalDecaissements;
    private TextBox txtTotalDecaissements;
    private Label lblSoldeDisponible;
    private TextBox txtSolde;
}
