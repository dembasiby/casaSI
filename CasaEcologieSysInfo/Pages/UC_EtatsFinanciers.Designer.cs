namespace CasaEcologieSysInfo.Pages
{
    partial class UC_EtatsFinanciers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCpteResultats = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTableauTresorerie = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvBilan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCOGS = new System.Windows.Forms.TextBox();
            this.btnImprimerCpteResultat = new System.Windows.Forms.Button();
            this.btnImprimerTablTresorerie = new System.Windows.Forms.Button();
            this.btnImprimerBilan = new System.Windows.Forms.Button();
            this.txtCoutAchat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantiteMatieresConsommees = new System.Windows.Forms.TextBox();
            this.txtCoutMatieresConsommees = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCoutProductionSachetPainDeSinge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMilleSachets = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCpteResultats)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableauTresorerie)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(418, 74);
            this.dtpDebut.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(115, 23);
            this.dtpDebut.TabIndex = 3;
            this.dtpDebut.Value = new System.DateTime(2019, 9, 1, 0, 0, 0, 0);
            this.dtpDebut.ValueChanged += new System.EventHandler(this.DtpDebut_ValueChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.label26.Location = new System.Drawing.Point(335, 21);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(333, 25);
            this.label26.TabIndex = 27;
            this.label26.Text = "Etats Financiers - Casa Ecologie";
            this.label26.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCpteResultats);
            this.groupBox1.Location = new System.Drawing.Point(7, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 460);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compte de résultats";
            // 
            // dgvCpteResultats
            // 
            this.dgvCpteResultats.AllowUserToAddRows = false;
            this.dgvCpteResultats.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCpteResultats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCpteResultats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCpteResultats.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCpteResultats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCpteResultats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCpteResultats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvCpteResultats.Location = new System.Drawing.Point(6, 22);
            this.dgvCpteResultats.Name = "dgvCpteResultats";
            this.dgvCpteResultats.ReadOnly = true;
            this.dgvCpteResultats.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCpteResultats.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCpteResultats.Size = new System.Drawing.Size(305, 438);
            this.dgvCpteResultats.TabIndex = 31;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "Description";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.FillWeight = 30F;
            this.Column2.HeaderText = "Montant";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFin.Location = new System.Drawing.Point(570, 73);
            this.dtpFin.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(115, 23);
            this.dtpFin.TabIndex = 3;
            this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFin_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(539, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "au";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(334, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Période du";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTableauTresorerie);
            this.groupBox2.Location = new System.Drawing.Point(329, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 460);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tableau de trésorerie";
            // 
            // dgvTableauTresorerie
            // 
            this.dgvTableauTresorerie.AllowUserToAddRows = false;
            this.dgvTableauTresorerie.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTableauTresorerie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTableauTresorerie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableauTresorerie.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTableauTresorerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTableauTresorerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableauTresorerie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvTableauTresorerie.Location = new System.Drawing.Point(6, 22);
            this.dgvTableauTresorerie.Name = "dgvTableauTresorerie";
            this.dgvTableauTresorerie.ReadOnly = true;
            this.dgvTableauTresorerie.RowHeadersVisible = false;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableauTresorerie.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTableauTresorerie.Size = new System.Drawing.Size(305, 438);
            this.dgvTableauTresorerie.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 70F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn2.FillWeight = 30F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Montant";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvBilan);
            this.groupBox3.Location = new System.Drawing.Point(650, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 460);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilan";
            // 
            // dgvBilan
            // 
            this.dgvBilan.AllowUserToAddRows = false;
            this.dgvBilan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBilan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBilan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBilan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBilan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvBilan.Location = new System.Drawing.Point(11, 22);
            this.dgvBilan.Name = "dgvBilan";
            this.dgvBilan.ReadOnly = true;
            this.dgvBilan.RowHeadersVisible = false;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBilan.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBilan.Size = new System.Drawing.Size(305, 438);
            this.dgvBilan.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 70F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 30F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Montant";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 54);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ajouter le Coût des produits vendus de la période dans le champs ci-dessous\r\n";
            // 
            // txtCOGS
            // 
            this.txtCOGS.Location = new System.Drawing.Point(13, 98);
            this.txtCOGS.Name = "txtCOGS";
            this.txtCOGS.Size = new System.Drawing.Size(141, 23);
            this.txtCOGS.TabIndex = 33;
            this.txtCOGS.Text = "0";
            this.txtCOGS.TextChanged += new System.EventHandler(this.TxtCOGS_TextChanged);
            // 
            // btnImprimerCpteResultat
            // 
            this.btnImprimerCpteResultat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnImprimerCpteResultat.FlatAppearance.BorderSize = 0;
            this.btnImprimerCpteResultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerCpteResultat.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnImprimerCpteResultat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimerCpteResultat.Location = new System.Drawing.Point(23, 594);
            this.btnImprimerCpteResultat.Name = "btnImprimerCpteResultat";
            this.btnImprimerCpteResultat.Size = new System.Drawing.Size(243, 25);
            this.btnImprimerCpteResultat.TabIndex = 61;
            this.btnImprimerCpteResultat.Text = "Imprimer le compte de résultats";
            this.btnImprimerCpteResultat.UseVisualStyleBackColor = false;
            this.btnImprimerCpteResultat.Click += new System.EventHandler(this.BtnImprimerCpteResultat_Click);
            // 
            // btnImprimerTablTresorerie
            // 
            this.btnImprimerTablTresorerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnImprimerTablTresorerie.FlatAppearance.BorderSize = 0;
            this.btnImprimerTablTresorerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerTablTresorerie.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnImprimerTablTresorerie.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimerTablTresorerie.Location = new System.Drawing.Point(361, 594);
            this.btnImprimerTablTresorerie.Name = "btnImprimerTablTresorerie";
            this.btnImprimerTablTresorerie.Size = new System.Drawing.Size(262, 25);
            this.btnImprimerTablTresorerie.TabIndex = 61;
            this.btnImprimerTablTresorerie.Text = "Imprimer le tableau de trésorerie";
            this.btnImprimerTablTresorerie.UseVisualStyleBackColor = false;
            this.btnImprimerTablTresorerie.Click += new System.EventHandler(this.BtnImprimerTablTresorerie_Click);
            // 
            // btnImprimerBilan
            // 
            this.btnImprimerBilan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnImprimerBilan.FlatAppearance.BorderSize = 0;
            this.btnImprimerBilan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerBilan.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnImprimerBilan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimerBilan.Location = new System.Drawing.Point(719, 594);
            this.btnImprimerBilan.Name = "btnImprimerBilan";
            this.btnImprimerBilan.Size = new System.Drawing.Size(214, 25);
            this.btnImprimerBilan.TabIndex = 61;
            this.btnImprimerBilan.Text = "Imprimer le bilan";
            this.btnImprimerBilan.UseVisualStyleBackColor = false;
            this.btnImprimerBilan.Click += new System.EventHandler(this.BtnImprimerBilan_Click);
            // 
            // txtCoutAchat
            // 
            this.txtCoutAchat.Location = new System.Drawing.Point(690, 41);
            this.txtCoutAchat.Name = "txtCoutAchat";
            this.txtCoutAchat.Size = new System.Drawing.Size(159, 23);
            this.txtCoutAchat.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Coût d\'achat pain de singe (FCFA / kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Quantite pain de singe consommee (kg)";
            // 
            // txtQuantiteMatieresConsommees
            // 
            this.txtQuantiteMatieresConsommees.Location = new System.Drawing.Point(690, 100);
            this.txtQuantiteMatieresConsommees.Name = "txtQuantiteMatieresConsommees";
            this.txtQuantiteMatieresConsommees.Size = new System.Drawing.Size(159, 23);
            this.txtQuantiteMatieresConsommees.TabIndex = 64;
            // 
            // txtCoutMatieresConsommees
            // 
            this.txtCoutMatieresConsommees.Location = new System.Drawing.Point(690, 157);
            this.txtCoutMatieresConsommees.Name = "txtCoutMatieresConsommees";
            this.txtCoutMatieresConsommees.Size = new System.Drawing.Size(159, 23);
            this.txtCoutMatieresConsommees.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "Cout pain de singe consomme (FCFA)";
            // 
            // txtCoutProductionSachetPainDeSinge
            // 
            this.txtCoutProductionSachetPainDeSinge.Location = new System.Drawing.Point(690, 217);
            this.txtCoutProductionSachetPainDeSinge.Name = "txtCoutProductionSachetPainDeSinge";
            this.txtCoutProductionSachetPainDeSinge.Size = new System.Drawing.Size(159, 23);
            this.txtCoutProductionSachetPainDeSinge.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(687, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Cout production sachet pain de singe (FCFA)";
            // 
            // txtMilleSachets
            // 
            this.txtMilleSachets.Location = new System.Drawing.Point(690, 278);
            this.txtMilleSachets.Name = "txtMilleSachets";
            this.txtMilleSachets.Size = new System.Drawing.Size(159, 23);
            this.txtMilleSachets.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(687, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Test pour 1000 sachets";
            // 
            // UC_EtatsFinanciers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCoutProductionSachetPainDeSinge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMilleSachets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCoutMatieresConsommees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantiteMatieresConsommees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCoutAchat);
            this.Controls.Add(this.btnImprimerBilan);
            this.Controls.Add(this.btnImprimerTablTresorerie);
            this.Controls.Add(this.btnImprimerCpteResultat);
            this.Controls.Add(this.txtCOGS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_EtatsFinanciers";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_EtatsFinMensuels_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCpteResultats)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableauTresorerie)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvCpteResultats;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTableauTresorerie;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvBilan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCOGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnImprimerCpteResultat;
        private System.Windows.Forms.Button btnImprimerTablTresorerie;
        private System.Windows.Forms.Button btnImprimerBilan;
        private System.Windows.Forms.TextBox txtCoutAchat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantiteMatieresConsommees;
        private System.Windows.Forms.TextBox txtCoutMatieresConsommees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCoutProductionSachetPainDeSinge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMilleSachets;
        private System.Windows.Forms.Label label6;
    }
}
