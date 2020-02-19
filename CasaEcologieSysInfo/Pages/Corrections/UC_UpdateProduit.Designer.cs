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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatierePrem = new System.Windows.Forms.TextBox();
            this.BtnMettreMatiereAJour = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxListeMatieres = new System.Windows.Forms.ComboBox();
            this.resStockMatieresPremiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtStockInitialMatiere = new System.Windows.Forms.TextBox();
            this.txtCoutAchatUnitaire = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProduitSemiFini = new System.Windows.Forms.TextBox();
            this.BtnMettreProduitSemiFiniAJour = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxListeProduitsSemiFini = new System.Windows.Forms.ComboBox();
            this.resStockProduitsSemiFiniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtStockInitialProduitSemiFini = new System.Windows.Forms.TextBox();
            this.txtCoutUnitaireProduitSemiFini = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resStockProduitsFiniBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremiereBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resStockProduitsSemiFiniBindingSource)).BeginInit();
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
            this.label8.Location = new System.Drawing.Point(12, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 21);
            this.label8.TabIndex = 63;
            this.label8.Text = "Prix de vente standard";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 36);
            this.label1.TabIndex = 63;
            this.label1.Text = "Veuillez choisir le produit modifier dans la liste ci-dessous";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 252);
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
            this.cbxListeProduits.Location = new System.Drawing.Point(13, 97);
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
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 21);
            this.label6.TabIndex = 63;
            this.label6.Text = "Stock initial (unité)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
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
            this.btnMettreProduitAJour.Location = new System.Drawing.Point(30, 378);
            this.btnMettreProduitAJour.Name = "btnMettreProduitAJour";
            this.btnMettreProduitAJour.Size = new System.Drawing.Size(223, 30);
            this.btnMettreProduitAJour.TabIndex = 4;
            this.btnMettreProduitAJour.Text = "Mettre le produit à jour";
            this.btnMettreProduitAJour.UseVisualStyleBackColor = false;
            this.btnMettreProduitAJour.Click += new System.EventHandler(this.BtnMettreProduitAJour_Click);
            // 
            // txtNomProduit
            // 
            this.txtNomProduit.Location = new System.Drawing.Point(12, 160);
            this.txtNomProduit.Name = "txtNomProduit";
            this.txtNomProduit.ReadOnly = true;
            this.txtNomProduit.Size = new System.Drawing.Size(258, 27);
            this.txtNomProduit.TabIndex = 0;
            // 
            // txtPrixDeVente
            // 
            this.txtPrixDeVente.Location = new System.Drawing.Point(12, 333);
            this.txtPrixDeVente.Name = "txtPrixDeVente";
            this.txtPrixDeVente.Size = new System.Drawing.Size(258, 27);
            this.txtPrixDeVente.TabIndex = 3;
            // 
            // txtStockInitial
            // 
            this.txtStockInitial.Location = new System.Drawing.Point(12, 219);
            this.txtStockInitial.Name = "txtStockInitial";
            this.txtStockInitial.Size = new System.Drawing.Size(258, 27);
            this.txtStockInitial.TabIndex = 1;
            // 
            // txtCoutUnitaire
            // 
            this.txtCoutUnitaire.Location = new System.Drawing.Point(12, 276);
            this.txtCoutUnitaire.Name = "txtCoutUnitaire";
            this.txtCoutUnitaire.Size = new System.Drawing.Size(258, 27);
            this.txtCoutUnitaire.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Moccasin;
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
            this.groupBox1.Location = new System.Drawing.Point(25, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 424);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mettre à jour un produit fini";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Wheat;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMatierePrem);
            this.groupBox2.Controls.Add(this.BtnMettreMatiereAJour);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbxListeMatieres);
            this.groupBox2.Controls.Add(this.txtStockInitialMatiere);
            this.groupBox2.Controls.Add(this.txtCoutAchatUnitaire);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(329, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 424);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mettre à jour une matière première";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 36);
            this.label2.TabIndex = 63;
            this.label2.Text = "Veuillez choisir le fruit, l\'emballage ou l\'étiquette à modifier dans la liste ci" +
    "-dessous";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMatierePrem
            // 
            this.txtMatierePrem.Location = new System.Drawing.Point(24, 160);
            this.txtMatierePrem.Name = "txtMatierePrem";
            this.txtMatierePrem.ReadOnly = true;
            this.txtMatierePrem.Size = new System.Drawing.Size(258, 27);
            this.txtMatierePrem.TabIndex = 0;
            // 
            // BtnMettreMatiereAJour
            // 
            this.BtnMettreMatiereAJour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnMettreMatiereAJour.FlatAppearance.BorderSize = 0;
            this.BtnMettreMatiereAJour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMettreMatiereAJour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMettreMatiereAJour.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMettreMatiereAJour.Location = new System.Drawing.Point(24, 378);
            this.BtnMettreMatiereAJour.Name = "BtnMettreMatiereAJour";
            this.BtnMettreMatiereAJour.Size = new System.Drawing.Size(258, 30);
            this.BtnMettreMatiereAJour.TabIndex = 4;
            this.BtnMettreMatiereAJour.Text = "Mettre la matière à jour";
            this.BtnMettreMatiereAJour.UseVisualStyleBackColor = false;
            this.BtnMettreMatiereAJour.Click += new System.EventHandler(this.BtnMettreMatiereAJour_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 21);
            this.label9.TabIndex = 63;
            this.label9.Text = "Coût unitaire d\'achat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 21);
            this.label10.TabIndex = 63;
            this.label10.Text = "Nom de la matière";
            // 
            // cbxListeMatieres
            // 
            this.cbxListeMatieres.DataSource = this.resStockMatieresPremiereBindingSource;
            this.cbxListeMatieres.DisplayMember = "NomMatiere";
            this.cbxListeMatieres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxListeMatieres.FormattingEnabled = true;
            this.cbxListeMatieres.Location = new System.Drawing.Point(28, 97);
            this.cbxListeMatieres.Name = "cbxListeMatieres";
            this.cbxListeMatieres.Size = new System.Drawing.Size(258, 29);
            this.cbxListeMatieres.TabIndex = 0;
            this.cbxListeMatieres.ValueMember = "CodeMatierePremiere";
            this.cbxListeMatieres.SelectedIndexChanged += new System.EventHandler(this.CbxListeMatieres_SelectedIndexChanged);
            // 
            // resStockMatieresPremiereBindingSource
            // 
            this.resStockMatieresPremiereBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResStockMatieresPremiere);
            // 
            // txtStockInitialMatiere
            // 
            this.txtStockInitialMatiere.Location = new System.Drawing.Point(27, 219);
            this.txtStockInitialMatiere.Name = "txtStockInitialMatiere";
            this.txtStockInitialMatiere.Size = new System.Drawing.Size(258, 27);
            this.txtStockInitialMatiere.TabIndex = 1;
            // 
            // txtCoutAchatUnitaire
            // 
            this.txtCoutAchatUnitaire.Location = new System.Drawing.Point(27, 276);
            this.txtCoutAchatUnitaire.Name = "txtCoutAchatUnitaire";
            this.txtCoutAchatUnitaire.Size = new System.Drawing.Size(258, 27);
            this.txtCoutAchatUnitaire.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 21);
            this.label11.TabIndex = 63;
            this.label11.Text = "Stock initial (unité)";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtProduitSemiFini);
            this.groupBox3.Controls.Add(this.BtnMettreProduitSemiFiniAJour);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cbxListeProduitsSemiFini);
            this.groupBox3.Controls.Add(this.txtStockInitialProduitSemiFini);
            this.groupBox3.Controls.Add(this.txtCoutUnitaireProduitSemiFini);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(667, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 424);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mettre à jour un produit semi fini";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 36);
            this.label5.TabIndex = 63;
            this.label5.Text = "Veuillez choisir le produit semi fini à modifier dans la liste ci-dessous";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProduitSemiFini
            // 
            this.txtProduitSemiFini.Location = new System.Drawing.Point(12, 160);
            this.txtProduitSemiFini.Name = "txtProduitSemiFini";
            this.txtProduitSemiFini.ReadOnly = true;
            this.txtProduitSemiFini.Size = new System.Drawing.Size(258, 27);
            this.txtProduitSemiFini.TabIndex = 0;
            // 
            // BtnMettreProduitSemiFiniAJour
            // 
            this.BtnMettreProduitSemiFiniAJour.BackColor = System.Drawing.Color.Maroon;
            this.BtnMettreProduitSemiFiniAJour.FlatAppearance.BorderSize = 0;
            this.BtnMettreProduitSemiFiniAJour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMettreProduitSemiFiniAJour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMettreProduitSemiFiniAJour.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMettreProduitSemiFiniAJour.Location = new System.Drawing.Point(19, 378);
            this.BtnMettreProduitSemiFiniAJour.Name = "BtnMettreProduitSemiFiniAJour";
            this.BtnMettreProduitSemiFiniAJour.Size = new System.Drawing.Size(258, 30);
            this.BtnMettreProduitSemiFiniAJour.TabIndex = 4;
            this.BtnMettreProduitSemiFiniAJour.Text = "Mettre le produit à jour";
            this.BtnMettreProduitSemiFiniAJour.UseVisualStyleBackColor = false;
            this.BtnMettreProduitSemiFiniAJour.Click += new System.EventHandler(this.BtnMettreProduitSemiFiniAJour_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 21);
            this.label12.TabIndex = 63;
            this.label12.Text = "Coût unitaire";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 21);
            this.label13.TabIndex = 63;
            this.label13.Text = "Nom du produit semi fini";
            // 
            // cbxListeProduitsSemiFini
            // 
            this.cbxListeProduitsSemiFini.DataSource = this.resStockProduitsSemiFiniBindingSource;
            this.cbxListeProduitsSemiFini.DisplayMember = "Description";
            this.cbxListeProduitsSemiFini.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxListeProduitsSemiFini.FormattingEnabled = true;
            this.cbxListeProduitsSemiFini.Location = new System.Drawing.Point(16, 97);
            this.cbxListeProduitsSemiFini.Name = "cbxListeProduitsSemiFini";
            this.cbxListeProduitsSemiFini.Size = new System.Drawing.Size(258, 29);
            this.cbxListeProduitsSemiFini.TabIndex = 0;
            this.cbxListeProduitsSemiFini.ValueMember = "CodeProduitSemiFini";
            this.cbxListeProduitsSemiFini.SelectedIndexChanged += new System.EventHandler(this.CbxListeProduitsSemiFini_SelectedIndexChanged);
            // 
            // resStockProduitsSemiFiniBindingSource
            // 
            this.resStockProduitsSemiFiniBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResStockProduitsSemiFini);
            // 
            // txtStockInitialProduitSemiFini
            // 
            this.txtStockInitialProduitSemiFini.Location = new System.Drawing.Point(15, 219);
            this.txtStockInitialProduitSemiFini.Name = "txtStockInitialProduitSemiFini";
            this.txtStockInitialProduitSemiFini.Size = new System.Drawing.Size(258, 27);
            this.txtStockInitialProduitSemiFini.TabIndex = 1;
            // 
            // txtCoutUnitaireProduitSemiFini
            // 
            this.txtCoutUnitaireProduitSemiFini.Location = new System.Drawing.Point(15, 276);
            this.txtCoutUnitaireProduitSemiFini.Name = "txtCoutUnitaireProduitSemiFini";
            this.txtCoutUnitaireProduitSemiFini.Size = new System.Drawing.Size(258, 27);
            this.txtCoutUnitaireProduitSemiFini.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 21);
            this.label14.TabIndex = 63;
            this.label14.Text = "Stock initial (unité)";
            // 
            // UC_UpdateProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremiereBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resStockProduitsSemiFiniBindingSource)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatierePrem;
        private System.Windows.Forms.Button BtnMettreMatiereAJour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxListeMatieres;
        private System.Windows.Forms.TextBox txtStockInitialMatiere;
        private System.Windows.Forms.TextBox txtCoutAchatUnitaire;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource resStockMatieresPremiereBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProduitSemiFini;
        private System.Windows.Forms.Button BtnMettreProduitSemiFiniAJour;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxListeProduitsSemiFini;
        private System.Windows.Forms.BindingSource resStockProduitsSemiFiniBindingSource;
        private System.Windows.Forms.TextBox txtStockInitialProduitSemiFini;
        private System.Windows.Forms.TextBox txtCoutUnitaireProduitSemiFini;
        private System.Windows.Forms.Label label14;
    }
}
