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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Dettes fournisseurs";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(234, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 481);
            this.dataGridView1.TabIndex = 27;
            // 
            // lbxListeFournisseursDettes
            // 
            this.lbxListeFournisseursDettes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxListeFournisseursDettes.FormattingEnabled = true;
            this.lbxListeFournisseursDettes.ItemHeight = 21;
            this.lbxListeFournisseursDettes.Location = new System.Drawing.Point(13, 122);
            this.lbxListeFournisseursDettes.Name = "lbxListeFournisseursDettes";
            this.lbxListeFournisseursDettes.Size = new System.Drawing.Size(215, 399);
            this.lbxListeFournisseursDettes.TabIndex = 28;
            this.lbxListeFournisseursDettes.SelectedValueChanged += new System.EventHandler(this.LbxListeFournisseursDettes_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Total des dettes fournisseurs";
            // 
            // txtTotalDettesFournisseurs
            // 
            this.txtTotalDettesFournisseurs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotalDettesFournisseurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalDettesFournisseurs.Enabled = false;
            this.txtTotalDettesFournisseurs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDettesFournisseurs.ForeColor = System.Drawing.Color.Red;
            this.txtTotalDettesFournisseurs.Location = new System.Drawing.Point(17, 86);
            this.txtTotalDettesFournisseurs.Name = "txtTotalDettesFournisseurs";
            this.txtTotalDettesFournisseurs.Size = new System.Drawing.Size(211, 20);
            this.txtTotalDettesFournisseurs.TabIndex = 30;
            this.txtTotalDettesFournisseurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Détails des dettes fournisseurs";
            // 
            // UC_DettesFournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalDettesFournisseurs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxListeFournisseursDettes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
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
    }
}
