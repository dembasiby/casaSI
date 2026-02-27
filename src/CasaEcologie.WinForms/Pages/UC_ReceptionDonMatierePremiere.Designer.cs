namespace CasaEcologie.WinForms.Pages;

partial class UC_ReceptionDonMatierePremiere
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
        grpDon = new GroupBox();
        lblDate = new Label();
        dtpDateReception = new DateTimePicker();
        lblFournisseur = new Label();
        cbxFournisseur = new ComboBox();
        lblMatierePremiere = new Label();
        cbxMatierePremiere = new ComboBox();
        lblQuantite = new Label();
        txtQuantite = new TextBox();
        lblEmploye = new Label();
        cbxEmploye = new ComboBox();
        btnEnregistrer = new Button();
        grpTransport = new GroupBox();
        lblTransport = new Label();
        txtTransport = new TextBox();
        lblCompte = new Label();
        cbxCompte = new ComboBox();
        grpDon.SuspendLayout();
        grpTransport.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(280, 10);
        lblTitre.Text = "Réception don de matière première";
        //
        // grpDon
        //
        grpDon.Controls.Add(lblDate);
        grpDon.Controls.Add(dtpDateReception);
        grpDon.Controls.Add(lblFournisseur);
        grpDon.Controls.Add(cbxFournisseur);
        grpDon.Controls.Add(lblMatierePremiere);
        grpDon.Controls.Add(cbxMatierePremiere);
        grpDon.Controls.Add(lblQuantite);
        grpDon.Controls.Add(txtQuantite);
        grpDon.Controls.Add(lblEmploye);
        grpDon.Controls.Add(cbxEmploye);
        grpDon.Controls.Add(btnEnregistrer);
        grpDon.Location = new Point(10, 50);
        grpDon.Size = new Size(950, 250);
        grpDon.Text = "Don de matière première";
        //
        lblDate.AutoSize = true;
        lblDate.Location = new Point(10, 30);
        lblDate.Text = "Date de réception";
        dtpDateReception.Location = new Point(200, 27);
        dtpDateReception.Size = new Size(300, 27);
        dtpDateReception.ValueChanged += DtpDateReception_ValueChanged;
        //
        lblFournisseur.AutoSize = true;
        lblFournisseur.Location = new Point(10, 65);
        lblFournisseur.Text = "Fournisseur";
        cbxFournisseur.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxFournisseur.Location = new Point(200, 62);
        cbxFournisseur.Size = new Size(300, 28);
        //
        lblMatierePremiere.AutoSize = true;
        lblMatierePremiere.Location = new Point(10, 100);
        lblMatierePremiere.Text = "Matière première";
        cbxMatierePremiere.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxMatierePremiere.Location = new Point(200, 97);
        cbxMatierePremiere.Size = new Size(300, 28);
        //
        lblQuantite.AutoSize = true;
        lblQuantite.Location = new Point(10, 135);
        lblQuantite.Text = "Quantité";
        txtQuantite.Location = new Point(200, 132);
        txtQuantite.Size = new Size(300, 27);
        txtQuantite.Text = "0";
        //
        lblEmploye.AutoSize = true;
        lblEmploye.Location = new Point(10, 170);
        lblEmploye.Text = "Responsable stock";
        cbxEmploye.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxEmploye.Location = new Point(200, 167);
        cbxEmploye.Size = new Size(300, 28);
        //
        btnEnregistrer.BackColor = Color.FromArgb(40, 92, 41);
        btnEnregistrer.FlatStyle = FlatStyle.Flat;
        btnEnregistrer.FlatAppearance.BorderSize = 0;
        btnEnregistrer.ForeColor = Color.WhiteSmoke;
        btnEnregistrer.Location = new Point(200, 205);
        btnEnregistrer.Size = new Size(300, 35);
        btnEnregistrer.Text = "Ajouter au stock";
        btnEnregistrer.UseVisualStyleBackColor = false;
        btnEnregistrer.Click += BtnEnregistrer_Click;
        //
        // grpTransport
        //
        grpTransport.Controls.Add(lblTransport);
        grpTransport.Controls.Add(txtTransport);
        grpTransport.Controls.Add(lblCompte);
        grpTransport.Controls.Add(cbxCompte);
        grpTransport.Location = new Point(10, 320);
        grpTransport.Size = new Size(950, 120);
        grpTransport.Text = "Paiement transport";
        //
        lblTransport.AutoSize = true;
        lblTransport.Location = new Point(10, 30);
        lblTransport.Text = "Transport";
        txtTransport.Location = new Point(200, 27);
        txtTransport.Size = new Size(300, 27);
        txtTransport.Text = "0";
        //
        lblCompte.AutoSize = true;
        lblCompte.Location = new Point(10, 65);
        lblCompte.Text = "Compte";
        cbxCompte.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxCompte.Location = new Point(200, 62);
        cbxCompte.Size = new Size(300, 28);
        //
        // UC_ReceptionDonMatierePremiere
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(grpDon);
        Controls.Add(grpTransport);
        Name = "UC_ReceptionDonMatierePremiere";
        Size = new Size(983, 635);
        Load += UC_ReceptionDonMatierePremiere_Load;
        grpDon.ResumeLayout(false);
        grpDon.PerformLayout();
        grpTransport.ResumeLayout(false);
        grpTransport.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private GroupBox grpDon;
    private Label lblDate;
    private DateTimePicker dtpDateReception;
    private Label lblFournisseur;
    private ComboBox cbxFournisseur;
    private Label lblMatierePremiere;
    private ComboBox cbxMatierePremiere;
    private Label lblQuantite;
    private TextBox txtQuantite;
    private Label lblEmploye;
    private ComboBox cbxEmploye;
    private Button btnEnregistrer;
    private GroupBox grpTransport;
    private Label lblTransport;
    private TextBox txtTransport;
    private Label lblCompte;
    private ComboBox cbxCompte;
}
