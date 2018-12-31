namespace CasaEcologieSysInfo.Pages
{
    partial class UC_NouveauCompteTresorerie
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
            this.txtSoldeCompte = new System.Windows.Forms.TextBox();
            this.txtNomCompte = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAjouterNouveauCompte = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Créer un nouveau compte de trésorerie";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSoldeCompte
            // 
            this.txtSoldeCompte.Enabled = false;
            this.txtSoldeCompte.Location = new System.Drawing.Point(410, 137);
            this.txtSoldeCompte.Name = "txtSoldeCompte";
            this.txtSoldeCompte.Size = new System.Drawing.Size(250, 27);
            this.txtSoldeCompte.TabIndex = 52;
            // 
            // txtNomCompte
            // 
            this.txtNomCompte.Location = new System.Drawing.Point(410, 94);
            this.txtNomCompte.Name = "txtNomCompte";
            this.txtNomCompte.Size = new System.Drawing.Size(250, 27);
            this.txtNomCompte.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(186, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 45;
            this.label8.Text = "Solde initial:";
            // 
            // btnAjouterNouveauCompte
            // 
            this.btnAjouterNouveauCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnAjouterNouveauCompte.FlatAppearance.BorderSize = 0;
            this.btnAjouterNouveauCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterNouveauCompte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterNouveauCompte.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAjouterNouveauCompte.Location = new System.Drawing.Point(396, 187);
            this.btnAjouterNouveauCompte.Name = "btnAjouterNouveauCompte";
            this.btnAjouterNouveauCompte.Size = new System.Drawing.Size(264, 31);
            this.btnAjouterNouveauCompte.TabIndex = 51;
            this.btnAjouterNouveauCompte.Text = "Ajouter le compte";
            this.btnAjouterNouveauCompte.UseVisualStyleBackColor = false;
            this.btnAjouterNouveauCompte.Click += new System.EventHandler(this.BtnAjouterNouveauCompte_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Nom du compte à ajouter:";
            // 
            // UC_NouveauCompteTresorerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSoldeCompte);
            this.Controls.Add(this.txtNomCompte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAjouterNouveauCompte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UC_NouveauCompteTresorerie";
            this.Size = new System.Drawing.Size(983, 635);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoldeCompte;
        private System.Windows.Forms.TextBox txtNomCompte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAjouterNouveauCompte;
        private System.Windows.Forms.Label label3;
    }
}
