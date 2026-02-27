namespace CasaEcologie.WinForms.Pages;

partial class UC_RegistreImmobilisations
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
        dgvImmobilisations = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvImmobilisations).BeginInit();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(280, 10);
        lblTitre.Text = "Registre des Immobilisations";
        //
        // dgvImmobilisations
        //
        dgvImmobilisations.AllowUserToAddRows = false;
        dgvImmobilisations.AllowUserToDeleteRows = false;
        dgvImmobilisations.ReadOnly = true;
        dgvImmobilisations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvImmobilisations.Location = new Point(10, 50);
        dgvImmobilisations.Size = new Size(960, 570);
        dgvImmobilisations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        //
        // UC_RegistreImmobilisations
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(dgvImmobilisations);
        Name = "UC_RegistreImmobilisations";
        Size = new Size(983, 635);
        Load += UC_RegistreImmobilisations_Load;
        ((System.ComponentModel.ISupportInitialize)dgvImmobilisations).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private DataGridView dgvImmobilisations;
}
