namespace CasaEcologieSysInfo.Pages
{
    partial class UC_JournalApprovisionnements
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
            this.cbxFournisseurs = new System.Windows.Forms.ComboBox();
            this.ageFournisseursMatieresPremiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxMatieresPremieres = new System.Windows.Forms.ComboBox();
            this.resStockMatieresPremiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dgvJournalApprovisionnements = new System.Windows.Forms.DataGridView();
            this.cbxLocaliteFournisseur = new System.Windows.Forms.ComboBox();
            this.ageFournisseursMatieresPremiereBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ageFournisseursMatieresPremiereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremiereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalApprovisionnements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFournisseursMatieresPremiereBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Journal des Approvisionnements";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbxFournisseurs
            // 
            this.cbxFournisseurs.DataSource = this.ageFournisseursMatieresPremiereBindingSource;
            this.cbxFournisseurs.DisplayMember = "Nom";
            this.cbxFournisseurs.FormattingEnabled = true;
            this.cbxFournisseurs.Location = new System.Drawing.Point(454, 99);
            this.cbxFournisseurs.Name = "cbxFournisseurs";
            this.cbxFournisseurs.Size = new System.Drawing.Size(234, 25);
            this.cbxFournisseurs.TabIndex = 27;
            this.cbxFournisseurs.ValueMember = "CodeFournisseurMatierePremiere";
            this.cbxFournisseurs.SelectedIndexChanged += new System.EventHandler(this.CbxFournisseurs_SelectedIndexChanged);
            this.cbxFournisseurs.TextChanged += new System.EventHandler(this.CbxFournisseurs_TextChanged);
            // 
            // ageFournisseursMatieresPremiereBindingSource
            // 
            this.ageFournisseursMatieresPremiereBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeFournisseursMatieresPremiere);
            // 
            // cbxMatieresPremieres
            // 
            this.cbxMatieresPremieres.DataSource = this.resStockMatieresPremiereBindingSource;
            this.cbxMatieresPremieres.DisplayMember = "NomMatiere";
            this.cbxMatieresPremieres.FormattingEnabled = true;
            this.cbxMatieresPremieres.Location = new System.Drawing.Point(454, 66);
            this.cbxMatieresPremieres.Name = "cbxMatieresPremieres";
            this.cbxMatieresPremieres.Size = new System.Drawing.Size(234, 25);
            this.cbxMatieresPremieres.TabIndex = 28;
            this.cbxMatieresPremieres.ValueMember = "CodeMatierePremiere";
            this.cbxMatieresPremieres.SelectedIndexChanged += new System.EventHandler(this.CbxMatieresPremieres_SelectedIndexChanged);
            this.cbxMatieresPremieres.TextChanged += new System.EventHandler(this.cbxMatieresPremieres_TextChanged);
            // 
            // resStockMatieresPremiereBindingSource
            // 
            this.resStockMatieresPremiereBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResStockMatieresPremiere);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Matière première";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Début";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nom du fournisseur";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(102, 97);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 23);
            this.dtpFin.TabIndex = 22;
            this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFin_ValueChanged);
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(102, 64);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 23);
            this.dtpDebut.TabIndex = 21;
            this.dtpDebut.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpDebut.ValueChanged += new System.EventHandler(this.DtpDebut_ValueChanged);
            // 
            // dgvJournalApprovisionnements
            // 
            this.dgvJournalApprovisionnements.AllowUserToAddRows = false;
            this.dgvJournalApprovisionnements.AllowUserToDeleteRows = false;
            this.dgvJournalApprovisionnements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvJournalApprovisionnements.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvJournalApprovisionnements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJournalApprovisionnements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournalApprovisionnements.Location = new System.Drawing.Point(42, 137);
            this.dgvJournalApprovisionnements.Name = "dgvJournalApprovisionnements";
            this.dgvJournalApprovisionnements.Size = new System.Drawing.Size(868, 497);
            this.dgvJournalApprovisionnements.TabIndex = 20;
            // 
            // cbxLocaliteFournisseur
            // 
            this.cbxLocaliteFournisseur.DataSource = this.ageFournisseursMatieresPremiereBindingSource1;
            this.cbxLocaliteFournisseur.DisplayMember = "Localite";
            this.cbxLocaliteFournisseur.FormattingEnabled = true;
            this.cbxLocaliteFournisseur.Location = new System.Drawing.Point(703, 97);
            this.cbxLocaliteFournisseur.Name = "cbxLocaliteFournisseur";
            this.cbxLocaliteFournisseur.Size = new System.Drawing.Size(234, 25);
            this.cbxLocaliteFournisseur.TabIndex = 28;
            this.cbxLocaliteFournisseur.ValueMember = "CodeMatierePremiere";
            this.cbxLocaliteFournisseur.SelectedIndexChanged += new System.EventHandler(this.CbxLocaliteFournisseur_SelectedIndexChanged);
            this.cbxLocaliteFournisseur.TextChanged += new System.EventHandler(this.CbxLocaliteFournisseur_TextChanged);
            // 
            // ageFournisseursMatieresPremiereBindingSource1
            // 
            this.ageFournisseursMatieresPremiereBindingSource1.DataSource = typeof(CasaEcologieSysInfo.AgeFournisseursMatieresPremiere);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(700, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Localité";
            // 
            // UC_JournalApprovisionnements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxFournisseurs);
            this.Controls.Add(this.cbxLocaliteFournisseur);
            this.Controls.Add(this.cbxMatieresPremieres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.dgvJournalApprovisionnements);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_JournalApprovisionnements";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_JournalApprovisionnements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageFournisseursMatieresPremiereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremiereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournalApprovisionnements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFournisseursMatieresPremiereBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxFournisseurs;
        private System.Windows.Forms.ComboBox cbxMatieresPremieres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DataGridView dgvJournalApprovisionnements;
        private System.Windows.Forms.BindingSource resStockMatieresPremiereBindingSource;
        private System.Windows.Forms.BindingSource ageFournisseursMatieresPremiereBindingSource;
        private System.Windows.Forms.ComboBox cbxLocaliteFournisseur;
        private System.Windows.Forms.BindingSource ageFournisseursMatieresPremiereBindingSource1;
        private System.Windows.Forms.Label label6;
    }
}
