namespace CasaEcologie.WinForms.Pages;

partial class UC_JournalApprovisionnements
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
        lblMatiere = new Label();
        cbxMatieresPremieres = new ComboBox();
        lblFournisseur = new Label();
        cbxFournisseurs = new ComboBox();
        lblLocalite = new Label();
        cbxLocaliteFournisseur = new ComboBox();
        dgvJournalApprovisionnements = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvJournalApprovisionnements).BeginInit();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(300, 10);
        lblTitre.Text = "Journal des Approvisionnements";
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
        lblMatiere.AutoSize = true;
        lblMatiere.Location = new Point(10, 90);
        lblMatiere.Text = "Matière première";
        cbxMatieresPremieres.Location = new Point(140, 87);
        cbxMatieresPremieres.Size = new Size(180, 28);
        cbxMatieresPremieres.SelectedIndexChanged += CbxMatieresPremieres_SelectedIndexChanged;
        cbxMatieresPremieres.TextChanged += CbxMatieresPremieres_TextChanged;
        //
        lblFournisseur.AutoSize = true;
        lblFournisseur.Location = new Point(340, 90);
        lblFournisseur.Text = "Fournisseur";
        cbxFournisseurs.Location = new Point(430, 87);
        cbxFournisseurs.Size = new Size(180, 28);
        cbxFournisseurs.SelectedIndexChanged += CbxFournisseurs_SelectedIndexChanged;
        cbxFournisseurs.TextChanged += CbxFournisseurs_TextChanged;
        //
        lblLocalite.AutoSize = true;
        lblLocalite.Location = new Point(630, 90);
        lblLocalite.Text = "Localité";
        cbxLocaliteFournisseur.Location = new Point(700, 87);
        cbxLocaliteFournisseur.Size = new Size(180, 28);
        cbxLocaliteFournisseur.SelectedIndexChanged += CbxLocaliteFournisseur_SelectedIndexChanged;
        cbxLocaliteFournisseur.TextChanged += CbxLocaliteFournisseur_TextChanged;
        //
        // dgvJournalApprovisionnements
        //
        dgvJournalApprovisionnements.AllowUserToAddRows = false;
        dgvJournalApprovisionnements.AllowUserToDeleteRows = false;
        dgvJournalApprovisionnements.ReadOnly = true;
        dgvJournalApprovisionnements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvJournalApprovisionnements.Location = new Point(10, 125);
        dgvJournalApprovisionnements.Size = new Size(960, 495);
        dgvJournalApprovisionnements.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        //
        // UC_JournalApprovisionnements
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(lblDebut);
        Controls.Add(dtpDebut);
        Controls.Add(lblFin);
        Controls.Add(dtpFin);
        Controls.Add(lblMatiere);
        Controls.Add(cbxMatieresPremieres);
        Controls.Add(lblFournisseur);
        Controls.Add(cbxFournisseurs);
        Controls.Add(lblLocalite);
        Controls.Add(cbxLocaliteFournisseur);
        Controls.Add(dgvJournalApprovisionnements);
        Name = "UC_JournalApprovisionnements";
        Size = new Size(983, 635);
        Load += UC_JournalApprovisionnements_Load;
        ((System.ComponentModel.ISupportInitialize)dgvJournalApprovisionnements).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblDebut;
    private DateTimePicker dtpDebut;
    private Label lblFin;
    private DateTimePicker dtpFin;
    private Label lblMatiere;
    private ComboBox cbxMatieresPremieres;
    private Label lblFournisseur;
    private ComboBox cbxFournisseurs;
    private Label lblLocalite;
    private ComboBox cbxLocaliteFournisseur;
    private DataGridView dgvJournalApprovisionnements;
}
