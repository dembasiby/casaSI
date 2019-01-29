namespace CasaEcologieSysInfo.Pages
{
    partial class UC_JournalProduction
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvJoursEtCodeProduction = new System.Windows.Forms.DataGridView();
            this.grbIntrants = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvwIntrantProduitSemiFini = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwIntrantMatierePremiere = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbResultat = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvwExtrantProduitSemiFini = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lvwExtrantProduitFini = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbRessourcesHumaines = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lvwRessourcesHumaines = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJoursEtCodeProduction)).BeginInit();
            this.grbIntrants.SuspendLayout();
            this.grbResultat.SuspendLayout();
            this.grbRessourcesHumaines.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Journal de Production";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvJoursEtCodeProduction
            // 
            this.dgvJoursEtCodeProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvJoursEtCodeProduction.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvJoursEtCodeProduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJoursEtCodeProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJoursEtCodeProduction.Location = new System.Drawing.Point(50, 145);
            this.dgvJoursEtCodeProduction.Name = "dgvJoursEtCodeProduction";
            this.dgvJoursEtCodeProduction.ReadOnly = true;
            this.dgvJoursEtCodeProduction.RowHeadersVisible = false;
            this.dgvJoursEtCodeProduction.Size = new System.Drawing.Size(155, 438);
            this.dgvJoursEtCodeProduction.TabIndex = 16;
            this.dgvJoursEtCodeProduction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvJoursEtCodeProduction_CellClick);
            // 
            // grbIntrants
            // 
            this.grbIntrants.Controls.Add(this.label3);
            this.grbIntrants.Controls.Add(this.label2);
            this.grbIntrants.Controls.Add(this.lvwIntrantProduitSemiFini);
            this.grbIntrants.Controls.Add(this.lvwIntrantMatierePremiere);
            this.grbIntrants.Location = new System.Drawing.Point(251, 87);
            this.grbIntrants.Name = "grbIntrants";
            this.grbIntrants.Size = new System.Drawing.Size(472, 244);
            this.grbIntrants.TabIndex = 17;
            this.grbIntrants.TabStop = false;
            this.grbIntrants.Text = "Intrants utilisés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Produits semi-finis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matières premières";
            // 
            // lvwIntrantProduitSemiFini
            // 
            this.lvwIntrantProduitSemiFini.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvwIntrantProduitSemiFini.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwIntrantProduitSemiFini.Location = new System.Drawing.Point(237, 39);
            this.lvwIntrantProduitSemiFini.Name = "lvwIntrantProduitSemiFini";
            this.lvwIntrantProduitSemiFini.Size = new System.Drawing.Size(229, 198);
            this.lvwIntrantProduitSemiFini.TabIndex = 0;
            this.lvwIntrantProduitSemiFini.UseCompatibleStateImageBehavior = false;
            this.lvwIntrantProduitSemiFini.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Produit semi-fini";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantité";
            this.columnHeader4.Width = 75;
            // 
            // lvwIntrantMatierePremiere
            // 
            this.lvwIntrantMatierePremiere.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwIntrantMatierePremiere.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwIntrantMatierePremiere.Location = new System.Drawing.Point(6, 40);
            this.lvwIntrantMatierePremiere.Name = "lvwIntrantMatierePremiere";
            this.lvwIntrantMatierePremiere.Size = new System.Drawing.Size(225, 198);
            this.lvwIntrantMatierePremiere.TabIndex = 0;
            this.lvwIntrantMatierePremiere.UseCompatibleStateImageBehavior = false;
            this.lvwIntrantMatierePremiere.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Matière première";
            this.columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantité";
            this.columnHeader2.Width = 65;
            // 
            // grbResultat
            // 
            this.grbResultat.Controls.Add(this.label5);
            this.grbResultat.Controls.Add(this.lvwExtrantProduitSemiFini);
            this.grbResultat.Controls.Add(this.label4);
            this.grbResultat.Controls.Add(this.lvwExtrantProduitFini);
            this.grbResultat.Location = new System.Drawing.Point(251, 346);
            this.grbResultat.Name = "grbResultat";
            this.grbResultat.Size = new System.Drawing.Size(714, 244);
            this.grbResultat.TabIndex = 17;
            this.grbResultat.TabStop = false;
            this.grbResultat.Text = "Résultat de la production";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Produits semi-finis";
            // 
            // lvwExtrantProduitSemiFini
            // 
            this.lvwExtrantProduitSemiFini.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lvwExtrantProduitSemiFini.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwExtrantProduitSemiFini.Location = new System.Drawing.Point(391, 40);
            this.lvwExtrantProduitSemiFini.Name = "lvwExtrantProduitSemiFini";
            this.lvwExtrantProduitSemiFini.Size = new System.Drawing.Size(309, 198);
            this.lvwExtrantProduitSemiFini.TabIndex = 0;
            this.lvwExtrantProduitSemiFini.UseCompatibleStateImageBehavior = false;
            this.lvwExtrantProduitSemiFini.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Produit semi-fini";
            this.columnHeader7.Width = 235;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Quantité";
            this.columnHeader8.Width = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Produits finis";
            // 
            // lvwExtrantProduitFini
            // 
            this.lvwExtrantProduitFini.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvwExtrantProduitFini.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwExtrantProduitFini.Location = new System.Drawing.Point(16, 40);
            this.lvwExtrantProduitFini.Name = "lvwExtrantProduitFini";
            this.lvwExtrantProduitFini.Size = new System.Drawing.Size(369, 198);
            this.lvwExtrantProduitFini.TabIndex = 0;
            this.lvwExtrantProduitFini.UseCompatibleStateImageBehavior = false;
            this.lvwExtrantProduitFini.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Produit fini";
            this.columnHeader5.Width = 295;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quantité";
            this.columnHeader6.Width = 70;
            // 
            // grbRessourcesHumaines
            // 
            this.grbRessourcesHumaines.Controls.Add(this.label6);
            this.grbRessourcesHumaines.Controls.Add(this.lvwRessourcesHumaines);
            this.grbRessourcesHumaines.Location = new System.Drawing.Point(729, 87);
            this.grbRessourcesHumaines.Name = "grbRessourcesHumaines";
            this.grbRessourcesHumaines.Size = new System.Drawing.Size(242, 244);
            this.grbRessourcesHumaines.TabIndex = 17;
            this.grbRessourcesHumaines.TabStop = false;
            this.grbRessourcesHumaines.Text = "Ressources humaines";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 35);
            this.label6.TabIndex = 1;
            this.label6.Text = "Employés ayant participé à la production";
            // 
            // lvwRessourcesHumaines
            // 
            this.lvwRessourcesHumaines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9});
            this.lvwRessourcesHumaines.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwRessourcesHumaines.Location = new System.Drawing.Point(6, 58);
            this.lvwRessourcesHumaines.Name = "lvwRessourcesHumaines";
            this.lvwRessourcesHumaines.Size = new System.Drawing.Size(230, 180);
            this.lvwRessourcesHumaines.TabIndex = 0;
            this.lvwRessourcesHumaines.UseCompatibleStateImageBehavior = false;
            this.lvwRessourcesHumaines.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Prénom et Nom";
            this.columnHeader9.Width = 225;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(50, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 23);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(50, 116);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(155, 23);
            this.dateTimePicker2.TabIndex = 19;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Du";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Au";
            // 
            // UC_JournalProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.grbResultat);
            this.Controls.Add(this.grbRessourcesHumaines);
            this.Controls.Add(this.grbIntrants);
            this.Controls.Add(this.dgvJoursEtCodeProduction);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_JournalProduction";
            this.Size = new System.Drawing.Size(983, 596);
            this.Load += new System.EventHandler(this.UC_JournalProduction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJoursEtCodeProduction)).EndInit();
            this.grbIntrants.ResumeLayout(false);
            this.grbIntrants.PerformLayout();
            this.grbResultat.ResumeLayout(false);
            this.grbResultat.PerformLayout();
            this.grbRessourcesHumaines.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvJoursEtCodeProduction;
        private System.Windows.Forms.GroupBox grbIntrants;
        private System.Windows.Forms.GroupBox grbResultat;
        private System.Windows.Forms.GroupBox grbRessourcesHumaines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwIntrantProduitSemiFini;
        private System.Windows.Forms.ListView lvwIntrantMatierePremiere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvwExtrantProduitSemiFini;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwExtrantProduitFini;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvwRessourcesHumaines;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}
