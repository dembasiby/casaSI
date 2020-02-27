namespace CasaEcologieSysInfo.Pages
{
    partial class UC_DettesFournisseurs
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbxListeFournisseursDettes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalDettesFournisseurs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImprimerTableau = new System.Windows.Forms.Button();
            this.rbtFMatieresPremieres = new System.Windows.Forms.RadioButton();
            this.rbtAutresFournisseurs = new System.Windows.Forms.RadioButton();
            this.rbtFEquipementsInfra = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Dettes fournisseurs";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(199, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(762, 480);
            this.dataGridView1.TabIndex = 27;
            // 
            // lbxListeFournisseursDettes
            // 
            this.lbxListeFournisseursDettes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxListeFournisseursDettes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxListeFournisseursDettes.FormattingEnabled = true;
            this.lbxListeFournisseursDettes.ItemHeight = 17;
            this.lbxListeFournisseursDettes.Location = new System.Drawing.Point(10, 99);
            this.lbxListeFournisseursDettes.Margin = new System.Windows.Forms.Padding(2);
            this.lbxListeFournisseursDettes.Name = "lbxListeFournisseursDettes";
            this.lbxListeFournisseursDettes.Size = new System.Drawing.Size(172, 323);
            this.lbxListeFournisseursDettes.TabIndex = 28;
            this.lbxListeFournisseursDettes.SelectedValueChanged += new System.EventHandler(this.LbxListeFournisseursDettes_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Total des dettes fournisseurs";
            // 
            // txtTotalDettesFournisseurs
            // 
            this.txtTotalDettesFournisseurs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotalDettesFournisseurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalDettesFournisseurs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDettesFournisseurs.ForeColor = System.Drawing.Color.Red;
            this.txtTotalDettesFournisseurs.Location = new System.Drawing.Point(14, 70);
            this.txtTotalDettesFournisseurs.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalDettesFournisseurs.Name = "txtTotalDettesFournisseurs";
            this.txtTotalDettesFournisseurs.ReadOnly = true;
            this.txtTotalDettesFournisseurs.Size = new System.Drawing.Size(169, 20);
            this.txtTotalDettesFournisseurs.TabIndex = 30;
            this.txtTotalDettesFournisseurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Détails des dettes fournisseurs";
            // 
            // btnImprimerTableau
            // 
            this.btnImprimerTableau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnImprimerTableau.FlatAppearance.BorderSize = 0;
            this.btnImprimerTableau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerTableau.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerTableau.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimerTableau.Location = new System.Drawing.Point(738, 9);
            this.btnImprimerTableau.Name = "btnImprimerTableau";
            this.btnImprimerTableau.Size = new System.Drawing.Size(223, 30);
            this.btnImprimerTableau.TabIndex = 59;
            this.btnImprimerTableau.Text = "Imprimer le tableau";
            this.btnImprimerTableau.UseVisualStyleBackColor = false;
            this.btnImprimerTableau.Click += new System.EventHandler(this.BtnImprimerTableau_Click);
            // 
            // rbtFMatieresPremieres
            // 
            this.rbtFMatieresPremieres.AutoSize = true;
            this.rbtFMatieresPremieres.Location = new System.Drawing.Point(229, 76);
            this.rbtFMatieresPremieres.Name = "rbtFMatieresPremieres";
            this.rbtFMatieresPremieres.Size = new System.Drawing.Size(224, 21);
            this.rbtFMatieresPremieres.TabIndex = 61;
            this.rbtFMatieresPremieres.TabStop = true;
            this.rbtFMatieresPremieres.Text = "Fournisseurs matières premières";
            this.rbtFMatieresPremieres.UseVisualStyleBackColor = true;
            this.rbtFMatieresPremieres.CheckedChanged += new System.EventHandler(this.RbtFMatieresPremieres_CheckedChanged);
            // 
            // rbtAutresFournisseurs
            // 
            this.rbtAutresFournisseurs.AutoSize = true;
            this.rbtAutresFournisseurs.Location = new System.Drawing.Point(743, 76);
            this.rbtAutresFournisseurs.Name = "rbtAutresFournisseurs";
            this.rbtAutresFournisseurs.Size = new System.Drawing.Size(140, 21);
            this.rbtAutresFournisseurs.TabIndex = 61;
            this.rbtAutresFournisseurs.TabStop = true;
            this.rbtAutresFournisseurs.Text = "Autres fournisseurs";
            this.rbtAutresFournisseurs.UseVisualStyleBackColor = true;
            this.rbtAutresFournisseurs.CheckedChanged += new System.EventHandler(this.RbtAutresFournisseurs_CheckedChanged);
            // 
            // rbtFEquipementsInfra
            // 
            this.rbtFEquipementsInfra.AutoSize = true;
            this.rbtFEquipementsInfra.Location = new System.Drawing.Point(460, 77);
            this.rbtFEquipementsInfra.Name = "rbtFEquipementsInfra";
            this.rbtFEquipementsInfra.Size = new System.Drawing.Size(276, 21);
            this.rbtFEquipementsInfra.TabIndex = 61;
            this.rbtFEquipementsInfra.TabStop = true;
            this.rbtFEquipementsInfra.Text = "Fournisseurs équipement/infrastructures";
            this.rbtFEquipementsInfra.UseVisualStyleBackColor = true;
            this.rbtFEquipementsInfra.CheckedChanged += new System.EventHandler(this.RbtFEquipementsInfra_CheckedChanged);
            // 
            // UC_DettesFournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbtFEquipementsInfra);
            this.Controls.Add(this.rbtAutresFournisseurs);
            this.Controls.Add(this.rbtFMatieresPremieres);
            this.Controls.Add(this.btnImprimerTableau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalDettesFournisseurs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxListeFournisseursDettes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_DettesFournisseurs";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_DettesFournisseurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lbxListeFournisseursDettes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalDettesFournisseurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprimerTableau;
        private System.Windows.Forms.RadioButton rbtFMatieresPremieres;
        private System.Windows.Forms.RadioButton rbtAutresFournisseurs;
        private System.Windows.Forms.RadioButton rbtFEquipementsInfra;
    }
}
