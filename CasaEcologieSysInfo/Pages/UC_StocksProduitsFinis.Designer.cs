namespace CasaEcologieSysInfo
{
    partial class UC_StocksProduitsFinis
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
            this.adgvJournalStocksProduitsFinis = new ADGV.AdvancedDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adgvJournalStocksProduitsFinis)).BeginInit();
            this.SuspendLayout();
            // 
            // adgvJournalStocksProduitsFinis
            // 
            this.adgvJournalStocksProduitsFinis.AutoGenerateContextFilters = true;
            this.adgvJournalStocksProduitsFinis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvJournalStocksProduitsFinis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvJournalStocksProduitsFinis.DateWithTime = false;
            this.adgvJournalStocksProduitsFinis.Location = new System.Drawing.Point(16, 61);
            this.adgvJournalStocksProduitsFinis.Name = "adgvJournalStocksProduitsFinis";
            this.adgvJournalStocksProduitsFinis.ReadOnly = true;
            this.adgvJournalStocksProduitsFinis.Size = new System.Drawing.Size(950, 571);
            this.adgvJournalStocksProduitsFinis.TabIndex = 0;
            this.adgvJournalStocksProduitsFinis.TimeFilter = false;
            this.adgvJournalStocksProduitsFinis.SortStringChanged += new System.EventHandler(this.AdgvJournalStocksProduitsFinis_SortStringChanged);
            this.adgvJournalStocksProduitsFinis.FilterStringChanged += new System.EventHandler(this.AdgvJournalStocksProduitsFinis_FilterStringChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Journal des Stocks de Produits Finis";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UC_StocksProduitsFinis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adgvJournalStocksProduitsFinis);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_StocksProduitsFinis";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_StocksProduitsFinis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvJournalStocksProduitsFinis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ADGV.AdvancedDataGridView adgvJournalStocksProduitsFinis;
        private System.Windows.Forms.Label label4;
    }
}
