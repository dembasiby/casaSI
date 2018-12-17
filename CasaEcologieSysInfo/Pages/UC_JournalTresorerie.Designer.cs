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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoldeInitial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.adgvJournalTresorerieDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.adgvJournalTresorerieDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvJournalTresorerieDetails.DateWithTime = false;
            this.adgvJournalTresorerieDetails.Location = new System.Drawing.Point(249, 131);
            this.adgvJournalTresorerieDetails.Name = "adgvJournalTresorerieDetails";
            this.adgvJournalTresorerieDetails.ReadOnly = true;
            this.adgvJournalTresorerieDetails.Size = new System.Drawing.Size(718, 493);
            this.adgvJournalTresorerieDetails.TabIndex = 14;
            this.adgvJournalTresorerieDetails.TimeFilter = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.label2.Location = new System.Drawing.Point(39, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.listBox1.DataSource = this.resComptesTresorerieBindingSource;
            this.listBox1.DisplayMember = "NomCompte";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(15, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 277);
            this.listBox1.TabIndex = 15;
            this.listBox1.ValueMember = "CodeCompte";
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.ListBox1_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Solde Initial à l\'ouverture du compte";
            // 
            // txtSoldeInitial
            // 
            this.txtSoldeInitial.Location = new System.Drawing.Point(758, 103);
            this.txtSoldeInitial.Name = "txtSoldeInitial";
            this.txtSoldeInitial.ReadOnly = true;
            this.txtSoldeInitial.Size = new System.Drawing.Size(206, 27);
            this.txtSoldeInitial.TabIndex = 17;
            // 
            // UC_JournalTresorerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSoldeInitial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.adgvJournalTresorerieDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoldeInitial;
    }
}
