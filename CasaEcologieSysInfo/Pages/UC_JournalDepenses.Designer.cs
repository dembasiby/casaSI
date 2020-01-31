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
            this.resStockMatieresPremieresRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adgvJournalDepenses = new ADGV.AdvancedDataGridView();
            this.eveDecaissementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImprimerFicheStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.casaDBDataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eveReceptionMatieresPremieresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eveReceptionMatieresPremieresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremieresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremieresRowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adgvJournalDepenses)).BeginInit();
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
            // resStockMatieresPremieresRowBindingSource
            // 
            this.resStockMatieresPremieresRowBindingSource.DataSource = typeof(CasaEcologieSysInfo.CasaDBDataSet5.ResStockMatieresPremieresRow);
            // 
            // adgvJournalDepenses
            // 
            this.adgvJournalDepenses.AllowUserToAddRows = false;
            this.adgvJournalDepenses.AllowUserToDeleteRows = false;
            this.adgvJournalDepenses.AutoGenerateContextFilters = true;
            this.adgvJournalDepenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvJournalDepenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvJournalDepenses.DateWithTime = false;
            this.adgvJournalDepenses.Location = new System.Drawing.Point(14, 49);
            this.adgvJournalDepenses.Name = "adgvJournalDepenses";
            this.adgvJournalDepenses.ReadOnly = true;
            this.adgvJournalDepenses.ShowEditingIcon = false;
            this.adgvJournalDepenses.Size = new System.Drawing.Size(953, 583);
            this.adgvJournalDepenses.TabIndex = 30;
            this.adgvJournalDepenses.TimeFilter = false;
            this.adgvJournalDepenses.SortStringChanged += new System.EventHandler(this.AdgvDepensesMatPrem_SortStringChanged);
            this.adgvJournalDepenses.FilterStringChanged += new System.EventHandler(this.AdgvDepensesMatPrem_FilterStringChanged);
            // 
            // eveDecaissementBindingSource
            // 
            this.eveDecaissementBindingSource.DataSource = typeof(CasaEcologieSysInfo.EveDecaissement);
            // 
            // btnImprimerFicheStock
            // 
            this.btnImprimerFicheStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnImprimerFicheStock.FlatAppearance.BorderSize = 0;
            this.btnImprimerFicheStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerFicheStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerFicheStock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimerFicheStock.Location = new System.Drawing.Point(744, 6);
            this.btnImprimerFicheStock.Name = "btnImprimerFicheStock";
            this.btnImprimerFicheStock.Size = new System.Drawing.Size(223, 30);
            this.btnImprimerFicheStock.TabIndex = 55;
            this.btnImprimerFicheStock.Text = "Imprimer le journal";
            this.btnImprimerFicheStock.UseVisualStyleBackColor = false;
            this.btnImprimerFicheStock.Click += new System.EventHandler(this.BtnImprimerFicheStock_Click);
            // 
            // UC_JournalDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnImprimerFicheStock);
            this.Controls.Add(this.adgvJournalDepenses);
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
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremieresRowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adgvJournalDepenses)).EndInit();
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
        private ADGV.AdvancedDataGridView adgvJournalDepenses;
        private System.Windows.Forms.Button btnImprimerFicheStock;
    }
}
