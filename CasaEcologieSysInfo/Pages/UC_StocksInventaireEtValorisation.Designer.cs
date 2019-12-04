namespace CasaEcologieSysInfo.Pages
{
    partial class UC_StocksInventaireEtValorisation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label26 = new System.Windows.Forms.Label();
            this.dgvTableauAffichageStocks = new System.Windows.Forms.DataGridView();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnMatieresPremieres = new System.Windows.Forms.RadioButton();
            this.rbtnProduitsSemiFinis = new System.Windows.Forms.RadioButton();
            this.rbtnProduitsFinis = new System.Windows.Forms.RadioButton();
            this.btnImprimerTablStocks = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStockMatieresPremieres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockProduitsSemiFinis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStocksProduitsFinis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValeurTotaleStocks = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableauAffichageStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(303, 14);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(371, 25);
            this.label26.TabIndex = 28;
            this.label26.Text = "Inventaire et valorisation des stocks";
            this.label26.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvTableauAffichageStocks
            // 
            this.dgvTableauAffichageStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableauAffichageStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableauAffichageStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTableauAffichageStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableauAffichageStocks.Location = new System.Drawing.Point(226, 160);
            this.dgvTableauAffichageStocks.Name = "dgvTableauAffichageStocks";
            this.dgvTableauAffichageStocks.RowHeadersVisible = false;
            this.dgvTableauAffichageStocks.Size = new System.Drawing.Size(734, 453);
            this.dgvTableauAffichageStocks.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(448, 55);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(142, 23);
            this.dtpDate.TabIndex = 30;
            this.dtpDate.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Valeur des stocks à la date du";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Veuillez choisir l\'élément à  afficher dans le tableau ci-dessous";
            // 
            // rbtnMatieresPremieres
            // 
            this.rbtnMatieresPremieres.AutoSize = true;
            this.rbtnMatieresPremieres.Checked = true;
            this.rbtnMatieresPremieres.Location = new System.Drawing.Point(311, 121);
            this.rbtnMatieresPremieres.Name = "rbtnMatieresPremieres";
            this.rbtnMatieresPremieres.Size = new System.Drawing.Size(145, 21);
            this.rbtnMatieresPremieres.TabIndex = 33;
            this.rbtnMatieresPremieres.TabStop = true;
            this.rbtnMatieresPremieres.Text = "Matières premières";
            this.rbtnMatieresPremieres.UseVisualStyleBackColor = true;
            this.rbtnMatieresPremieres.CheckedChanged += new System.EventHandler(this.RbtnMatieresPremieres_CheckedChanged);
            // 
            // rbtnProduitsSemiFinis
            // 
            this.rbtnProduitsSemiFinis.AutoSize = true;
            this.rbtnProduitsSemiFinis.Location = new System.Drawing.Point(462, 122);
            this.rbtnProduitsSemiFinis.Name = "rbtnProduitsSemiFinis";
            this.rbtnProduitsSemiFinis.Size = new System.Drawing.Size(137, 21);
            this.rbtnProduitsSemiFinis.TabIndex = 34;
            this.rbtnProduitsSemiFinis.TabStop = true;
            this.rbtnProduitsSemiFinis.Text = "Produits semi finis";
            this.rbtnProduitsSemiFinis.UseVisualStyleBackColor = true;
            this.rbtnProduitsSemiFinis.CheckedChanged += new System.EventHandler(this.RbtnProduitsSemiFinis_CheckedChanged);
            // 
            // rbtnProduitsFinis
            // 
            this.rbtnProduitsFinis.AutoSize = true;
            this.rbtnProduitsFinis.Location = new System.Drawing.Point(608, 121);
            this.rbtnProduitsFinis.Name = "rbtnProduitsFinis";
            this.rbtnProduitsFinis.Size = new System.Drawing.Size(104, 21);
            this.rbtnProduitsFinis.TabIndex = 34;
            this.rbtnProduitsFinis.TabStop = true;
            this.rbtnProduitsFinis.Text = "Produits finis";
            this.rbtnProduitsFinis.UseVisualStyleBackColor = true;
            this.rbtnProduitsFinis.CheckedChanged += new System.EventHandler(this.RbtnProduitsFinis_CheckedChanged);
            // 
            // btnImprimerTablStocks
            // 
            this.btnImprimerTablStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnImprimerTablStocks.FlatAppearance.BorderSize = 0;
            this.btnImprimerTablStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerTablStocks.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnImprimerTablStocks.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimerTablStocks.Location = new System.Drawing.Point(756, 17);
            this.btnImprimerTablStocks.Name = "btnImprimerTablStocks";
            this.btnImprimerTablStocks.Size = new System.Drawing.Size(185, 25);
            this.btnImprimerTablStocks.TabIndex = 62;
            this.btnImprimerTablStocks.Text = "Imprimer le tableau";
            this.btnImprimerTablStocks.UseVisualStyleBackColor = false;
            this.btnImprimerTablStocks.Click += new System.EventHandler(this.BtnImprimerTablStocks_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Stock de matières premières";
            // 
            // txtStockMatieresPremieres
            // 
            this.txtStockMatieresPremieres.Location = new System.Drawing.Point(16, 179);
            this.txtStockMatieresPremieres.Name = "txtStockMatieresPremieres";
            this.txtStockMatieresPremieres.ReadOnly = true;
            this.txtStockMatieresPremieres.Size = new System.Drawing.Size(204, 23);
            this.txtStockMatieresPremieres.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "Stock de produits semi finis";
            // 
            // txtStockProduitsSemiFinis
            // 
            this.txtStockProduitsSemiFinis.Location = new System.Drawing.Point(16, 240);
            this.txtStockProduitsSemiFinis.Name = "txtStockProduitsSemiFinis";
            this.txtStockProduitsSemiFinis.ReadOnly = true;
            this.txtStockProduitsSemiFinis.Size = new System.Drawing.Size(204, 23);
            this.txtStockProduitsSemiFinis.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "Stock de produits finis";
            // 
            // txtStocksProduitsFinis
            // 
            this.txtStocksProduitsFinis.Location = new System.Drawing.Point(16, 296);
            this.txtStocksProduitsFinis.Name = "txtStocksProduitsFinis";
            this.txtStocksProduitsFinis.ReadOnly = true;
            this.txtStocksProduitsFinis.Size = new System.Drawing.Size(204, 23);
            this.txtStocksProduitsFinis.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 18);
            this.label6.TabIndex = 63;
            this.label6.Text = "Valeur total des stock";
            // 
            // txtValeurTotaleStocks
            // 
            this.txtValeurTotaleStocks.BackColor = System.Drawing.Color.Maroon;
            this.txtValeurTotaleStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValeurTotaleStocks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValeurTotaleStocks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtValeurTotaleStocks.Location = new System.Drawing.Point(16, 349);
            this.txtValeurTotaleStocks.Name = "txtValeurTotaleStocks";
            this.txtValeurTotaleStocks.ReadOnly = true;
            this.txtValeurTotaleStocks.Size = new System.Drawing.Size(204, 20);
            this.txtValeurTotaleStocks.TabIndex = 64;
            // 
            // UC_StocksInventaireEtValorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtValeurTotaleStocks);
            this.Controls.Add(this.txtStocksProduitsFinis);
            this.Controls.Add(this.txtStockProduitsSemiFinis);
            this.Controls.Add(this.txtStockMatieresPremieres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnImprimerTablStocks);
            this.Controls.Add(this.dgvTableauAffichageStocks);
            this.Controls.Add(this.rbtnProduitsFinis);
            this.Controls.Add(this.rbtnProduitsSemiFinis);
            this.Controls.Add(this.rbtnMatieresPremieres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label26);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_StocksInventaireEtValorisation";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_StocksInventaireEtValorisation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableauAffichageStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTableauAffichageStocks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnMatieresPremieres;
        private System.Windows.Forms.RadioButton rbtnProduitsSemiFinis;
        private System.Windows.Forms.RadioButton rbtnProduitsFinis;
        private System.Windows.Forms.Button btnImprimerTablStocks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStockMatieresPremieres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockProduitsSemiFinis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStocksProduitsFinis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValeurTotaleStocks;
    }
}
