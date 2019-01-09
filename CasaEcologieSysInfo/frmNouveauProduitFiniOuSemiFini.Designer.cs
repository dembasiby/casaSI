namespace CasaEcologieSysInfo
{
    partial class frmNouveauProduitFiniOuSemiFini
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gBxNouveauProduit = new System.Windows.Forms.GroupBox();
            this.cbxNomMatiereP = new System.Windows.Forms.ComboBox();
            this.resStockMatieresPremiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAjouterNouveauProduitFiniOuSFini = new System.Windows.Forms.Button();
            this.txtPrixDeVente = new System.Windows.Forms.TextBox();
            this.txtStockInitialProduitFini = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomProduitSemiFini = new System.Windows.Forms.TextBox();
            this.txtNomProduitFini = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gBxNouveauProduit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremiereBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gBxNouveauProduit
            // 
            this.gBxNouveauProduit.Controls.Add(this.cbxNomMatiereP);
            this.gBxNouveauProduit.Controls.Add(this.btnQuitter);
            this.gBxNouveauProduit.Controls.Add(this.btnAjouterNouveauProduitFiniOuSFini);
            this.gBxNouveauProduit.Controls.Add(this.txtPrixDeVente);
            this.gBxNouveauProduit.Controls.Add(this.txtStockInitialProduitFini);
            this.gBxNouveauProduit.Controls.Add(this.label27);
            this.gBxNouveauProduit.Controls.Add(this.label9);
            this.gBxNouveauProduit.Controls.Add(this.txtNomProduitSemiFini);
            this.gBxNouveauProduit.Controls.Add(this.txtNomProduitFini);
            this.gBxNouveauProduit.Controls.Add(this.label10);
            this.gBxNouveauProduit.Controls.Add(this.label6);
            this.gBxNouveauProduit.Controls.Add(this.label2);
            this.gBxNouveauProduit.Controls.Add(this.label23);
            this.gBxNouveauProduit.Controls.Add(this.label4);
            this.gBxNouveauProduit.Controls.Add(this.label7);
            this.gBxNouveauProduit.Controls.Add(this.label3);
            this.gBxNouveauProduit.Controls.Add(this.label5);
            this.gBxNouveauProduit.Controls.Add(this.label1);
            this.gBxNouveauProduit.Controls.Add(this.label11);
            this.gBxNouveauProduit.Controls.Add(this.label12);
            this.gBxNouveauProduit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxNouveauProduit.Location = new System.Drawing.Point(12, 21);
            this.gBxNouveauProduit.Name = "gBxNouveauProduit";
            this.gBxNouveauProduit.Size = new System.Drawing.Size(522, 350);
            this.gBxNouveauProduit.TabIndex = 27;
            this.gBxNouveauProduit.TabStop = false;
            this.gBxNouveauProduit.Text = "Produit ne figurant pas dans la liste des produits finis ou semi-finis";
            // 
            // cbxNomMatiereP
            // 
            this.cbxNomMatiereP.DataSource = this.resStockMatieresPremiereBindingSource;
            this.cbxNomMatiereP.DisplayMember = "NomMatiere";
            this.cbxNomMatiereP.FormattingEnabled = true;
            this.cbxNomMatiereP.Location = new System.Drawing.Point(165, 165);
            this.cbxNomMatiereP.Name = "cbxNomMatiereP";
            this.cbxNomMatiereP.Size = new System.Drawing.Size(251, 29);
            this.cbxNomMatiereP.TabIndex = 8;
            // 
            // resStockMatieresPremiereBindingSource
            // 
            this.resStockMatieresPremiereBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResStockMatieresPremiere);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitter.Location = new System.Drawing.Point(246, 320);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(170, 24);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            // 
            // btnAjouterNouveauProduitFiniOuSFini
            // 
            this.btnAjouterNouveauProduitFiniOuSFini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(31)))), ((int)(((byte)(20)))));
            this.btnAjouterNouveauProduitFiniOuSFini.FlatAppearance.BorderSize = 0;
            this.btnAjouterNouveauProduitFiniOuSFini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterNouveauProduitFiniOuSFini.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterNouveauProduitFiniOuSFini.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAjouterNouveauProduitFiniOuSFini.Location = new System.Drawing.Point(22, 320);
            this.btnAjouterNouveauProduitFiniOuSFini.Name = "btnAjouterNouveauProduitFiniOuSFini";
            this.btnAjouterNouveauProduitFiniOuSFini.Size = new System.Drawing.Size(170, 24);
            this.btnAjouterNouveauProduitFiniOuSFini.TabIndex = 4;
            this.btnAjouterNouveauProduitFiniOuSFini.Text = "Ajouter le produit";
            this.btnAjouterNouveauProduitFiniOuSFini.UseVisualStyleBackColor = false;
            this.btnAjouterNouveauProduitFiniOuSFini.Click += new System.EventHandler(this.BtnAjouterNouveauProduitFiniOuSFini_Click);
            // 
            // txtPrixDeVente
            // 
            this.txtPrixDeVente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixDeVente.Location = new System.Drawing.Point(165, 114);
            this.txtPrixDeVente.Name = "txtPrixDeVente";
            this.txtPrixDeVente.Size = new System.Drawing.Size(251, 23);
            this.txtPrixDeVente.TabIndex = 1;
            this.txtPrixDeVente.Text = "00";
            // 
            // txtStockInitialProduitFini
            // 
            this.txtStockInitialProduitFini.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockInitialProduitFini.Location = new System.Drawing.Point(165, 283);
            this.txtStockInitialProduitFini.Name = "txtStockInitialProduitFini";
            this.txtStockInitialProduitFini.Size = new System.Drawing.Size(251, 23);
            this.txtStockInitialProduitFini.TabIndex = 3;
            this.txtStockInitialProduitFini.Text = "00";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(13, 123);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(91, 17);
            this.label27.TabIndex = 5;
            this.label27.Text = "Prix de vente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Stock initial";
            // 
            // txtNomProduitSemiFini
            // 
            this.txtNomProduitSemiFini.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProduitSemiFini.Location = new System.Drawing.Point(165, 229);
            this.txtNomProduitSemiFini.Name = "txtNomProduitSemiFini";
            this.txtNomProduitSemiFini.Size = new System.Drawing.Size(251, 23);
            this.txtNomProduitSemiFini.TabIndex = 2;
            // 
            // txtNomProduitFini
            // 
            this.txtNomProduitFini.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProduitFini.Location = new System.Drawing.Point(165, 87);
            this.txtNomProduitFini.Name = "txtNomProduitFini";
            this.txtNomProduitFini.Size = new System.Drawing.Size(251, 23);
            this.txtNomProduitFini.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Matière première";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom produit semi-fini";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(7, 40);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 17);
            this.label23.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(13, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pour l\'un ou l\'autre, veuillez mettre le stock initial en kg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(13, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "du produit semi-fini";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(13, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(448, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Veuillez mettre une description indiquant le nom du fruit et la nature";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(403, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Veuillez remplir le champs ci-dessous s\'il s\'agit d\'un produit fini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Veuillez remplir le champs ci-dessous s\'il s\'agit d\'un produit semi-fini";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(497, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Veuillez enregistrer le produit ou le produit semi fini s\'il n\'est pas sur la lis" +
    "te";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Produit fini";
            // 
            // frmNouveauProduitFiniOuSemiFini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(546, 383);
            this.Controls.Add(this.gBxNouveauProduit);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNouveauProduitFiniOuSemiFini";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'un Nouveau Produit Fini ou Semi-Fini";
            this.Load += new System.EventHandler(this.frmNouveauProduitFiniOuSemiFini_Load);
            this.gBxNouveauProduit.ResumeLayout(false);
            this.gBxNouveauProduit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremiereBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBxNouveauProduit;
        private System.Windows.Forms.Button btnAjouterNouveauProduitFiniOuSFini;
        private System.Windows.Forms.TextBox txtPrixDeVente;
        private System.Windows.Forms.TextBox txtStockInitialProduitFini;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomProduitSemiFini;
        private System.Windows.Forms.TextBox txtNomProduitFini;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ComboBox cbxNomMatiereP;
        private System.Windows.Forms.BindingSource resStockMatieresPremiereBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}