namespace CasaEcologieSysInfo
{
    partial class UC_NouveauDecaissement
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
            this.txtDetteFournisseur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateDecaissement = new System.Windows.Forms.DateTimePicker();
            this.cbxCompte = new System.Windows.Forms.ComboBox();
            this.resComptesTresorerieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxTresoriere = new System.Windows.Forms.ComboBox();
            this.ageEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxLocaliteFournisseur = new System.Windows.Forms.ComboBox();
            this.cbxNomFournisseur = new System.Windows.Forms.ComboBox();
            this.txtMontantPaye = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnregistrerDecaissement = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxTypeFournisseur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDetteFournisseur
            // 
            this.txtDetteFournisseur.Enabled = false;
            this.txtDetteFournisseur.Location = new System.Drawing.Point(644, 95);
            this.txtDetteFournisseur.Name = "txtDetteFournisseur";
            this.txtDetteFournisseur.Size = new System.Drawing.Size(283, 27);
            this.txtDetteFournisseur.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Enregistrer un nouveau décaissement";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpDateDecaissement
            // 
            this.dtpDateDecaissement.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateDecaissement.Location = new System.Drawing.Point(287, 294);
            this.dtpDateDecaissement.Name = "dtpDateDecaissement";
            this.dtpDateDecaissement.Size = new System.Drawing.Size(264, 23);
            this.dtpDateDecaissement.TabIndex = 35;
            // 
            // cbxCompte
            // 
            this.cbxCompte.DataSource = this.resComptesTresorerieBindingSource;
            this.cbxCompte.DisplayMember = "NomCompte";
            this.cbxCompte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompte.FormattingEnabled = true;
            this.cbxCompte.Location = new System.Drawing.Point(334, 216);
            this.cbxCompte.Name = "cbxCompte";
            this.cbxCompte.Size = new System.Drawing.Size(218, 29);
            this.cbxCompte.TabIndex = 38;
            this.cbxCompte.ValueMember = "CodeEmploye";
            // 
            // resComptesTresorerieBindingSource
            // 
            this.resComptesTresorerieBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResComptesTresorerie);
            // 
            // cbxTresoriere
            // 
            this.cbxTresoriere.DataSource = this.ageEmployeBindingSource;
            this.cbxTresoriere.DisplayMember = "PrenomNom";
            this.cbxTresoriere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTresoriere.FormattingEnabled = true;
            this.cbxTresoriere.Location = new System.Drawing.Point(289, 254);
            this.cbxTresoriere.Name = "cbxTresoriere";
            this.cbxTresoriere.Size = new System.Drawing.Size(264, 29);
            this.cbxTresoriere.TabIndex = 39;
            this.cbxTresoriere.ValueMember = "CodeEmploye";
            // 
            // ageEmployeBindingSource
            // 
            this.ageEmployeBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // cbxLocaliteFournisseur
            // 
            this.cbxLocaliteFournisseur.DisplayMember = "Localite";
            this.cbxLocaliteFournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocaliteFournisseur.FormattingEnabled = true;
            this.cbxLocaliteFournisseur.Location = new System.Drawing.Point(244, 146);
            this.cbxLocaliteFournisseur.Name = "cbxLocaliteFournisseur";
            this.cbxLocaliteFournisseur.Size = new System.Drawing.Size(308, 29);
            this.cbxLocaliteFournisseur.TabIndex = 36;
            this.cbxLocaliteFournisseur.ValueMember = "CodeClient";
            // 
            // cbxNomFournisseur
            // 
            this.cbxNomFournisseur.DisplayMember = "NomClient";
            this.cbxNomFournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNomFournisseur.FormattingEnabled = true;
            this.cbxNomFournisseur.Location = new System.Drawing.Point(244, 107);
            this.cbxNomFournisseur.Name = "cbxNomFournisseur";
            this.cbxNomFournisseur.Size = new System.Drawing.Size(309, 29);
            this.cbxNomFournisseur.TabIndex = 37;
            this.cbxNomFournisseur.ValueMember = "CodeClient";
            // 
            // txtMontantPaye
            // 
            this.txtMontantPaye.Location = new System.Drawing.Point(334, 181);
            this.txtMontantPaye.Name = "txtMontantPaye";
            this.txtMontantPaye.Size = new System.Drawing.Size(218, 27);
            this.txtMontantPaye.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Date";
            // 
            // btnEnregistrerDecaissement
            // 
            this.btnEnregistrerDecaissement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnEnregistrerDecaissement.FlatAppearance.BorderSize = 0;
            this.btnEnregistrerDecaissement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrerDecaissement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerDecaissement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnregistrerDecaissement.Location = new System.Drawing.Point(287, 327);
            this.btnEnregistrerDecaissement.Name = "btnEnregistrerDecaissement";
            this.btnEnregistrerDecaissement.Size = new System.Drawing.Size(264, 31);
            this.btnEnregistrerDecaissement.TabIndex = 33;
            this.btnEnregistrerDecaissement.Text = "Enregistrer le paiement";
            this.btnEnregistrerDecaissement.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(79, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = "Décaissement fait par:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Localité:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 21);
            this.label9.TabIndex = 28;
            this.label9.Text = "Compte de trésorie utilisé:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(640, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Montant total dû au fournisseur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Nom du fournisseur:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Montant payé au fournisseur:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Type de fournisseur:";
            // 
            // cbxTypeFournisseur
            // 
            this.cbxTypeFournisseur.DisplayMember = "NomClient";
            this.cbxTypeFournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeFournisseur.FormattingEnabled = true;
            this.cbxTypeFournisseur.Items.AddRange(new object[] {
            "Fournisseur de matière première",
            "Fournisseur d\'équipement ou entrepreneur",
            "Fournisseur de services ou fournitures"});
            this.cbxTypeFournisseur.Location = new System.Drawing.Point(244, 66);
            this.cbxTypeFournisseur.Name = "cbxTypeFournisseur";
            this.cbxTypeFournisseur.Size = new System.Drawing.Size(309, 29);
            this.cbxTypeFournisseur.TabIndex = 1;
            this.cbxTypeFournisseur.Tag = "Test";
            // 
            // UC_NouveauDecaissement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDetteFournisseur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDateDecaissement);
            this.Controls.Add(this.cbxCompte);
            this.Controls.Add(this.cbxTresoriere);
            this.Controls.Add(this.cbxLocaliteFournisseur);
            this.Controls.Add(this.cbxTypeFournisseur);
            this.Controls.Add(this.cbxNomFournisseur);
            this.Controls.Add(this.txtMontantPaye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnregistrerDecaissement);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_NouveauDecaissement";
            this.Size = new System.Drawing.Size(983, 635);
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetteFournisseur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateDecaissement;
        private System.Windows.Forms.ComboBox cbxCompte;
        private System.Windows.Forms.BindingSource resComptesTresorerieBindingSource;
        private System.Windows.Forms.ComboBox cbxTresoriere;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource;
        private System.Windows.Forms.ComboBox cbxLocaliteFournisseur;
        private System.Windows.Forms.ComboBox cbxNomFournisseur;
        private System.Windows.Forms.TextBox txtMontantPaye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnregistrerDecaissement;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxTypeFournisseur;
    }
}
