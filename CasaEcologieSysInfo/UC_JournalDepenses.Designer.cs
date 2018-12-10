namespace CasaEcologieSysInfo
{
    partial class UC_JournalDepenses
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casaDBDataSetAll = new CasaEcologieSysInfo.CasaDBDataSetAll();
            this.eveReceptionMatieresPremieresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eveReceptionMatieresPremieresTableAdapter = new CasaEcologieSysInfo.CasaDBDataSetAllTableAdapters.EveReceptionMatieresPremieresTableAdapter();
            this.eveReceptionMatieresPremieresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resStockMatieresPremieresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resStockMatieresPremieresTableAdapter = new CasaEcologieSysInfo.CasaDBDataSetAllTableAdapters.ResStockMatieresPremieresTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.resStockMatieresPremieresRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adgvDepensesMatPrem = new ADGV.AdvancedDataGridView();
            this.eveDecaissementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.casaDBDataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eveReceptionMatieresPremieresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eveReceptionMatieresPremieresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremieresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremieresRowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adgvDepensesMatPrem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eveDecaissementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Journal des dépenses";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ResStockMatieresPremiere";
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // casaDBDataSetAll
            // 
            this.casaDBDataSetAll.DataSetName = "CasaDBDataSetAll";
            this.casaDBDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eveReceptionMatieresPremieresBindingSource
            // 
            this.eveReceptionMatieresPremieresBindingSource.DataMember = "EveReceptionMatieresPremieres";
            this.eveReceptionMatieresPremieresBindingSource.DataSource = this.casaDBDataSetAll;
            // 
            // eveReceptionMatieresPremieresTableAdapter
            // 
            this.eveReceptionMatieresPremieresTableAdapter.ClearBeforeFill = true;
            // 
            // eveReceptionMatieresPremieresBindingSource1
            // 
            this.eveReceptionMatieresPremieresBindingSource1.DataMember = "EveReceptionMatieresPremieres";
            this.eveReceptionMatieresPremieresBindingSource1.DataSource = typeof(CasaEcologieSysInfo.CasaDBDataSet5);
            // 
            // resStockMatieresPremieresBindingSource
            // 
            this.resStockMatieresPremieresBindingSource.DataMember = "ResStockMatieresPremieres";
            this.resStockMatieresPremieresBindingSource.DataSource = this.casaDBDataSetAll;
            // 
            // resStockMatieresPremieresTableAdapter
            // 
            this.resStockMatieresPremieresTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Achats de matière première";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(331, 89);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(314, 528);
            this.dataGridView2.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Achats de services et fournitures";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(652, 89);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(314, 528);
            this.dataGridView3.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(648, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Achats d\'équipements";
            // 
            // resStockMatieresPremieresRowBindingSource
            // 
            this.resStockMatieresPremieresRowBindingSource.DataSource = typeof(CasaEcologieSysInfo.CasaDBDataSet5.ResStockMatieresPremieresRow);
            // 
            // adgvDepensesMatPrem
            // 
            this.adgvDepensesMatPrem.AllowUserToAddRows = false;
            this.adgvDepensesMatPrem.AllowUserToDeleteRows = false;
            this.adgvDepensesMatPrem.AutoGenerateContextFilters = true;
            this.adgvDepensesMatPrem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvDepensesMatPrem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvDepensesMatPrem.DateWithTime = false;
            this.adgvDepensesMatPrem.Location = new System.Drawing.Point(14, 89);
            this.adgvDepensesMatPrem.Name = "adgvDepensesMatPrem";
            this.adgvDepensesMatPrem.ReadOnly = true;
            this.adgvDepensesMatPrem.ShowEditingIcon = false;
            this.adgvDepensesMatPrem.Size = new System.Drawing.Size(312, 528);
            this.adgvDepensesMatPrem.TabIndex = 30;
            this.adgvDepensesMatPrem.TimeFilter = false;
            this.adgvDepensesMatPrem.SortStringChanged += new System.EventHandler(this.AdgvDepensesMatPrem_SortStringChanged);
            this.adgvDepensesMatPrem.FilterStringChanged += new System.EventHandler(this.AdgvDepensesMatPrem_FilterStringChanged);
            // 
            // eveDecaissementBindingSource
            // 
            this.eveDecaissementBindingSource.DataSource = typeof(CasaEcologieSysInfo.EveDecaissement);
            // 
            // UC_JournalDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adgvDepensesMatPrem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_JournalDepenses";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_JournalDepenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.casaDBDataSetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eveReceptionMatieresPremieresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eveReceptionMatieresPremieresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremieresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremieresRowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adgvDepensesMatPrem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eveDecaissementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource resStockMatieresPremieresRowBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource eveDecaissementBindingSource;
        private System.Windows.Forms.BindingSource eveReceptionMatieresPremieresBindingSource;
        private CasaDBDataSetAll casaDBDataSetAll;
        private CasaDBDataSetAllTableAdapters.EveReceptionMatieresPremieresTableAdapter eveReceptionMatieresPremieresTableAdapter;
        private System.Windows.Forms.BindingSource resStockMatieresPremieresBindingSource;
        private CasaDBDataSetAllTableAdapters.ResStockMatieresPremieresTableAdapter resStockMatieresPremieresTableAdapter;
        private System.Windows.Forms.BindingSource eveReceptionMatieresPremieresBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private ADGV.AdvancedDataGridView adgvDepensesMatPrem;
    }
}
