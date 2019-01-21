namespace CasaEcologieSysInfo.Pages
{
    partial class UC_ReceptionDonMatierePremiere
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbxFournisseur = new System.Windows.Forms.ComboBox();
            this.ageFournisseursMatieresPremiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMatierePremiere = new System.Windows.Forms.ComboBox();
            this.resStockMatieresPremiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxEmploye = new System.Windows.Forms.ComboBox();
            this.ageEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDateReception = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxCompte = new System.Windows.Forms.ComboBox();
            this.resComptesTresorerieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ageFournisseursMatieresPremiereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremiereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxFournisseur
            // 
            this.cbxFournisseur.DataSource = this.ageFournisseursMatieresPremiereBindingSource;
            this.cbxFournisseur.DisplayMember = "Nom";
            this.cbxFournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFournisseur.FormattingEnabled = true;
            this.cbxFournisseur.Location = new System.Drawing.Point(384, 215);
            this.cbxFournisseur.Name = "cbxFournisseur";
            this.cbxFournisseur.Size = new System.Drawing.Size(306, 29);
            this.cbxFournisseur.TabIndex = 2;
            this.cbxFournisseur.ValueMember = "CodeFournisseurMatierePremiere";
            // 
            // ageFournisseursMatieresPremiereBindingSource
            // 
            this.ageFournisseursMatieresPremiereBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeFournisseursMatieresPremiere);
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnFiltrer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnFiltrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrer.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrer.Location = new System.Drawing.Point(384, 507);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(306, 31);
            this.btnFiltrer.TabIndex = 6;
            this.btnFiltrer.Text = "Ajouter au stock";
            this.btnFiltrer.UseVisualStyleBackColor = false;
            this.btnFiltrer.Click += new System.EventHandler(this.BtnFiltrer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fournisseur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Réception de dons d\'intrants";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 49);
            this.label1.TabIndex = 21;
            this.label1.Text = "Veuillez enregistrer les dons de matières premières, d\'emballages et de tout autr" +
    "e élément listé dans les matières premières";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Matière première";
            // 
            // cbxMatierePremiere
            // 
            this.cbxMatierePremiere.DataSource = this.resStockMatieresPremiereBindingSource;
            this.cbxMatierePremiere.DisplayMember = "NomMatiere";
            this.cbxMatierePremiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatierePremiere.FormattingEnabled = true;
            this.cbxMatierePremiere.Location = new System.Drawing.Point(384, 178);
            this.cbxMatierePremiere.Name = "cbxMatierePremiere";
            this.cbxMatierePremiere.Size = new System.Drawing.Size(306, 29);
            this.cbxMatierePremiere.TabIndex = 1;
            this.cbxMatierePremiere.ValueMember = "CodeMatierePremiere";
            // 
            // resStockMatieresPremiereBindingSource
            // 
            this.resStockMatieresPremiereBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResStockMatieresPremiere);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Quantité";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Coût du transport";
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(384, 255);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(306, 27);
            this.txtQuantite.TabIndex = 3;
            // 
            // txtTransport
            // 
            this.txtTransport.Location = new System.Drawing.Point(188, 63);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(267, 27);
            this.txtTransport.TabIndex = 4;
            this.txtTransport.Text = "0";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(213, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 49);
            this.label8.TabIndex = 21;
            this.label8.Text = "Produit réceptionné par";
            // 
            // cbxEmploye
            // 
            this.cbxEmploye.DataSource = this.ageEmployeBindingSource;
            this.cbxEmploye.DisplayMember = "PrenomNom";
            this.cbxEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmploye.FormattingEnabled = true;
            this.cbxEmploye.Location = new System.Drawing.Point(384, 294);
            this.cbxEmploye.Name = "cbxEmploye";
            this.cbxEmploye.Size = new System.Drawing.Size(306, 29);
            this.cbxEmploye.TabIndex = 5;
            this.cbxEmploye.ValueMember = "CodeEmploye";
            // 
            // ageEmployeBindingSource
            // 
            this.ageEmployeBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // dtpDateReception
            // 
            this.dtpDateReception.Location = new System.Drawing.Point(384, 143);
            this.dtpDateReception.Name = "dtpDateReception";
            this.dtpDateReception.Size = new System.Drawing.Size(306, 27);
            this.dtpDateReception.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTransport);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbxCompte);
            this.groupBox1.Location = new System.Drawing.Point(244, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 147);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paiement transport";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(461, 40);
            this.label9.TabIndex = 21;
            this.label9.Text = "Remplissez cette section si la réception du don exige la prise en charge du trans" +
    "port";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Compte de paiement";
            // 
            // cbxCompte
            // 
            this.cbxCompte.DataSource = this.resComptesTresorerieBindingSource;
            this.cbxCompte.DisplayMember = "NomCompte";
            this.cbxCompte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompte.FormattingEnabled = true;
            this.cbxCompte.Location = new System.Drawing.Point(189, 100);
            this.cbxCompte.Name = "cbxCompte";
            this.cbxCompte.Size = new System.Drawing.Size(266, 29);
            this.cbxCompte.TabIndex = 2;
            this.cbxCompte.ValueMember = "CodeCompte";
            // 
            // resComptesTresorerieBindingSource
            // 
            this.resComptesTresorerieBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResComptesTresorerie);
            // 
            // UC_ReceptionDonMatierePremiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDateReception);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.cbxMatierePremiere);
            this.Controls.Add(this.cbxEmploye);
            this.Controls.Add(this.cbxFournisseur);
            this.Controls.Add(this.btnFiltrer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_ReceptionDonMatierePremiere";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_ReceptionDonMatierePremiere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageFournisseursMatieresPremiereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremiereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFournisseur;
        private System.Windows.Forms.Button btnFiltrer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource ageFournisseursMatieresPremiereBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMatierePremiere;
        private System.Windows.Forms.BindingSource resStockMatieresPremiereBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxEmploye;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource;
        private System.Windows.Forms.DateTimePicker dtpDateReception;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxCompte;
        private System.Windows.Forms.BindingSource resComptesTresorerieBindingSource;
    }
}
