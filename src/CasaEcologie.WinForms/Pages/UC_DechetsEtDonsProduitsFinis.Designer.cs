namespace CasaEcologie.WinForms.Pages;

partial class UC_DechetsEtDonsProduitsFinis
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
        grpSortie = new GroupBox();
        lblDate = new Label();
        dtpDateSortieDechetsOuDons = new DateTimePicker();
        lblProduitFini = new Label();
        cbxProduitsFinis = new ComboBox();
        lblStockDisponible = new Label();
        txtStockDisponible = new TextBox();
        lblQuantite = new Label();
        txtQuantite = new TextBox();
        lblDescription = new Label();
        txtDescription = new TextBox();
        lblResponsableStock = new Label();
        cbxResponsableStock = new ComboBox();
        btnEnregistrerSortie = new Button();
        grpSortie.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(220, 10);
        lblTitre.Text = "Sortie de déchets ou dons de produits finis";
        //
        // grpSortie
        //
        grpSortie.Controls.Add(lblDate);
        grpSortie.Controls.Add(dtpDateSortieDechetsOuDons);
        grpSortie.Controls.Add(lblProduitFini);
        grpSortie.Controls.Add(cbxProduitsFinis);
        grpSortie.Controls.Add(lblStockDisponible);
        grpSortie.Controls.Add(txtStockDisponible);
        grpSortie.Controls.Add(lblQuantite);
        grpSortie.Controls.Add(txtQuantite);
        grpSortie.Controls.Add(lblDescription);
        grpSortie.Controls.Add(txtDescription);
        grpSortie.Controls.Add(lblResponsableStock);
        grpSortie.Controls.Add(cbxResponsableStock);
        grpSortie.Controls.Add(btnEnregistrerSortie);
        grpSortie.Location = new Point(10, 50);
        grpSortie.Size = new Size(950, 310);
        grpSortie.Text = "Sortie";
        //
        lblDate.AutoSize = true;
        lblDate.Location = new Point(10, 30);
        lblDate.Text = "Date opération";
        dtpDateSortieDechetsOuDons.Location = new Point(200, 27);
        dtpDateSortieDechetsOuDons.Size = new Size(300, 27);
        dtpDateSortieDechetsOuDons.ValueChanged += DtpDateSortieDechetsOuDons_ValueChanged;
        //
        lblProduitFini.AutoSize = true;
        lblProduitFini.Location = new Point(10, 65);
        lblProduitFini.Text = "Produit fini";
        cbxProduitsFinis.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxProduitsFinis.Location = new Point(200, 62);
        cbxProduitsFinis.Size = new Size(300, 28);
        cbxProduitsFinis.SelectedIndexChanged += CbxProduitsFinis_SelectedIndexChanged;
        //
        lblStockDisponible.AutoSize = true;
        lblStockDisponible.Location = new Point(10, 100);
        lblStockDisponible.Text = "Stock disponible";
        txtStockDisponible.Location = new Point(200, 97);
        txtStockDisponible.Size = new Size(300, 27);
        txtStockDisponible.ReadOnly = true;
        //
        lblQuantite.AutoSize = true;
        lblQuantite.Location = new Point(10, 135);
        lblQuantite.Text = "Quantité";
        txtQuantite.Location = new Point(200, 132);
        txtQuantite.Size = new Size(300, 27);
        //
        lblDescription.AutoSize = true;
        lblDescription.Location = new Point(10, 170);
        lblDescription.Text = "Description";
        txtDescription.Location = new Point(200, 167);
        txtDescription.Size = new Size(300, 27);
        //
        lblResponsableStock.AutoSize = true;
        lblResponsableStock.Location = new Point(10, 205);
        lblResponsableStock.Text = "Responsable du stock";
        cbxResponsableStock.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxResponsableStock.Location = new Point(200, 202);
        cbxResponsableStock.Size = new Size(300, 28);
        //
        btnEnregistrerSortie.BackColor = Color.FromArgb(40, 92, 41);
        btnEnregistrerSortie.FlatStyle = FlatStyle.Flat;
        btnEnregistrerSortie.FlatAppearance.BorderSize = 0;
        btnEnregistrerSortie.ForeColor = Color.WhiteSmoke;
        btnEnregistrerSortie.Location = new Point(200, 242);
        btnEnregistrerSortie.Size = new Size(300, 35);
        btnEnregistrerSortie.Text = "Enregistrer la sortie";
        btnEnregistrerSortie.UseVisualStyleBackColor = false;
        btnEnregistrerSortie.Click += BtnEnregistrerSortie_Click;
        //
        // UC_DechetsEtDonsProduitsFinis
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(grpSortie);
        Name = "UC_DechetsEtDonsProduitsFinis";
        Size = new Size(983, 635);
        Load += UC_DechetsEtDonsProduitsFinis_Load;
        grpSortie.ResumeLayout(false);
        grpSortie.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private GroupBox grpSortie;
    private Label lblDate;
    private DateTimePicker dtpDateSortieDechetsOuDons;
    private Label lblProduitFini;
    private ComboBox cbxProduitsFinis;
    private Label lblStockDisponible;
    private TextBox txtStockDisponible;
    private Label lblQuantite;
    private TextBox txtQuantite;
    private Label lblDescription;
    private TextBox txtDescription;
    private Label lblResponsableStock;
    private ComboBox cbxResponsableStock;
    private Button btnEnregistrerSortie;
}
