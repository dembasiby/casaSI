namespace CasaEcologieSysInfo
{
    partial class UC_TableauDeBord
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
            this.quantiteDeMatierePremiereAcheteeParBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casaDBDataSet6 = new CasaEcologieSysInfo.CasaDBDataSet6();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.janvierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.févrierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avrilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juilletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aoûtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.septembreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.octobreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.novembreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.décembreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventesMensuellesResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.quantiteDeMatierePremiereAcheteeParTableAdapter = new CasaEcologieSysInfo.CasaDBDataSet6TableAdapters.QuantiteDeMatierePremiereAcheteeParTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProduitsLesPlusVendus = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCadeaux = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTop10Clients = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteDeMatierePremiereAcheteeParBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventesMensuellesResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduitsLesPlusVendus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadeaux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop10Clients)).BeginInit();
            this.SuspendLayout();
            // 
            // quantiteDeMatierePremiereAcheteeParBindingSource
            // 
            this.quantiteDeMatierePremiereAcheteeParBindingSource.DataMember = "QuantiteDeMatierePremiereAcheteePar";
            this.quantiteDeMatierePremiereAcheteeParBindingSource.DataSource = this.casaDBDataSet6;
            // 
            // casaDBDataSet6
            // 
            this.casaDBDataSet6.DataSetName = "CasaDBDataSet6";
            this.casaDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tableau de bord";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.janvierDataGridViewTextBoxColumn,
            this.févrierDataGridViewTextBoxColumn,
            this.marsDataGridViewTextBoxColumn,
            this.avrilDataGridViewTextBoxColumn,
            this.maiDataGridViewTextBoxColumn,
            this.juinDataGridViewTextBoxColumn,
            this.juilletDataGridViewTextBoxColumn,
            this.aoûtDataGridViewTextBoxColumn,
            this.septembreDataGridViewTextBoxColumn,
            this.octobreDataGridViewTextBoxColumn,
            this.novembreDataGridViewTextBoxColumn,
            this.décembreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ventesMensuellesResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(88, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 17;
            this.dataGridView1.Size = new System.Drawing.Size(868, 77);
            this.dataGridView1.TabIndex = 27;
            // 
            // janvierDataGridViewTextBoxColumn
            // 
            this.janvierDataGridViewTextBoxColumn.DataPropertyName = "Janvier";
            this.janvierDataGridViewTextBoxColumn.HeaderText = "Janvier";
            this.janvierDataGridViewTextBoxColumn.Name = "janvierDataGridViewTextBoxColumn";
            this.janvierDataGridViewTextBoxColumn.ReadOnly = true;
            this.janvierDataGridViewTextBoxColumn.Width = 70;
            // 
            // févrierDataGridViewTextBoxColumn
            // 
            this.févrierDataGridViewTextBoxColumn.DataPropertyName = "Février";
            this.févrierDataGridViewTextBoxColumn.HeaderText = "Février";
            this.févrierDataGridViewTextBoxColumn.Name = "févrierDataGridViewTextBoxColumn";
            this.févrierDataGridViewTextBoxColumn.ReadOnly = true;
            this.févrierDataGridViewTextBoxColumn.Width = 69;
            // 
            // marsDataGridViewTextBoxColumn
            // 
            this.marsDataGridViewTextBoxColumn.DataPropertyName = "Mars";
            this.marsDataGridViewTextBoxColumn.HeaderText = "Mars";
            this.marsDataGridViewTextBoxColumn.Name = "marsDataGridViewTextBoxColumn";
            this.marsDataGridViewTextBoxColumn.ReadOnly = true;
            this.marsDataGridViewTextBoxColumn.Width = 62;
            // 
            // avrilDataGridViewTextBoxColumn
            // 
            this.avrilDataGridViewTextBoxColumn.DataPropertyName = "Avril";
            this.avrilDataGridViewTextBoxColumn.HeaderText = "Avril";
            this.avrilDataGridViewTextBoxColumn.Name = "avrilDataGridViewTextBoxColumn";
            this.avrilDataGridViewTextBoxColumn.ReadOnly = true;
            this.avrilDataGridViewTextBoxColumn.Width = 60;
            // 
            // maiDataGridViewTextBoxColumn
            // 
            this.maiDataGridViewTextBoxColumn.DataPropertyName = "Mai";
            this.maiDataGridViewTextBoxColumn.HeaderText = "Mai";
            this.maiDataGridViewTextBoxColumn.Name = "maiDataGridViewTextBoxColumn";
            this.maiDataGridViewTextBoxColumn.ReadOnly = true;
            this.maiDataGridViewTextBoxColumn.Width = 56;
            // 
            // juinDataGridViewTextBoxColumn
            // 
            this.juinDataGridViewTextBoxColumn.DataPropertyName = "Juin";
            this.juinDataGridViewTextBoxColumn.HeaderText = "Juin";
            this.juinDataGridViewTextBoxColumn.Name = "juinDataGridViewTextBoxColumn";
            this.juinDataGridViewTextBoxColumn.ReadOnly = true;
            this.juinDataGridViewTextBoxColumn.Width = 58;
            // 
            // juilletDataGridViewTextBoxColumn
            // 
            this.juilletDataGridViewTextBoxColumn.DataPropertyName = "Juillet";
            this.juilletDataGridViewTextBoxColumn.HeaderText = "Juillet";
            this.juilletDataGridViewTextBoxColumn.Name = "juilletDataGridViewTextBoxColumn";
            this.juilletDataGridViewTextBoxColumn.ReadOnly = true;
            this.juilletDataGridViewTextBoxColumn.Width = 55;
            // 
            // aoûtDataGridViewTextBoxColumn
            // 
            this.aoûtDataGridViewTextBoxColumn.DataPropertyName = "Août";
            this.aoûtDataGridViewTextBoxColumn.HeaderText = "Août";
            this.aoûtDataGridViewTextBoxColumn.Name = "aoûtDataGridViewTextBoxColumn";
            this.aoûtDataGridViewTextBoxColumn.ReadOnly = true;
            this.aoûtDataGridViewTextBoxColumn.Width = 64;
            // 
            // septembreDataGridViewTextBoxColumn
            // 
            this.septembreDataGridViewTextBoxColumn.DataPropertyName = "Septembre";
            this.septembreDataGridViewTextBoxColumn.HeaderText = "Septembre";
            this.septembreDataGridViewTextBoxColumn.Name = "septembreDataGridViewTextBoxColumn";
            this.septembreDataGridViewTextBoxColumn.ReadOnly = true;
            this.septembreDataGridViewTextBoxColumn.Width = 103;
            // 
            // octobreDataGridViewTextBoxColumn
            // 
            this.octobreDataGridViewTextBoxColumn.DataPropertyName = "Octobre";
            this.octobreDataGridViewTextBoxColumn.HeaderText = "Octobre";
            this.octobreDataGridViewTextBoxColumn.Name = "octobreDataGridViewTextBoxColumn";
            this.octobreDataGridViewTextBoxColumn.ReadOnly = true;
            this.octobreDataGridViewTextBoxColumn.Width = 80;
            // 
            // novembreDataGridViewTextBoxColumn
            // 
            this.novembreDataGridViewTextBoxColumn.DataPropertyName = "Novembre";
            this.novembreDataGridViewTextBoxColumn.HeaderText = "Novembre";
            this.novembreDataGridViewTextBoxColumn.Name = "novembreDataGridViewTextBoxColumn";
            this.novembreDataGridViewTextBoxColumn.ReadOnly = true;
            this.novembreDataGridViewTextBoxColumn.Width = 95;
            // 
            // décembreDataGridViewTextBoxColumn
            // 
            this.décembreDataGridViewTextBoxColumn.DataPropertyName = "Décembre";
            this.décembreDataGridViewTextBoxColumn.HeaderText = "Décembre";
            this.décembreDataGridViewTextBoxColumn.Name = "décembreDataGridViewTextBoxColumn";
            this.décembreDataGridViewTextBoxColumn.ReadOnly = true;
            this.décembreDataGridViewTextBoxColumn.Width = 95;
            // 
            // ventesMensuellesResultBindingSource
            // 
            this.ventesMensuellesResultBindingSource.DataSource = typeof(CasaEcologieSysInfo.VentesMensuelles_Result);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Années";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Récapitulatif des ventes mensuelles";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(663, 34);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(88, 23);
            this.dtpDebut.TabIndex = 31;
            this.dtpDebut.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpDebut.ValueChanged += new System.EventHandler(this.DtpDebut_ValueChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(786, 34);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(88, 23);
            this.dtpFin.TabIndex = 31;
            this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFin_ValueChanged);
            // 
            // quantiteDeMatierePremiereAcheteeParTableAdapter
            // 
            this.quantiteDeMatierePremiereAcheteeParTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 189);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(297, 251);
            this.dataGridView2.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Quantité de matière première achetée";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.panel1.Location = new System.Drawing.Point(-3, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 10);
            this.panel1.TabIndex = 34;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(6, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(78, 51);
            this.listBox1.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(653, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Choisir l\'intervalle de temps ci-dessous";
            // 
            // dgvProduitsLesPlusVendus
            // 
            this.dgvProduitsLesPlusVendus.AllowUserToAddRows = false;
            this.dgvProduitsLesPlusVendus.AllowUserToDeleteRows = false;
            this.dgvProduitsLesPlusVendus.AllowUserToOrderColumns = true;
            this.dgvProduitsLesPlusVendus.AllowUserToResizeColumns = false;
            this.dgvProduitsLesPlusVendus.AllowUserToResizeRows = false;
            this.dgvProduitsLesPlusVendus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProduitsLesPlusVendus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduitsLesPlusVendus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduitsLesPlusVendus.Location = new System.Drawing.Point(325, 189);
            this.dgvProduitsLesPlusVendus.Name = "dgvProduitsLesPlusVendus";
            this.dgvProduitsLesPlusVendus.RowHeadersVisible = false;
            this.dgvProduitsLesPlusVendus.Size = new System.Drawing.Size(333, 251);
            this.dgvProduitsLesPlusVendus.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Top 10 des produits les plus vendus (Chiffre d\'affaires)";
            // 
            // dgvCadeaux
            // 
            this.dgvCadeaux.AllowUserToAddRows = false;
            this.dgvCadeaux.AllowUserToDeleteRows = false;
            this.dgvCadeaux.AllowUserToOrderColumns = true;
            this.dgvCadeaux.AllowUserToResizeColumns = false;
            this.dgvCadeaux.AllowUserToResizeRows = false;
            this.dgvCadeaux.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCadeaux.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCadeaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadeaux.Location = new System.Drawing.Point(664, 189);
            this.dgvCadeaux.Name = "dgvCadeaux";
            this.dgvCadeaux.RowHeadersVisible = false;
            this.dgvCadeaux.Size = new System.Drawing.Size(305, 251);
            this.dgvCadeaux.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(675, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Cadeaux et manque à gagner";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 10);
            this.panel2.TabIndex = 34;
            // 
            // dgvTop10Clients
            // 
            this.dgvTop10Clients.AllowUserToAddRows = false;
            this.dgvTop10Clients.AllowUserToDeleteRows = false;
            this.dgvTop10Clients.AllowUserToOrderColumns = true;
            this.dgvTop10Clients.AllowUserToResizeColumns = false;
            this.dgvTop10Clients.AllowUserToResizeRows = false;
            this.dgvTop10Clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTop10Clients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTop10Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop10Clients.Location = new System.Drawing.Point(6, 470);
            this.dgvTop10Clients.Name = "dgvTop10Clients";
            this.dgvTop10Clients.RowHeadersVisible = false;
            this.dgvTop10Clients.Size = new System.Drawing.Size(325, 162);
            this.dgvTop10Clients.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Top 10 des clients";
            // 
            // UC_TableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCadeaux);
            this.Controls.Add(this.dgvProduitsLesPlusVendus);
            this.Controls.Add(this.dgvTop10Clients);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_TableauDeBord";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_TableauDeBord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantiteDeMatierePremiereAcheteeParBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventesMensuellesResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduitsLesPlusVendus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadeaux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop10Clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource ventesMensuellesResultBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.BindingSource quantiteDeMatierePremiereAcheteeParBindingSource;
        private CasaDBDataSet6 casaDBDataSet6;
        private CasaDBDataSet6TableAdapters.QuantiteDeMatierePremiereAcheteeParTableAdapter quantiteDeMatierePremiereAcheteeParTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn janvierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn févrierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avrilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juilletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aoûtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn septembreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn octobreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn novembreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn décembreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvProduitsLesPlusVendus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCadeaux;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTop10Clients;
        private System.Windows.Forms.Label label8;
    }
}
