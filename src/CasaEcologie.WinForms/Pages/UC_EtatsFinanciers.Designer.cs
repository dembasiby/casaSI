namespace CasaEcologie.WinForms.Pages;

partial class UC_EtatsFinanciers
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
        tabControl = new TabControl();
        tabCpteResultats = new TabPage();
        dgvCpteResultats = new DataGridView();
        colLibelleCR = new DataGridViewTextBoxColumn();
        colMontantCR = new DataGridViewTextBoxColumn();
        tabTresorerie = new TabPage();
        dgvTableauTresorerie = new DataGridView();
        colLibelleTres = new DataGridViewTextBoxColumn();
        colMontantTres = new DataGridViewTextBoxColumn();
        tabBilan = new TabPage();
        dgvBilan = new DataGridView();
        colLibelleBilan = new DataGridViewTextBoxColumn();
        colMontantBilan = new DataGridViewTextBoxColumn();
        tabControl.SuspendLayout();
        tabCpteResultats.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCpteResultats).BeginInit();
        tabTresorerie.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTableauTresorerie).BeginInit();
        tabBilan.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvBilan).BeginInit();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(320, 10);
        lblTitre.Text = "États Financiers";
        //
        // lblDebut / dtpDebut
        //
        lblDebut.AutoSize = true;
        lblDebut.Location = new Point(10, 55);
        lblDebut.Text = "Du";
        dtpDebut.Format = DateTimePickerFormat.Short;
        dtpDebut.Location = new Point(35, 50);
        dtpDebut.Size = new Size(150, 27);
        dtpDebut.Value = new DateTime(2019, 1, 1);
        dtpDebut.ValueChanged += DtpDebut_ValueChanged;
        //
        // lblFin / dtpFin
        //
        lblFin.AutoSize = true;
        lblFin.Location = new Point(200, 55);
        lblFin.Text = "Au";
        dtpFin.Format = DateTimePickerFormat.Short;
        dtpFin.Location = new Point(225, 50);
        dtpFin.Size = new Size(150, 27);
        dtpFin.ValueChanged += DtpFin_ValueChanged;
        //
        // tabControl
        //
        tabControl.Location = new Point(10, 85);
        tabControl.Size = new Size(960, 540);
        tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabControl.Controls.Add(tabCpteResultats);
        tabControl.Controls.Add(tabTresorerie);
        tabControl.Controls.Add(tabBilan);
        //
        // tabCpteResultats
        //
        tabCpteResultats.Text = "Compte de résultat";
        tabCpteResultats.Controls.Add(dgvCpteResultats);
        //
        // dgvCpteResultats
        //
        dgvCpteResultats.AllowUserToAddRows = false;
        dgvCpteResultats.AllowUserToDeleteRows = false;
        dgvCpteResultats.ReadOnly = true;
        dgvCpteResultats.RowHeadersVisible = false;
        dgvCpteResultats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvCpteResultats.Dock = DockStyle.Fill;
        dgvCpteResultats.Columns.AddRange(colLibelleCR, colMontantCR);
        colLibelleCR.HeaderText = "Libellé";
        colLibelleCR.FillWeight = 200;
        colMontantCR.HeaderText = "Montant";
        colMontantCR.DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight };
        //
        // tabTresorerie
        //
        tabTresorerie.Text = "Trésorerie";
        tabTresorerie.Controls.Add(dgvTableauTresorerie);
        //
        // dgvTableauTresorerie
        //
        dgvTableauTresorerie.AllowUserToAddRows = false;
        dgvTableauTresorerie.AllowUserToDeleteRows = false;
        dgvTableauTresorerie.ReadOnly = true;
        dgvTableauTresorerie.RowHeadersVisible = false;
        dgvTableauTresorerie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTableauTresorerie.Dock = DockStyle.Fill;
        dgvTableauTresorerie.Columns.AddRange(colLibelleTres, colMontantTres);
        colLibelleTres.HeaderText = "Libellé";
        colLibelleTres.FillWeight = 200;
        colMontantTres.HeaderText = "Montant";
        colMontantTres.DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight };
        //
        // tabBilan
        //
        tabBilan.Text = "Bilan";
        tabBilan.Controls.Add(dgvBilan);
        //
        // dgvBilan
        //
        dgvBilan.AllowUserToAddRows = false;
        dgvBilan.AllowUserToDeleteRows = false;
        dgvBilan.ReadOnly = true;
        dgvBilan.RowHeadersVisible = false;
        dgvBilan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvBilan.Dock = DockStyle.Fill;
        dgvBilan.Columns.AddRange(colLibelleBilan, colMontantBilan);
        colLibelleBilan.HeaderText = "Libellé";
        colLibelleBilan.FillWeight = 200;
        colMontantBilan.HeaderText = "Montant";
        colMontantBilan.DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight };
        //
        // UC_EtatsFinanciers
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(lblDebut);
        Controls.Add(dtpDebut);
        Controls.Add(lblFin);
        Controls.Add(dtpFin);
        Controls.Add(tabControl);
        Name = "UC_EtatsFinanciers";
        Size = new Size(983, 635);
        Load += UC_EtatsFinanciers_Load;
        tabControl.ResumeLayout(false);
        tabCpteResultats.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvCpteResultats).EndInit();
        tabTresorerie.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvTableauTresorerie).EndInit();
        tabBilan.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvBilan).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblDebut;
    private DateTimePicker dtpDebut;
    private Label lblFin;
    private DateTimePicker dtpFin;
    private TabControl tabControl;
    private TabPage tabCpteResultats;
    private DataGridView dgvCpteResultats;
    private DataGridViewTextBoxColumn colLibelleCR;
    private DataGridViewTextBoxColumn colMontantCR;
    private TabPage tabTresorerie;
    private DataGridView dgvTableauTresorerie;
    private DataGridViewTextBoxColumn colLibelleTres;
    private DataGridViewTextBoxColumn colMontantTres;
    private TabPage tabBilan;
    private DataGridView dgvBilan;
    private DataGridViewTextBoxColumn colLibelleBilan;
    private DataGridViewTextBoxColumn colMontantBilan;
}
