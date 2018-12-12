namespace CasaEcologieSysInfo
{
    partial class UC_JournalVentes
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
            this.label4 = new System.Windows.Forms.Label();
            this.adgvJournalVentes = new ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.adgvJournalVentes)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Journal des Ventes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adgvJournalVentes
            // 
            this.adgvJournalVentes.AllowUserToAddRows = false;
            this.adgvJournalVentes.AllowUserToDeleteRows = false;
            this.adgvJournalVentes.AutoGenerateContextFilters = true;
            this.adgvJournalVentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvJournalVentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvJournalVentes.DateWithTime = false;
            this.adgvJournalVentes.Location = new System.Drawing.Point(13, 58);
            this.adgvJournalVentes.Name = "adgvJournalVentes";
            this.adgvJournalVentes.ReadOnly = true;
            this.adgvJournalVentes.RowHeadersVisible = false;
            this.adgvJournalVentes.Size = new System.Drawing.Size(952, 574);
            this.adgvJournalVentes.TabIndex = 13;
            this.adgvJournalVentes.TimeFilter = true;
            this.adgvJournalVentes.VirtualMode = true;
            this.adgvJournalVentes.SortStringChanged += new System.EventHandler(this.AdgvJournalVentes_SortStringChanged);
            this.adgvJournalVentes.FilterStringChanged += new System.EventHandler(this.AdgvJournalVentes_FilterStringChanged);
            // 
            // UC_JournalVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adgvJournalVentes);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_JournalVentes";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_JournalVentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvJournalVentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private ADGV.AdvancedDataGridView adgvJournalVentes;
    }
}
