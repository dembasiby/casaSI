namespace CasaEcologie.WinForms.Pages;

partial class UC_NouveauCompteTresorerie
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
        txtSoldeCompte = new TextBox();
        txtNomCompte = new TextBox();
        lblSoldeInitial = new Label();
        btnAjouterNouveauCompte = new Button();
        lblNomCompte = new Label();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(237, 19);
        lblTitre.Name = "lblTitre";
        lblTitre.Size = new Size(414, 32);
        lblTitre.Text = "Créer un nouveau compte de trésorerie";
        lblTitre.TextAlign = ContentAlignment.TopCenter;
        //
        // lblNomCompte
        //
        lblNomCompte.AutoSize = true;
        lblNomCompte.Location = new Point(186, 95);
        lblNomCompte.Name = "lblNomCompte";
        lblNomCompte.Size = new Size(218, 20);
        lblNomCompte.Text = "Nom du compte à ajouter:";
        //
        // txtNomCompte
        //
        txtNomCompte.Location = new Point(410, 94);
        txtNomCompte.Name = "txtNomCompte";
        txtNomCompte.Size = new Size(250, 27);
        //
        // lblSoldeInitial
        //
        lblSoldeInitial.AutoSize = true;
        lblSoldeInitial.Location = new Point(186, 137);
        lblSoldeInitial.Name = "lblSoldeInitial";
        lblSoldeInitial.Size = new Size(100, 20);
        lblSoldeInitial.Text = "Solde initial:";
        //
        // txtSoldeCompte
        //
        txtSoldeCompte.Location = new Point(410, 137);
        txtSoldeCompte.Name = "txtSoldeCompte";
        txtSoldeCompte.Size = new Size(250, 27);
        //
        // btnAjouterNouveauCompte
        //
        btnAjouterNouveauCompte.BackColor = Color.FromArgb(40, 92, 41);
        btnAjouterNouveauCompte.FlatAppearance.BorderSize = 0;
        btnAjouterNouveauCompte.FlatStyle = FlatStyle.Flat;
        btnAjouterNouveauCompte.ForeColor = Color.WhiteSmoke;
        btnAjouterNouveauCompte.Location = new Point(396, 187);
        btnAjouterNouveauCompte.Name = "btnAjouterNouveauCompte";
        btnAjouterNouveauCompte.Size = new Size(264, 35);
        btnAjouterNouveauCompte.Text = "Ajouter le compte";
        btnAjouterNouveauCompte.UseVisualStyleBackColor = false;
        btnAjouterNouveauCompte.Click += BtnAjouterNouveauCompte_Click;
        //
        // UC_NouveauCompteTresorerie
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(txtSoldeCompte);
        Controls.Add(txtNomCompte);
        Controls.Add(lblSoldeInitial);
        Controls.Add(btnAjouterNouveauCompte);
        Controls.Add(lblNomCompte);
        Controls.Add(lblTitre);
        Name = "UC_NouveauCompteTresorerie";
        Size = new Size(983, 635);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private TextBox txtSoldeCompte;
    private TextBox txtNomCompte;
    private Label lblSoldeInitial;
    private Button btnAjouterNouveauCompte;
    private Label lblNomCompte;
}
