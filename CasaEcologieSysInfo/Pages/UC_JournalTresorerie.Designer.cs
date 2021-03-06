﻿namespace CasaEcologieSysInfo.Pages
{
    partial class UC_JournalTresorerie
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
            this.resComptesTresorerieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalEncaissements = new System.Windows.Forms.Label();
            this.lblTotalMatPrem = new System.Windows.Forms.Label();
            this.txtTotalEncaissements = new System.Windows.Forms.TextBox();
            this.txtTotalDecaissements = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoldesInitiaux = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSolde = new System.Windows.Forms.TextBox();
            this.dgvJournalTresorerieDetails = new System.Windows.Forms.DataGridView();
            this.btnImprimerJournal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalTresorerieDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(393, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Journal de Trésorerie Détaillé par Compte";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Journal de Trésorerie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Liste des Comptes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resComptesTresorerieBindingSource
            // 
            this.resComptesTresorerieBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResComptesTresorerie);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.DataSource = this.resComptesTresorerieBindingSource;
            this.listBox1.DisplayMember = "NomCompte";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(4, 156);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 138);
            this.listBox1.TabIndex = 15;
            this.listBox1.ValueMember = "CodeCompte";
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.ListBox1_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(5, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cliquez sur un compte ci-dessous";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(5, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "pour afficher le détail des";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(5, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "transactions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total des fonds disponibles";
            // 
            // lblTotalEncaissements
            // 
            this.lblTotalEncaissements.AutoSize = true;
            this.lblTotalEncaissements.Location = new System.Drawing.Point(3, 389);
            this.lblTotalEncaissements.Name = "lblTotalEncaissements";
            this.lblTotalEncaissements.Size = new System.Drawing.Size(135, 17);
            this.lblTotalEncaissements.TabIndex = 18;
            this.lblTotalEncaissements.Text = "Total Encaissements";
            // 
            // lblTotalMatPrem
            // 
            this.lblTotalMatPrem.AutoSize = true;
            this.lblTotalMatPrem.Location = new System.Drawing.Point(3, 431);
            this.lblTotalMatPrem.Name = "lblTotalMatPrem";
            this.lblTotalMatPrem.Size = new System.Drawing.Size(137, 17);
            this.lblTotalMatPrem.TabIndex = 18;
            this.lblTotalMatPrem.Text = "Total decaissements";
            // 
            // txtTotalEncaissements
            // 
            this.txtTotalEncaissements.Enabled = false;
            this.txtTotalEncaissements.Location = new System.Drawing.Point(6, 408);
            this.txtTotalEncaissements.Name = "txtTotalEncaissements";
            this.txtTotalEncaissements.Size = new System.Drawing.Size(169, 23);
            this.txtTotalEncaissements.TabIndex = 19;
            // 
            // txtTotalDecaissements
            // 
            this.txtTotalDecaissements.Enabled = false;
            this.txtTotalDecaissements.Location = new System.Drawing.Point(6, 451);
            this.txtTotalDecaissements.Name = "txtTotalDecaissements";
            this.txtTotalDecaissements.Size = new System.Drawing.Size(169, 23);
            this.txtTotalDecaissements.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Soldes Initiaux";
            // 
            // txtSoldesInitiaux
            // 
            this.txtSoldesInitiaux.Enabled = false;
            this.txtSoldesInitiaux.Location = new System.Drawing.Point(6, 364);
            this.txtSoldesInitiaux.Name = "txtSoldesInitiaux";
            this.txtSoldesInitiaux.Size = new System.Drawing.Size(169, 23);
            this.txtSoldesInitiaux.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Solde disponible";
            // 
            // txtSolde
            // 
            this.txtSolde.Enabled = false;
            this.txtSolde.Location = new System.Drawing.Point(8, 506);
            this.txtSolde.Name = "txtSolde";
            this.txtSolde.Size = new System.Drawing.Size(169, 23);
            this.txtSolde.TabIndex = 19;
            // 
            // dgvJournalTresorerieDetails
            // 
            this.dgvJournalTresorerieDetails.AllowUserToAddRows = false;
            this.dgvJournalTresorerieDetails.AllowUserToDeleteRows = false;
            this.dgvJournalTresorerieDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJournalTresorerieDetails.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvJournalTresorerieDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJournalTresorerieDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournalTresorerieDetails.Location = new System.Drawing.Point(207, 133);
            this.dgvJournalTresorerieDetails.Name = "dgvJournalTresorerieDetails";
            this.dgvJournalTresorerieDetails.ReadOnly = true;
            this.dgvJournalTresorerieDetails.Size = new System.Drawing.Size(759, 457);
            this.dgvJournalTresorerieDetails.TabIndex = 20;
            // 
            // btnImprimerJournal
            // 
            this.btnImprimerJournal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnImprimerJournal.FlatAppearance.BorderSize = 0;
            this.btnImprimerJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerJournal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerJournal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimerJournal.Location = new System.Drawing.Point(743, 11);
            this.btnImprimerJournal.Name = "btnImprimerJournal";
            this.btnImprimerJournal.Size = new System.Drawing.Size(223, 30);
            this.btnImprimerJournal.TabIndex = 57;
            this.btnImprimerJournal.Text = "Imprimer le journal";
            this.btnImprimerJournal.UseVisualStyleBackColor = false;
            this.btnImprimerJournal.Click += new System.EventHandler(this.BtnImprimerJournal_Click);
            // 
            // UC_JournalTresorerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnImprimerJournal);
            this.Controls.Add(this.dgvJournalTresorerieDetails);
            this.Controls.Add(this.txtSolde);
            this.Controls.Add(this.txtTotalDecaissements);
            this.Controls.Add(this.txtSoldesInitiaux);
            this.Controls.Add(this.txtTotalEncaissements);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalMatPrem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalEncaissements);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_JournalTresorerie";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_JournalTresorerie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalTresorerieDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource resComptesTresorerieBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalEncaissements;
        private System.Windows.Forms.Label lblTotalMatPrem;
        private System.Windows.Forms.TextBox txtTotalEncaissements;
        private System.Windows.Forms.TextBox txtTotalDecaissements;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoldesInitiaux;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSolde;
        private System.Windows.Forms.DataGridView dgvJournalTresorerieDetails;
        private System.Windows.Forms.Button btnImprimerJournal;
    }
}
