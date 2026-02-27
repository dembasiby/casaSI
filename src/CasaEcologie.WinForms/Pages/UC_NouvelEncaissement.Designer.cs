namespace CasaEcologie.WinForms.Pages;

partial class UC_NouvelEncaissement
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
        lblClient = new Label();
        cbxNomClient = new ComboBox();
        lblCreancesClient = new Label();
        txtCreancesClient = new TextBox();
        lblDate = new Label();
        dtpDateEncaissement = new DateTimePicker();
        lblTresoriere = new Label();
        cbxTres = new ComboBox();
        lblCompte = new Label();
        cbxCompte = new ComboBox();
        lblMontant = new Label();
        txtMontantEncaisse = new TextBox();
        btnEnregistrerEncaissement = new Button();
        grpEncaissement.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(280, 10);
        lblTitre.Text = "Encaissement de créances clients";
        //
        // grpEncaissement
        //
        grpEncaissement.Controls.Add(lblClient);
        grpEncaissement.Controls.Add(cbxNomClient);
        grpEncaissement.Controls.Add(lblCreancesClient);
        grpEncaissement.Controls.Add(txtCreancesClient);
        grpEncaissement.Controls.Add(lblDate);
        grpEncaissement.Controls.Add(dtpDateEncaissement);
        grpEncaissement.Controls.Add(lblTresoriere);
        grpEncaissement.Controls.Add(cbxTres);
        grpEncaissement.Controls.Add(lblCompte);
        grpEncaissement.Controls.Add(cbxCompte);
        grpEncaissement.Controls.Add(lblMontant);
        grpEncaissement.Controls.Add(txtMontantEncaisse);
        grpEncaissement.Controls.Add(btnEnregistrerEncaissement);
        grpEncaissement.Location = new Point(10, 50);
        grpEncaissement.Size = new Size(950, 280);
        grpEncaissement.Text = "Encaissement";
        //
        lblClient.AutoSize = true;
        lblClient.Location = new Point(10, 30);
        lblClient.Text = "Client";
        cbxNomClient.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxNomClient.Location = new Point(180, 27);
        cbxNomClient.Size = new Size(300, 28);
        cbxNomClient.SelectedValueChanged += CbxNomClient_SelectedValueChanged;
        //
        lblCreancesClient.AutoSize = true;
        lblCreancesClient.Location = new Point(10, 65);
        lblCreancesClient.Text = "Créances du client";
        txtCreancesClient.Location = new Point(180, 62);
        txtCreancesClient.Size = new Size(300, 27);
        txtCreancesClient.ReadOnly = true;
        //
        lblDate.AutoSize = true;
        lblDate.Location = new Point(10, 100);
        lblDate.Text = "Date";
        dtpDateEncaissement.Location = new Point(180, 97);
        dtpDateEncaissement.Size = new Size(300, 27);
        dtpDateEncaissement.ValueChanged += DtpDateEncaissement_ValueChanged;
        //
        lblTresoriere.AutoSize = true;
        lblTresoriere.Location = new Point(10, 135);
        lblTresoriere.Text = "Trésorière";
        cbxTres.Location = new Point(180, 132);
        cbxTres.Size = new Size(300, 28);
        //
        lblCompte.AutoSize = true;
        lblCompte.Location = new Point(10, 170);
        lblCompte.Text = "Compte";
        cbxCompte.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxCompte.Location = new Point(180, 167);
        cbxCompte.Size = new Size(300, 28);
        //
        lblMontant.AutoSize = true;
        lblMontant.Location = new Point(10, 205);
        lblMontant.Text = "Montant encaissé";
        txtMontantEncaisse.Location = new Point(180, 202);
        txtMontantEncaisse.Size = new Size(300, 27);
        //
        btnEnregistrerEncaissement.BackColor = Color.FromArgb(40, 92, 41);
        btnEnregistrerEncaissement.FlatStyle = FlatStyle.Flat;
        btnEnregistrerEncaissement.FlatAppearance.BorderSize = 0;
        btnEnregistrerEncaissement.ForeColor = Color.WhiteSmoke;
        btnEnregistrerEncaissement.Location = new Point(180, 237);
        btnEnregistrerEncaissement.Size = new Size(300, 35);
        btnEnregistrerEncaissement.Text = "Enregistrer l'encaissement";
        btnEnregistrerEncaissement.UseVisualStyleBackColor = false;
        btnEnregistrerEncaissement.Click += BtnEnregistrerEncaissement_Click;
        //
        // UC_NouvelEncaissement
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(grpEncaissement);
        Name = "UC_NouvelEncaissement";
        Size = new Size(983, 635);
        Load += UC_NouvelEncaissement_Load;
        grpEncaissement.ResumeLayout(false);
        grpEncaissement.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private GroupBox grpEncaissement;
    private Label lblClient;
    private ComboBox cbxNomClient;
    private Label lblCreancesClient;
    private TextBox txtCreancesClient;
    private Label lblDate;
    private DateTimePicker dtpDateEncaissement;
    private Label lblTresoriere;
    private ComboBox cbxTres;
    private Label lblCompte;
    private ComboBox cbxCompte;
    private Label lblMontant;
    private TextBox txtMontantEncaisse;
    private Button btnEnregistrerEncaissement;
}
