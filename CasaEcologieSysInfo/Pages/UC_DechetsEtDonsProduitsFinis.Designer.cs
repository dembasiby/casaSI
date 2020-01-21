namespace CasaEcologieSysInfo.Pages
{
    partial class UC_DechetsEtDonsProduitsFinis
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.cbxResponsableStock = new System.Windows.Forms.ComboBox();
            this.ageEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxProduitsFinis = new System.Windows.Forms.ComboBox();
            this.resStockProduitsFiniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtpDateSortieDechetsOuDons = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.btnEnregistrerSortie = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStockDisponible = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockProduitsFiniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(467, 123);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(234, 30);
            this.txtDescription.TabIndex = 65;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(467, 187);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(234, 30);
            this.txtQuantite.TabIndex = 66;
            // 
            // cbxResponsableStock
            // 
            this.cbxResponsableStock.DataSource = this.ageEmployeBindingSource;
            this.cbxResponsableStock.DisplayMember = "PrenomNom";
            this.cbxResponsableStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxResponsableStock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxResponsableStock.FormattingEnabled = true;
            this.cbxResponsableStock.Location = new System.Drawing.Point(467, 259);
            this.cbxResponsableStock.Name = "cbxResponsableStock";
            this.cbxResponsableStock.Size = new System.Drawing.Size(234, 25);
            this.cbxResponsableStock.TabIndex = 55;
            this.cbxResponsableStock.ValueMember = "CodeEmploye";
            // 
            // ageEmployeBindingSource
            // 
            this.ageEmployeBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 59;
            this.label5.Text = "Quantité (unité)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Responsable du stock";
            // 
            // cbxProduitsFinis
            // 
            this.cbxProduitsFinis.DataSource = this.resStockProduitsFiniBindingSource;
            this.cbxProduitsFinis.DisplayMember = "NomProduit";
            this.cbxProduitsFinis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProduitsFinis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProduitsFinis.FormattingEnabled = true;
            this.cbxProduitsFinis.Location = new System.Drawing.Point(467, 158);
            this.cbxProduitsFinis.Name = "cbxProduitsFinis";
            this.cbxProduitsFinis.Size = new System.Drawing.Size(234, 25);
            this.cbxProduitsFinis.TabIndex = 57;
            this.cbxProduitsFinis.ValueMember = "CodeProduit";
            this.cbxProduitsFinis.SelectedIndexChanged += new System.EventHandler(this.CbxProduitsFinis_SelectedIndexChanged);
            // 
            // resStockProduitsFiniBindingSource
            // 
            this.resStockProduitsFiniBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResStockProduitsFini);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Produit Fini";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(302, 127);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 17);
            this.lblDescription.TabIndex = 63;
            this.lblDescription.Text = "Description";
            // 
            // dtpDateSortieDechetsOuDons
            // 
            this.dtpDateSortieDechetsOuDons.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateSortieDechetsOuDons.Location = new System.Drawing.Point(467, 93);
            this.dtpDateSortieDechetsOuDons.Name = "dtpDateSortieDechetsOuDons";
            this.dtpDateSortieDechetsOuDons.Size = new System.Drawing.Size(234, 23);
            this.dtpDateSortieDechetsOuDons.TabIndex = 64;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(292, 96);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 18);
            this.label21.TabIndex = 58;
            this.label21.Text = "Date opération";
            // 
            // btnEnregistrerSortie
            // 
            this.btnEnregistrerSortie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(31)))), ((int)(((byte)(20)))));
            this.btnEnregistrerSortie.FlatAppearance.BorderSize = 0;
            this.btnEnregistrerSortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrerSortie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerSortie.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnregistrerSortie.Location = new System.Drawing.Point(467, 295);
            this.btnEnregistrerSortie.Name = "btnEnregistrerSortie";
            this.btnEnregistrerSortie.Size = new System.Drawing.Size(234, 31);
            this.btnEnregistrerSortie.TabIndex = 54;
            this.btnEnregistrerSortie.Text = "Enregistrer la sortie";
            this.btnEnregistrerSortie.UseVisualStyleBackColor = false;
            this.btnEnregistrerSortie.Click += new System.EventHandler(this.BtnEnregistrerSortie_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(438, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "Sortie de déchets ou dons de produits finis";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Stock Disponible (unité)";
            // 
            // txtStockDisponible
            // 
            this.txtStockDisponible.Location = new System.Drawing.Point(467, 223);
            this.txtStockDisponible.Name = "txtStockDisponible";
            this.txtStockDisponible.Size = new System.Drawing.Size(234, 30);
            this.txtStockDisponible.TabIndex = 66;
            // 
            // UC_DechetsEtDonsProduitsFinis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtStockDisponible);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.cbxResponsableStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxProduitsFinis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dtpDateSortieDechetsOuDons);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnEnregistrerSortie);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_DechetsEtDonsProduitsFinis";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_DechetsEtDonsProduitsFinis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockProduitsFiniBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.ComboBox cbxResponsableStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxProduitsFinis;
        private System.Windows.Forms.BindingSource resStockProduitsFiniBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker dtpDateSortieDechetsOuDons;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnEnregistrerSortie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStockDisponible;
    }
}
