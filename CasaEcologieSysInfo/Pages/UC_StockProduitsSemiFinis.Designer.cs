namespace CasaEcologieSysInfo.Pages
{
    partial class UC_StockProduitsSemiFinis
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
            this.adgvJournalStocksProduitsSemiFinis = new ADGV.AdvancedDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxListeProduitsSemiFinis = new System.Windows.Forms.ListBox();
            this.resStockProduitsSemiFiniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adgvJournalStocksProduitsSemiFinis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockProduitsSemiFiniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adgvJournalStocksProduitsSemiFinis
            // 
            this.adgvJournalStocksProduitsSemiFinis.AutoGenerateContextFilters = true;
            this.adgvJournalStocksProduitsSemiFinis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvJournalStocksProduitsSemiFinis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvJournalStocksProduitsSemiFinis.DateWithTime = false;
            this.adgvJournalStocksProduitsSemiFinis.Location = new System.Drawing.Point(174, 82);
            this.adgvJournalStocksProduitsSemiFinis.Name = "adgvJournalStocksProduitsSemiFinis";
            this.adgvJournalStocksProduitsSemiFinis.ReadOnly = true;
            this.adgvJournalStocksProduitsSemiFinis.Size = new System.Drawing.Size(794, 550);
            this.adgvJournalStocksProduitsSemiFinis.TabIndex = 0;
            this.adgvJournalStocksProduitsSemiFinis.TimeFilter = false;
            this.adgvJournalStocksProduitsSemiFinis.SortStringChanged += new System.EventHandler(this.AdgvJournalStocksProduitsSemiFinis_SortStringChanged);
            this.adgvJournalStocksProduitsSemiFinis.FilterStringChanged += new System.EventHandler(this.AdgvJournalStocksProduitsSemiFinis_FilterStringChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Journal des Stocks de Produits Semi-Finis";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbxListeProduitsSemiFinis
            // 
            this.lbxListeProduitsSemiFinis.FormattingEnabled = true;
            this.lbxListeProduitsSemiFinis.ItemHeight = 21;
            this.lbxListeProduitsSemiFinis.Location = new System.Drawing.Point(3, 87);
            this.lbxListeProduitsSemiFinis.Name = "lbxListeProduitsSemiFinis";
            this.lbxListeProduitsSemiFinis.Size = new System.Drawing.Size(165, 277);
            this.lbxListeProduitsSemiFinis.TabIndex = 16;
            this.lbxListeProduitsSemiFinis.SelectedIndexChanged += new System.EventHandler(this.lbxListeProduitsSemiFinis_SelectedIndexChanged);
            // 
            // resStockProduitsSemiFiniBindingSource
            // 
            this.resStockProduitsSemiFiniBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResStockProduitsSemiFini);
            // 
            // UC_StockProduitsSemiFinis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbxListeProduitsSemiFinis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adgvJournalStocksProduitsSemiFinis);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_StockProduitsSemiFinis";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_StockProduitsSemiFinis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvJournalStocksProduitsSemiFinis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockProduitsSemiFiniBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ADGV.AdvancedDataGridView adgvJournalStocksProduitsSemiFinis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxListeProduitsSemiFinis;
        private System.Windows.Forms.BindingSource resStockProduitsSemiFiniBindingSource;
    }
}
