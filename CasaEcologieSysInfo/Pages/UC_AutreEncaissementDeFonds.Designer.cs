namespace CasaEcologieSysInfo.Pages
{
    partial class UC_AutreEncaissementDeFonds
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateEncaissement = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtMontantEncaisse = new System.Windows.Forms.TextBox();
            this.cbxCompteCrediteur = new System.Windows.Forms.ComboBox();
            this.cbxResponsableTransaction = new System.Windows.Forms.ComboBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.resComptesTresorerieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ageEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Autres encaissements de fonds";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Veuillez enregistrer subventions, prêts bancaires, dons et cotisations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Compte créditeur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Montant reçu";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(143, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 72);
            this.label7.TabIndex = 28;
            this.label7.Text = "Employé responsable de la transaction";
            // 
            // dtpDateEncaissement
            // 
            this.dtpDateEncaissement.Location = new System.Drawing.Point(367, 116);
            this.dtpDateEncaissement.Name = "dtpDateEncaissement";
            this.dtpDateEncaissement.Size = new System.Drawing.Size(382, 27);
            this.dtpDateEncaissement.TabIndex = 29;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(367, 157);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(382, 27);
            this.txtDescription.TabIndex = 30;
            // 
            // txtMontantEncaisse
            // 
            this.txtMontantEncaisse.Location = new System.Drawing.Point(367, 197);
            this.txtMontantEncaisse.Name = "txtMontantEncaisse";
            this.txtMontantEncaisse.Size = new System.Drawing.Size(382, 27);
            this.txtMontantEncaisse.TabIndex = 30;
            // 
            // cbxCompteCrediteur
            // 
            this.cbxCompteCrediteur.DataSource = this.resComptesTresorerieBindingSource;
            this.cbxCompteCrediteur.DisplayMember = "NomCompte";
            this.cbxCompteCrediteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompteCrediteur.FormattingEnabled = true;
            this.cbxCompteCrediteur.Location = new System.Drawing.Point(367, 238);
            this.cbxCompteCrediteur.Name = "cbxCompteCrediteur";
            this.cbxCompteCrediteur.Size = new System.Drawing.Size(382, 29);
            this.cbxCompteCrediteur.TabIndex = 31;
            // 
            // cbxResponsableTransaction
            // 
            this.cbxResponsableTransaction.DataSource = this.ageEmployeBindingSource;
            this.cbxResponsableTransaction.DisplayMember = "PrenomNom";
            this.cbxResponsableTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxResponsableTransaction.FormattingEnabled = true;
            this.cbxResponsableTransaction.Location = new System.Drawing.Point(367, 283);
            this.cbxResponsableTransaction.Name = "cbxResponsableTransaction";
            this.cbxResponsableTransaction.Size = new System.Drawing.Size(382, 29);
            this.cbxResponsableTransaction.TabIndex = 31;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(367, 354);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(224, 36);
            this.btnEnregistrer.TabIndex = 32;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(608, 354);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(141, 36);
            this.btnAnnuler.TabIndex = 32;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // resComptesTresorerieBindingSource
            // 
            this.resComptesTresorerieBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResComptesTresorerie);
            // 
            // ageEmployeBindingSource
            // 
            this.ageEmployeBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // UC_AutreEncaissementDeFonds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.cbxResponsableTransaction);
            this.Controls.Add(this.cbxCompteCrediteur);
            this.Controls.Add(this.txtMontantEncaisse);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dtpDateEncaissement);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UC_AutreEncaissementDeFonds";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_AutreEncaissementDeFonds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDateEncaissement;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtMontantEncaisse;
        private System.Windows.Forms.ComboBox cbxCompteCrediteur;
        private System.Windows.Forms.BindingSource resComptesTresorerieBindingSource;
        private System.Windows.Forms.ComboBox cbxResponsableTransaction;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
