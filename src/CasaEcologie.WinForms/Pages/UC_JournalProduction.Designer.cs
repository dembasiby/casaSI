namespace CasaEcologie.WinForms.Pages;

partial class UC_JournalProduction
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
        lblDu = new Label();
        dtpDebut = new DateTimePicker();
        lblAu = new Label();
        dtpFin = new DateTimePicker();
        dgvJoursEtCodeProduction = new DataGridView();
        grbIntrants = new GroupBox();
        lblMatieresPrem = new Label();
        lvwIntrantMatierePremiere = new ListView();
        colMPNom = new ColumnHeader();
        colMPQuantite = new ColumnHeader();
        lblPSFUtilises = new Label();
        lvwIntrantProduitSemiFini = new ListView();
        colPSFNom = new ColumnHeader();
        colPSFQuantite = new ColumnHeader();
        grbResultat = new GroupBox();
        lblProduitsFinis = new Label();
        lvwExtrantProduitFini = new ListView();
        colPFNom = new ColumnHeader();
        colPFQuantite = new ColumnHeader();
        lblPSFProduits = new Label();
        lvwExtrantProduitSemiFini = new ListView();
        colPSFProdNom = new ColumnHeader();
        colPSFProdQuantite = new ColumnHeader();
        grbRessourcesHumaines = new GroupBox();
        lvwRessourcesHumaines = new ListView();
        colEmploye = new ColumnHeader();
        ((System.ComponentModel.ISupportInitialize)dgvJoursEtCodeProduction).BeginInit();
        grbIntrants.SuspendLayout();
        grbResultat.SuspendLayout();
        grbRessourcesHumaines.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(350, 10);
        lblTitre.Text = "Journal de Production";
        //
        lblDu.AutoSize = true;
        lblDu.Location = new Point(10, 50);
        lblDu.Text = "Du";
        dtpDebut.Format = DateTimePickerFormat.Short;
        dtpDebut.Location = new Point(35, 47);
        dtpDebut.Size = new Size(120, 27);
        dtpDebut.ValueChanged += DtpDebut_ValueChanged;
        //
        lblAu.AutoSize = true;
        lblAu.Location = new Point(165, 50);
        lblAu.Text = "Au";
        dtpFin.Format = DateTimePickerFormat.Short;
        dtpFin.Location = new Point(190, 47);
        dtpFin.Size = new Size(120, 27);
        dtpFin.ValueChanged += DtpFin_ValueChanged;
        //
        // dgvJoursEtCodeProduction
        //
        dgvJoursEtCodeProduction.AllowUserToAddRows = false;
        dgvJoursEtCodeProduction.AllowUserToDeleteRows = false;
        dgvJoursEtCodeProduction.ReadOnly = true;
        dgvJoursEtCodeProduction.RowHeadersVisible = false;
        dgvJoursEtCodeProduction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvJoursEtCodeProduction.Location = new Point(10, 80);
        dgvJoursEtCodeProduction.Size = new Size(300, 540);
        dgvJoursEtCodeProduction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        dgvJoursEtCodeProduction.CellClick += DgvJoursEtCodeProduction_CellClick;
        //
        // grbIntrants
        //
        grbIntrants.Controls.Add(lblMatieresPrem);
        grbIntrants.Controls.Add(lvwIntrantMatierePremiere);
        grbIntrants.Controls.Add(lblPSFUtilises);
        grbIntrants.Controls.Add(lvwIntrantProduitSemiFini);
        grbIntrants.Location = new Point(320, 80);
        grbIntrants.Size = new Size(650, 180);
        grbIntrants.Text = "Intrants utilisés";
        //
        lblMatieresPrem.AutoSize = true;
        lblMatieresPrem.Location = new Point(10, 22);
        lblMatieresPrem.Text = "Matières premières";
        //
        colMPNom.Text = "Matière première";
        colMPNom.Width = 155;
        colMPQuantite.Text = "Quantité";
        colMPQuantite.Width = 65;
        lvwIntrantMatierePremiere.Columns.AddRange(new[] { colMPNom, colMPQuantite });
        lvwIntrantMatierePremiere.View = View.Details;
        lvwIntrantMatierePremiere.Location = new Point(10, 42);
        lvwIntrantMatierePremiere.Size = new Size(300, 125);
        //
        lblPSFUtilises.AutoSize = true;
        lblPSFUtilises.Location = new Point(330, 22);
        lblPSFUtilises.Text = "Produits semi-finis";
        //
        colPSFNom.Text = "Produit semi-fini";
        colPSFNom.Width = 150;
        colPSFQuantite.Text = "Quantité";
        colPSFQuantite.Width = 75;
        lvwIntrantProduitSemiFini.Columns.AddRange(new[] { colPSFNom, colPSFQuantite });
        lvwIntrantProduitSemiFini.View = View.Details;
        lvwIntrantProduitSemiFini.Location = new Point(330, 42);
        lvwIntrantProduitSemiFini.Size = new Size(300, 125);
        //
        // grbResultat
        //
        grbResultat.Controls.Add(lblProduitsFinis);
        grbResultat.Controls.Add(lvwExtrantProduitFini);
        grbResultat.Controls.Add(lblPSFProduits);
        grbResultat.Controls.Add(lvwExtrantProduitSemiFini);
        grbResultat.Location = new Point(320, 270);
        grbResultat.Size = new Size(650, 180);
        grbResultat.Text = "Résultat de la production";
        //
        lblProduitsFinis.AutoSize = true;
        lblProduitsFinis.Location = new Point(10, 22);
        lblProduitsFinis.Text = "Produits finis";
        //
        colPFNom.Text = "Produit fini";
        colPFNom.Width = 220;
        colPFQuantite.Text = "Quantité";
        colPFQuantite.Width = 70;
        lvwExtrantProduitFini.Columns.AddRange(new[] { colPFNom, colPFQuantite });
        lvwExtrantProduitFini.View = View.Details;
        lvwExtrantProduitFini.Location = new Point(10, 42);
        lvwExtrantProduitFini.Size = new Size(300, 125);
        //
        lblPSFProduits.AutoSize = true;
        lblPSFProduits.Location = new Point(330, 22);
        lblPSFProduits.Text = "Produits semi-finis";
        //
        colPSFProdNom.Text = "Produit semi-fini";
        colPSFProdNom.Width = 180;
        colPSFProdQuantite.Text = "Quantité";
        colPSFProdQuantite.Width = 70;
        lvwExtrantProduitSemiFini.Columns.AddRange(new[] { colPSFProdNom, colPSFProdQuantite });
        lvwExtrantProduitSemiFini.View = View.Details;
        lvwExtrantProduitSemiFini.Location = new Point(330, 42);
        lvwExtrantProduitSemiFini.Size = new Size(300, 125);
        //
        // grbRessourcesHumaines
        //
        grbRessourcesHumaines.Controls.Add(lvwRessourcesHumaines);
        grbRessourcesHumaines.Location = new Point(320, 460);
        grbRessourcesHumaines.Size = new Size(650, 160);
        grbRessourcesHumaines.Text = "Employés ayant participé à la production";
        grbRessourcesHumaines.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        //
        colEmploye.Text = "Prénom et Nom";
        colEmploye.Width = 250;
        lvwRessourcesHumaines.Columns.Add(colEmploye);
        lvwRessourcesHumaines.View = View.Details;
        lvwRessourcesHumaines.Location = new Point(10, 25);
        lvwRessourcesHumaines.Size = new Size(625, 120);
        lvwRessourcesHumaines.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        //
        // UC_JournalProduction
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(lblDu);
        Controls.Add(dtpDebut);
        Controls.Add(lblAu);
        Controls.Add(dtpFin);
        Controls.Add(dgvJoursEtCodeProduction);
        Controls.Add(grbIntrants);
        Controls.Add(grbResultat);
        Controls.Add(grbRessourcesHumaines);
        Name = "UC_JournalProduction";
        Size = new Size(983, 635);
        Load += UC_JournalProduction_Load;
        ((System.ComponentModel.ISupportInitialize)dgvJoursEtCodeProduction).EndInit();
        grbIntrants.ResumeLayout(false);
        grbIntrants.PerformLayout();
        grbResultat.ResumeLayout(false);
        grbResultat.PerformLayout();
        grbRessourcesHumaines.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblDu;
    private DateTimePicker dtpDebut;
    private Label lblAu;
    private DateTimePicker dtpFin;
    private DataGridView dgvJoursEtCodeProduction;
    private GroupBox grbIntrants;
    private Label lblMatieresPrem;
    private ListView lvwIntrantMatierePremiere;
    private ColumnHeader colMPNom;
    private ColumnHeader colMPQuantite;
    private Label lblPSFUtilises;
    private ListView lvwIntrantProduitSemiFini;
    private ColumnHeader colPSFNom;
    private ColumnHeader colPSFQuantite;
    private GroupBox grbResultat;
    private Label lblProduitsFinis;
    private ListView lvwExtrantProduitFini;
    private ColumnHeader colPFNom;
    private ColumnHeader colPFQuantite;
    private Label lblPSFProduits;
    private ListView lvwExtrantProduitSemiFini;
    private ColumnHeader colPSFProdNom;
    private ColumnHeader colPSFProdQuantite;
    private GroupBox grbRessourcesHumaines;
    private ListView lvwRessourcesHumaines;
    private ColumnHeader colEmploye;
}
