namespace CasaEcologie.WinForms.Pages;

partial class UC_StocksProduitsFinis
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
        lblNomProduit = new Label();
        lbxListeProduitsFinis = new ListBox();
        dgvJournal = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvJournal).BeginInit();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(200, 10);
        lblTitre.Text = "Journal des Stocks de Produits Finis";
        //
        // lblListeProduits
        //
        lblListeProduits.AutoSize = true;
        lblListeProduits.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblListeProduits.Location = new Point(5, 72);
        lblListeProduits.Text = "Liste des produits finis";
        //
        // lblFiche
        //
        lblFiche.AutoSize = true;
        lblFiche.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline);
        lblFiche.Location = new Point(440, 50);
        lblFiche.Text = "Fiche de stocks par produit";
        //
        // lblNomProduit
        //
        lblNomProduit.AutoSize = true;
        lblNomProduit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblNomProduit.Location = new Point(440, 72);
        //
        // lbxListeProduitsFinis
        //
        lbxListeProduitsFinis.BorderStyle = BorderStyle.FixedSingle;
        lbxListeProduitsFinis.Location = new Point(5, 100);
        lbxListeProduitsFinis.Size = new Size(180, 480);
        lbxListeProduitsFinis.SelectedIndexChanged += LbxListeProduitsFinis_SelectedIndexChanged;
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
        // UC_StocksProduitsFinis
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(lblListeProduits);
        Controls.Add(lblFiche);
        Controls.Add(lblNomProduit);
        Controls.Add(lbxListeProduitsFinis);
        Controls.Add(dgvJournal);
        Name = "UC_StocksProduitsFinis";
        Size = new Size(983, 635);
        Load += UC_StocksProduitsFinis_Load;
        ((System.ComponentModel.ISupportInitialize)dgvJournal).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblListeProduits;
    private Label lblFiche;
    private Label lblNomProduit;
    private ListBox lbxListeProduitsFinis;
    private DataGridView dgvJournal;
}
