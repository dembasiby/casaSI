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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventesMensuellesResultBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(48, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(933, 138);
            this.dataGridView1.TabIndex = 27;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(3, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.Size = new System.Drawing.Size(40, 340);
            this.listBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Années";
            // 
            // janvierDataGridViewTextBoxColumn
            // 
            this.janvierDataGridViewTextBoxColumn.DataPropertyName = "Janvier";
            this.janvierDataGridViewTextBoxColumn.HeaderText = "Janvier";
            this.janvierDataGridViewTextBoxColumn.Name = "janvierDataGridViewTextBoxColumn";
            this.janvierDataGridViewTextBoxColumn.Width = 79;
            // 
            // févrierDataGridViewTextBoxColumn
            // 
            this.févrierDataGridViewTextBoxColumn.DataPropertyName = "Février";
            this.févrierDataGridViewTextBoxColumn.HeaderText = "Février";
            this.févrierDataGridViewTextBoxColumn.Name = "févrierDataGridViewTextBoxColumn";
            this.févrierDataGridViewTextBoxColumn.Width = 74;
            // 
            // marsDataGridViewTextBoxColumn
            // 
            this.marsDataGridViewTextBoxColumn.DataPropertyName = "Mars";
            this.marsDataGridViewTextBoxColumn.HeaderText = "Mars";
            this.marsDataGridViewTextBoxColumn.Name = "marsDataGridViewTextBoxColumn";
            this.marsDataGridViewTextBoxColumn.Width = 62;
            // 
            // avrilDataGridViewTextBoxColumn
            // 
            this.avrilDataGridViewTextBoxColumn.DataPropertyName = "Avril";
            this.avrilDataGridViewTextBoxColumn.HeaderText = "Avril";
            this.avrilDataGridViewTextBoxColumn.Name = "avrilDataGridViewTextBoxColumn";
            this.avrilDataGridViewTextBoxColumn.Width = 60;
            // 
            // maiDataGridViewTextBoxColumn
            // 
            this.maiDataGridViewTextBoxColumn.DataPropertyName = "Mai";
            this.maiDataGridViewTextBoxColumn.HeaderText = "Mai";
            this.maiDataGridViewTextBoxColumn.Name = "maiDataGridViewTextBoxColumn";
            this.maiDataGridViewTextBoxColumn.Width = 56;
            // 
            // juinDataGridViewTextBoxColumn
            // 
            this.juinDataGridViewTextBoxColumn.DataPropertyName = "Juin";
            this.juinDataGridViewTextBoxColumn.HeaderText = "Juin";
            this.juinDataGridViewTextBoxColumn.Name = "juinDataGridViewTextBoxColumn";
            this.juinDataGridViewTextBoxColumn.Width = 58;
            // 
            // juilletDataGridViewTextBoxColumn
            // 
            this.juilletDataGridViewTextBoxColumn.DataPropertyName = "Juillet";
            this.juilletDataGridViewTextBoxColumn.HeaderText = "Juillet";
            this.juilletDataGridViewTextBoxColumn.Name = "juilletDataGridViewTextBoxColumn";
            this.juilletDataGridViewTextBoxColumn.Width = 69;
            // 
            // aoûtDataGridViewTextBoxColumn
            // 
            this.aoûtDataGridViewTextBoxColumn.DataPropertyName = "Août";
            this.aoûtDataGridViewTextBoxColumn.HeaderText = "Août";
            this.aoûtDataGridViewTextBoxColumn.Name = "aoûtDataGridViewTextBoxColumn";
            this.aoûtDataGridViewTextBoxColumn.Width = 64;
            // 
            // septembreDataGridViewTextBoxColumn
            // 
            this.septembreDataGridViewTextBoxColumn.DataPropertyName = "Septembre";
            this.septembreDataGridViewTextBoxColumn.HeaderText = "Septembre";
            this.septembreDataGridViewTextBoxColumn.Name = "septembreDataGridViewTextBoxColumn";
            this.septembreDataGridViewTextBoxColumn.Width = 103;
            // 
            // octobreDataGridViewTextBoxColumn
            // 
            this.octobreDataGridViewTextBoxColumn.DataPropertyName = "Octobre";
            this.octobreDataGridViewTextBoxColumn.HeaderText = "Octobre";
            this.octobreDataGridViewTextBoxColumn.Name = "octobreDataGridViewTextBoxColumn";
            this.octobreDataGridViewTextBoxColumn.Width = 87;
            // 
            // novembreDataGridViewTextBoxColumn
            // 
            this.novembreDataGridViewTextBoxColumn.DataPropertyName = "Novembre";
            this.novembreDataGridViewTextBoxColumn.HeaderText = "Novembre";
            this.novembreDataGridViewTextBoxColumn.Name = "novembreDataGridViewTextBoxColumn";
            this.novembreDataGridViewTextBoxColumn.Width = 102;
            // 
            // décembreDataGridViewTextBoxColumn
            // 
            this.décembreDataGridViewTextBoxColumn.DataPropertyName = "Décembre";
            this.décembreDataGridViewTextBoxColumn.HeaderText = "Décembre";
            this.décembreDataGridViewTextBoxColumn.Name = "décembreDataGridViewTextBoxColumn";
            this.décembreDataGridViewTextBoxColumn.Width = 101;
            // 
            // ventesMensuellesResultBindingSource
            // 
            this.ventesMensuellesResultBindingSource.DataSource = typeof(CasaEcologieSysInfo.VentesMensuelles_Result);
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
            // UC_TableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_TableauDeBord";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_TableauDeBord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventesMensuellesResultBindingSource)).EndInit();
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
