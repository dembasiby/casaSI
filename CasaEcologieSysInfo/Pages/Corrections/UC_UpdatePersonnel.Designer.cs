namespace CasaEcologieSysInfo.Pages.Corrections
{
    partial class UC_UpdatePersonnel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxNon = new System.Windows.Forms.CheckBox();
            this.cbxOui = new System.Windows.Forms.CheckBox();
            this.cbxEmployeAChanger = new System.Windows.Forms.ComboBox();
            this.ageEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNomAChanger = new System.Windows.Forms.TextBox();
            this.txtPosteAChanger = new System.Windows.Forms.TextBox();
            this.lblLocaliteFournisseur = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNomFournisseur = new System.Windows.Forms.Label();
            this.lblNomMatierePremiere = new System.Windows.Forms.Label();
            this.BtnMettreDonneesPersoAJour = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDatePaiement = new System.Windows.Forms.DateTimePicker();
            this.CbxCompteDePaiment = new System.Windows.Forms.ComboBox();
            this.resComptesTresorerieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CbxTresoriere = new System.Windows.Forms.ComboBox();
            this.ageEmployeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.CbxNomEmploye = new System.Windows.Forms.ComboBox();
            this.ageEmployeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtMontantPaye = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosteOccupe = new System.Windows.Forms.TextBox();
            this.txtPeriodePayee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.BtnSupprimerTransaction = new System.Windows.Forms.Button();
            this.BtnMettreTransactionAJour = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.DgvListePaiementsEmployes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListePaiementsEmployes)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Mettre à jour .....";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.cbxNon);
            this.groupBox1.Controls.Add(this.cbxOui);
            this.groupBox1.Controls.Add(this.cbxEmployeAChanger);
            this.groupBox1.Controls.Add(this.txtNomAChanger);
            this.groupBox1.Controls.Add(this.txtPosteAChanger);
            this.groupBox1.Controls.Add(this.lblLocaliteFournisseur);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblNomFournisseur);
            this.groupBox1.Controls.Add(this.lblNomMatierePremiere);
            this.groupBox1.Controls.Add(this.BtnMettreDonneesPersoAJour);
            this.groupBox1.Location = new System.Drawing.Point(372, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 220);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails des employés et membres";
            // 
            // cbxNon
            // 
            this.cbxNon.AutoSize = true;
            this.cbxNon.Location = new System.Drawing.Point(414, 131);
            this.cbxNon.Name = "cbxNon";
            this.cbxNon.Size = new System.Drawing.Size(61, 25);
            this.cbxNon.TabIndex = 60;
            this.cbxNon.Text = "Non";
            this.cbxNon.UseVisualStyleBackColor = true;
            // 
            // cbxOui
            // 
            this.cbxOui.AutoSize = true;
            this.cbxOui.Location = new System.Drawing.Point(280, 131);
            this.cbxOui.Name = "cbxOui";
            this.cbxOui.Size = new System.Drawing.Size(56, 25);
            this.cbxOui.TabIndex = 60;
            this.cbxOui.Text = "Oui";
            this.cbxOui.UseVisualStyleBackColor = true;
            // 
            // cbxEmployeAChanger
            // 
            this.cbxEmployeAChanger.DataSource = this.ageEmployeBindingSource;
            this.cbxEmployeAChanger.DisplayMember = "PrenomNom";
            this.cbxEmployeAChanger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmployeAChanger.FormattingEnabled = true;
            this.cbxEmployeAChanger.Location = new System.Drawing.Point(260, 27);
            this.cbxEmployeAChanger.Margin = new System.Windows.Forms.Padding(5);
            this.cbxEmployeAChanger.Name = "cbxEmployeAChanger";
            this.cbxEmployeAChanger.Size = new System.Drawing.Size(286, 29);
            this.cbxEmployeAChanger.TabIndex = 40;
            this.cbxEmployeAChanger.ValueMember = "CodeEmploye";
            this.cbxEmployeAChanger.SelectedIndexChanged += new System.EventHandler(this.CbxEmployeAChanger_SelectedIndexChanged);
            // 
            // ageEmployeBindingSource
            // 
            this.ageEmployeBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // txtNomAChanger
            // 
            this.txtNomAChanger.Location = new System.Drawing.Point(260, 67);
            this.txtNomAChanger.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomAChanger.Name = "txtNomAChanger";
            this.txtNomAChanger.ReadOnly = true;
            this.txtNomAChanger.Size = new System.Drawing.Size(286, 27);
            this.txtNomAChanger.TabIndex = 59;
            // 
            // txtPosteAChanger
            // 
            this.txtPosteAChanger.Location = new System.Drawing.Point(260, 102);
            this.txtPosteAChanger.Margin = new System.Windows.Forms.Padding(5);
            this.txtPosteAChanger.Name = "txtPosteAChanger";
            this.txtPosteAChanger.ReadOnly = true;
            this.txtPosteAChanger.Size = new System.Drawing.Size(286, 27);
            this.txtPosteAChanger.TabIndex = 59;
            // 
            // lblLocaliteFournisseur
            // 
            this.lblLocaliteFournisseur.AutoSize = true;
            this.lblLocaliteFournisseur.Location = new System.Drawing.Point(14, 135);
            this.lblLocaliteFournisseur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLocaliteFournisseur.Name = "lblLocaliteFournisseur";
            this.lblLocaliteFournisseur.Size = new System.Drawing.Size(57, 21);
            this.lblLocaliteFournisseur.TabIndex = 52;
            this.lblLocaliteFournisseur.Text = "Actif?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 54;
            this.label5.Text = "Prénom et nom";
            // 
            // lblNomFournisseur
            // 
            this.lblNomFournisseur.AutoSize = true;
            this.lblNomFournisseur.Location = new System.Drawing.Point(14, 102);
            this.lblNomFournisseur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomFournisseur.Name = "lblNomFournisseur";
            this.lblNomFournisseur.Size = new System.Drawing.Size(117, 21);
            this.lblNomFournisseur.TabIndex = 54;
            this.lblNomFournisseur.Text = "Poste occupé";
            // 
            // lblNomMatierePremiere
            // 
            this.lblNomMatierePremiere.AutoSize = true;
            this.lblNomMatierePremiere.Location = new System.Drawing.Point(11, 27);
            this.lblNomMatierePremiere.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomMatierePremiere.Name = "lblNomMatierePremiere";
            this.lblNomMatierePremiere.Size = new System.Drawing.Size(151, 21);
            this.lblNomMatierePremiere.TabIndex = 53;
            this.lblNomMatierePremiere.Text = "Liste des employes";
            // 
            // BtnMettreDonneesPersoAJour
            // 
            this.BtnMettreDonneesPersoAJour.BackColor = System.Drawing.Color.DarkGray;
            this.BtnMettreDonneesPersoAJour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMettreDonneesPersoAJour.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnMettreDonneesPersoAJour.FlatAppearance.BorderSize = 2;
            this.BtnMettreDonneesPersoAJour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMettreDonneesPersoAJour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMettreDonneesPersoAJour.Location = new System.Drawing.Point(287, 170);
            this.BtnMettreDonneesPersoAJour.Name = "BtnMettreDonneesPersoAJour";
            this.BtnMettreDonneesPersoAJour.Size = new System.Drawing.Size(259, 36);
            this.BtnMettreDonneesPersoAJour.TabIndex = 39;
            this.BtnMettreDonneesPersoAJour.Text = "Mettre données à jour";
            this.BtnMettreDonneesPersoAJour.UseVisualStyleBackColor = false;
            this.BtnMettreDonneesPersoAJour.Click += new System.EventHandler(this.BtnMettreDonneesPersoAJour_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.dtpDatePaiement);
            this.groupBox2.Controls.Add(this.CbxCompteDePaiment);
            this.groupBox2.Controls.Add(this.CbxTresoriere);
            this.groupBox2.Controls.Add(this.CbxNomEmploye);
            this.groupBox2.Controls.Add(this.txtMontantPaye);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPosteOccupe);
            this.groupBox2.Controls.Add(this.txtPeriodePayee);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.BtnSupprimerTransaction);
            this.groupBox2.Controls.Add(this.BtnMettreTransactionAJour);
            this.groupBox2.Location = new System.Drawing.Point(372, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 333);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Détails de la transaction";
            // 
            // dtpDatePaiement
            // 
            this.dtpDatePaiement.Checked = false;
            this.dtpDatePaiement.CustomFormat = "dd / MM / yyyy";
            this.dtpDatePaiement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatePaiement.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatePaiement.Location = new System.Drawing.Point(280, 120);
            this.dtpDatePaiement.Name = "dtpDatePaiement";
            this.dtpDatePaiement.Size = new System.Drawing.Size(286, 27);
            this.dtpDatePaiement.TabIndex = 64;
            // 
            // CbxCompteDePaiment
            // 
            this.CbxCompteDePaiment.DataSource = this.resComptesTresorerieBindingSource;
            this.CbxCompteDePaiment.DisplayMember = "NomCompte";
            this.CbxCompteDePaiment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCompteDePaiment.FormattingEnabled = true;
            this.CbxCompteDePaiment.Location = new System.Drawing.Point(280, 221);
            this.CbxCompteDePaiment.Margin = new System.Windows.Forms.Padding(5);
            this.CbxCompteDePaiment.Name = "CbxCompteDePaiment";
            this.CbxCompteDePaiment.Size = new System.Drawing.Size(286, 29);
            this.CbxCompteDePaiment.TabIndex = 63;
            this.CbxCompteDePaiment.ValueMember = "CodeCompte";
            // 
            // resComptesTresorerieBindingSource
            // 
            this.resComptesTresorerieBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResComptesTresorerie);
            // 
            // CbxTresoriere
            // 
            this.CbxTresoriere.DataSource = this.ageEmployeBindingSource2;
            this.CbxTresoriere.DisplayMember = "PrenomNom";
            this.CbxTresoriere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTresoriere.FormattingEnabled = true;
            this.CbxTresoriere.Location = new System.Drawing.Point(280, 186);
            this.CbxTresoriere.Margin = new System.Windows.Forms.Padding(5);
            this.CbxTresoriere.Name = "CbxTresoriere";
            this.CbxTresoriere.Size = new System.Drawing.Size(286, 29);
            this.CbxTresoriere.TabIndex = 62;
            this.CbxTresoriere.ValueMember = "CodeEmploye";
            // 
            // ageEmployeBindingSource2
            // 
            this.ageEmployeBindingSource2.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // CbxNomEmploye
            // 
            this.CbxNomEmploye.DataSource = this.ageEmployeBindingSource1;
            this.CbxNomEmploye.DisplayMember = "PrenomNom";
            this.CbxNomEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxNomEmploye.FormattingEnabled = true;
            this.CbxNomEmploye.Location = new System.Drawing.Point(280, 20);
            this.CbxNomEmploye.Margin = new System.Windows.Forms.Padding(5);
            this.CbxNomEmploye.Name = "CbxNomEmploye";
            this.CbxNomEmploye.Size = new System.Drawing.Size(286, 29);
            this.CbxNomEmploye.TabIndex = 40;
            this.CbxNomEmploye.ValueMember = "CodeEmploye";
            // 
            // ageEmployeBindingSource1
            // 
            this.ageEmployeBindingSource1.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // txtMontantPaye
            // 
            this.txtMontantPaye.Location = new System.Drawing.Point(280, 153);
            this.txtMontantPaye.Margin = new System.Windows.Forms.Padding(5);
            this.txtMontantPaye.Name = "txtMontantPaye";
            this.txtMontantPaye.ReadOnly = true;
            this.txtMontantPaye.Size = new System.Drawing.Size(286, 27);
            this.txtMontantPaye.TabIndex = 58;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(280, 256);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(286, 27);
            this.textBox2.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Solde compte séléctionné";
            // 
            // txtPosteOccupe
            // 
            this.txtPosteOccupe.Location = new System.Drawing.Point(280, 54);
            this.txtPosteOccupe.Margin = new System.Windows.Forms.Padding(5);
            this.txtPosteOccupe.Name = "txtPosteOccupe";
            this.txtPosteOccupe.ReadOnly = true;
            this.txtPosteOccupe.Size = new System.Drawing.Size(286, 27);
            this.txtPosteOccupe.TabIndex = 59;
            // 
            // txtPeriodePayee
            // 
            this.txtPeriodePayee.Location = new System.Drawing.Point(280, 88);
            this.txtPeriodePayee.Margin = new System.Windows.Forms.Padding(5);
            this.txtPeriodePayee.Name = "txtPeriodePayee";
            this.txtPeriodePayee.ReadOnly = true;
            this.txtPeriodePayee.Size = new System.Drawing.Size(286, 27);
            this.txtPeriodePayee.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Compte de paiement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Décaissement fait par";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 47;
            this.label7.Text = "Montant Payé";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 120);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 21);
            this.label12.TabIndex = 51;
            this.label12.Text = "Date de paiement";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 88);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 21);
            this.label13.TabIndex = 50;
            this.label13.Text = "Période payée";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 54);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 21);
            this.label15.TabIndex = 54;
            this.label15.Text = "Poste occupé";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 28);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(268, 21);
            this.label16.TabIndex = 53;
            this.label16.Text = "Nom de l\'employé ou du membre";
            // 
            // BtnSupprimerTransaction
            // 
            this.BtnSupprimerTransaction.BackColor = System.Drawing.Color.DarkRed;
            this.BtnSupprimerTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSupprimerTransaction.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnSupprimerTransaction.FlatAppearance.BorderSize = 2;
            this.BtnSupprimerTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimerTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimerTransaction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSupprimerTransaction.Location = new System.Drawing.Point(339, 288);
            this.BtnSupprimerTransaction.Name = "BtnSupprimerTransaction";
            this.BtnSupprimerTransaction.Size = new System.Drawing.Size(229, 36);
            this.BtnSupprimerTransaction.TabIndex = 39;
            this.BtnSupprimerTransaction.Text = "Supprimer la transaction";
            this.BtnSupprimerTransaction.UseVisualStyleBackColor = false;
            this.BtnSupprimerTransaction.Click += new System.EventHandler(this.BtnSupprimerTransaction_Click);
            // 
            // BtnMettreTransactionAJour
            // 
            this.BtnMettreTransactionAJour.BackColor = System.Drawing.Color.DarkGray;
            this.BtnMettreTransactionAJour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMettreTransactionAJour.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnMettreTransactionAJour.FlatAppearance.BorderSize = 2;
            this.BtnMettreTransactionAJour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMettreTransactionAJour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMettreTransactionAJour.Location = new System.Drawing.Point(11, 288);
            this.BtnMettreTransactionAJour.Name = "BtnMettreTransactionAJour";
            this.BtnMettreTransactionAJour.Size = new System.Drawing.Size(309, 36);
            this.BtnMettreTransactionAJour.TabIndex = 39;
            this.BtnMettreTransactionAJour.Text = "Mettre le compte de paiement à jour";
            this.BtnMettreTransactionAJour.UseVisualStyleBackColor = false;
            this.BtnMettreTransactionAJour.Click += new System.EventHandler(this.BtnMettreTransactionAJour_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 21);
            this.label8.TabIndex = 57;
            this.label8.Text = "Au";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 21);
            this.label6.TabIndex = 58;
            this.label6.Text = "Du";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(53, 118);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(131, 27);
            this.dtpFin.TabIndex = 56;
            this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFin_ValueChanged);
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(53, 85);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(131, 27);
            this.dtpDebut.TabIndex = 55;
            this.dtpDebut.ValueChanged += new System.EventHandler(this.DtpDebut_ValueChanged);
            // 
            // DgvListePaiementsEmployes
            // 
            this.DgvListePaiementsEmployes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvListePaiementsEmployes.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.DgvListePaiementsEmployes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvListePaiementsEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListePaiementsEmployes.Location = new System.Drawing.Point(18, 157);
            this.DgvListePaiementsEmployes.Name = "DgvListePaiementsEmployes";
            this.DgvListePaiementsEmployes.ReadOnly = true;
            this.DgvListePaiementsEmployes.RowHeadersVisible = false;
            this.DgvListePaiementsEmployes.Size = new System.Drawing.Size(335, 424);
            this.DgvListePaiementsEmployes.TabIndex = 54;
            this.DgvListePaiementsEmployes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListePaiementsEmployes_CellContentClick);
            // 
            // UC_UpdatePersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.DgvListePaiementsEmployes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_UpdatePersonnel";
            this.Size = new System.Drawing.Size(983, 596);
            this.Load += new System.EventHandler(this.UC_UpdatePersonnel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListePaiementsEmployes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxEmployeAChanger;
        private System.Windows.Forms.TextBox txtPosteAChanger;
        private System.Windows.Forms.Label lblLocaliteFournisseur;
        private System.Windows.Forms.Label lblNomFournisseur;
        private System.Windows.Forms.Label lblNomMatierePremiere;
        private System.Windows.Forms.Button BtnMettreDonneesPersoAJour;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BtnSupprimerTransaction;
        private System.Windows.Forms.Button BtnMettreTransactionAJour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DataGridView DgvListePaiementsEmployes;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource;
        private System.Windows.Forms.BindingSource resComptesTresorerieBindingSource;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource2;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource1;
        private System.Windows.Forms.DateTimePicker dtpDatePaiement;
        private System.Windows.Forms.ComboBox CbxCompteDePaiment;
        private System.Windows.Forms.ComboBox CbxTresoriere;
        private System.Windows.Forms.ComboBox CbxNomEmploye;
        private System.Windows.Forms.TextBox txtMontantPaye;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPosteOccupe;
        private System.Windows.Forms.TextBox txtPeriodePayee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomAChanger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxNon;
        private System.Windows.Forms.CheckBox cbxOui;
    }
}
