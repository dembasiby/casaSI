namespace CasaEcologieSysInfo
{
    partial class UC_StockMatieresPremieres
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
            this.adgvJournalStockMatieresPremieres = new ADGV.AdvancedDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adgvJournalStockMatieresPremieres)).BeginInit();
            this.SuspendLayout();
            // 
            // adgvJournalStockMatieresPremieres
            // 
            this.adgvJournalStockMatieresPremieres.AllowUserToAddRows = false;
            this.adgvJournalStockMatieresPremieres.AllowUserToDeleteRows = false;
            this.adgvJournalStockMatieresPremieres.AllowUserToResizeColumns = false;
            this.adgvJournalStockMatieresPremieres.AllowUserToResizeRows = false;
            this.adgvJournalStockMatieresPremieres.AutoGenerateContextFilters = false;
            this.adgvJournalStockMatieresPremieres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvJournalStockMatieresPremieres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvJournalStockMatieresPremieres.DateWithTime = false;
            this.adgvJournalStockMatieresPremieres.Location = new System.Drawing.Point(12, 52);
            this.adgvJournalStockMatieresPremieres.Name = "adgvJournalStockMatieresPremieres";
            this.adgvJournalStockMatieresPremieres.ReadOnly = true;
            this.adgvJournalStockMatieresPremieres.Size = new System.Drawing.Size(957, 580);
            this.adgvJournalStockMatieresPremieres.TabIndex = 0;
            this.adgvJournalStockMatieresPremieres.TimeFilter = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(429, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Journal des Stocks de Matières Premières";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UC_StockMatieresPremieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adgvJournalStockMatieresPremieres);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_StockMatieresPremieres";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_StockMatieresPremieres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvJournalStockMatieresPremieres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ADGV.AdvancedDataGridView adgvJournalStockMatieresPremieres;
        private System.Windows.Forms.Label label4;
    }
}
