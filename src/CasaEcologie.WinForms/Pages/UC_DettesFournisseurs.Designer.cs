namespace CasaEcologie.WinForms.Pages;

partial class UC_DettesFournisseurs
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
        lblTotalLabel = new Label();
        txtTotalDettesFournisseurs = new TextBox();
        lblDetailsLabel = new Label();
        rbtFMatieresPremieres = new RadioButton();
        rbtFEquipementsInfra = new RadioButton();
        rbtAutresFournisseurs = new RadioButton();
        lbxListeFournisseursDettes = new ListBox();
        dgvDetails = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(295, 10);
        lblTitre.Text = "Dettes fournisseurs";
        //
        // lblTotalLabel
        //
        lblTotalLabel.AutoSize = true;
        lblTotalLabel.Location = new Point(10, 50);
        lblTotalLabel.Text = "Total des dettes fournisseurs";
        //
        // txtTotalDettesFournisseurs
        //
        txtTotalDettesFournisseurs.Location = new Point(10, 70);
        txtTotalDettesFournisseurs.Size = new Size(170, 27);
        txtTotalDettesFournisseurs.ReadOnly = true;
        txtTotalDettesFournisseurs.ForeColor = Color.Red;
        txtTotalDettesFournisseurs.TextAlign = HorizontalAlignment.Center;
        //
        // rbtFMatieresPremieres
        //
        rbtFMatieresPremieres.AutoSize = true;
        rbtFMatieresPremieres.Location = new Point(200, 75);
        rbtFMatieresPremieres.Text = "Fournisseurs matières premières";
        rbtFMatieresPremieres.CheckedChanged += RbtFMatieresPremieres_CheckedChanged;
        //
        // rbtFEquipementsInfra
        //
        rbtFEquipementsInfra.AutoSize = true;
        rbtFEquipementsInfra.Location = new Point(460, 75);
        rbtFEquipementsInfra.Text = "Fournisseurs équipement/infrastructures";
        rbtFEquipementsInfra.CheckedChanged += RbtFEquipementsInfra_CheckedChanged;
        //
        // rbtAutresFournisseurs
        //
        rbtAutresFournisseurs.AutoSize = true;
        rbtAutresFournisseurs.Location = new Point(740, 75);
        rbtAutresFournisseurs.Text = "Autres fournisseurs";
        rbtAutresFournisseurs.CheckedChanged += RbtAutresFournisseurs_CheckedChanged;
        //
        // lbxListeFournisseursDettes
        //
        lbxListeFournisseursDettes.BorderStyle = BorderStyle.FixedSingle;
        lbxListeFournisseursDettes.Location = new Point(10, 105);
        lbxListeFournisseursDettes.Size = new Size(175, 480);
        lbxListeFournisseursDettes.SelectedValueChanged += LbxListeFournisseursDettes_SelectedValueChanged;
        //
        // lblDetailsLabel
        //
        lblDetailsLabel.AutoSize = true;
        lblDetailsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblDetailsLabel.Location = new Point(345, 48);
        lblDetailsLabel.Text = "Détails des dettes fournisseurs";
        //
        // dgvDetails
        //
        dgvDetails.AllowUserToAddRows = false;
        dgvDetails.AllowUserToDeleteRows = false;
        dgvDetails.ReadOnly = true;
        dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvDetails.RowHeadersVisible = false;
        dgvDetails.Location = new Point(200, 105);
        dgvDetails.Size = new Size(770, 480);
        dgvDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        //
        // UC_DettesFournisseurs
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(lblTotalLabel);
        Controls.Add(txtTotalDettesFournisseurs);
        Controls.Add(rbtFMatieresPremieres);
        Controls.Add(rbtFEquipementsInfra);
        Controls.Add(rbtAutresFournisseurs);
        Controls.Add(lbxListeFournisseursDettes);
        Controls.Add(lblDetailsLabel);
        Controls.Add(dgvDetails);
        Name = "UC_DettesFournisseurs";
        Size = new Size(983, 635);
        Load += UC_DettesFournisseurs_Load;
        ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblTotalLabel;
    private TextBox txtTotalDettesFournisseurs;
    private Label lblDetailsLabel;
    private RadioButton rbtFMatieresPremieres;
    private RadioButton rbtFEquipementsInfra;
    private RadioButton rbtAutresFournisseurs;
    private ListBox lbxListeFournisseursDettes;
    private DataGridView dgvDetails;
}
