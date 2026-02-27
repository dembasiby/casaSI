namespace CasaEcologie.WinForms.Pages;

partial class UC_JournalDepenses
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
        dgvJournalDepenses = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvJournalDepenses).BeginInit();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(350, 10);
        lblTitre.Text = "Journal des dépenses";
        //
        // dgvJournalDepenses
        //
        dgvJournalDepenses.AllowUserToAddRows = false;
        dgvJournalDepenses.AllowUserToDeleteRows = false;
        dgvJournalDepenses.ReadOnly = true;
        dgvJournalDepenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvJournalDepenses.Location = new Point(10, 50);
        dgvJournalDepenses.Size = new Size(960, 570);
        dgvJournalDepenses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        //
        // UC_JournalDepenses
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(dgvJournalDepenses);
        Name = "UC_JournalDepenses";
        Size = new Size(983, 635);
        Load += UC_JournalDepenses_Load;
        ((System.ComponentModel.ISupportInitialize)dgvJournalDepenses).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private DataGridView dgvJournalDepenses;
}
