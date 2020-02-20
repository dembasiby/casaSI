namespace CasaEcologieSysInfo.Pages.Corrections
{
    partial class UC_UpdateAchatMatPremiere
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDateApprovisionnement = new System.Windows.Forms.DateTimePicker();
            this.cbxComptePaiement = new System.Windows.Forms.ComboBox();
            this.resComptesTresorerieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxTresoriere = new System.Windows.Forms.ComboBox();
            this.ageEmployeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbxFournisseurMPrem = new System.Windows.Forms.ComboBox();
            this.ageFournisseursMatieresPremiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxRespStocks = new System.Windows.Forms.ComboBox();
            this.ageEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxNomMatierePremiere = new System.Windows.Forms.ComboBox();
            this.resStockMatieresPremiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMontantPaye = new System.Windows.Forms.TextBox();
            this.txtSoldeCompte = new System.Windows.Forms.TextBox();
            this.txtTransportMatierePremiere = new System.Windows.Forms.TextBox();
            this.txtMontantAchat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocaliteFournisseur = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.lblComptePaiement = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMontantPaye = new System.Windows.Forms.Label();
            this.lblAchatFaitPar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblLocaliteFournisseur = new System.Windows.Forms.Label();
            this.lblNomFournisseur = new System.Windows.Forms.Label();
            this.lblNomMatierePremiere = new System.Windows.Forms.Label();
            this.BtnSupprimerTransaction = new System.Windows.Forms.Button();
            this.btnMettreTransactionAJour = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dgvListeAchatsMatieres = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFournisseursMatieresPremiereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremiereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeAchatsMatieres)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.dtpDateApprovisionnement);
            this.groupBox1.Controls.Add(this.cbxComptePaiement);
            this.groupBox1.Controls.Add(this.cbxTresoriere);
            this.groupBox1.Controls.Add(this.cbxFournisseurMPrem);
            this.groupBox1.Controls.Add(this.cbxRespStocks);
            this.groupBox1.Controls.Add(this.cbxNomMatierePremiere);
            this.groupBox1.Controls.Add(this.txtMontantPaye);
            this.groupBox1.Controls.Add(this.txtSoldeCompte);
            this.groupBox1.Controls.Add(this.txtTransportMatierePremiere);
            this.groupBox1.Controls.Add(this.txtMontantAchat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLocaliteFournisseur);
            this.groupBox1.Controls.Add(this.txtQuantite);
            this.groupBox1.Controls.Add(this.lblComptePaiement);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblMontantPaye);
            this.groupBox1.Controls.Add(this.lblAchatFaitPar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblMontant);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblQuantite);
            this.groupBox1.Controls.Add(this.lblLocaliteFournisseur);
            this.groupBox1.Controls.Add(this.lblNomFournisseur);
            this.groupBox1.Controls.Add(this.lblNomMatierePremiere);
            this.groupBox1.Controls.Add(this.BtnSupprimerTransaction);
            this.groupBox1.Controls.Add(this.btnMettreTransactionAJour);
            this.groupBox1.Location = new System.Drawing.Point(383, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 544);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails de la transaction";
            // 
            // dtpDateApprovisionnement
            // 
            this.dtpDateApprovisionnement.Checked = false;
            this.dtpDateApprovisionnement.CustomFormat = "dd / MM / yyyy";
            this.dtpDateApprovisionnement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateApprovisionnement.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateApprovisionnement.Location = new System.Drawing.Point(261, 177);
            this.dtpDateApprovisionnement.Name = "dtpDateApprovisionnement";
            this.dtpDateApprovisionnement.Size = new System.Drawing.Size(286, 27);
            this.dtpDateApprovisionnement.TabIndex = 64;
            // 
            // cbxComptePaiement
            // 
            this.cbxComptePaiement.DataSource = this.resComptesTresorerieBindingSource;
            this.cbxComptePaiement.DisplayMember = "NomCompte";
            this.cbxComptePaiement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComptePaiement.FormattingEnabled = true;
            this.cbxComptePaiement.Location = new System.Drawing.Point(261, 397);
            this.cbxComptePaiement.Margin = new System.Windows.Forms.Padding(5);
            this.cbxComptePaiement.Name = "cbxComptePaiement";
            this.cbxComptePaiement.Size = new System.Drawing.Size(286, 29);
            this.cbxComptePaiement.TabIndex = 63;
            this.cbxComptePaiement.ValueMember = "CodeCompte";
            // 
            // resComptesTresorerieBindingSource
            // 
            this.resComptesTresorerieBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResComptesTresorerie);
            // 
            // cbxTresoriere
            // 
            this.cbxTresoriere.DataSource = this.ageEmployeBindingSource1;
            this.cbxTresoriere.DisplayMember = "PrenomNom";
            this.cbxTresoriere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTresoriere.FormattingEnabled = true;
            this.cbxTresoriere.Location = new System.Drawing.Point(261, 358);
            this.cbxTresoriere.Margin = new System.Windows.Forms.Padding(5);
            this.cbxTresoriere.Name = "cbxTresoriere";
            this.cbxTresoriere.Size = new System.Drawing.Size(286, 29);
            this.cbxTresoriere.TabIndex = 62;
            this.cbxTresoriere.ValueMember = "CodeEmploye";
            // 
            // ageEmployeBindingSource1
            // 
            this.ageEmployeBindingSource1.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // cbxFournisseurMPrem
            // 
            this.cbxFournisseurMPrem.DataSource = this.ageFournisseursMatieresPremiereBindingSource;
            this.cbxFournisseurMPrem.DisplayMember = "Nom";
            this.cbxFournisseurMPrem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFournisseurMPrem.FormattingEnabled = true;
            this.cbxFournisseurMPrem.Location = new System.Drawing.Point(261, 65);
            this.cbxFournisseurMPrem.Margin = new System.Windows.Forms.Padding(5);
            this.cbxFournisseurMPrem.Name = "cbxFournisseurMPrem";
            this.cbxFournisseurMPrem.Size = new System.Drawing.Size(286, 29);
            this.cbxFournisseurMPrem.TabIndex = 42;
            this.cbxFournisseurMPrem.ValueMember = "CodeFournisseurMatierePremiere";
            // 
            // ageFournisseursMatieresPremiereBindingSource
            // 
            this.ageFournisseursMatieresPremiereBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeFournisseursMatieresPremiere);
            // 
            // cbxRespStocks
            // 
            this.cbxRespStocks.DataSource = this.ageEmployeBindingSource;
            this.cbxRespStocks.DisplayMember = "PrenomNom";
            this.cbxRespStocks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRespStocks.FormattingEnabled = true;
            this.cbxRespStocks.Location = new System.Drawing.Point(261, 319);
            this.cbxRespStocks.Margin = new System.Windows.Forms.Padding(5);
            this.cbxRespStocks.Name = "cbxRespStocks";
            this.cbxRespStocks.Size = new System.Drawing.Size(286, 29);
            this.cbxRespStocks.TabIndex = 61;
            this.cbxRespStocks.ValueMember = "CodeEmploye";
            // 
            // ageEmployeBindingSource
            // 
            this.ageEmployeBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // cbxNomMatierePremiere
            // 
            this.cbxNomMatierePremiere.DataSource = this.resStockMatieresPremiereBindingSource;
            this.cbxNomMatierePremiere.DisplayMember = "NomMatiere";
            this.cbxNomMatierePremiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNomMatierePremiere.FormattingEnabled = true;
            this.cbxNomMatierePremiere.Location = new System.Drawing.Point(261, 28);
            this.cbxNomMatierePremiere.Margin = new System.Windows.Forms.Padding(5);
            this.cbxNomMatierePremiere.Name = "cbxNomMatierePremiere";
            this.cbxNomMatierePremiere.Size = new System.Drawing.Size(286, 29);
            this.cbxNomMatierePremiere.TabIndex = 40;
            this.cbxNomMatierePremiere.ValueMember = "CodeMatierePremiere";
            // 
            // resStockMatieresPremiereBindingSource
            // 
            this.resStockMatieresPremiereBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResStockMatieresPremiere);
            // 
            // txtMontantPaye
            // 
            this.txtMontantPaye.Location = new System.Drawing.Point(261, 284);
            this.txtMontantPaye.Margin = new System.Windows.Forms.Padding(5);
            this.txtMontantPaye.Name = "txtMontantPaye";
            this.txtMontantPaye.Size = new System.Drawing.Size(286, 27);
            this.txtMontantPaye.TabIndex = 58;
            // 
            // txtSoldeCompte
            // 
            this.txtSoldeCompte.Enabled = false;
            this.txtSoldeCompte.Location = new System.Drawing.Point(261, 438);
            this.txtSoldeCompte.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoldeCompte.Name = "txtSoldeCompte";
            this.txtSoldeCompte.ReadOnly = true;
            this.txtSoldeCompte.Size = new System.Drawing.Size(286, 27);
            this.txtSoldeCompte.TabIndex = 57;
            // 
            // txtTransportMatierePremiere
            // 
            this.txtTransportMatierePremiere.Location = new System.Drawing.Point(261, 248);
            this.txtTransportMatierePremiere.Margin = new System.Windows.Forms.Padding(5);
            this.txtTransportMatierePremiere.Name = "txtTransportMatierePremiere";
            this.txtTransportMatierePremiere.Size = new System.Drawing.Size(286, 27);
            this.txtTransportMatierePremiere.TabIndex = 56;
            this.txtTransportMatierePremiere.Text = "0";
            // 
            // txtMontantAchat
            // 
            this.txtMontantAchat.Location = new System.Drawing.Point(261, 214);
            this.txtMontantAchat.Margin = new System.Windows.Forms.Padding(5);
            this.txtMontantAchat.Name = "txtMontantAchat";
            this.txtMontantAchat.Size = new System.Drawing.Size(286, 27);
            this.txtMontantAchat.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 441);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "Solde compte séléctionné";
            // 
            // txtLocaliteFournisseur
            // 
            this.txtLocaliteFournisseur.Location = new System.Drawing.Point(261, 104);
            this.txtLocaliteFournisseur.Margin = new System.Windows.Forms.Padding(5);
            this.txtLocaliteFournisseur.Name = "txtLocaliteFournisseur";
            this.txtLocaliteFournisseur.ReadOnly = true;
            this.txtLocaliteFournisseur.Size = new System.Drawing.Size(286, 27);
            this.txtLocaliteFournisseur.TabIndex = 59;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(261, 140);
            this.txtQuantite.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(286, 27);
            this.txtQuantite.TabIndex = 59;
            // 
            // lblComptePaiement
            // 
            this.lblComptePaiement.AutoSize = true;
            this.lblComptePaiement.Location = new System.Drawing.Point(39, 402);
            this.lblComptePaiement.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblComptePaiement.Name = "lblComptePaiement";
            this.lblComptePaiement.Size = new System.Drawing.Size(182, 21);
            this.lblComptePaiement.TabIndex = 49;
            this.lblComptePaiement.Text = "Compte de paiement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 363);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 21);
            this.label6.TabIndex = 48;
            this.label6.Text = "Décaissement fait par";
            // 
            // lblMontantPaye
            // 
            this.lblMontantPaye.AutoSize = true;
            this.lblMontantPaye.Location = new System.Drawing.Point(41, 290);
            this.lblMontantPaye.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMontantPaye.Name = "lblMontantPaye";
            this.lblMontantPaye.Size = new System.Drawing.Size(122, 21);
            this.lblMontantPaye.TabIndex = 47;
            this.lblMontantPaye.Text = "Montant Payé";
            // 
            // lblAchatFaitPar
            // 
            this.lblAchatFaitPar.AutoSize = true;
            this.lblAchatFaitPar.Location = new System.Drawing.Point(39, 327);
            this.lblAchatFaitPar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAchatFaitPar.Name = "lblAchatFaitPar";
            this.lblAchatFaitPar.Size = new System.Drawing.Size(196, 21);
            this.lblAchatFaitPar.TabIndex = 46;
            this.lblAchatFaitPar.Text = "Produit réceptionné par";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 254);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 45;
            this.label9.Text = "Transport";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(41, 220);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(80, 21);
            this.lblMontant.TabIndex = 44;
            this.lblMontant.Text = "Montant";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(39, 183);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 21);
            this.lblDate.TabIndex = 51;
            this.lblDate.Text = "Date";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(39, 146);
            this.lblQuantite.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(220, 21);
            this.lblQuantite.TabIndex = 50;
            this.lblQuantite.Text = "Quantité (kg pour les fruits)";
            // 
            // lblLocaliteFournisseur
            // 
            this.lblLocaliteFournisseur.AutoSize = true;
            this.lblLocaliteFournisseur.Location = new System.Drawing.Point(41, 106);
            this.lblLocaliteFournisseur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLocaliteFournisseur.Name = "lblLocaliteFournisseur";
            this.lblLocaliteFournisseur.Size = new System.Drawing.Size(155, 21);
            this.lblLocaliteFournisseur.TabIndex = 52;
            this.lblLocaliteFournisseur.Text = "Localité fournisseur";
            // 
            // lblNomFournisseur
            // 
            this.lblNomFournisseur.AutoSize = true;
            this.lblNomFournisseur.Location = new System.Drawing.Point(39, 73);
            this.lblNomFournisseur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomFournisseur.Name = "lblNomFournisseur";
            this.lblNomFournisseur.Size = new System.Drawing.Size(131, 21);
            this.lblNomFournisseur.TabIndex = 54;
            this.lblNomFournisseur.Text = "Nom fournisseur";
            // 
            // lblNomMatierePremiere
            // 
            this.lblNomMatierePremiere.AutoSize = true;
            this.lblNomMatierePremiere.Location = new System.Drawing.Point(39, 36);
            this.lblNomMatierePremiere.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomMatierePremiere.Name = "lblNomMatierePremiere";
            this.lblNomMatierePremiere.Size = new System.Drawing.Size(185, 21);
            this.lblNomMatierePremiere.TabIndex = 53;
            this.lblNomMatierePremiere.Text = "Nom matière première";
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
            this.BtnSupprimerTransaction.Location = new System.Drawing.Point(318, 484);
            this.BtnSupprimerTransaction.Name = "BtnSupprimerTransaction";
            this.BtnSupprimerTransaction.Size = new System.Drawing.Size(229, 36);
            this.BtnSupprimerTransaction.TabIndex = 39;
            this.BtnSupprimerTransaction.Text = "Supprimer la transaction";
            this.BtnSupprimerTransaction.UseVisualStyleBackColor = false;
            this.BtnSupprimerTransaction.Click += new System.EventHandler(this.BtnSupprimerTransaction_Click);
            // 
            // btnMettreTransactionAJour
            // 
            this.btnMettreTransactionAJour.BackColor = System.Drawing.Color.DarkGray;
            this.btnMettreTransactionAJour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMettreTransactionAJour.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnMettreTransactionAJour.FlatAppearance.BorderSize = 2;
            this.btnMettreTransactionAJour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMettreTransactionAJour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMettreTransactionAJour.Location = new System.Drawing.Point(26, 484);
            this.btnMettreTransactionAJour.Name = "btnMettreTransactionAJour";
            this.btnMettreTransactionAJour.Size = new System.Drawing.Size(259, 36);
            this.btnMettreTransactionAJour.TabIndex = 39;
            this.btnMettreTransactionAJour.Text = "Mettre la transaction à jour";
            this.btnMettreTransactionAJour.UseVisualStyleBackColor = false;
            this.btnMettreTransactionAJour.Click += new System.EventHandler(this.BtnMettreTransactionAJour_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 21);
            this.label8.TabIndex = 50;
            this.label8.Text = "Au";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 21);
            this.label7.TabIndex = 51;
            this.label7.Text = "Du";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(246, 43);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(131, 27);
            this.dtpFin.TabIndex = 49;
            this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFin_ValueChanged);
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(48, 43);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(131, 27);
            this.dtpDebut.TabIndex = 48;
            this.dtpDebut.ValueChanged += new System.EventHandler(this.DtpDebut_ValueChanged);
            // 
            // dgvListeAchatsMatieres
            // 
            this.dgvListeAchatsMatieres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListeAchatsMatieres.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvListeAchatsMatieres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListeAchatsMatieres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeAchatsMatieres.Location = new System.Drawing.Point(16, 76);
            this.dgvListeAchatsMatieres.Name = "dgvListeAchatsMatieres";
            this.dgvListeAchatsMatieres.ReadOnly = true;
            this.dgvListeAchatsMatieres.RowHeadersVisible = false;
            this.dgvListeAchatsMatieres.Size = new System.Drawing.Size(361, 515);
            this.dgvListeAchatsMatieres.TabIndex = 47;
            this.dgvListeAchatsMatieres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListeAchatsMatieres_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(760, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Mettre à jour un achat de matière première, d\'emballages ou d\'étiquettes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UC_UpdateAchatMatPremiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.dgvListeAchatsMatieres);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_UpdateAchatMatPremiere";
            this.Size = new System.Drawing.Size(983, 596);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFournisseursMatieresPremiereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremiereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeAchatsMatieres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSupprimerTransaction;
        private System.Windows.Forms.Button btnMettreTransactionAJour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DataGridView dgvListeAchatsMatieres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateApprovisionnement;
        private System.Windows.Forms.ComboBox cbxComptePaiement;
        private System.Windows.Forms.ComboBox cbxTresoriere;
        private System.Windows.Forms.ComboBox cbxFournisseurMPrem;
        private System.Windows.Forms.ComboBox cbxRespStocks;
        private System.Windows.Forms.ComboBox cbxNomMatierePremiere;
        private System.Windows.Forms.TextBox txtMontantPaye;
        private System.Windows.Forms.TextBox txtSoldeCompte;
        private System.Windows.Forms.TextBox txtTransportMatierePremiere;
        private System.Windows.Forms.TextBox txtMontantAchat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocaliteFournisseur;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Label lblComptePaiement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMontantPaye;
        private System.Windows.Forms.Label lblAchatFaitPar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblLocaliteFournisseur;
        private System.Windows.Forms.Label lblNomFournisseur;
        private System.Windows.Forms.Label lblNomMatierePremiere;
        private System.Windows.Forms.BindingSource ageFournisseursMatieresPremiereBindingSource;
        private System.Windows.Forms.BindingSource resStockMatieresPremiereBindingSource;
        private System.Windows.Forms.BindingSource resComptesTresorerieBindingSource;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource1;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource;
    }
}
