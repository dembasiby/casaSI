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
            this.label4 = new System.Windows.Forms.Label();
            this.lbxListeProduitsSemiFinis = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resStockProduitsSemiFiniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvJournalStocksProduitsSemiFinis = new System.Windows.Forms.DataGridView();
            this.btnImprimerFicheStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resStockProduitsSemiFiniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalStocksProduitsSemiFinis)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Journal des Stocks de Produits Semi-Finis";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbxListeProduitsSemiFinis
            // 
            this.lbxListeProduitsSemiFinis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxListeProduitsSemiFinis.FormattingEnabled = true;
            this.lbxListeProduitsSemiFinis.ItemHeight = 17;
            this.lbxListeProduitsSemiFinis.Location = new System.Drawing.Point(5, 89);
            this.lbxListeProduitsSemiFinis.Margin = new System.Windows.Forms.Padding(2);
            this.lbxListeProduitsSemiFinis.Name = "lbxListeProduitsSemiFinis";
            this.lbxListeProduitsSemiFinis.Size = new System.Drawing.Size(168, 493);
            this.lbxListeProduitsSemiFinis.TabIndex = 16;
            this.lbxListeProduitsSemiFinis.SelectedIndexChanged += new System.EventHandler(this.LbxListeProduitsSemiFinis_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Fiche de stocks par produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Liste des produits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "semi-finis";
            // 
            // resStockProduitsSemiFiniBindingSource
            // 
            this.resStockProduitsSemiFiniBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResStockProduitsSemiFini);
            // 
            // dgvJournalStocksProduitsSemiFinis
            // 
            this.dgvJournalStocksProduitsSemiFinis.AllowUserToAddRows = false;
            this.dgvJournalStocksProduitsSemiFinis.AllowUserToDeleteRows = false;
            this.dgvJournalStocksProduitsSemiFinis.AllowUserToOrderColumns = true;
            this.dgvJournalStocksProduitsSemiFinis.AllowUserToResizeColumns = false;
            this.dgvJournalStocksProduitsSemiFinis.AllowUserToResizeRows = false;
            this.dgvJournalStocksProduitsSemiFinis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvJournalStocksProduitsSemiFinis.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvJournalStocksProduitsSemiFinis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJournalStocksProduitsSemiFinis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournalStocksProduitsSemiFinis.Location = new System.Drawing.Point(179, 89);
            this.dgvJournalStocksProduitsSemiFinis.Name = "dgvJournalStocksProduitsSemiFinis";
            this.dgvJournalStocksProduitsSemiFinis.Size = new System.Drawing.Size(788, 493);
            this.dgvJournalStocksProduitsSemiFinis.TabIndex = 18;
            // 
            // btnImprimerFicheStock
            // 
            this.btnImprimerFicheStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnImprimerFicheStock.FlatAppearance.BorderSize = 0;
            this.btnImprimerFicheStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerFicheStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerFicheStock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimerFicheStock.Location = new System.Drawing.Point(744, 28);
            this.btnImprimerFicheStock.Name = "btnImprimerFicheStock";
            this.btnImprimerFicheStock.Size = new System.Drawing.Size(223, 30);
            this.btnImprimerFicheStock.TabIndex = 53;
            this.btnImprimerFicheStock.Text = "Imprimer la fiche de stock";
            this.btnImprimerFicheStock.UseVisualStyleBackColor = false;
            this.btnImprimerFicheStock.Click += new System.EventHandler(this.BtnImprimerFicheStock_Click);
            // 
            // UC_StockProduitsSemiFinis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnImprimerFicheStock);
            this.Controls.Add(this.dgvJournalStocksProduitsSemiFinis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxListeProduitsSemiFinis);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_StockProduitsSemiFinis";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_StockProduitsSemiFinis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resStockProduitsSemiFiniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalStocksProduitsSemiFinis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxListeProduitsSemiFinis;
        private System.Windows.Forms.BindingSource resStockProduitsSemiFiniBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvJournalStocksProduitsSemiFinis;
        private System.Windows.Forms.Button btnImprimerFicheStock;
    }
}
