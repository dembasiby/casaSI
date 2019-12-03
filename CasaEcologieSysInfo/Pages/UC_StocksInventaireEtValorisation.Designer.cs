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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label26 = new System.Windows.Forms.Label();
            this.dgvTableauAffichageStocks = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnMatieresPremieres = new System.Windows.Forms.RadioButton();
            this.rbtnProduitsSemiFinis = new System.Windows.Forms.RadioButton();
            this.rbtnProduitsFinis = new System.Windows.Forms.RadioButton();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableauAffichageStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTableauAffichageStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableauAffichageStocks.Location = new System.Drawing.Point(137, 160);
            this.dgvTableauAffichageStocks.Name = "dgvTableauAffichageStocks";
            this.dgvTableauAffichageStocks.RowHeadersVisible = false;
            this.dgvTableauAffichageStocks.Size = new System.Drawing.Size(734, 453);
            this.dgvTableauAffichageStocks.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(448, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 23);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Date";
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
            // UC_StocksInventaireEtValorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTableauAffichageStocks);
            this.Controls.Add(this.rbtnProduitsFinis);
            this.Controls.Add(this.rbtnProduitsSemiFinis);
            this.Controls.Add(this.rbtnMatieresPremieres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTableauAffichageStocks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnMatieresPremieres;
        private System.Windows.Forms.RadioButton rbtnProduitsSemiFinis;
        private System.Windows.Forms.RadioButton rbtnProduitsFinis;
    }
}
