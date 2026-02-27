namespace CasaEcologie.WinForms.Pages;

partial class UC_AutreEncaissementDeFonds
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
        grpEncaissement = new GroupBox();
        lblDate = new Label();
        dtpDateEncaissement = new DateTimePicker();
        lblCompte = new Label();
        cbxCompteCrediteur = new ComboBox();
        lblResponsable = new Label();
        cbxResponsableTransaction = new ComboBox();
        lblDescription = new Label();
        txtDescription = new TextBox();
        lblMontant = new Label();
        txtMontantEncaisse = new TextBox();
        btnEnregistrer = new Button();
        grpEncaissement.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(280, 10);
        lblTitre.Text = "Autre encaissement de fonds";
        //
        // grpEncaissement
        //
        grpEncaissement.Controls.Add(lblDate);
        grpEncaissement.Controls.Add(dtpDateEncaissement);
        grpEncaissement.Controls.Add(lblCompte);
        grpEncaissement.Controls.Add(cbxCompteCrediteur);
        grpEncaissement.Controls.Add(lblResponsable);
        grpEncaissement.Controls.Add(cbxResponsableTransaction);
        grpEncaissement.Controls.Add(lblDescription);
        grpEncaissement.Controls.Add(txtDescription);
        grpEncaissement.Controls.Add(lblMontant);
        grpEncaissement.Controls.Add(txtMontantEncaisse);
        grpEncaissement.Controls.Add(btnEnregistrer);
        grpEncaissement.Location = new Point(10, 50);
        grpEncaissement.Size = new Size(950, 260);
        grpEncaissement.Text = "Encaissement";
        //
        lblDate.AutoSize = true;
        lblDate.Location = new Point(10, 30);
        lblDate.Text = "Date";
        dtpDateEncaissement.Location = new Point(200, 27);
        dtpDateEncaissement.Size = new Size(300, 27);
        dtpDateEncaissement.ValueChanged += DtpDateEncaissement_ValueChanged;
        //
        lblCompte.AutoSize = true;
        lblCompte.Location = new Point(10, 65);
        lblCompte.Text = "Compte créditeur";
        cbxCompteCrediteur.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxCompteCrediteur.Location = new Point(200, 62);
        cbxCompteCrediteur.Size = new Size(300, 28);
        //
        lblResponsable.AutoSize = true;
        lblResponsable.Location = new Point(10, 100);
        lblResponsable.Text = "Responsable";
        cbxResponsableTransaction.Location = new Point(200, 97);
        cbxResponsableTransaction.Size = new Size(300, 28);
        //
        lblDescription.AutoSize = true;
        lblDescription.Location = new Point(10, 135);
        lblDescription.Text = "Description";
        txtDescription.Location = new Point(200, 132);
        txtDescription.Size = new Size(300, 27);
        //
        lblMontant.AutoSize = true;
        lblMontant.Location = new Point(10, 170);
        lblMontant.Text = "Montant encaissé";
        txtMontantEncaisse.Location = new Point(200, 167);
        txtMontantEncaisse.Size = new Size(300, 27);
        //
        btnEnregistrer.BackColor = Color.FromArgb(40, 92, 41);
        btnEnregistrer.FlatStyle = FlatStyle.Flat;
        btnEnregistrer.FlatAppearance.BorderSize = 0;
        btnEnregistrer.ForeColor = Color.WhiteSmoke;
        btnEnregistrer.Location = new Point(200, 207);
        btnEnregistrer.Size = new Size(300, 35);
        btnEnregistrer.Text = "Enregistrer";
        btnEnregistrer.UseVisualStyleBackColor = false;
        btnEnregistrer.Click += BtnEnregistrer_Click;
        //
        // UC_AutreEncaissementDeFonds
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(grpEncaissement);
        Name = "UC_AutreEncaissementDeFonds";
        Size = new Size(983, 635);
        Load += UC_AutreEncaissementDeFonds_Load;
        grpEncaissement.ResumeLayout(false);
        grpEncaissement.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private GroupBox grpEncaissement;
    private Label lblDate;
    private DateTimePicker dtpDateEncaissement;
    private Label lblCompte;
    private ComboBox cbxCompteCrediteur;
    private Label lblResponsable;
    private ComboBox cbxResponsableTransaction;
    private Label lblDescription;
    private TextBox txtDescription;
    private Label lblMontant;
    private TextBox txtMontantEncaisse;
    private Button btnEnregistrer;
}
