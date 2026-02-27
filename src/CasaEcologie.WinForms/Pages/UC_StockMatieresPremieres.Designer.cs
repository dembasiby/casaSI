namespace CasaEcologie.WinForms.Pages;

partial class UC_StockMatieresPremieres
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
        lblListeMatieres = new Label();
        lblFiche = new Label();
        lstMatieres = new ListBox();
        dgvJournal = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvJournal).BeginInit();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(180, 10);
        lblTitre.Text = "Journal des Stocks de Matières Premières";
        //
        // lblListeMatieres
        //
        lblListeMatieres.AutoSize = true;
        lblListeMatieres.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblListeMatieres.Location = new Point(5, 72);
        lblListeMatieres.Text = "Liste des matières premières";
        //
        // lblFiche
        //
        lblFiche.AutoSize = true;
        lblFiche.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline);
        lblFiche.Location = new Point(440, 72);
        lblFiche.Text = "Fiche de stocks par produit";
        //
        // lstMatieres
        //
        lstMatieres.BorderStyle = BorderStyle.FixedSingle;
        lstMatieres.Location = new Point(5, 100);
        lstMatieres.Size = new Size(180, 480);
        lstMatieres.SelectedIndexChanged += LstMatieres_SelectedIndexChanged;
        //
        // dgvJournal
        //
        dgvJournal.AllowUserToAddRows = false;
        dgvJournal.AllowUserToDeleteRows = false;
        dgvJournal.ReadOnly = true;
        dgvJournal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvJournal.RowHeadersVisible = false;
        dgvJournal.Location = new Point(200, 100);
        dgvJournal.Size = new Size(770, 480);
        dgvJournal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        //
        // UC_StockMatieresPremieres
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(lblListeMatieres);
        Controls.Add(lblFiche);
        Controls.Add(lstMatieres);
        Controls.Add(dgvJournal);
        Name = "UC_StockMatieresPremieres";
        Size = new Size(983, 635);
        Load += UC_StockMatieresPremieres_Load;
        ((System.ComponentModel.ISupportInitialize)dgvJournal).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblListeMatieres;
    private Label lblFiche;
    private ListBox lstMatieres;
    private DataGridView dgvJournal;
}
