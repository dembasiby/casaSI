namespace CasaEcologieSysInfo
{
    partial class UC_AchatMatierePremiere
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
            this.cbxNomMatierePremiere = new System.Windows.Forms.ComboBox();
            this.resStockMatieresPremieresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casaDBDataSetAll = new CasaEcologieSysInfo.CasaDBDataSetAll();
            this.btnEnregistrerAchatMatierePremiere = new System.Windows.Forms.Button();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomMatierePremiere = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDateApprovisionnement = new System.Windows.Forms.DateTimePicker();
            this.lblNomFournisseur = new System.Windows.Forms.Label();
            this.cbxFournisseurMPrem = new System.Windows.Forms.ComboBox();
            this.ageFournisseursMatieresPremieresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbNouveauFournisseur = new System.Windows.Forms.GroupBox();
            this.btnNouveauFournisseur = new System.Windows.Forms.Button();
            this.txtSoldeInitialeDette = new System.Windows.Forms.TextBox();
            this.txtLocalite = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNomFournisseurMP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNomNouveauClient = new System.Windows.Forms.Label();
            this.gBxNouvelleMatierePremiere = new System.Windows.Forms.GroupBox();
            this.btnAjouterNouvelleMatierePremiere = new System.Windows.Forms.Button();
            this.txtStockInitial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomMatierePremiere = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMontantPaye = new System.Windows.Forms.Label();
            this.txtMontantPaye = new System.Windows.Forms.TextBox();
            this.casaDBDataSet = new CasaEcologieSysInfo.CasaDBDataSet();
            this.casaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ageFournisseursMatieresPremieresTableAdapter = new CasaEcologieSysInfo.CasaDBDataSetAllTableAdapters.AgeFournisseursMatieresPremieresTableAdapter();
            this.resStockMatieresPremieresTableAdapter = new CasaEcologieSysInfo.CasaDBDataSetAllTableAdapters.ResStockMatieresPremieresTableAdapter();
            this.lblAchatFaitPar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxRespStocks = new System.Windows.Forms.ComboBox();
            this.ageEmployesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ageEmployesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxTresoriere = new System.Windows.Forms.ComboBox();
            this.ageEmployesTableAdapter = new CasaEcologieSysInfo.CasaDBDataSetAllTableAdapters.AgeEmployesTableAdapter();
            this.lblComptePaiement = new System.Windows.Forms.Label();
            this.cbxComptePaiement = new System.Windows.Forms.ComboBox();
            this.resComptesTresorerieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resComptesTresorerieTableAdapter = new CasaEcologieSysInfo.CasaDBDataSetAllTableAdapters.ResComptesTresorerieTableAdapter();
            this.lblLocaliteFournisseur = new System.Windows.Forms.Label();
            this.txtLocaliteFournisseur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoldeCompte = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTransportMatierePremiere = new System.Windows.Forms.TextBox();
            this.cbxTypesMatieres = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremieresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDBDataSetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFournisseursMatieresPremieresBindingSource)).BeginInit();
            this.grbNouveauFournisseur.SuspendLayout();
            this.gBxNouvelleMatierePremiere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxNomMatierePremiere
            // 
            this.cbxNomMatierePremiere.DataSource = this.resStockMatieresPremieresBindingSource;
            this.cbxNomMatierePremiere.DisplayMember = "NomMatiere";
            this.cbxNomMatierePremiere.FormattingEnabled = true;
            this.cbxNomMatierePremiere.Location = new System.Drawing.Point(249, 102);
            this.cbxNomMatierePremiere.Margin = new System.Windows.Forms.Padding(5);
            this.cbxNomMatierePremiere.Name = "cbxNomMatierePremiere";
            this.cbxNomMatierePremiere.Size = new System.Drawing.Size(286, 29);
            this.cbxNomMatierePremiere.TabIndex = 1;
            // 
            // resStockMatieresPremieresBindingSource
            // 
            this.resStockMatieresPremieresBindingSource.DataMember = "ResStockMatieresPremieres";
            this.resStockMatieresPremieresBindingSource.DataSource = this.casaDBDataSetAll;
            // 
            // casaDBDataSetAll
            // 
            this.casaDBDataSetAll.DataSetName = "CasaDBDataSetAll";
            this.casaDBDataSetAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEnregistrerAchatMatierePremiere
            // 
            this.btnEnregistrerAchatMatierePremiere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(31)))), ((int)(((byte)(20)))));
            this.btnEnregistrerAchatMatierePremiere.FlatAppearance.BorderSize = 0;
            this.btnEnregistrerAchatMatierePremiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrerAchatMatierePremiere.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerAchatMatierePremiere.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnregistrerAchatMatierePremiere.Location = new System.Drawing.Point(31, 557);
            this.btnEnregistrerAchatMatierePremiere.Margin = new System.Windows.Forms.Padding(5);
            this.btnEnregistrerAchatMatierePremiere.Name = "btnEnregistrerAchatMatierePremiere";
            this.btnEnregistrerAchatMatierePremiere.Size = new System.Drawing.Size(504, 34);
            this.btnEnregistrerAchatMatierePremiere.TabIndex = 15;
            this.btnEnregistrerAchatMatierePremiere.Text = "Enregistrer";
            this.btnEnregistrerAchatMatierePremiere.UseVisualStyleBackColor = false;
            this.btnEnregistrerAchatMatierePremiere.Click += new System.EventHandler(this.BtnEnregistrerAchatMatierePremiere_Click);
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(249, 288);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(5);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(286, 27);
            this.txtMontant.TabIndex = 13;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(249, 214);
            this.txtQuantite.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(286, 27);
            this.txtQuantite.TabIndex = 14;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(29, 294);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(80, 21);
            this.lblMontant.TabIndex = 9;
            this.lblMontant.Text = "Montant";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(27, 220);
            this.lblQuantite.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(82, 21);
            this.lblQuantite.TabIndex = 10;
            this.lblQuantite.Text = "Quantité";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(430, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enregistrer un achat de matière première";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNomMatierePremiere
            // 
            this.lblNomMatierePremiere.AutoSize = true;
            this.lblNomMatierePremiere.Location = new System.Drawing.Point(27, 110);
            this.lblNomMatierePremiere.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomMatierePremiere.Name = "lblNomMatierePremiere";
            this.lblNomMatierePremiere.Size = new System.Drawing.Size(185, 21);
            this.lblNomMatierePremiere.TabIndex = 12;
            this.lblNomMatierePremiere.Text = "Nom matière première";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(27, 257);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 21);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date";
            // 
            // dtpDateApprovisionnement
            // 
            this.dtpDateApprovisionnement.Checked = false;
            this.dtpDateApprovisionnement.CustomFormat = "dd / MM / yyyy";
            this.dtpDateApprovisionnement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateApprovisionnement.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateApprovisionnement.Location = new System.Drawing.Point(249, 251);
            this.dtpDateApprovisionnement.Name = "dtpDateApprovisionnement";
            this.dtpDateApprovisionnement.Size = new System.Drawing.Size(286, 27);
            this.dtpDateApprovisionnement.TabIndex = 19;
            // 
            // lblNomFournisseur
            // 
            this.lblNomFournisseur.AutoSize = true;
            this.lblNomFournisseur.Location = new System.Drawing.Point(27, 147);
            this.lblNomFournisseur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomFournisseur.Name = "lblNomFournisseur";
            this.lblNomFournisseur.Size = new System.Drawing.Size(131, 21);
            this.lblNomFournisseur.TabIndex = 12;
            this.lblNomFournisseur.Text = "Nom fournisseur";
            // 
            // cbxFournisseurMPrem
            // 
            this.cbxFournisseurMPrem.DataSource = this.ageFournisseursMatieresPremieresBindingSource;
            this.cbxFournisseurMPrem.DisplayMember = "Nom";
            this.cbxFournisseurMPrem.FormattingEnabled = true;
            this.cbxFournisseurMPrem.Location = new System.Drawing.Point(249, 139);
            this.cbxFournisseurMPrem.Margin = new System.Windows.Forms.Padding(5);
            this.cbxFournisseurMPrem.Name = "cbxFournisseurMPrem";
            this.cbxFournisseurMPrem.Size = new System.Drawing.Size(286, 29);
            this.cbxFournisseurMPrem.TabIndex = 2;
            // 
            // ageFournisseursMatieresPremieresBindingSource
            // 
            this.ageFournisseursMatieresPremieresBindingSource.DataMember = "AgeFournisseursMatieresPremieres";
            this.ageFournisseursMatieresPremieresBindingSource.DataSource = this.casaDBDataSetAll;
            // 
            // grbNouveauFournisseur
            // 
            this.grbNouveauFournisseur.Controls.Add(this.btnNouveauFournisseur);
            this.grbNouveauFournisseur.Controls.Add(this.txtSoldeInitialeDette);
            this.grbNouveauFournisseur.Controls.Add(this.txtLocalite);
            this.grbNouveauFournisseur.Controls.Add(this.label12);
            this.grbNouveauFournisseur.Controls.Add(this.txtNomFournisseurMP);
            this.grbNouveauFournisseur.Controls.Add(this.label13);
            this.grbNouveauFournisseur.Controls.Add(this.label8);
            this.grbNouveauFournisseur.Controls.Add(this.lblNomNouveauClient);
            this.grbNouveauFournisseur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNouveauFournisseur.Location = new System.Drawing.Point(571, 360);
            this.grbNouveauFournisseur.Name = "grbNouveauFournisseur";
            this.grbNouveauFournisseur.Size = new System.Drawing.Size(395, 214);
            this.grbNouveauFournisseur.TabIndex = 20;
            this.grbNouveauFournisseur.TabStop = false;
            this.grbNouveauFournisseur.Text = "Nouveau Fournisseur";
            // 
            // btnNouveauFournisseur
            // 
            this.btnNouveauFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(31)))), ((int)(((byte)(20)))));
            this.btnNouveauFournisseur.FlatAppearance.BorderSize = 0;
            this.btnNouveauFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouveauFournisseur.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveauFournisseur.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNouveauFournisseur.Location = new System.Drawing.Point(244, 178);
            this.btnNouveauFournisseur.Name = "btnNouveauFournisseur";
            this.btnNouveauFournisseur.Size = new System.Drawing.Size(145, 31);
            this.btnNouveauFournisseur.TabIndex = 10;
            this.btnNouveauFournisseur.Text = "Enregistrer";
            this.btnNouveauFournisseur.UseVisualStyleBackColor = false;
            this.btnNouveauFournisseur.Click += new System.EventHandler(this.BtnNouveauFournisseur_Click);
            // 
            // txtSoldeInitialeDette
            // 
            this.txtSoldeInitialeDette.Location = new System.Drawing.Point(170, 178);
            this.txtSoldeInitialeDette.Name = "txtSoldeInitialeDette";
            this.txtSoldeInitialeDette.Size = new System.Drawing.Size(68, 27);
            this.txtSoldeInitialeDette.TabIndex = 8;
            this.txtSoldeInitialeDette.Text = "00";
            // 
            // txtLocalite
            // 
            this.txtLocalite.Location = new System.Drawing.Point(6, 145);
            this.txtLocalite.Name = "txtLocalite";
            this.txtLocalite.Size = new System.Drawing.Size(383, 27);
            this.txtLocalite.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "Solde initiale dette";
            // 
            // txtNomFournisseurMP
            // 
            this.txtNomFournisseurMP.Location = new System.Drawing.Point(5, 88);
            this.txtNomFournisseurMP.Name = "txtNomFournisseurMP";
            this.txtNomFournisseurMP.Size = new System.Drawing.Size(384, 27);
            this.txtNomFournisseurMP.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 21);
            this.label13.TabIndex = 5;
            this.label13.Text = "Localité";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(353, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Veuillez enregistrer le fournisseur s\'il n\'est pas sur la liste\r\n";
            // 
            // lblNomNouveauClient
            // 
            this.lblNomNouveauClient.AutoSize = true;
            this.lblNomNouveauClient.Location = new System.Drawing.Point(5, 64);
            this.lblNomNouveauClient.Name = "lblNomNouveauClient";
            this.lblNomNouveauClient.Size = new System.Drawing.Size(159, 21);
            this.lblNomNouveauClient.TabIndex = 7;
            this.lblNomNouveauClient.Text = "Nom du Fournisseur";
            // 
            // gBxNouvelleMatierePremiere
            // 
            this.gBxNouvelleMatierePremiere.Controls.Add(this.btnAjouterNouvelleMatierePremiere);
            this.gBxNouvelleMatierePremiere.Controls.Add(this.txtStockInitial);
            this.gBxNouvelleMatierePremiere.Controls.Add(this.label10);
            this.gBxNouvelleMatierePremiere.Controls.Add(this.label1);
            this.gBxNouvelleMatierePremiere.Controls.Add(this.txtNomMatierePremiere);
            this.gBxNouvelleMatierePremiere.Controls.Add(this.label2);
            this.gBxNouvelleMatierePremiere.Controls.Add(this.label3);
            this.gBxNouvelleMatierePremiere.Controls.Add(this.cbxTypesMatieres);
            this.gBxNouvelleMatierePremiere.Controls.Add(this.label7);
            this.gBxNouvelleMatierePremiere.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxNouvelleMatierePremiere.Location = new System.Drawing.Point(571, 95);
            this.gBxNouvelleMatierePremiere.Name = "gBxNouvelleMatierePremiere";
            this.gBxNouvelleMatierePremiere.Size = new System.Drawing.Size(395, 254);
            this.gBxNouvelleMatierePremiere.TabIndex = 20;
            this.gBxNouvelleMatierePremiere.TabStop = false;
            this.gBxNouvelleMatierePremiere.Text = "Nouvelle matière première";
            // 
            // btnAjouterNouvelleMatierePremiere
            // 
            this.btnAjouterNouvelleMatierePremiere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(31)))), ((int)(((byte)(20)))));
            this.btnAjouterNouvelleMatierePremiere.FlatAppearance.BorderSize = 0;
            this.btnAjouterNouvelleMatierePremiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterNouvelleMatierePremiere.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterNouvelleMatierePremiere.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAjouterNouvelleMatierePremiere.Location = new System.Drawing.Point(5, 203);
            this.btnAjouterNouvelleMatierePremiere.Name = "btnAjouterNouvelleMatierePremiere";
            this.btnAjouterNouvelleMatierePremiere.Size = new System.Drawing.Size(365, 31);
            this.btnAjouterNouvelleMatierePremiere.TabIndex = 10;
            this.btnAjouterNouvelleMatierePremiere.Text = "Enregistrer";
            this.btnAjouterNouvelleMatierePremiere.UseVisualStyleBackColor = false;
            this.btnAjouterNouvelleMatierePremiere.Click += new System.EventHandler(this.BtnAjouterNouvelleMatierePremiere_Click);
            // 
            // txtStockInitial
            // 
            this.txtStockInitial.Location = new System.Drawing.Point(123, 167);
            this.txtStockInitial.Name = "txtStockInitial";
            this.txtStockInitial.Size = new System.Drawing.Size(247, 23);
            this.txtStockInitial.TabIndex = 8;
            this.txtStockInitial.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Stock initial";
            // 
            // txtNomMatierePremiere
            // 
            this.txtNomMatierePremiere.Location = new System.Drawing.Point(123, 95);
            this.txtNomMatierePremiere.Name = "txtNomMatierePremiere";
            this.txtNomMatierePremiere.Size = new System.Drawing.Size(247, 23);
            this.txtNomMatierePremiere.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "n\'est pas sur la liste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Veuillez enregistrer la matière première si elle";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Matière Première";
            // 
            // lblMontantPaye
            // 
            this.lblMontantPaye.AutoSize = true;
            this.lblMontantPaye.Location = new System.Drawing.Point(29, 364);
            this.lblMontantPaye.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMontantPaye.Name = "lblMontantPaye";
            this.lblMontantPaye.Size = new System.Drawing.Size(122, 21);
            this.lblMontantPaye.TabIndex = 9;
            this.lblMontantPaye.Text = "Montant Payé";
            // 
            // txtMontantPaye
            // 
            this.txtMontantPaye.Location = new System.Drawing.Point(249, 358);
            this.txtMontantPaye.Margin = new System.Windows.Forms.Padding(5);
            this.txtMontantPaye.Name = "txtMontantPaye";
            this.txtMontantPaye.Size = new System.Drawing.Size(286, 27);
            this.txtMontantPaye.TabIndex = 13;
            // 
            // casaDBDataSet
            // 
            this.casaDBDataSet.DataSetName = "CasaDBDataSet";
            this.casaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // casaDBDataSetBindingSource
            // 
            this.casaDBDataSetBindingSource.DataSource = this.casaDBDataSet;
            this.casaDBDataSetBindingSource.Position = 0;
            // 
            // ageFournisseursMatieresPremieresTableAdapter
            // 
            this.ageFournisseursMatieresPremieresTableAdapter.ClearBeforeFill = true;
            // 
            // resStockMatieresPremieresTableAdapter
            // 
            this.resStockMatieresPremieresTableAdapter.ClearBeforeFill = true;
            // 
            // lblAchatFaitPar
            // 
            this.lblAchatFaitPar.AutoSize = true;
            this.lblAchatFaitPar.Location = new System.Drawing.Point(27, 401);
            this.lblAchatFaitPar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAchatFaitPar.Name = "lblAchatFaitPar";
            this.lblAchatFaitPar.Size = new System.Drawing.Size(196, 21);
            this.lblAchatFaitPar.TabIndex = 9;
            this.lblAchatFaitPar.Text = "Produit réceptionné par";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 437);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Décaissement fait par";
            // 
            // cbxRespStocks
            // 
            this.cbxRespStocks.DataSource = this.ageEmployesBindingSource1;
            this.cbxRespStocks.DisplayMember = "PrenomNom";
            this.cbxRespStocks.FormattingEnabled = true;
            this.cbxRespStocks.Location = new System.Drawing.Point(249, 393);
            this.cbxRespStocks.Margin = new System.Windows.Forms.Padding(5);
            this.cbxRespStocks.Name = "cbxRespStocks";
            this.cbxRespStocks.Size = new System.Drawing.Size(286, 29);
            this.cbxRespStocks.TabIndex = 16;
            // 
            // ageEmployesBindingSource1
            // 
            this.ageEmployesBindingSource1.DataMember = "AgeEmployes";
            this.ageEmployesBindingSource1.DataSource = this.casaDBDataSetAll;
            // 
            // ageEmployesBindingSource
            // 
            this.ageEmployesBindingSource.DataMember = "AgeEmployes";
            this.ageEmployesBindingSource.DataSource = this.casaDBDataSetAll;
            // 
            // cbxTresoriere
            // 
            this.cbxTresoriere.DataSource = this.ageEmployesBindingSource;
            this.cbxTresoriere.DisplayMember = "PrenomNom";
            this.cbxTresoriere.FormattingEnabled = true;
            this.cbxTresoriere.Location = new System.Drawing.Point(249, 432);
            this.cbxTresoriere.Margin = new System.Windows.Forms.Padding(5);
            this.cbxTresoriere.Name = "cbxTresoriere";
            this.cbxTresoriere.Size = new System.Drawing.Size(286, 29);
            this.cbxTresoriere.TabIndex = 16;
            // 
            // ageEmployesTableAdapter
            // 
            this.ageEmployesTableAdapter.ClearBeforeFill = true;
            // 
            // lblComptePaiement
            // 
            this.lblComptePaiement.AutoSize = true;
            this.lblComptePaiement.Location = new System.Drawing.Point(27, 476);
            this.lblComptePaiement.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblComptePaiement.Name = "lblComptePaiement";
            this.lblComptePaiement.Size = new System.Drawing.Size(182, 21);
            this.lblComptePaiement.TabIndex = 9;
            this.lblComptePaiement.Text = "Compte de paiement";
            // 
            // cbxComptePaiement
            // 
            this.cbxComptePaiement.DataSource = this.resComptesTresorerieBindingSource;
            this.cbxComptePaiement.DisplayMember = "NomCompte";
            this.cbxComptePaiement.FormattingEnabled = true;
            this.cbxComptePaiement.Location = new System.Drawing.Point(249, 471);
            this.cbxComptePaiement.Margin = new System.Windows.Forms.Padding(5);
            this.cbxComptePaiement.Name = "cbxComptePaiement";
            this.cbxComptePaiement.Size = new System.Drawing.Size(286, 29);
            this.cbxComptePaiement.TabIndex = 16;
            this.cbxComptePaiement.SelectedIndexChanged += new System.EventHandler(this.CbxComptePaiement_SelectedIndexChanged);
            // 
            // resComptesTresorerieBindingSource
            // 
            this.resComptesTresorerieBindingSource.DataMember = "ResComptesTresorerie";
            this.resComptesTresorerieBindingSource.DataSource = this.casaDBDataSetAll;
            // 
            // resComptesTresorerieTableAdapter
            // 
            this.resComptesTresorerieTableAdapter.ClearBeforeFill = true;
            // 
            // lblLocaliteFournisseur
            // 
            this.lblLocaliteFournisseur.AutoSize = true;
            this.lblLocaliteFournisseur.Location = new System.Drawing.Point(29, 180);
            this.lblLocaliteFournisseur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLocaliteFournisseur.Name = "lblLocaliteFournisseur";
            this.lblLocaliteFournisseur.Size = new System.Drawing.Size(155, 21);
            this.lblLocaliteFournisseur.TabIndex = 12;
            this.lblLocaliteFournisseur.Text = "Localité fournisseur";
            // 
            // txtLocaliteFournisseur
            // 
            this.txtLocaliteFournisseur.Location = new System.Drawing.Point(249, 178);
            this.txtLocaliteFournisseur.Margin = new System.Windows.Forms.Padding(5);
            this.txtLocaliteFournisseur.Name = "txtLocaliteFournisseur";
            this.txtLocaliteFournisseur.Size = new System.Drawing.Size(286, 27);
            this.txtLocaliteFournisseur.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 515);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Solde compte séléctionné";
            // 
            // txtSoldeCompte
            // 
            this.txtSoldeCompte.Enabled = false;
            this.txtSoldeCompte.Location = new System.Drawing.Point(249, 512);
            this.txtSoldeCompte.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoldeCompte.Name = "txtSoldeCompte";
            this.txtSoldeCompte.Size = new System.Drawing.Size(286, 27);
            this.txtSoldeCompte.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 328);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Transport matière première";
            // 
            // txtTransportMatierePremiere
            // 
            this.txtTransportMatierePremiere.Location = new System.Drawing.Point(249, 322);
            this.txtTransportMatierePremiere.Margin = new System.Windows.Forms.Padding(5);
            this.txtTransportMatierePremiere.Name = "txtTransportMatierePremiere";
            this.txtTransportMatierePremiere.Size = new System.Drawing.Size(286, 27);
            this.txtTransportMatierePremiere.TabIndex = 13;
            this.txtTransportMatierePremiere.Text = "0";
            // 
            // cbxTypesMatieres
            // 
            this.cbxTypesMatieres.DisplayMember = "PrenomNom";
            this.cbxTypesMatieres.FormattingEnabled = true;
            this.cbxTypesMatieres.Location = new System.Drawing.Point(123, 130);
            this.cbxTypesMatieres.Margin = new System.Windows.Forms.Padding(5);
            this.cbxTypesMatieres.Name = "cbxTypesMatieres";
            this.cbxTypesMatieres.Size = new System.Drawing.Size(247, 25);
            this.cbxTypesMatieres.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Type de matiere";
            // 
            // UC_AchatMatierePremiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gBxNouvelleMatierePremiere);
            this.Controls.Add(this.grbNouveauFournisseur);
            this.Controls.Add(this.dtpDateApprovisionnement);
            this.Controls.Add(this.cbxComptePaiement);
            this.Controls.Add(this.cbxTresoriere);
            this.Controls.Add(this.cbxFournisseurMPrem);
            this.Controls.Add(this.cbxRespStocks);
            this.Controls.Add(this.cbxNomMatierePremiere);
            this.Controls.Add(this.btnEnregistrerAchatMatierePremiere);
            this.Controls.Add(this.txtMontantPaye);
            this.Controls.Add(this.txtLocaliteFournisseur);
            this.Controls.Add(this.txtSoldeCompte);
            this.Controls.Add(this.txtTransportMatierePremiere);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.lblComptePaiement);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMontantPaye);
            this.Controls.Add(this.lblAchatFaitPar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLocaliteFournisseur);
            this.Controls.Add(this.lblNomFournisseur);
            this.Controls.Add(this.lblNomMatierePremiere);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_AchatMatierePremiere";
            this.Size = new System.Drawing.Size(983, 596);
            this.Load += new System.EventHandler(this.UC_AchatMatierePremiere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resStockMatieresPremieresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDBDataSetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFournisseursMatieresPremieresBindingSource)).EndInit();
            this.grbNouveauFournisseur.ResumeLayout(false);
            this.grbNouveauFournisseur.PerformLayout();
            this.gBxNouvelleMatierePremiere.ResumeLayout(false);
            this.gBxNouvelleMatierePremiere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxNomMatierePremiere;
        private System.Windows.Forms.Button btnEnregistrerAchatMatierePremiere;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNomMatierePremiere;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDateApprovisionnement;
        private System.Windows.Forms.Label lblNomFournisseur;
        private System.Windows.Forms.ComboBox cbxFournisseurMPrem;
        private System.Windows.Forms.GroupBox grbNouveauFournisseur;
        private System.Windows.Forms.Button btnNouveauFournisseur;
        private System.Windows.Forms.TextBox txtSoldeInitialeDette;
        private System.Windows.Forms.TextBox txtLocalite;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNomFournisseurMP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNomNouveauClient;
        private System.Windows.Forms.GroupBox gBxNouvelleMatierePremiere;
        private System.Windows.Forms.Button btnAjouterNouvelleMatierePremiere;
        private System.Windows.Forms.TextBox txtStockInitial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomMatierePremiere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMontantPaye;
        private System.Windows.Forms.TextBox txtMontantPaye;
        private System.Windows.Forms.BindingSource ageFournisseursMatieresPremieresBindingSource;
        private CasaDBDataSetAll casaDBDataSetAll;
        private CasaDBDataSet casaDBDataSet;
        private System.Windows.Forms.BindingSource casaDBDataSetBindingSource;
        private CasaDBDataSetAllTableAdapters.AgeFournisseursMatieresPremieresTableAdapter ageFournisseursMatieresPremieresTableAdapter;
        private System.Windows.Forms.BindingSource resStockMatieresPremieresBindingSource;
        private CasaDBDataSetAllTableAdapters.ResStockMatieresPremieresTableAdapter resStockMatieresPremieresTableAdapter;
        private System.Windows.Forms.Label lblAchatFaitPar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxRespStocks;
        private System.Windows.Forms.BindingSource ageEmployesBindingSource;
        private System.Windows.Forms.ComboBox cbxTresoriere;
        private CasaDBDataSetAllTableAdapters.AgeEmployesTableAdapter ageEmployesTableAdapter;
        private System.Windows.Forms.BindingSource ageEmployesBindingSource1;
        private System.Windows.Forms.Label lblComptePaiement;
        private System.Windows.Forms.ComboBox cbxComptePaiement;
        private System.Windows.Forms.BindingSource resComptesTresorerieBindingSource;
        private CasaDBDataSetAllTableAdapters.ResComptesTresorerieTableAdapter resComptesTresorerieTableAdapter;
        private System.Windows.Forms.Label lblLocaliteFournisseur;
        private System.Windows.Forms.TextBox txtLocaliteFournisseur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoldeCompte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTransportMatierePremiere;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxTypesMatieres;
    }
}
