namespace CasaEcologieSysInfo.Pages
{
    partial class UC_MouvementCompteACompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MouvementCompteACompte));
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnregistrerTransfert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateOperation = new System.Windows.Forms.DateTimePicker();
            this.cbxCompteDebit = new System.Windows.Forms.ComboBox();
            this.resComptesTresorerieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCompteDebiteur = new System.Windows.Forms.Label();
            this.tlpTransfert = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.cbxCompteCredit = new System.Windows.Forms.ComboBox();
            this.resComptesTresorerieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxEmploye = new System.Windows.Forms.ComboBox();
            this.ageEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoldeCompte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Transfert de compte à compte";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEnregistrerTransfert
            // 
            this.btnEnregistrerTransfert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnEnregistrerTransfert.FlatAppearance.BorderSize = 0;
            this.btnEnregistrerTransfert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrerTransfert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerTransfert.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnregistrerTransfert.Location = new System.Drawing.Point(521, 409);
            this.btnEnregistrerTransfert.Name = "btnEnregistrerTransfert";
            this.btnEnregistrerTransfert.Size = new System.Drawing.Size(277, 32);
            this.btnEnregistrerTransfert.TabIndex = 27;
            this.btnEnregistrerTransfert.Text = "Enregistrer";
            this.btnEnregistrerTransfert.UseVisualStyleBackColor = false;
            this.btnEnregistrerTransfert.Click += new System.EventHandler(this.BtnEnregistrerTransfert_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 56);
            this.label1.TabIndex = 28;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // dtpDateOperation
            // 
            this.dtpDateOperation.Location = new System.Drawing.Point(521, 147);
            this.dtpDateOperation.Name = "dtpDateOperation";
            this.dtpDateOperation.Size = new System.Drawing.Size(277, 27);
            this.dtpDateOperation.TabIndex = 29;
            this.dtpDateOperation.ValueChanged += new System.EventHandler(this.DtpDateOperation_ValueChanged);
            // 
            // cbxCompteDebit
            // 
            this.cbxCompteDebit.DataSource = this.resComptesTresorerieBindingSource1;
            this.cbxCompteDebit.DisplayMember = "NomCompte";
            this.cbxCompteDebit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompteDebit.FormattingEnabled = true;
            this.cbxCompteDebit.Location = new System.Drawing.Point(521, 226);
            this.cbxCompteDebit.Name = "cbxCompteDebit";
            this.cbxCompteDebit.Size = new System.Drawing.Size(277, 29);
            this.cbxCompteDebit.TabIndex = 30;
            this.cbxCompteDebit.SelectedIndexChanged += new System.EventHandler(this.CbxCompteDebit_SelectedIndexChanged);
            // 
            // resComptesTresorerieBindingSource1
            // 
            this.resComptesTresorerieBindingSource1.DataSource = typeof(CasaEcologieSysInfo.ResComptesTresorerie);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(521, 192);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(277, 27);
            this.txtDescription.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Date";
            // 
            // lblCompteDebiteur
            // 
            this.lblCompteDebiteur.AutoSize = true;
            this.lblCompteDebiteur.Location = new System.Drawing.Point(226, 229);
            this.lblCompteDebiteur.Name = "lblCompteDebiteur";
            this.lblCompteDebiteur.Size = new System.Drawing.Size(289, 21);
            this.lblCompteDebiteur.TabIndex = 31;
            this.lblCompteDebiteur.Text = "Compte d\'où proviendront les fonds";
            // 
            // tlpTransfert
            // 
            this.tlpTransfert.IsBalloon = true;
            this.tlpTransfert.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tlpTransfert.ToolTipTitle = "A retenir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Compte qui encaissera les fonds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Montant";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(521, 295);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(277, 27);
            this.txtMontant.TabIndex = 32;
            // 
            // cbxCompteCredit
            // 
            this.cbxCompteCredit.DataSource = this.resComptesTresorerieBindingSource;
            this.cbxCompteCredit.DisplayMember = "NomCompte";
            this.cbxCompteCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompteCredit.FormattingEnabled = true;
            this.cbxCompteCredit.Location = new System.Drawing.Point(521, 331);
            this.cbxCompteCredit.Name = "cbxCompteCredit";
            this.cbxCompteCredit.Size = new System.Drawing.Size(277, 29);
            this.cbxCompteCredit.TabIndex = 30;
            // 
            // resComptesTresorerieBindingSource
            // 
            this.resComptesTresorerieBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResComptesTresorerie);
            // 
            // cbxEmploye
            // 
            this.cbxEmploye.DataSource = this.ageEmployeBindingSource;
            this.cbxEmploye.DisplayMember = "PrenomNom";
            this.cbxEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmploye.FormattingEnabled = true;
            this.cbxEmploye.Location = new System.Drawing.Point(521, 370);
            this.cbxEmploye.Name = "cbxEmploye";
            this.cbxEmploye.Size = new System.Drawing.Size(277, 29);
            this.cbxEmploye.TabIndex = 30;
            // 
            // ageEmployeBindingSource
            // 
            this.ageEmployeBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Employé en charge du transfert";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "Solde du compte";
            // 
            // txtSoldeCompte
            // 
            this.txtSoldeCompte.Location = new System.Drawing.Point(521, 262);
            this.txtSoldeCompte.Name = "txtSoldeCompte";
            this.txtSoldeCompte.ReadOnly = true;
            this.txtSoldeCompte.Size = new System.Drawing.Size(277, 27);
            this.txtSoldeCompte.TabIndex = 32;
            // 
            // UC_MouvementCompteACompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSoldeCompte);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCompteDebiteur);
            this.Controls.Add(this.cbxEmploye);
            this.Controls.Add(this.cbxCompteCredit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCompteDebit);
            this.Controls.Add(this.dtpDateOperation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnregistrerTransfert);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_MouvementCompteACompte";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_MouvementCompteACompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnregistrerTransfert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateOperation;
        private System.Windows.Forms.ComboBox cbxCompteDebit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCompteDebiteur;
        private System.Windows.Forms.ToolTip tlpTransfert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.ComboBox cbxCompteCredit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource resComptesTresorerieBindingSource;
        private System.Windows.Forms.BindingSource resComptesTresorerieBindingSource1;
        private System.Windows.Forms.ComboBox cbxEmploye;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoldeCompte;
    }
}
