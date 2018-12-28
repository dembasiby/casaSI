namespace CasaEcologieSysInfo.Pages
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
            this.adgvJournalTresorerieDetails = new ADGV.AdvancedDataGridView();
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
            this.lbel8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalEncaissements = new System.Windows.Forms.TextBox();
            this.txtTotalMatPrem = new System.Windows.Forms.TextBox();
            this.txtTotalEquipementsInfr = new System.Windows.Forms.TextBox();
            this.lblFour = new System.Windows.Forms.Label();
            this.txtFournServ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoldesInitiaux = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSolde = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.adgvJournalTresorerieDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).BeginInit();
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
            // adgvJournalTresorerieDetails
            // 
            this.adgvJournalTresorerieDetails.AllowUserToAddRows = false;
            this.adgvJournalTresorerieDetails.AllowUserToDeleteRows = false;
            this.adgvJournalTresorerieDetails.AutoGenerateContextFilters = true;
            this.adgvJournalTresorerieDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvJournalTresorerieDetails.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.adgvJournalTresorerieDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adgvJournalTresorerieDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvJournalTresorerieDetails.DateWithTime = false;
            this.adgvJournalTresorerieDetails.Location = new System.Drawing.Point(201, 108);
            this.adgvJournalTresorerieDetails.Margin = new System.Windows.Forms.Padding(2);
            this.adgvJournalTresorerieDetails.Name = "adgvJournalTresorerieDetails";
            this.adgvJournalTresorerieDetails.ReadOnly = true;
            this.adgvJournalTresorerieDetails.Size = new System.Drawing.Size(768, 472);
            this.adgvJournalTresorerieDetails.TabIndex = 14;
            this.adgvJournalTresorerieDetails.TimeFilter = false;
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
            this.lblTotalMatPrem.Size = new System.Drawing.Size(126, 17);
            this.lblTotalMatPrem.TabIndex = 18;
            this.lblTotalMatPrem.Text = "Matieres Premieres";
            // 
            // lbel8
            // 
            this.lbel8.AutoSize = true;
            this.lbel8.Location = new System.Drawing.Point(3, 477);
            this.lbel8.Name = "lbel8";
            this.lbel8.Size = new System.Drawing.Size(114, 17);
            this.lbel8.TabIndex = 18;
            this.lbel8.Text = "Equipements Infr";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 523);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Fourn / Services";
            // 
            // txtTotalEncaissements
            // 
            this.txtTotalEncaissements.Enabled = false;
            this.txtTotalEncaissements.Location = new System.Drawing.Point(6, 408);
            this.txtTotalEncaissements.Name = "txtTotalEncaissements";
            this.txtTotalEncaissements.Size = new System.Drawing.Size(169, 23);
            this.txtTotalEncaissements.TabIndex = 19;
            // 
            // txtTotalMatPrem
            // 
            this.txtTotalMatPrem.Enabled = false;
            this.txtTotalMatPrem.Location = new System.Drawing.Point(6, 451);
            this.txtTotalMatPrem.Name = "txtTotalMatPrem";
            this.txtTotalMatPrem.Size = new System.Drawing.Size(169, 23);
            this.txtTotalMatPrem.TabIndex = 19;
            // 
            // txtTotalEquipementsInfr
            // 
            this.txtTotalEquipementsInfr.Enabled = false;
            this.txtTotalEquipementsInfr.Location = new System.Drawing.Point(6, 497);
            this.txtTotalEquipementsInfr.Name = "txtTotalEquipementsInfr";
            this.txtTotalEquipementsInfr.Size = new System.Drawing.Size(169, 23);
            this.txtTotalEquipementsInfr.TabIndex = 19;
            // 
            // lblFour
            // 
            this.lblFour.AutoSize = true;
            this.lblFour.Location = new System.Drawing.Point(3, 523);
            this.lblFour.Name = "lblFour";
            this.lblFour.Size = new System.Drawing.Size(107, 17);
            this.lblFour.TabIndex = 18;
            this.lblFour.Text = "Fourn / Services";
            // 
            // txtFournServ
            // 
            this.txtFournServ.Enabled = false;
            this.txtFournServ.Location = new System.Drawing.Point(6, 543);
            this.txtFournServ.Name = "txtFournServ";
            this.txtFournServ.Size = new System.Drawing.Size(169, 23);
            this.txtFournServ.TabIndex = 19;
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
            this.label9.Location = new System.Drawing.Point(3, 579);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Solde disponible";
            // 
            // txtSolde
            // 
            this.txtSolde.Enabled = false;
            this.txtSolde.Location = new System.Drawing.Point(6, 599);
            this.txtSolde.Name = "txtSolde";
            this.txtSolde.Size = new System.Drawing.Size(169, 23);
            this.txtSolde.TabIndex = 19;
            // 
            // UC_JournalTresorerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSolde);
            this.Controls.Add(this.txtFournServ);
            this.Controls.Add(this.txtTotalEquipementsInfr);
            this.Controls.Add(this.txtTotalMatPrem);
            this.Controls.Add(this.txtSoldesInitiaux);
            this.Controls.Add(this.txtTotalEncaissements);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblFour);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbel8);
            this.Controls.Add(this.lblTotalMatPrem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalEncaissements);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.adgvJournalTresorerieDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_JournalTresorerie";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_JournalTresorerie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvJournalTresorerieDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private ADGV.AdvancedDataGridView adgvJournalTresorerieDetails;
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
        private System.Windows.Forms.Label lbel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalEncaissements;
        private System.Windows.Forms.TextBox txtTotalMatPrem;
        private System.Windows.Forms.TextBox txtTotalEquipementsInfr;
        private System.Windows.Forms.Label lblFour;
        private System.Windows.Forms.TextBox txtFournServ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoldesInitiaux;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSolde;
    }
}
