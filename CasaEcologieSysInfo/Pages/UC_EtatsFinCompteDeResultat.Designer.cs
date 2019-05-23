namespace CasaEcologieSysInfo.Pages
{
    partial class UC_EtatsFinCompteDeResultat
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtpAnnee = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Choisir l\'année";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtpAnnee
            // 
            this.dtpAnnee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnnee.Location = new System.Drawing.Point(395, 79);
            this.dtpAnnee.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpAnnee.Name = "dtpAnnee";
            this.dtpAnnee.Size = new System.Drawing.Size(115, 23);
            this.dtpAnnee.TabIndex = 3;
            this.dtpAnnee.ValueChanged += new System.EventHandler(this.DtpAnnee_ValueChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(348, 16);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(325, 25);
            this.label26.TabIndex = 27;
            this.label26.Text = "Comptes de résultats mensuels";
            this.label26.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UC_EtatsFinCompteDeResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label26);
            this.Controls.Add(this.dtpAnnee);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_EtatsFinCompteDeResultat";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_EtatsFinMensuels_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpAnnee;
        private System.Windows.Forms.Label label26;
    }
}
