﻿namespace CasaEcologieSysInfo
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.resStockMatieresPremiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvJournalStocksMatieresPremieres = new System.Windows.Forms.DataGridView();
            this.btnImprimerFicheStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremiereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalStocksMatieresPremieres)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(429, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Journal des Stocks de Matières Premières";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.DataSource = this.resStockMatieresPremiereBindingSource;
            this.listBox1.DisplayMember = "NomMatiere";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(6, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 476);
            this.listBox1.TabIndex = 14;
            this.listBox1.ValueMember = "NomMatiere";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // resStockMatieresPremiereBindingSource
            // 
            this.resStockMatieresPremiereBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResStockMatieresPremiere);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fiche de stocks par produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Liste des matières premières";
            // 
            // dgvJournalStocksMatieresPremieres
            // 
            this.dgvJournalStocksMatieresPremieres.AllowUserToAddRows = false;
            this.dgvJournalStocksMatieresPremieres.AllowUserToDeleteRows = false;
            this.dgvJournalStocksMatieresPremieres.AllowUserToOrderColumns = true;
            this.dgvJournalStocksMatieresPremieres.AllowUserToResizeColumns = false;
            this.dgvJournalStocksMatieresPremieres.AllowUserToResizeRows = false;
            this.dgvJournalStocksMatieresPremieres.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvJournalStocksMatieresPremieres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJournalStocksMatieresPremieres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournalStocksMatieresPremieres.Location = new System.Drawing.Point(198, 100);
            this.dgvJournalStocksMatieresPremieres.Name = "dgvJournalStocksMatieresPremieres";
            this.dgvJournalStocksMatieresPremieres.ReadOnly = true;
            this.dgvJournalStocksMatieresPremieres.RowHeadersVisible = false;
            this.dgvJournalStocksMatieresPremieres.Size = new System.Drawing.Size(771, 476);
            this.dgvJournalStocksMatieresPremieres.TabIndex = 20;
            // 
            // btnImprimerFicheStock
            // 
            this.btnImprimerFicheStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnImprimerFicheStock.FlatAppearance.BorderSize = 0;
            this.btnImprimerFicheStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerFicheStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerFicheStock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimerFicheStock.Location = new System.Drawing.Point(746, 39);
            this.btnImprimerFicheStock.Name = "btnImprimerFicheStock";
            this.btnImprimerFicheStock.Size = new System.Drawing.Size(223, 30);
            this.btnImprimerFicheStock.TabIndex = 54;
            this.btnImprimerFicheStock.Text = "Imprimer la fiche de stock";
            this.btnImprimerFicheStock.UseVisualStyleBackColor = false;
            this.btnImprimerFicheStock.Click += new System.EventHandler(this.BtnImprimerFicheStock_Click);
            // 
            // UC_StockMatieresPremieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnImprimerFicheStock);
            this.Controls.Add(this.dgvJournalStocksMatieresPremieres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_StockMatieresPremieres";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_StockMatieresPremieres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremiereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalStocksMatieresPremieres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource resStockMatieresPremiereBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvJournalStocksMatieresPremieres;
        private System.Windows.Forms.Button btnImprimerFicheStock;
    }
}
