namespace CasaEcologieSysInfo.Pages.Corrections
{
    partial class UC_UpdateProduit
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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxListeProduits = new System.Windows.Forms.ComboBox();
            this.resStockProduitsFiniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMettreProduitAJour = new System.Windows.Forms.Button();
            this.txtNomProduit = new System.Windows.Forms.TextBox();
            this.txtPrixDeVente = new System.Windows.Forms.TextBox();
            this.txtStockInitial = new System.Windows.Forms.TextBox();
            this.txtCoutUnitaire = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.resStockProduitsFiniBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Mettre à jour  un produit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 21);
            this.label8.TabIndex = 63;
            this.label8.Text = "Prix de vente standard";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 36);
            this.label1.TabIndex = 63;
            this.label1.Text = "Veuillez choisir le produit modifier dans la liste ci-dessous";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 21);
            this.label7.TabIndex = 63;
            this.label7.Text = "Coût unitaire de production";
            // 
            // cbxListeProduits
            // 
            this.cbxListeProduits.DataSource = this.resStockProduitsFiniBindingSource;
            this.cbxListeProduits.DisplayMember = "NomProduit";
            this.cbxListeProduits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxListeProduits.FormattingEnabled = true;
            this.cbxListeProduits.Location = new System.Drawing.Point(112, 62);
            this.cbxListeProduits.Name = "cbxListeProduits";
            this.cbxListeProduits.Size = new System.Drawing.Size(258, 29);
            this.cbxListeProduits.TabIndex = 0;
            this.cbxListeProduits.ValueMember = "CodeProduit";
            this.cbxListeProduits.SelectedIndexChanged += new System.EventHandler(this.CbxListeProduits_SelectedIndexChanged);
            // 
            // resStockProduitsFiniBindingSource
            // 
            this.resStockProduitsFiniBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResStockProduitsFini);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 21);
            this.label6.TabIndex = 63;
            this.label6.Text = "Stock initial (unité)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 63;
            this.label3.Text = "Nom du produit";
            // 
            // btnMettreProduitAJour
            // 
            this.btnMettreProduitAJour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnMettreProduitAJour.FlatAppearance.BorderSize = 0;
            this.btnMettreProduitAJour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMettreProduitAJour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMettreProduitAJour.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMettreProduitAJour.Location = new System.Drawing.Point(129, 364);
            this.btnMettreProduitAJour.Name = "btnMettreProduitAJour";
            this.btnMettreProduitAJour.Size = new System.Drawing.Size(223, 30);
            this.btnMettreProduitAJour.TabIndex = 4;
            this.btnMettreProduitAJour.Text = "Mettre le produit à jour";
            this.btnMettreProduitAJour.UseVisualStyleBackColor = false;
            this.btnMettreProduitAJour.Click += new System.EventHandler(this.BtnMettreProduitAJour_Click);
            // 
            // txtNomProduit
            // 
            this.txtNomProduit.Location = new System.Drawing.Point(111, 146);
            this.txtNomProduit.Name = "txtNomProduit";
            this.txtNomProduit.Size = new System.Drawing.Size(258, 27);
            this.txtNomProduit.TabIndex = 0;
            // 
            // txtPrixDeVente
            // 
            this.txtPrixDeVente.Location = new System.Drawing.Point(111, 319);
            this.txtPrixDeVente.Name = "txtPrixDeVente";
            this.txtPrixDeVente.Size = new System.Drawing.Size(258, 27);
            this.txtPrixDeVente.TabIndex = 3;
            // 
            // txtStockInitial
            // 
            this.txtStockInitial.Location = new System.Drawing.Point(111, 205);
            this.txtStockInitial.Name = "txtStockInitial";
            this.txtStockInitial.Size = new System.Drawing.Size(258, 27);
            this.txtStockInitial.TabIndex = 1;
            // 
            // txtCoutUnitaire
            // 
            this.txtCoutUnitaire.Location = new System.Drawing.Point(111, 262);
            this.txtCoutUnitaire.Name = "txtCoutUnitaire";
            this.txtCoutUnitaire.Size = new System.Drawing.Size(258, 27);
            this.txtCoutUnitaire.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNomProduit);
            this.groupBox1.Controls.Add(this.btnMettreProduitAJour);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPrixDeVente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxListeProduits);
            this.groupBox1.Controls.Add(this.txtStockInitial);
            this.groupBox1.Controls.Add(this.txtCoutUnitaire);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(224, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 424);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            // 
            // UC_UpdateProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_UpdateProduit";
            this.Size = new System.Drawing.Size(983, 596);
            this.Load += new System.EventHandler(this.UC_UpdateVentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resStockProduitsFiniBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxListeProduits;
        private System.Windows.Forms.BindingSource resStockProduitsFiniBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrixDeVente;
        private System.Windows.Forms.TextBox txtCoutUnitaire;
        private System.Windows.Forms.TextBox txtStockInitial;
        private System.Windows.Forms.TextBox txtNomProduit;
        private System.Windows.Forms.Button btnMettreProduitAJour;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
