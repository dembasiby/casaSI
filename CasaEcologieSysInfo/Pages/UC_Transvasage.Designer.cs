namespace CasaEcologieSysInfo.Pages
{
    partial class UC_Transvasage
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
            this.btnTransvaser = new System.Windows.Forms.Button();
            this.cbxEmballageInitial = new System.Windows.Forms.ComboBox();
            this.p = new System.Windows.Forms.Label();
            this.dtpDateTransvasage = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEmballageFinal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProduitInitial = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantiteATransvaser = new System.Windows.Forms.TextBox();
            this.cbxProduitFinal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(495, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Opération de transvasage de bouteille en verre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTransvaser
            // 
            this.btnTransvaser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(31)))), ((int)(((byte)(20)))));
            this.btnTransvaser.FlatAppearance.BorderSize = 0;
            this.btnTransvaser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransvaser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransvaser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransvaser.Location = new System.Drawing.Point(377, 286);
            this.btnTransvaser.Name = "btnTransvaser";
            this.btnTransvaser.Size = new System.Drawing.Size(329, 31);
            this.btnTransvaser.TabIndex = 32;
            this.btnTransvaser.Text = "Procéder au transvasage";
            this.btnTransvaser.UseVisualStyleBackColor = false;
            this.btnTransvaser.Click += new System.EventHandler(this.BtnTransvaser_Click);
            // 
            // cbxEmballageInitial
            // 
            this.cbxEmballageInitial.DisplayMember = "NomMatiere";
            this.cbxEmballageInitial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmballageInitial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmballageInitial.FormattingEnabled = true;
            this.cbxEmballageInitial.Location = new System.Drawing.Point(472, 128);
            this.cbxEmballageInitial.Name = "cbxEmballageInitial";
            this.cbxEmballageInitial.Size = new System.Drawing.Size(234, 25);
            this.cbxEmballageInitial.TabIndex = 34;
            this.cbxEmballageInitial.ValueMember = "CodeMatierePremiere";
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.Location = new System.Drawing.Point(321, 131);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(116, 17);
            this.p.TabIndex = 36;
            this.p.Text = "Emballage initial";
            // 
            // dtpDateTransvasage
            // 
            this.dtpDateTransvasage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTransvasage.Location = new System.Drawing.Point(472, 97);
            this.dtpDateTransvasage.Name = "dtpDateTransvasage";
            this.dtpDateTransvasage.Size = new System.Drawing.Size(234, 23);
            this.dtpDateTransvasage.TabIndex = 37;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(311, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 18);
            this.label21.TabIndex = 35;
            this.label21.Text = "Date opération";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Emballage final";
            // 
            // cbxEmballageFinal
            // 
            this.cbxEmballageFinal.DisplayMember = "NomMatiere";
            this.cbxEmballageFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmballageFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmballageFinal.FormattingEnabled = true;
            this.cbxEmballageFinal.Location = new System.Drawing.Point(472, 160);
            this.cbxEmballageFinal.Name = "cbxEmballageFinal";
            this.cbxEmballageFinal.Size = new System.Drawing.Size(234, 25);
            this.cbxEmballageFinal.TabIndex = 34;
            this.cbxEmballageFinal.ValueMember = "CodeMatierePremiere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Produit initial";
            // 
            // cbxProduitInitial
            // 
            this.cbxProduitInitial.DisplayMember = "NomMatiere";
            this.cbxProduitInitial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProduitInitial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProduitInitial.FormattingEnabled = true;
            this.cbxProduitInitial.Location = new System.Drawing.Point(472, 191);
            this.cbxProduitInitial.Name = "cbxProduitInitial";
            this.cbxProduitInitial.Size = new System.Drawing.Size(234, 25);
            this.cbxProduitInitial.TabIndex = 34;
            this.cbxProduitInitial.ValueMember = "CodeMatierePremiere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Produit final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Quantité à transvaser";
            // 
            // txtQuantiteATransvaser
            // 
            this.txtQuantiteATransvaser.Location = new System.Drawing.Point(472, 253);
            this.txtQuantiteATransvaser.Name = "txtQuantiteATransvaser";
            this.txtQuantiteATransvaser.Size = new System.Drawing.Size(234, 27);
            this.txtQuantiteATransvaser.TabIndex = 38;
            // 
            // cbxProduitFinal
            // 
            this.cbxProduitFinal.DisplayMember = "NomMatiere";
            this.cbxProduitFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProduitFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProduitFinal.FormattingEnabled = true;
            this.cbxProduitFinal.Location = new System.Drawing.Point(472, 222);
            this.cbxProduitFinal.Name = "cbxProduitFinal";
            this.cbxProduitFinal.Size = new System.Drawing.Size(234, 25);
            this.cbxProduitFinal.TabIndex = 34;
            this.cbxProduitFinal.ValueMember = "CodeMatierePremiere";
            // 
            // UC_Transvasage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtQuantiteATransvaser);
            this.Controls.Add(this.cbxProduitFinal);
            this.Controls.Add(this.cbxProduitInitial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxEmballageFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEmballageInitial);
            this.Controls.Add(this.p);
            this.Controls.Add(this.dtpDateTransvasage);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnTransvaser);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UC_Transvasage";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_Transvasage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTransvaser;
        private System.Windows.Forms.ComboBox cbxEmballageInitial;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.DateTimePicker dtpDateTransvasage;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEmballageFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxProduitInitial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantiteATransvaser;
        private System.Windows.Forms.ComboBox cbxProduitFinal;
    }
}
