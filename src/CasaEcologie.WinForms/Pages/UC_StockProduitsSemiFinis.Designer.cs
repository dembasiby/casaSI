namespace CasaEcologie.WinForms.Pages;

partial class UC_StockProduitsSemiFinis
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
        lblListeProduits = new Label();
        lblFiche = new Label();
        lbxListeProduitsSemiFinis = new ListBox();
        dgvJournal = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvJournal).BeginInit();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(180, 10);
        lblTitre.Text = "Journal des Stocks de Produits Semi-Finis";
        //
        // lblListeProduits
        //
        lblListeProduits.AutoSize = true;
        lblListeProduits.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblListeProduits.Location = new Point(5, 72);
        lblListeProduits.Text = "Liste des produits semi-finis";
        //
        // lblFiche
        //
        lblFiche.AutoSize = true;
        lblFiche.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline);
        lblFiche.Location = new Point(440, 72);
        lblFiche.Text = "Fiche de stocks par produit";
        //
        // lbxListeProduitsSemiFinis
        //
        lbxListeProduitsSemiFinis.BorderStyle = BorderStyle.FixedSingle;
        lbxListeProduitsSemiFinis.Location = new Point(5, 100);
        lbxListeProduitsSemiFinis.Size = new Size(180, 480);
        lbxListeProduitsSemiFinis.SelectedIndexChanged += LbxListeProduitsSemiFinis_SelectedIndexChanged;
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
        // UC_StockProduitsSemiFinis
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(lblListeProduits);
        Controls.Add(lblFiche);
        Controls.Add(lbxListeProduitsSemiFinis);
        Controls.Add(dgvJournal);
        Name = "UC_StockProduitsSemiFinis";
        Size = new Size(983, 635);
        Load += UC_StockProduitsSemiFinis_Load;
        ((System.ComponentModel.ISupportInitialize)dgvJournal).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblListeProduits;
    private Label lblFiche;
    private ListBox lbxListeProduitsSemiFinis;
    private DataGridView dgvJournal;
}
