namespace CasaEcologie.WinForms.Pages;

partial class UC_SortieDechetsMatierePremiere
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
        grpSortie = new GroupBox();
        lblDate = new Label();
        dtpDateSortieDechets = new DateTimePicker();
        lblMatierePremiere = new Label();
        cbxMatierePremiere = new ComboBox();
        lblQuantite = new Label();
        txtQuantite = new TextBox();
        lblDescription = new Label();
        txtDescription = new TextBox();
        lblResponsableStock = new Label();
        cbxResponsableStock = new ComboBox();
        lblEmployeRecevant = new Label();
        cbxEmployeAyantRecuLesDechets = new ComboBox();
        btnEnregistrerSortie = new Button();
        grpSortie.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(280, 10);
        lblTitre.Text = "Sortie de déchets de matière première";
        //
        // grpSortie
        //
        grpSortie.Controls.Add(lblDate);
        grpSortie.Controls.Add(dtpDateSortieDechets);
        grpSortie.Controls.Add(lblMatierePremiere);
        grpSortie.Controls.Add(cbxMatierePremiere);
        grpSortie.Controls.Add(lblQuantite);
        grpSortie.Controls.Add(txtQuantite);
        grpSortie.Controls.Add(lblDescription);
        grpSortie.Controls.Add(txtDescription);
        grpSortie.Controls.Add(lblResponsableStock);
        grpSortie.Controls.Add(cbxResponsableStock);
        grpSortie.Controls.Add(lblEmployeRecevant);
        grpSortie.Controls.Add(cbxEmployeAyantRecuLesDechets);
        grpSortie.Controls.Add(btnEnregistrerSortie);
        grpSortie.Location = new Point(10, 50);
        grpSortie.Size = new Size(950, 290);
        grpSortie.Text = "Sortie déchets";
        //
        lblDate.AutoSize = true;
        lblDate.Location = new Point(10, 30);
        lblDate.Text = "Date";
        dtpDateSortieDechets.Location = new Point(200, 27);
        dtpDateSortieDechets.Size = new Size(300, 27);
        dtpDateSortieDechets.ValueChanged += DtpDateSortieDechets_ValueChanged;
        //
        lblMatierePremiere.AutoSize = true;
        lblMatierePremiere.Location = new Point(10, 65);
        lblMatierePremiere.Text = "Matière première";
        cbxMatierePremiere.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxMatierePremiere.Location = new Point(200, 62);
        cbxMatierePremiere.Size = new Size(300, 28);
        //
        lblQuantite.AutoSize = true;
        lblQuantite.Location = new Point(10, 100);
        lblQuantite.Text = "Quantité";
        txtQuantite.Location = new Point(200, 97);
        txtQuantite.Size = new Size(300, 27);
        //
        lblDescription.AutoSize = true;
        lblDescription.Location = new Point(10, 135);
        lblDescription.Text = "Description";
        txtDescription.Location = new Point(200, 132);
        txtDescription.Size = new Size(300, 27);
        //
        lblResponsableStock.AutoSize = true;
        lblResponsableStock.Location = new Point(10, 170);
        lblResponsableStock.Text = "Responsable stock";
        cbxResponsableStock.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxResponsableStock.Location = new Point(200, 167);
        cbxResponsableStock.Size = new Size(300, 28);
        //
        lblEmployeRecevant.AutoSize = true;
        lblEmployeRecevant.Location = new Point(10, 205);
        lblEmployeRecevant.Text = "Employé ayant reçu";
        cbxEmployeAyantRecuLesDechets.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxEmployeAyantRecuLesDechets.Location = new Point(200, 202);
        cbxEmployeAyantRecuLesDechets.Size = new Size(300, 28);
        //
        btnEnregistrerSortie.BackColor = Color.FromArgb(40, 92, 41);
        btnEnregistrerSortie.FlatStyle = FlatStyle.Flat;
        btnEnregistrerSortie.FlatAppearance.BorderSize = 0;
        btnEnregistrerSortie.ForeColor = Color.WhiteSmoke;
        btnEnregistrerSortie.Location = new Point(200, 242);
        btnEnregistrerSortie.Size = new Size(300, 35);
        btnEnregistrerSortie.Text = "Enregistrer la sortie";
        btnEnregistrerSortie.UseVisualStyleBackColor = false;
        btnEnregistrerSortie.Click += BtnEnregistrerSortie_Click;
        //
        // UC_SortieDechetsMatierePremiere
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblTitre);
        Controls.Add(grpSortie);
        Name = "UC_SortieDechetsMatierePremiere";
        Size = new Size(983, 635);
        Load += UC_SortieDechetsMatierePremiere_Load;
        grpSortie.ResumeLayout(false);
        grpSortie.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private GroupBox grpSortie;
    private Label lblDate;
    private DateTimePicker dtpDateSortieDechets;
    private Label lblMatierePremiere;
    private ComboBox cbxMatierePremiere;
    private Label lblQuantite;
    private TextBox txtQuantite;
    private Label lblDescription;
    private TextBox txtDescription;
    private Label lblResponsableStock;
    private ComboBox cbxResponsableStock;
    private Label lblEmployeRecevant;
    private ComboBox cbxEmployeAyantRecuLesDechets;
    private Button btnEnregistrerSortie;
}
