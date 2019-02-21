namespace CasaEcologieSysInfo
{
    partial class UC_JournalVentes
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
            this.dgvJournalVentes = new System.Windows.Forms.DataGridView();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.cbxProduits = new System.Windows.Forms.ComboBox();
            this.resStockProduitsFiniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxClients = new System.Windows.Forms.ComboBox();
            this.ageClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalVentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockProduitsFiniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Journal des Ventes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvJournalVentes
            // 
            this.dgvJournalVentes.AllowUserToAddRows = false;
            this.dgvJournalVentes.AllowUserToDeleteRows = false;
            this.dgvJournalVentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvJournalVentes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvJournalVentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJournalVentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournalVentes.Location = new System.Drawing.Point(26, 117);
            this.dgvJournalVentes.Name = "dgvJournalVentes";
            this.dgvJournalVentes.ReadOnly = true;
            this.dgvJournalVentes.RowHeadersVisible = false;
            this.dgvJournalVentes.Size = new System.Drawing.Size(838, 497);
            this.dgvJournalVentes.TabIndex = 13;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(114, 55);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 23);
            this.dtpDebut.TabIndex = 14;
            this.dtpDebut.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpDebut.ValueChanged += new System.EventHandler(this.DtpDebut_ValueChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(114, 88);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 23);
            this.dtpFin.TabIndex = 15;
            this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nom du client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Produit fini";
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(836, 19);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(133, 23);
            this.btnImprimer.TabIndex = 18;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnFiltrer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnFiltrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrer.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrer.Location = new System.Drawing.Point(731, 71);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(133, 31);
            this.btnFiltrer.TabIndex = 18;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = false;
            this.btnFiltrer.Click += new System.EventHandler(this.BtnFiltrer_Click);
            // 
            // cbxProduits
            // 
            this.cbxProduits.DataSource = this.resStockProduitsFiniBindingSource;
            this.cbxProduits.DisplayMember = "NomProduit";
            this.cbxProduits.FormattingEnabled = true;
            this.cbxProduits.Location = new System.Drawing.Point(470, 57);
            this.cbxProduits.Name = "cbxProduits";
            this.cbxProduits.Size = new System.Drawing.Size(234, 25);
            this.cbxProduits.TabIndex = 19;
            this.cbxProduits.SelectedIndexChanged += new System.EventHandler(this.CbxProduits_SelectedIndexChanged);
            this.cbxProduits.TextChanged += new System.EventHandler(this.CbxProduits_TextChanged);
            // 
            // resStockProduitsFiniBindingSource
            // 
            this.resStockProduitsFiniBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResStockProduitsFini);
            // 
            // cbxClients
            // 
            this.cbxClients.DataSource = this.ageClientBindingSource;
            this.cbxClients.DisplayMember = "NomClient";
            this.cbxClients.FormattingEnabled = true;
            this.cbxClients.Location = new System.Drawing.Point(470, 90);
            this.cbxClients.Name = "cbxClients";
            this.cbxClients.Size = new System.Drawing.Size(234, 25);
            this.cbxClients.TabIndex = 19;
            this.cbxClients.SelectedIndexChanged += new System.EventHandler(this.CbxClients_SelectedIndexChanged);
            this.cbxClients.TextChanged += new System.EventHandler(this.CbxClients_TextChanged);
            // 
            // ageClientBindingSource
            // 
            this.ageClientBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeClient);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Début";
            // 
            // UC_JournalVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxClients);
            this.Controls.Add(this.cbxProduits);
            this.Controls.Add(this.btnFiltrer);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.dgvJournalVentes);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_JournalVentes";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_JournalVentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalVentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockProduitsFiniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageClientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvJournalVentes;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnFiltrer;
        private System.Windows.Forms.ComboBox cbxProduits;
        private System.Windows.Forms.BindingSource resStockProduitsFiniBindingSource;
        private System.Windows.Forms.ComboBox cbxClients;
        private System.Windows.Forms.BindingSource ageClientBindingSource;
        private System.Windows.Forms.Label label5;
    }
}
