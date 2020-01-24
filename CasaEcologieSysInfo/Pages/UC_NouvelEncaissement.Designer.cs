namespace CasaEcologieSysInfo
{
    partial class UC_NouvelEncaissement
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
            this.dtpDateEncaissement = new System.Windows.Forms.DateTimePicker();
            this.cbxCompte = new System.Windows.Forms.ComboBox();
            this.resComptesTresorerieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxTres = new System.Windows.Forms.ComboBox();
            this.ageEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ageClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMontantEncaisse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnregistrerEncaissement = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreancesClient = new System.Windows.Forms.TextBox();
            this.cbxNomClient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateEncaissement
            // 
            this.dtpDateEncaissement.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateEncaissement.Location = new System.Drawing.Point(243, 279);
            this.dtpDateEncaissement.Name = "dtpDateEncaissement";
            this.dtpDateEncaissement.Size = new System.Drawing.Size(264, 23);
            this.dtpDateEncaissement.TabIndex = 20;
            this.dtpDateEncaissement.ValueChanged += new System.EventHandler(this.DtpDateEncaissement_ValueChanged);
            // 
            // cbxCompte
            // 
            this.cbxCompte.DataSource = this.resComptesTresorerieBindingSource;
            this.cbxCompte.DisplayMember = "NomCompte";
            this.cbxCompte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompte.FormattingEnabled = true;
            this.cbxCompte.Location = new System.Drawing.Point(290, 201);
            this.cbxCompte.Name = "cbxCompte";
            this.cbxCompte.Size = new System.Drawing.Size(218, 29);
            this.cbxCompte.TabIndex = 22;
            this.cbxCompte.ValueMember = "CodeEmploye";
            // 
            // resComptesTresorerieBindingSource
            // 
            this.resComptesTresorerieBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResComptesTresorerie);
            // 
            // cbxTres
            // 
            this.cbxTres.DataSource = this.ageEmployeBindingSource;
            this.cbxTres.DisplayMember = "PrenomNom";
            this.cbxTres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTres.FormattingEnabled = true;
            this.cbxTres.Location = new System.Drawing.Point(245, 239);
            this.cbxTres.Name = "cbxTres";
            this.cbxTres.Size = new System.Drawing.Size(264, 29);
            this.cbxTres.TabIndex = 23;
            this.cbxTres.ValueMember = "CodeEmploye";
            // 
            // ageEmployeBindingSource
            // 
            this.ageEmployeBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // ageClientBindingSource
            // 
            this.ageClientBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeClient);
            // 
            // txtMontantEncaisse
            // 
            this.txtMontantEncaisse.Location = new System.Drawing.Point(290, 166);
            this.txtMontantEncaisse.Name = "txtMontantEncaisse";
            this.txtMontantEncaisse.Size = new System.Drawing.Size(218, 27);
            this.txtMontantEncaisse.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date";
            // 
            // btnEnregistrerEncaissement
            // 
            this.btnEnregistrerEncaissement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnEnregistrerEncaissement.FlatAppearance.BorderSize = 0;
            this.btnEnregistrerEncaissement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrerEncaissement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerEncaissement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnregistrerEncaissement.Location = new System.Drawing.Point(243, 312);
            this.btnEnregistrerEncaissement.Name = "btnEnregistrerEncaissement";
            this.btnEnregistrerEncaissement.Size = new System.Drawing.Size(264, 31);
            this.btnEnregistrerEncaissement.TabIndex = 17;
            this.btnEnregistrerEncaissement.Text = "Enregistrer le paiement";
            this.btnEnregistrerEncaissement.UseVisualStyleBackColor = false;
            this.btnEnregistrerEncaissement.Click += new System.EventHandler(this.BtnEnregistrerEncaissement_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "Encaissement fait par:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Compte de trésorie utilisé:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nom du client:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Montant versé par le client:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Localité du client:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ageClientBindingSource;
            this.comboBox1.DisplayMember = "Localite";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(325, 29);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "CodeClient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Enregistrer un nouvel encaissement";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(596, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Montant total des créance du client:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1058, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "FCFA";
            // 
            // txtCreancesClient
            // 
            this.txtCreancesClient.Location = new System.Drawing.Point(600, 117);
            this.txtCreancesClient.Name = "txtCreancesClient";
            this.txtCreancesClient.ReadOnly = true;
            this.txtCreancesClient.Size = new System.Drawing.Size(283, 27);
            this.txtCreancesClient.TabIndex = 25;
            // 
            // cbxNomClient
            // 
            this.cbxNomClient.DataSource = this.ageClientBindingSource;
            this.cbxNomClient.DisplayMember = "NomClient";
            this.cbxNomClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNomClient.FormattingEnabled = true;
            this.cbxNomClient.Location = new System.Drawing.Point(183, 92);
            this.cbxNomClient.Name = "cbxNomClient";
            this.cbxNomClient.Size = new System.Drawing.Size(326, 29);
            this.cbxNomClient.TabIndex = 21;
            this.cbxNomClient.ValueMember = "CodeClient";
            this.cbxNomClient.SelectedValueChanged += new System.EventHandler(this.CbxNomClient_SelectedValueChanged);
            // 
            // UC_NouvelEncaissement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCreancesClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDateEncaissement);
            this.Controls.Add(this.cbxCompte);
            this.Controls.Add(this.cbxTres);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbxNomClient);
            this.Controls.Add(this.txtMontantEncaisse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnregistrerEncaissement);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_NouvelEncaissement";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_NouvelEncaissement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageClientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateEncaissement;
        private System.Windows.Forms.ComboBox cbxCompte;
        private System.Windows.Forms.ComboBox cbxTres;
        private System.Windows.Forms.TextBox txtMontantEncaisse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnregistrerEncaissement;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource ageClientBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource resComptesTresorerieBindingSource;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCreancesClient;
        private System.Windows.Forms.ComboBox cbxNomClient;
    }
}
