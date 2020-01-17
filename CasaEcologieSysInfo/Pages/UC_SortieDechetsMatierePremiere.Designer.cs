namespace CasaEcologieSysInfo.Pages
{
    partial class UC_SortieDechetsMatierePremiere
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
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.cbxResponsableStock = new System.Windows.Forms.ComboBox();
            this.ageEmployeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbxEmployeAyantRecuLesDechets = new System.Windows.Forms.ComboBox();
            this.ageEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMatierePremiere = new System.Windows.Forms.ComboBox();
            this.resStockMatieresPremiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtpDateSortieDechets = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.btnEnregistrerSortie = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremiereBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(457, 196);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(234, 27);
            this.txtQuantite.TabIndex = 52;
            // 
            // cbxResponsableStock
            // 
            this.cbxResponsableStock.DataSource = this.ageEmployeBindingSource1;
            this.cbxResponsableStock.DisplayMember = "PrenomNom";
            this.cbxResponsableStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxResponsableStock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxResponsableStock.FormattingEnabled = true;
            this.cbxResponsableStock.Location = new System.Drawing.Point(457, 227);
            this.cbxResponsableStock.Name = "cbxResponsableStock";
            this.cbxResponsableStock.Size = new System.Drawing.Size(234, 25);
            this.cbxResponsableStock.TabIndex = 41;
            this.cbxResponsableStock.ValueMember = "CodeEmploye";
            // 
            // ageEmployeBindingSource1
            // 
            this.ageEmployeBindingSource1.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // cbxEmployeAyantRecuLesDechets
            // 
            this.cbxEmployeAyantRecuLesDechets.DataSource = this.ageEmployeBindingSource;
            this.cbxEmployeAyantRecuLesDechets.DisplayMember = "PrenomNom";
            this.cbxEmployeAyantRecuLesDechets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmployeAyantRecuLesDechets.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmployeAyantRecuLesDechets.FormattingEnabled = true;
            this.cbxEmployeAyantRecuLesDechets.Location = new System.Drawing.Point(457, 260);
            this.cbxEmployeAyantRecuLesDechets.Name = "cbxEmployeAyantRecuLesDechets";
            this.cbxEmployeAyantRecuLesDechets.Size = new System.Drawing.Size(234, 25);
            this.cbxEmployeAyantRecuLesDechets.TabIndex = 42;
            this.cbxEmployeAyantRecuLesDechets.ValueMember = "CodeEmploye";
            // 
            // ageEmployeBindingSource
            // 
            this.ageEmployeBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Quantité (kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Responsable du stock";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 38);
            this.label2.TabIndex = 48;
            this.label2.Text = "Employé ayant reçu les déchets";
            // 
            // cbxMatierePremiere
            // 
            this.cbxMatierePremiere.DataSource = this.resStockMatieresPremiereBindingSource;
            this.cbxMatierePremiere.DisplayMember = "NomMatiere";
            this.cbxMatierePremiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatierePremiere.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMatierePremiere.FormattingEnabled = true;
            this.cbxMatierePremiere.Location = new System.Drawing.Point(457, 165);
            this.cbxMatierePremiere.Name = "cbxMatierePremiere";
            this.cbxMatierePremiere.Size = new System.Drawing.Size(234, 25);
            this.cbxMatierePremiere.TabIndex = 43;
            this.cbxMatierePremiere.ValueMember = "CodeMatierePremiere";
            // 
            // resStockMatieresPremiereBindingSource
            // 
            this.resStockMatieresPremiereBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResStockMatieresPremiere);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Matière première";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(306, 136);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 17);
            this.lblDescription.TabIndex = 50;
            this.lblDescription.Text = "Description";
            // 
            // dtpDateSortieDechets
            // 
            this.dtpDateSortieDechets.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateSortieDechets.Location = new System.Drawing.Point(457, 102);
            this.dtpDateSortieDechets.Name = "dtpDateSortieDechets";
            this.dtpDateSortieDechets.Size = new System.Drawing.Size(234, 23);
            this.dtpDateSortieDechets.TabIndex = 51;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(296, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 18);
            this.label21.TabIndex = 45;
            this.label21.Text = "Date opération";
            // 
            // btnEnregistrerSortie
            // 
            this.btnEnregistrerSortie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(31)))), ((int)(((byte)(20)))));
            this.btnEnregistrerSortie.FlatAppearance.BorderSize = 0;
            this.btnEnregistrerSortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrerSortie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerSortie.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnregistrerSortie.Location = new System.Drawing.Point(457, 301);
            this.btnEnregistrerSortie.Name = "btnEnregistrerSortie";
            this.btnEnregistrerSortie.Size = new System.Drawing.Size(234, 31);
            this.btnEnregistrerSortie.TabIndex = 40;
            this.btnEnregistrerSortie.Text = "Enregistrer la sortie";
            this.btnEnregistrerSortie.UseVisualStyleBackColor = false;
            this.btnEnregistrerSortie.Click += new System.EventHandler(this.BtnEnregistrerSortie_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(420, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Sortie de déchets de matières premières";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(457, 132);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(234, 27);
            this.txtDescription.TabIndex = 52;
            // 
            // UC_SortieDechetsMatierePremiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.cbxResponsableStock);
            this.Controls.Add(this.cbxEmployeAyantRecuLesDechets);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxMatierePremiere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dtpDateSortieDechets);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnEnregistrerSortie);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_SortieDechetsMatierePremiere";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_SortieDechetsMatierePremiere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremiereBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.ComboBox cbxResponsableStock;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource1;
        private System.Windows.Forms.ComboBox cbxEmployeAyantRecuLesDechets;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMatierePremiere;
        private System.Windows.Forms.BindingSource resStockMatieresPremiereBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker dtpDateSortieDechets;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnEnregistrerSortie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
    }
}
