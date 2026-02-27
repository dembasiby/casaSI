namespace CasaEcologie.WinForms.Pages;

partial class UC_MouvementCompteACompte
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
        grpTransfert = new GroupBox();
        lblDate = new Label();
        dtpDateOperation = new DateTimePicker();
        lblCompteDebit = new Label();
        cbxCompteDebit = new ComboBox();
        lblSoldeCompte = new Label();
        txtSoldeCompte = new TextBox();
        lblCompteCredit = new Label();
        cbxCompteCredit = new ComboBox();
        lblEmploye = new Label();
        cbxEmploye = new ComboBox();
        lblDescription = new Label();
        txtDescription = new TextBox();
        lblMontant = new Label();
        txtMontant = new TextBox();
        btnEnregistrerTransfert = new Button();
        grpTransfert.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(280, 10);
        lblTitre.Text = "Mouvement de compte à compte";
        //
        // grpTransfert
        //
        grpTransfert.Controls.Add(lblDate);
        grpTransfert.Controls.Add(dtpDateOperation);
        grpTransfert.Controls.Add(lblCompteDebit);
        grpTransfert.Controls.Add(cbxCompteDebit);
        grpTransfert.Controls.Add(lblSoldeCompte);
        grpTransfert.Controls.Add(txtSoldeCompte);
        grpTransfert.Controls.Add(lblCompteCredit);
        grpTransfert.Controls.Add(cbxCompteCredit);
        grpTransfert.Controls.Add(lblEmploye);
        grpTransfert.Controls.Add(cbxEmploye);
        grpTransfert.Controls.Add(lblDescription);
        grpTransfert.Controls.Add(txtDescription);
        grpTransfert.Controls.Add(lblMontant);
        grpTransfert.Controls.Add(txtMontant);
        grpTransfert.Controls.Add(btnEnregistrerTransfert);
        grpTransfert.Location = new Point(10, 50);
        grpTransfert.Size = new Size(950, 320);
        grpTransfert.Text = "Transfert";
        //
        lblDate.AutoSize = true;
        lblDate.Location = new Point(10, 30);
        lblDate.Text = "Date";
        dtpDateOperation.Location = new Point(200, 27);
        dtpDateOperation.Size = new Size(300, 27);
        dtpDateOperation.ValueChanged += DtpDateOperation_ValueChanged;
        //
        lblCompteDebit.AutoSize = true;
        lblCompteDebit.Location = new Point(10, 65);
        lblCompteDebit.Text = "Compte débiteur";
        cbxCompteDebit.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxCompteDebit.Location = new Point(200, 62);
        cbxCompteDebit.Size = new Size(300, 28);
        cbxCompteDebit.SelectedIndexChanged += CbxCompteDebit_SelectedIndexChanged;
        //
        lblSoldeCompte.AutoSize = true;
        lblSoldeCompte.Location = new Point(10, 100);
        lblSoldeCompte.Text = "Solde du compte";
        txtSoldeCompte.Location = new Point(200, 97);
        txtSoldeCompte.Size = new Size(300, 27);
        txtSoldeCompte.ReadOnly = true;
        //
        lblCompteCredit.AutoSize = true;
        lblCompteCredit.Location = new Point(10, 135);
        lblCompteCredit.Text = "Compte créditeur";
        cbxCompteCredit.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxCompteCredit.Location = new Point(200, 132);
        cbxCompteCredit.Size = new Size(300, 28);
        //
        lblEmploye.AutoSize = true;
        lblEmploye.Location = new Point(10, 170);
        lblEmploye.Text = "Employé";
        cbxEmploye.Location = new Point(200, 167);
        cbxEmploye.Size = new Size(300, 28);
        //
        lblDescription.AutoSize = true;
        lblDescription.Location = new Point(10, 205);
        lblDescription.Text = "Description";
        txtDescription.Location = new Point(200, 202);
        txtDescription.Size = new Size(300, 27);
        //
        lblMontant.AutoSize = true;
        lblMontant.Location = new Point(10, 240);
        lblMontant.Text = "Montant";
        txtMontant.Location = new Point(200, 237);
        txtMontant.Size = new Size(300, 27);
        //
        btnEnregistrerTransfert.BackColor = Color.FromArgb(40, 92, 41);
        btnEnregistrerTransfert.FlatStyle = FlatStyle.Flat;
        btnEnregistrerTransfert.FlatAppearance.BorderSize = 0;
        btnEnregistrerTransfert.ForeColor = Color.WhiteSmoke;
        btnEnregistrerTransfert.Location = new Point(200, 272);
        btnEnregistrerTransfert.Size = new Size(300, 35);
        btnEnregistrerTransfert.Text = "Enregistrer le transfert";
        btnEnregistrerTransfert.UseVisualStyleBackColor = false;
        btnEnregistrerTransfert.Click += BtnEnregistrerTransfert_Click;
        //
        // UC_MouvementCompteACompte
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(grpTransfert);
        Name = "UC_MouvementCompteACompte";
        Size = new Size(983, 635);
        Load += UC_MouvementCompteACompte_Load;
        grpTransfert.ResumeLayout(false);
        grpTransfert.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private GroupBox grpTransfert;
    private Label lblDate;
    private DateTimePicker dtpDateOperation;
    private Label lblCompteDebit;
    private ComboBox cbxCompteDebit;
    private Label lblSoldeCompte;
    private TextBox txtSoldeCompte;
    private Label lblCompteCredit;
    private ComboBox cbxCompteCredit;
    private Label lblEmploye;
    private ComboBox cbxEmploye;
    private Label lblDescription;
    private TextBox txtDescription;
    private Label lblMontant;
    private TextBox txtMontant;
    private Button btnEnregistrerTransfert;
}
