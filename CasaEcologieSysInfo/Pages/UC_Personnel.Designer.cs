namespace CasaEcologieSysInfo.Pages
{
    partial class UC_Personnel
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
            this.dgvListePersonnel = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrenomNom = new System.Windows.Forms.TextBox();
            this.btnNouvelEmploye = new System.Windows.Forms.Button();
            this.txtPosteEmploye = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Page de suivi du personnel";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvListePersonnel
            // 
            this.dgvListePersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListePersonnel.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListePersonnel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListePersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListePersonnel.Enabled = false;
            this.dgvListePersonnel.Location = new System.Drawing.Point(13, 93);
            this.dgvListePersonnel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListePersonnel.Name = "dgvListePersonnel";
            this.dgvListePersonnel.Size = new System.Drawing.Size(551, 121);
            this.dgvListePersonnel.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(678, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ajouter un nouvel employé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Prénom et nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Poste";
            // 
            // txtPrenomNom
            // 
            this.txtPrenomNom.Location = new System.Drawing.Point(682, 93);
            this.txtPrenomNom.Name = "txtPrenomNom";
            this.txtPrenomNom.Size = new System.Drawing.Size(272, 23);
            this.txtPrenomNom.TabIndex = 29;
            // 
            // btnNouvelEmploye
            // 
            this.btnNouvelEmploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnNouvelEmploye.FlatAppearance.BorderSize = 0;
            this.btnNouvelEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouvelEmploye.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvelEmploye.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNouvelEmploye.Location = new System.Drawing.Point(682, 168);
            this.btnNouvelEmploye.Name = "btnNouvelEmploye";
            this.btnNouvelEmploye.Size = new System.Drawing.Size(272, 31);
            this.btnNouvelEmploye.TabIndex = 30;
            this.btnNouvelEmploye.Text = "Ajouter un nouvel employé";
            this.btnNouvelEmploye.UseVisualStyleBackColor = false;
            this.btnNouvelEmploye.Click += new System.EventHandler(this.BtnNouvelEmploye_Click);
            // 
            // txtPosteEmploye
            // 
            this.txtPosteEmploye.Location = new System.Drawing.Point(682, 125);
            this.txtPosteEmploye.Name = "txtPosteEmploye";
            this.txtPosteEmploye.Size = new System.Drawing.Size(272, 23);
            this.txtPosteEmploye.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Liste des employés";
            // 
            // UC_Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNouvelEmploye);
            this.Controls.Add(this.txtPosteEmploye);
            this.Controls.Add(this.txtPrenomNom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListePersonnel);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_Personnel";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_Personnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvListePersonnel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrenomNom;
        private System.Windows.Forms.Button btnNouvelEmploye;
        private System.Windows.Forms.TextBox txtPosteEmploye;
        private System.Windows.Forms.Label label5;
    }
}
