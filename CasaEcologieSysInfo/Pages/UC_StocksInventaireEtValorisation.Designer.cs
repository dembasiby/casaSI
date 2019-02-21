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
            this.label26 = new System.Windows.Forms.Label();
            this.gbxMatieresPremières = new System.Windows.Forms.GroupBox();
            this.dgvMatieresPremieres = new System.Windows.Forms.DataGridView();
            this.gbxProduitsSemiFinis = new System.Windows.Forms.GroupBox();
            this.dgvProduitsSemiFinis = new System.Windows.Forms.DataGridView();
            this.gbxProduitsFinis = new System.Windows.Forms.GroupBox();
            this.dgvProduitsFinis = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxMatieresPremières.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatieresPremieres)).BeginInit();
            this.gbxProduitsSemiFinis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduitsSemiFinis)).BeginInit();
            this.gbxProduitsFinis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduitsFinis)).BeginInit();
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
            // gbxMatieresPremières
            // 
            this.gbxMatieresPremières.Controls.Add(this.dgvMatieresPremieres);
            this.gbxMatieresPremières.Location = new System.Drawing.Point(3, 93);
            this.gbxMatieresPremières.Name = "gbxMatieresPremières";
            this.gbxMatieresPremières.Size = new System.Drawing.Size(375, 480);
            this.gbxMatieresPremières.TabIndex = 29;
            this.gbxMatieresPremières.TabStop = false;
            this.gbxMatieresPremières.Text = "Matières premières";
            // 
            // dgvMatieresPremieres
            // 
            this.dgvMatieresPremieres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMatieresPremieres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatieresPremieres.Location = new System.Drawing.Point(7, 23);
            this.dgvMatieresPremieres.Name = "dgvMatieresPremieres";
            this.dgvMatieresPremieres.ReadOnly = true;
            this.dgvMatieresPremieres.RowHeadersVisible = false;
            this.dgvMatieresPremieres.Size = new System.Drawing.Size(362, 451);
            this.dgvMatieresPremieres.TabIndex = 0;
            // 
            // gbxProduitsSemiFinis
            // 
            this.gbxProduitsSemiFinis.Controls.Add(this.dgvProduitsSemiFinis);
            this.gbxProduitsSemiFinis.Location = new System.Drawing.Point(384, 93);
            this.gbxProduitsSemiFinis.Name = "gbxProduitsSemiFinis";
            this.gbxProduitsSemiFinis.Size = new System.Drawing.Size(161, 480);
            this.gbxProduitsSemiFinis.TabIndex = 29;
            this.gbxProduitsSemiFinis.TabStop = false;
            this.gbxProduitsSemiFinis.Text = "Produits semi-finis";
            // 
            // dgvProduitsSemiFinis
            // 
            this.dgvProduitsSemiFinis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProduitsSemiFinis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduitsSemiFinis.Location = new System.Drawing.Point(6, 23);
            this.dgvProduitsSemiFinis.Name = "dgvProduitsSemiFinis";
            this.dgvProduitsSemiFinis.ReadOnly = true;
            this.dgvProduitsSemiFinis.RowHeadersVisible = false;
            this.dgvProduitsSemiFinis.Size = new System.Drawing.Size(99, 451);
            this.dgvProduitsSemiFinis.TabIndex = 0;
            // 
            // gbxProduitsFinis
            // 
            this.gbxProduitsFinis.Controls.Add(this.dgvProduitsFinis);
            this.gbxProduitsFinis.Location = new System.Drawing.Point(551, 93);
            this.gbxProduitsFinis.Name = "gbxProduitsFinis";
            this.gbxProduitsFinis.Size = new System.Drawing.Size(415, 480);
            this.gbxProduitsFinis.TabIndex = 29;
            this.gbxProduitsFinis.TabStop = false;
            this.gbxProduitsFinis.Text = "Produits finis";
            // 
            // dgvProduitsFinis
            // 
            this.dgvProduitsFinis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProduitsFinis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduitsFinis.Location = new System.Drawing.Point(6, 22);
            this.dgvProduitsFinis.Name = "dgvProduitsFinis";
            this.dgvProduitsFinis.ReadOnly = true;
            this.dgvProduitsFinis.RowHeadersVisible = false;
            this.dgvProduitsFinis.Size = new System.Drawing.Size(403, 451);
            this.dgvProduitsFinis.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(415, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 23);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Date";
            // 
            // UC_StocksInventaireEtValorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbxProduitsFinis);
            this.Controls.Add(this.gbxProduitsSemiFinis);
            this.Controls.Add(this.gbxMatieresPremières);
            this.Controls.Add(this.label26);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_StocksInventaireEtValorisation";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_StocksInventaireEtValorisation_Load);
            this.gbxMatieresPremières.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatieresPremieres)).EndInit();
            this.gbxProduitsSemiFinis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduitsSemiFinis)).EndInit();
            this.gbxProduitsFinis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduitsFinis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox gbxMatieresPremières;
        private System.Windows.Forms.GroupBox gbxProduitsSemiFinis;
        private System.Windows.Forms.GroupBox gbxProduitsFinis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMatieresPremieres;
        private System.Windows.Forms.DataGridView dgvProduitsSemiFinis;
        private System.Windows.Forms.DataGridView dgvProduitsFinis;
    }
}
