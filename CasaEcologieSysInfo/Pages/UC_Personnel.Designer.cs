namespace CasaEcologieSysInfo.Pages
{
    partial class UC_Personnel
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
            this.dgvListePersonnel = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrenomNom = new System.Windows.Forms.TextBox();
            this.btnPresenceEmploye = new System.Windows.Forms.Button();
            this.txtPosteEmploye = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTimeSheetNomEmploye = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNouvelEmploye = new System.Windows.Forms.Button();
            this.ageEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dgvTempsEtRemun = new System.Windows.Forms.DataGridView();
            this.cbxTempsEtRemun = new System.Windows.Forms.ComboBox();
            this.txtRemunerationJournaliere = new System.Windows.Forms.TextBox();
            this.btnPayerEmploye = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpDatePaiement = new System.Windows.Forms.DateTimePicker();
            this.txtRemunerationPeriod = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxComptePaiement = new System.Windows.Forms.ComboBox();
            this.resComptesTresorerieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.cbxTresoriere = new System.Windows.Forms.ComboBox();
            this.ageEmployeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePersonnel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempsEtRemun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Page de suivi du personnel";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvListePersonnel
            // 
            this.dgvListePersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListePersonnel.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListePersonnel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListePersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListePersonnel.Location = new System.Drawing.Point(13, 93);
            this.dgvListePersonnel.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListePersonnel.Name = "dgvListePersonnel";
            this.dgvListePersonnel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListePersonnel.Size = new System.Drawing.Size(551, 136);
            this.dgvListePersonnel.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(678, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ajouter un nouvel employé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Prénom et nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Poste";
            // 
            // txtPrenomNom
            // 
            this.txtPrenomNom.Location = new System.Drawing.Point(682, 93);
            this.txtPrenomNom.Name = "txtPrenomNom";
            this.txtPrenomNom.Size = new System.Drawing.Size(272, 23);
            this.txtPrenomNom.TabIndex = 29;
            // 
            // btnPresenceEmploye
            // 
            this.btnPresenceEmploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnPresenceEmploye.FlatAppearance.BorderSize = 0;
            this.btnPresenceEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresenceEmploye.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresenceEmploye.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPresenceEmploye.Location = new System.Drawing.Point(13, 437);
            this.btnPresenceEmploye.Name = "btnPresenceEmploye";
            this.btnPresenceEmploye.Size = new System.Drawing.Size(223, 31);
            this.btnPresenceEmploye.TabIndex = 30;
            this.btnPresenceEmploye.Text = "Enregistrer";
            this.btnPresenceEmploye.UseVisualStyleBackColor = false;
            this.btnPresenceEmploye.Click += new System.EventHandler(this.BtnPresenceEmploye_Click);
            // 
            // txtPosteEmploye
            // 
            this.txtPosteEmploye.Location = new System.Drawing.Point(682, 125);
            this.txtPosteEmploye.Name = "txtPosteEmploye";
            this.txtPosteEmploye.Size = new System.Drawing.Size(272, 23);
            this.txtPosteEmploye.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Liste des employés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "TimeSheet";
            // 
            // cbxTimeSheetNomEmploye
            // 
            this.cbxTimeSheetNomEmploye.FormattingEnabled = true;
            this.cbxTimeSheetNomEmploye.Location = new System.Drawing.Point(13, 302);
            this.cbxTimeSheetNomEmploye.Name = "cbxTimeSheetNomEmploye";
            this.cbxTimeSheetNomEmploye.Size = new System.Drawing.Size(223, 25);
            this.cbxTimeSheetNomEmploye.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 282);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Prénom et nom";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-1, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 10);
            this.panel1.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.panel4.Location = new System.Drawing.Point(630, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 396);
            this.panel4.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.panel3.Location = new System.Drawing.Point(630, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 396);
            this.panel3.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 387);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Rémunération journalière";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.panel2.Location = new System.Drawing.Point(242, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 396);
            this.panel2.TabIndex = 36;
            // 
            // btnNouvelEmploye
            // 
            this.btnNouvelEmploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnNouvelEmploye.FlatAppearance.BorderSize = 0;
            this.btnNouvelEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouvelEmploye.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvelEmploye.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNouvelEmploye.Location = new System.Drawing.Point(682, 172);
            this.btnNouvelEmploye.Name = "btnNouvelEmploye";
            this.btnNouvelEmploye.Size = new System.Drawing.Size(272, 31);
            this.btnNouvelEmploye.TabIndex = 30;
            this.btnNouvelEmploye.Text = "Ajouter un nouvel employé";
            this.btnNouvelEmploye.UseVisualStyleBackColor = false;
            this.btnNouvelEmploye.Click += new System.EventHandler(this.BtnNouvelEmploye_Click);
            // 
            // ageEmployeBindingSource
            // 
            this.ageEmployeBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 334);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(11, 356);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(225, 23);
            this.dtpDate.TabIndex = 37;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(258, 285);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(123, 23);
            this.dtpDebut.TabIndex = 38;
            this.dtpDebut.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(400, 285);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(123, 23);
            this.dtpFin.TabIndex = 38;
            this.dtpFin.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // dgvTempsEtRemun
            // 
            this.dgvTempsEtRemun.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTempsEtRemun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTempsEtRemun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTempsEtRemun.Location = new System.Drawing.Point(258, 325);
            this.dgvTempsEtRemun.Name = "dgvTempsEtRemun";
            this.dgvTempsEtRemun.RowHeadersVisible = false;
            this.dgvTempsEtRemun.Size = new System.Drawing.Size(325, 307);
            this.dgvTempsEtRemun.TabIndex = 40;
            // 
            // cbxTempsEtRemun
            // 
            this.cbxTempsEtRemun.FormattingEnabled = true;
            this.cbxTempsEtRemun.Location = new System.Drawing.Point(258, 250);
            this.cbxTempsEtRemun.Name = "cbxTempsEtRemun";
            this.cbxTempsEtRemun.Size = new System.Drawing.Size(265, 25);
            this.cbxTempsEtRemun.TabIndex = 41;
            this.cbxTempsEtRemun.SelectedIndexChanged += new System.EventHandler(this.CbxTempsEtRemun_SelectedIndexChanged);
            // 
            // txtRemunerationJournaliere
            // 
            this.txtRemunerationJournaliere.Location = new System.Drawing.Point(13, 408);
            this.txtRemunerationJournaliere.Name = "txtRemunerationJournaliere";
            this.txtRemunerationJournaliere.Size = new System.Drawing.Size(223, 23);
            this.txtRemunerationJournaliere.TabIndex = 42;
            // 
            // btnPayerEmploye
            // 
            this.btnPayerEmploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnPayerEmploye.FlatAppearance.BorderSize = 0;
            this.btnPayerEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayerEmploye.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayerEmploye.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPayerEmploye.Location = new System.Drawing.Point(665, 522);
            this.btnPayerEmploye.Name = "btnPayerEmploye";
            this.btnPayerEmploye.Size = new System.Drawing.Size(223, 31);
            this.btnPayerEmploye.TabIndex = 30;
            this.btnPayerEmploye.Text = "Payer l\'employé";
            this.btnPayerEmploye.UseVisualStyleBackColor = false;
            this.btnPayerEmploye.Click += new System.EventHandler(this.BtnPayerEmploye_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(678, 279);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = "Paiement des salaires";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(662, 416);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "Rémunération de la période";
            // 
            // dtpDatePaiement
            // 
            this.dtpDatePaiement.Location = new System.Drawing.Point(663, 327);
            this.dtpDatePaiement.Name = "dtpDatePaiement";
            this.dtpDatePaiement.Size = new System.Drawing.Size(225, 23);
            this.dtpDatePaiement.TabIndex = 37;
            // 
            // txtRemunerationPeriod
            // 
            this.txtRemunerationPeriod.Location = new System.Drawing.Point(665, 437);
            this.txtRemunerationPeriod.Name = "txtRemunerationPeriod";
            this.txtRemunerationPeriod.ReadOnly = true;
            this.txtRemunerationPeriod.Size = new System.Drawing.Size(223, 23);
            this.txtRemunerationPeriod.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(662, 307);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Date";
            // 
            // cbxComptePaiement
            // 
            this.cbxComptePaiement.DataSource = this.resComptesTresorerieBindingSource;
            this.cbxComptePaiement.DisplayMember = "NomCompte";
            this.cbxComptePaiement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComptePaiement.FormattingEnabled = true;
            this.cbxComptePaiement.Location = new System.Drawing.Point(665, 385);
            this.cbxComptePaiement.Name = "cbxComptePaiement";
            this.cbxComptePaiement.Size = new System.Drawing.Size(223, 25);
            this.cbxComptePaiement.TabIndex = 32;
            this.cbxComptePaiement.ValueMember = "CodeCompte";
            // 
            // resComptesTresorerieBindingSource
            // 
            this.resComptesTresorerieBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResComptesTresorerie);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(662, 362);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Compte de paiement";
            // 
            // cbxTresoriere
            // 
            this.cbxTresoriere.DataSource = this.ageEmployeBindingSource1;
            this.cbxTresoriere.DisplayMember = "PrenomNom";
            this.cbxTresoriere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTresoriere.FormattingEnabled = true;
            this.cbxTresoriere.Location = new System.Drawing.Point(665, 491);
            this.cbxTresoriere.Name = "cbxTresoriere";
            this.cbxTresoriere.Size = new System.Drawing.Size(223, 25);
            this.cbxTresoriere.TabIndex = 32;
            this.cbxTresoriere.ValueMember = "CodeEmploye";
            // 
            // ageEmployeBindingSource1
            // 
            this.ageEmployeBindingSource1.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(662, 471);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "Paiement fait par:";
            // 
            // UC_Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtRemunerationPeriod);
            this.Controls.Add(this.txtRemunerationJournaliere);
            this.Controls.Add(this.cbxTempsEtRemun);
            this.Controls.Add(this.dgvTempsEtRemun);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.dtpDatePaiement);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbxTresoriere);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbxComptePaiement);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxTimeSheetNomEmploye);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPayerEmploye);
            this.Controls.Add(this.btnNouvelEmploye);
            this.Controls.Add(this.btnPresenceEmploye);
            this.Controls.Add(this.txtPosteEmploye);
            this.Controls.Add(this.txtPrenomNom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListePersonnel);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Personnel";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_Personnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePersonnel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempsEtRemun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvListePersonnel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrenomNom;
        private System.Windows.Forms.Button btnPresenceEmploye;
        private System.Windows.Forms.TextBox txtPosteEmploye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTimeSheetNomEmploye;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNouvelEmploye;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DataGridView dgvTempsEtRemun;
        private System.Windows.Forms.ComboBox cbxTempsEtRemun;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRemunerationJournaliere;
        private System.Windows.Forms.Button btnPayerEmploye;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDatePaiement;
        private System.Windows.Forms.TextBox txtRemunerationPeriod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxComptePaiement;
        private System.Windows.Forms.BindingSource resComptesTresorerieBindingSource;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxTresoriere;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource1;
        private System.Windows.Forms.Label label14;
    }
}
