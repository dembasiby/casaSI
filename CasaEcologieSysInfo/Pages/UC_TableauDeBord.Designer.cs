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
            this.casaDBDataSet6 = new CasaEcologieSysInfo.CasaDBDataSet6();
            this.quantiteDeMatierePremiereAcheteeParBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantiteDeMatierePremiereAcheteeParTableAdapter = new CasaEcologieSysInfo.CasaDBDataSet6TableAdapters.QuantiteDeMatierePremiereAcheteeParTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventesMensuellesResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteDeMatierePremiereAcheteeParBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 12);
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dataGridView1.Location = new System.Drawing.Point(75, 88);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(898, 113);
            this.dataGridView1.TabIndex = 27;
            // 
            // janvierDataGridViewTextBoxColumn
            // 
            this.janvierDataGridViewTextBoxColumn.DataPropertyName = "Janvier";
            this.janvierDataGridViewTextBoxColumn.HeaderText = "Janvier";
            this.janvierDataGridViewTextBoxColumn.Name = "janvierDataGridViewTextBoxColumn";
            this.janvierDataGridViewTextBoxColumn.ReadOnly = true;
            this.janvierDataGridViewTextBoxColumn.Width = 79;
            // 
            // févrierDataGridViewTextBoxColumn
            // 
            this.févrierDataGridViewTextBoxColumn.DataPropertyName = "Février";
            this.févrierDataGridViewTextBoxColumn.HeaderText = "Février";
            this.févrierDataGridViewTextBoxColumn.Name = "févrierDataGridViewTextBoxColumn";
            this.févrierDataGridViewTextBoxColumn.ReadOnly = true;
            this.févrierDataGridViewTextBoxColumn.Width = 74;
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
            this.juilletDataGridViewTextBoxColumn.Width = 69;
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
            this.octobreDataGridViewTextBoxColumn.Width = 87;
            // 
            // novembreDataGridViewTextBoxColumn
            // 
            this.novembreDataGridViewTextBoxColumn.DataPropertyName = "Novembre";
            this.novembreDataGridViewTextBoxColumn.HeaderText = "Novembre";
            this.novembreDataGridViewTextBoxColumn.Name = "novembreDataGridViewTextBoxColumn";
            this.novembreDataGridViewTextBoxColumn.ReadOnly = true;
            this.novembreDataGridViewTextBoxColumn.Width = 102;
            // 
            // décembreDataGridViewTextBoxColumn
            // 
            this.décembreDataGridViewTextBoxColumn.DataPropertyName = "Décembre";
            this.décembreDataGridViewTextBoxColumn.HeaderText = "Décembre";
            this.décembreDataGridViewTextBoxColumn.Name = "décembreDataGridViewTextBoxColumn";
            this.décembreDataGridViewTextBoxColumn.ReadOnly = true;
            this.décembreDataGridViewTextBoxColumn.Width = 101;
            // 
            // ventesMensuellesResultBindingSource
            // 
            this.ventesMensuellesResultBindingSource.DataSource = typeof(CasaEcologieSysInfo.VentesMensuelles_Result);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Années";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 55);
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
            this.dtpDebut.Location = new System.Drawing.Point(369, 340);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(88, 23);
            this.dtpDebut.TabIndex = 31;
            this.dtpDebut.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpDebut.ValueChanged += new System.EventHandler(this.DtpDebut_ValueChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(369, 369);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(88, 23);
            this.dtpFin.TabIndex = 31;
            this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFin_ValueChanged);
            // 
            // casaDBDataSet6
            // 
            this.casaDBDataSet6.DataSetName = "CasaDBDataSet6";
            this.casaDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quantiteDeMatierePremiereAcheteeParBindingSource
            // 
            this.quantiteDeMatierePremiereAcheteeParBindingSource.DataMember = "QuantiteDeMatierePremiereAcheteePar";
            this.quantiteDeMatierePremiereAcheteeParBindingSource.DataSource = this.casaDBDataSet6;
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
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 244);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(347, 158);
            this.dataGridView2.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Quantité de matière première achetée par période";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.panel1.Location = new System.Drawing.Point(-3, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 10);
            this.panel1.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.panel3.Location = new System.Drawing.Point(472, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 423);
            this.panel3.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.panel4.Location = new System.Drawing.Point(-2, 408);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(986, 10);
            this.panel4.TabIndex = 35;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(6, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(64, 85);
            this.listBox1.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 78);
            this.label5.TabIndex = 37;
            this.label5.Text = "Choisir l\'intervalle de temps ci-dessous";
            // 
            // UC_TableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventesMensuellesResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteDeMatierePremiereAcheteeParBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource ventesMensuellesResultBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
    }
}
