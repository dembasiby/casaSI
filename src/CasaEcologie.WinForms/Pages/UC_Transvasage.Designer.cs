namespace CasaEcologie.WinForms.Pages;

partial class UC_Transvasage
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
        grpTransvasage = new GroupBox();
        lblDate = new Label();
        dtpDateTransvasage = new DateTimePicker();
        lblEmballageInitial = new Label();
        cbxEmballageInitial = new ComboBox();
        lblEmballageFinal = new Label();
        cbxEmballageFinal = new ComboBox();
        lblProduitInitial = new Label();
        cbxProduitInitial = new ComboBox();
        lblProduitFinal = new Label();
        cbxProduitFinal = new ComboBox();
        lblQuantite = new Label();
        txtQuantiteATransvaser = new TextBox();
        btnTransvaser = new Button();
        grpTransvasage.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(280, 10);
        lblTitre.Text = "Opération de transvasage";
        //
        // grpTransvasage
        //
        grpTransvasage.Controls.Add(lblDate);
        grpTransvasage.Controls.Add(dtpDateTransvasage);
        grpTransvasage.Controls.Add(lblEmballageInitial);
        grpTransvasage.Controls.Add(cbxEmballageInitial);
        grpTransvasage.Controls.Add(lblEmballageFinal);
        grpTransvasage.Controls.Add(cbxEmballageFinal);
        grpTransvasage.Controls.Add(lblProduitInitial);
        grpTransvasage.Controls.Add(cbxProduitInitial);
        grpTransvasage.Controls.Add(lblProduitFinal);
        grpTransvasage.Controls.Add(cbxProduitFinal);
        grpTransvasage.Controls.Add(lblQuantite);
        grpTransvasage.Controls.Add(txtQuantiteATransvaser);
        grpTransvasage.Controls.Add(btnTransvaser);
        grpTransvasage.Location = new Point(10, 50);
        grpTransvasage.Size = new Size(950, 290);
        grpTransvasage.Text = "Transvasage";
        //
        lblDate.AutoSize = true;
        lblDate.Location = new Point(10, 30);
        lblDate.Text = "Date opération";
        dtpDateTransvasage.Location = new Point(200, 27);
        dtpDateTransvasage.Size = new Size(300, 27);
        //
        lblEmballageInitial.AutoSize = true;
        lblEmballageInitial.Location = new Point(10, 65);
        lblEmballageInitial.Text = "Emballage initial";
        cbxEmballageInitial.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxEmballageInitial.Location = new Point(200, 62);
        cbxEmballageInitial.Size = new Size(300, 28);
        //
        lblEmballageFinal.AutoSize = true;
        lblEmballageFinal.Location = new Point(10, 100);
        lblEmballageFinal.Text = "Emballage final";
        cbxEmballageFinal.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxEmballageFinal.Location = new Point(200, 97);
        cbxEmballageFinal.Size = new Size(300, 28);
        //
        lblProduitInitial.AutoSize = true;
        lblProduitInitial.Location = new Point(10, 135);
        lblProduitInitial.Text = "Produit initial";
        cbxProduitInitial.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxProduitInitial.Location = new Point(200, 132);
        cbxProduitInitial.Size = new Size(300, 28);
        //
        lblProduitFinal.AutoSize = true;
        lblProduitFinal.Location = new Point(10, 170);
        lblProduitFinal.Text = "Produit final";
        cbxProduitFinal.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxProduitFinal.Location = new Point(200, 167);
        cbxProduitFinal.Size = new Size(300, 28);
        //
        lblQuantite.AutoSize = true;
        lblQuantite.Location = new Point(10, 205);
        lblQuantite.Text = "Quantité à transvaser";
        txtQuantiteATransvaser.Location = new Point(200, 202);
        txtQuantiteATransvaser.Size = new Size(300, 27);
        //
        btnTransvaser.BackColor = Color.FromArgb(40, 92, 41);
        btnTransvaser.FlatStyle = FlatStyle.Flat;
        btnTransvaser.FlatAppearance.BorderSize = 0;
        btnTransvaser.ForeColor = Color.WhiteSmoke;
        btnTransvaser.Location = new Point(200, 242);
        btnTransvaser.Size = new Size(300, 35);
        btnTransvaser.Text = "Procéder au transvasage";
        btnTransvaser.UseVisualStyleBackColor = false;
        btnTransvaser.Click += BtnTransvaser_Click;
        //
        // UC_Transvasage
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(grpTransvasage);
        Name = "UC_Transvasage";
        Size = new Size(983, 635);
        Load += UC_Transvasage_Load;
        grpTransvasage.ResumeLayout(false);
        grpTransvasage.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private GroupBox grpTransvasage;
    private Label lblDate;
    private DateTimePicker dtpDateTransvasage;
    private Label lblEmballageInitial;
    private ComboBox cbxEmballageInitial;
    private Label lblEmballageFinal;
    private ComboBox cbxEmballageFinal;
    private Label lblProduitInitial;
    private ComboBox cbxProduitInitial;
    private Label lblProduitFinal;
    private ComboBox cbxProduitFinal;
    private Label lblQuantite;
    private TextBox txtQuantiteATransvaser;
    private Button btnTransvaser;
}
