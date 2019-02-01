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
            this.gbxProduitsSemiFinis = new System.Windows.Forms.GroupBox();
            this.gbxProduitsFinis = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.gbxMatieresPremières.Location = new System.Drawing.Point(23, 93);
            this.gbxMatieresPremières.Name = "gbxMatieresPremières";
            this.gbxMatieresPremières.Size = new System.Drawing.Size(290, 480);
            this.gbxMatieresPremières.TabIndex = 29;
            this.gbxMatieresPremières.TabStop = false;
            this.gbxMatieresPremières.Text = "Matières premières";
            // 
            // gbxProduitsSemiFinis
            // 
            this.gbxProduitsSemiFinis.Location = new System.Drawing.Point(327, 93);
            this.gbxProduitsSemiFinis.Name = "gbxProduitsSemiFinis";
            this.gbxProduitsSemiFinis.Size = new System.Drawing.Size(301, 480);
            this.gbxProduitsSemiFinis.TabIndex = 29;
            this.gbxProduitsSemiFinis.TabStop = false;
            this.gbxProduitsSemiFinis.Text = "Produits semi-finis";
            // 
            // gbxProduitsFinis
            // 
            this.gbxProduitsFinis.Location = new System.Drawing.Point(646, 93);
            this.gbxProduitsFinis.Name = "gbxProduitsFinis";
            this.gbxProduitsFinis.Size = new System.Drawing.Size(320, 480);
            this.gbxProduitsFinis.TabIndex = 29;
            this.gbxProduitsFinis.TabStop = false;
            this.gbxProduitsFinis.Text = "Produits finis";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(415, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 23);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(590, 51);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(142, 23);
            this.dateTimePicker2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Pour la période du";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "au";
            // 
            // UC_StocksInventaireEtValorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbxProduitsFinis);
            this.Controls.Add(this.gbxProduitsSemiFinis);
            this.Controls.Add(this.gbxMatieresPremières);
            this.Controls.Add(this.label26);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_StocksInventaireEtValorisation";
            this.Size = new System.Drawing.Size(983, 635);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox gbxMatieresPremières;
        private System.Windows.Forms.GroupBox gbxProduitsSemiFinis;
        private System.Windows.Forms.GroupBox gbxProduitsFinis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
