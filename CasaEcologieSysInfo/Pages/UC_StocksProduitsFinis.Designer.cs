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
            this.lbxListeProduitsFinis = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adgvJournalStocksProduitsFinis)).BeginInit();
            this.SuspendLayout();
            // 
            // adgvJournalStocksProduitsFinis
            // 
            this.adgvJournalStocksProduitsFinis.AutoGenerateContextFilters = true;
            this.adgvJournalStocksProduitsFinis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvJournalStocksProduitsFinis.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.adgvJournalStocksProduitsFinis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adgvJournalStocksProduitsFinis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvJournalStocksProduitsFinis.DateWithTime = false;
            this.adgvJournalStocksProduitsFinis.Location = new System.Drawing.Point(264, 104);
            this.adgvJournalStocksProduitsFinis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adgvJournalStocksProduitsFinis.Name = "adgvJournalStocksProduitsFinis";
            this.adgvJournalStocksProduitsFinis.ReadOnly = true;
            this.adgvJournalStocksProduitsFinis.Size = new System.Drawing.Size(704, 476);
            this.adgvJournalStocksProduitsFinis.TabIndex = 0;
            this.adgvJournalStocksProduitsFinis.TimeFilter = false;
            this.adgvJournalStocksProduitsFinis.SortStringChanged += new System.EventHandler(this.AdgvJournalStocksProduitsFinis_SortStringChanged);
            this.adgvJournalStocksProduitsFinis.FilterStringChanged += new System.EventHandler(this.AdgvJournalStocksProduitsFinis_FilterStringChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Journal des Stocks de Produits Finis";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbxListeProduitsFinis
            // 
            this.lbxListeProduitsFinis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxListeProduitsFinis.FormattingEnabled = true;
            this.lbxListeProduitsFinis.ItemHeight = 17;
            this.lbxListeProduitsFinis.Location = new System.Drawing.Point(14, 104);
            this.lbxListeProduitsFinis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxListeProduitsFinis.Name = "lbxListeProduitsFinis";
            this.lbxListeProduitsFinis.Size = new System.Drawing.Size(246, 476);
            this.lbxListeProduitsFinis.TabIndex = 15;
            this.lbxListeProduitsFinis.SelectedIndexChanged += new System.EventHandler(this.LbxListeProduitsFinis_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fiche de stocks par produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Liste des produits finis";
            // 
            // UC_StocksProduitsFinis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxListeProduitsFinis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adgvJournalStocksProduitsFinis);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ListBox lbxListeProduitsFinis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
