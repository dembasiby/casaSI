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
            this.dgvCompteDeResultats = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtCoutMatierePremiereParUnite = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Janvier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fevrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avril = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juillet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Septembre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Octobre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Novembre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Decembre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompteDeResultats)).BeginInit();
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
            // dgvCompteDeResultats
            // 
            this.dgvCompteDeResultats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCompteDeResultats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompteDeResultats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Janvier,
            this.Fevrier,
            this.Mars,
            this.Avril,
            this.Mai,
            this.Juin,
            this.Juillet,
            this.Aout,
            this.Septembre,
            this.Octobre,
            this.Novembre,
            this.Decembre,
            this.Total});
            this.dgvCompteDeResultats.Location = new System.Drawing.Point(3, 132);
            this.dgvCompteDeResultats.Margin = new System.Windows.Forms.Padding(1);
            this.dgvCompteDeResultats.Name = "dgvCompteDeResultats";
            this.dgvCompteDeResultats.ReadOnly = true;
            this.dgvCompteDeResultats.RowHeadersVisible = false;
            this.dgvCompteDeResultats.Size = new System.Drawing.Size(977, 469);
            this.dgvCompteDeResultats.TabIndex = 28;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(14, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(297, 106);
            this.listBox1.TabIndex = 29;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // txtCoutMatierePremiereParUnite
            // 
            this.txtCoutMatierePremiereParUnite.Location = new System.Drawing.Point(731, 81);
            this.txtCoutMatierePremiereParUnite.Name = "txtCoutMatierePremiereParUnite";
            this.txtCoutMatierePremiereParUnite.ReadOnly = true;
            this.txtCoutMatierePremiereParUnite.Size = new System.Drawing.Size(156, 23);
            this.txtCoutMatierePremiereParUnite.TabIndex = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Description";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 105;
            // 
            // Janvier
            // 
            this.Janvier.HeaderText = "Janvier";
            this.Janvier.Name = "Janvier";
            this.Janvier.ReadOnly = true;
            this.Janvier.Width = 79;
            // 
            // Fevrier
            // 
            this.Fevrier.HeaderText = "Février";
            this.Fevrier.Name = "Fevrier";
            this.Fevrier.ReadOnly = true;
            this.Fevrier.Width = 74;
            // 
            // Mars
            // 
            this.Mars.HeaderText = "Mars";
            this.Mars.Name = "Mars";
            this.Mars.ReadOnly = true;
            this.Mars.Width = 62;
            // 
            // Avril
            // 
            this.Avril.HeaderText = "Avril";
            this.Avril.Name = "Avril";
            this.Avril.ReadOnly = true;
            this.Avril.Width = 60;
            // 
            // Mai
            // 
            this.Mai.HeaderText = "Mai";
            this.Mai.Name = "Mai";
            this.Mai.ReadOnly = true;
            this.Mai.Width = 56;
            // 
            // Juin
            // 
            this.Juin.HeaderText = "Juin";
            this.Juin.Name = "Juin";
            this.Juin.ReadOnly = true;
            this.Juin.Width = 58;
            // 
            // Juillet
            // 
            this.Juillet.HeaderText = "Juillet";
            this.Juillet.Name = "Juillet";
            this.Juillet.ReadOnly = true;
            this.Juillet.Width = 69;
            // 
            // Aout
            // 
            this.Aout.HeaderText = "Août";
            this.Aout.Name = "Aout";
            this.Aout.ReadOnly = true;
            this.Aout.Width = 64;
            // 
            // Septembre
            // 
            this.Septembre.HeaderText = "Septembre";
            this.Septembre.Name = "Septembre";
            this.Septembre.ReadOnly = true;
            this.Septembre.Width = 103;
            // 
            // Octobre
            // 
            this.Octobre.HeaderText = "Octobre";
            this.Octobre.Name = "Octobre";
            this.Octobre.ReadOnly = true;
            this.Octobre.Width = 87;
            // 
            // Novembre
            // 
            this.Novembre.HeaderText = "Novembre";
            this.Novembre.Name = "Novembre";
            this.Novembre.ReadOnly = true;
            this.Novembre.Width = 102;
            // 
            // Decembre
            // 
            this.Decembre.HeaderText = "Décembre";
            this.Decembre.Name = "Decembre";
            this.Decembre.ReadOnly = true;
            this.Decembre.Width = 101;
            // 
            // Total
            // 
            this.Total.HeaderText = "TOTAL";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 69;
            // 
            // UC_EtatsFinCompteDeResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCoutMatierePremiereParUnite);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dgvCompteDeResultats);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.dtpAnnee);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_EtatsFinCompteDeResultat";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_EtatsFinMensuels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompteDeResultats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpAnnee;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView dgvCompteDeResultats;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtCoutMatierePremiereParUnite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Janvier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fevrier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avril;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juillet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Septembre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Octobre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Novembre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Decembre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}
