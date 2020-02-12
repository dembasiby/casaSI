namespace CasaEcologieSysInfo.Pages.Corrections
{
    partial class UC_UpdateProduction
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dgvListeProductions = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMettreProductionAJour = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxProduitFini = new System.Windows.Forms.ComboBox();
            this.txtNombreProduitsFinis = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxEtiquette = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEmballage = new System.Windows.Forms.ComboBox();
            this.cbxFruitUtilise = new System.Windows.Forms.ComboBox();
            this.txtQuantiteSucre = new System.Windows.Forms.TextBox();
            this.txtQuantiteFruit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeProductions)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(562, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mettre à jour les données d\'une séance de production";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "Au";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "Du";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(41, 84);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(227, 27);
            this.dtpFin.TabIndex = 35;
            this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFin_ValueChanged);
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(41, 55);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(227, 27);
            this.dtpDebut.TabIndex = 34;
            this.dtpDebut.ValueChanged += new System.EventHandler(this.DtpDebut_ValueChanged);
            // 
            // dgvListeProductions
            // 
            this.dgvListeProductions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListeProductions.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvListeProductions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListeProductions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeProductions.Location = new System.Drawing.Point(41, 117);
            this.dgvListeProductions.Name = "dgvListeProductions";
            this.dgvListeProductions.ReadOnly = true;
            this.dgvListeProductions.RowHeadersVisible = false;
            this.dgvListeProductions.Size = new System.Drawing.Size(227, 464);
            this.dgvListeProductions.TabIndex = 33;
            this.dgvListeProductions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListeProductions_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.btnMettreProductionAJour);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(293, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 521);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails de la production";
            // 
            // btnMettreProductionAJour
            // 
            this.btnMettreProductionAJour.BackColor = System.Drawing.Color.DarkGray;
            this.btnMettreProductionAJour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMettreProductionAJour.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnMettreProductionAJour.FlatAppearance.BorderSize = 2;
            this.btnMettreProductionAJour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMettreProductionAJour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMettreProductionAJour.Location = new System.Drawing.Point(200, 371);
            this.btnMettreProductionAJour.Name = "btnMettreProductionAJour";
            this.btnMettreProductionAJour.Size = new System.Drawing.Size(290, 39);
            this.btnMettreProductionAJour.TabIndex = 39;
            this.btnMettreProductionAJour.Text = "Mettre la production à jour";
            this.btnMettreProductionAJour.UseVisualStyleBackColor = false;
            this.btnMettreProductionAJour.Click += new System.EventHandler(this.BtnMettreProductionAJour_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cbxProduitFini);
            this.groupBox3.Controls.Add(this.txtNombreProduitsFinis);
            this.groupBox3.Location = new System.Drawing.Point(374, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 268);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Résultats production";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre d\'unités produites";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 21);
            this.label13.TabIndex = 3;
            this.label13.Text = "Produit Fini ou semi fini";
            // 
            // cbxProduitFini
            // 
            this.cbxProduitFini.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProduitFini.FormattingEnabled = true;
            this.cbxProduitFini.Location = new System.Drawing.Point(19, 75);
            this.cbxProduitFini.Name = "cbxProduitFini";
            this.cbxProduitFini.Size = new System.Drawing.Size(224, 29);
            this.cbxProduitFini.TabIndex = 1;
            // 
            // txtNombreProduitsFinis
            // 
            this.txtNombreProduitsFinis.Location = new System.Drawing.Point(19, 143);
            this.txtNombreProduitsFinis.Name = "txtNombreProduitsFinis";
            this.txtNombreProduitsFinis.Size = new System.Drawing.Size(224, 27);
            this.txtNombreProduitsFinis.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbxEtiquette);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbxEmballage);
            this.groupBox2.Controls.Add(this.cbxFruitUtilise);
            this.groupBox2.Controls.Add(this.txtQuantiteSucre);
            this.groupBox2.Controls.Add(this.txtQuantiteFruit);
            this.groupBox2.Location = new System.Drawing.Point(6, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 268);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Intrants utilisés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantité de sucre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Etiquette";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Emballage";
            // 
            // cbxEtiquette
            // 
            this.cbxEtiquette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEtiquette.FormattingEnabled = true;
            this.cbxEtiquette.Location = new System.Drawing.Point(132, 174);
            this.cbxEtiquette.Name = "cbxEtiquette";
            this.cbxEtiquette.Size = new System.Drawing.Size(224, 29);
            this.cbxEtiquette.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fruit ou produit semi fini";
            // 
            // cbxEmballage
            // 
            this.cbxEmballage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmballage.FormattingEnabled = true;
            this.cbxEmballage.Location = new System.Drawing.Point(129, 124);
            this.cbxEmballage.Name = "cbxEmballage";
            this.cbxEmballage.Size = new System.Drawing.Size(224, 29);
            this.cbxEmballage.TabIndex = 1;
            // 
            // cbxFruitUtilise
            // 
            this.cbxFruitUtilise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFruitUtilise.FormattingEnabled = true;
            this.cbxFruitUtilise.Location = new System.Drawing.Point(19, 75);
            this.cbxFruitUtilise.Name = "cbxFruitUtilise";
            this.cbxFruitUtilise.Size = new System.Drawing.Size(242, 29);
            this.cbxFruitUtilise.TabIndex = 1;
            // 
            // txtQuantiteSucre
            // 
            this.txtQuantiteSucre.Location = new System.Drawing.Point(173, 219);
            this.txtQuantiteSucre.Name = "txtQuantiteSucre";
            this.txtQuantiteSucre.Size = new System.Drawing.Size(183, 27);
            this.txtQuantiteSucre.TabIndex = 2;
            // 
            // txtQuantiteFruit
            // 
            this.txtQuantiteFruit.Location = new System.Drawing.Point(267, 77);
            this.txtQuantiteFruit.Name = "txtQuantiteFruit";
            this.txtQuantiteFruit.Size = new System.Drawing.Size(86, 27);
            this.txtQuantiteFruit.TabIndex = 2;
            // 
            // UC_UpdateProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.dgvListeProductions);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_UpdateProduction";
            this.Size = new System.Drawing.Size(983, 596);
            this.Load += new System.EventHandler(this.UC_UpdateProduction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeProductions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DataGridView dgvListeProductions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxProduitFini;
        private System.Windows.Forms.TextBox txtNombreProduitsFinis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxEtiquette;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEmballage;
        private System.Windows.Forms.ComboBox cbxFruitUtilise;
        private System.Windows.Forms.TextBox txtQuantiteSucre;
        private System.Windows.Forms.TextBox txtQuantiteFruit;
        private System.Windows.Forms.Button btnMettreProductionAJour;
    }
}
