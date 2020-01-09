namespace CasaEcologieSysInfo.Pages.Corrections
{
    partial class UC_UpdateVente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListeVentes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwPanier = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSupprimerVente = new System.Windows.Forms.Button();
            this.btnAnnulerCorrection = new System.Windows.Forms.Button();
            this.btnMettreVenteAJour = new System.Windows.Forms.Button();
            this.txtLocaliteClient = new System.Windows.Forms.TextBox();
            this.txtMontantTotal = new System.Windows.Forms.TextBox();
            this.txtMontantPaye = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxListeComptes = new System.Windows.Forms.ComboBox();
            this.resComptesTresorerieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxListeClients = new System.Windows.Forms.ComboBox();
            this.ageClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDateVente = new System.Windows.Forms.DateTimePicker();
            this.btnEnleverProduitDuPanier = new System.Windows.Forms.Button();
            this.btnAugmenterQuantite = new System.Windows.Forms.Button();
            this.btnDiminuerQuantite = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAjouterAuPanier = new System.Windows.Forms.Button();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtPU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxListeProduits = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeVentes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageClientBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mettre à jour  une vente";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(315, 60);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(126, 27);
            this.dtpDebut.TabIndex = 33;
            this.dtpDebut.ValueChanged += new System.EventHandler(this.DtpDebut_ValueChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(527, 60);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(126, 27);
            this.dtpFin.TabIndex = 33;
            this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFin_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListeVentes);
            this.groupBox1.Location = new System.Drawing.Point(3, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 473);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des ventes de la période";
            // 
            // dgvListeVentes
            // 
            this.dgvListeVentes.AllowUserToAddRows = false;
            this.dgvListeVentes.AllowUserToDeleteRows = false;
            this.dgvListeVentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListeVentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeVentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvListeVentes.Location = new System.Drawing.Point(6, 51);
            this.dgvListeVentes.MultiSelect = false;
            this.dgvListeVentes.Name = "dgvListeVentes";
            this.dgvListeVentes.ReadOnly = true;
            this.dgvListeVentes.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListeVentes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListeVentes.Size = new System.Drawing.Size(232, 403);
            this.dgvListeVentes.TabIndex = 0;
            this.dgvListeVentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListeVentes_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lvwPanier);
            this.groupBox2.Controls.Add(this.btnDiminuerQuantite);
            this.groupBox2.Controls.Add(this.btnAugmenterQuantite);
            this.groupBox2.Controls.Add(this.btnEnleverProduitDuPanier);
            this.groupBox2.Controls.Add(this.btnSupprimerVente);
            this.groupBox2.Controls.Add(this.btnAnnulerCorrection);
            this.groupBox2.Controls.Add(this.btnMettreVenteAJour);
            this.groupBox2.Controls.Add(this.txtLocaliteClient);
            this.groupBox2.Controls.Add(this.txtMontantTotal);
            this.groupBox2.Controls.Add(this.txtMontantPaye);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbxListeComptes);
            this.groupBox2.Controls.Add(this.cbxListeClients);
            this.groupBox2.Controls.Add(this.dtpDateVente);
            this.groupBox2.Location = new System.Drawing.Point(253, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 473);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lvwPanier
            // 
            this.lvwPanier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwPanier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPanier.FullRowSelect = true;
            this.lvwPanier.GridLines = true;
            this.lvwPanier.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwPanier.HideSelection = false;
            this.lvwPanier.Location = new System.Drawing.Point(6, 169);
            this.lvwPanier.MultiSelect = false;
            this.lvwPanier.Name = "lvwPanier";
            this.lvwPanier.Size = new System.Drawing.Size(416, 257);
            this.lvwPanier.TabIndex = 39;
            this.lvwPanier.UseCompatibleStateImageBehavior = false;
            this.lvwPanier.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Produit";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qté";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PU";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Montant";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 110;
            // 
            // btnSupprimerVente
            // 
            this.btnSupprimerVente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSupprimerVente.FlatAppearance.BorderSize = 0;
            this.btnSupprimerVente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerVente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerVente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSupprimerVente.Location = new System.Drawing.Point(11, 437);
            this.btnSupprimerVente.Name = "btnSupprimerVente";
            this.btnSupprimerVente.Size = new System.Drawing.Size(102, 31);
            this.btnSupprimerVente.TabIndex = 38;
            this.btnSupprimerVente.Text = "Supprimer";
            this.btnSupprimerVente.UseVisualStyleBackColor = false;
            this.btnSupprimerVente.Click += new System.EventHandler(this.BtnSupprimerVente_Click);
            // 
            // btnAnnulerCorrection
            // 
            this.btnAnnulerCorrection.BackColor = System.Drawing.Color.Silver;
            this.btnAnnulerCorrection.FlatAppearance.BorderSize = 0;
            this.btnAnnulerCorrection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerCorrection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerCorrection.ForeColor = System.Drawing.Color.Black;
            this.btnAnnulerCorrection.Location = new System.Drawing.Point(119, 437);
            this.btnAnnulerCorrection.Name = "btnAnnulerCorrection";
            this.btnAnnulerCorrection.Size = new System.Drawing.Size(87, 31);
            this.btnAnnulerCorrection.TabIndex = 38;
            this.btnAnnulerCorrection.Text = "Annuler";
            this.btnAnnulerCorrection.UseVisualStyleBackColor = false;
            this.btnAnnulerCorrection.Click += new System.EventHandler(this.BtnAnnulerCorrection_Click);
            // 
            // btnMettreVenteAJour
            // 
            this.btnMettreVenteAJour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnMettreVenteAJour.FlatAppearance.BorderSize = 0;
            this.btnMettreVenteAJour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMettreVenteAJour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMettreVenteAJour.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMettreVenteAJour.Location = new System.Drawing.Point(212, 437);
            this.btnMettreVenteAJour.Name = "btnMettreVenteAJour";
            this.btnMettreVenteAJour.Size = new System.Drawing.Size(210, 31);
            this.btnMettreVenteAJour.TabIndex = 38;
            this.btnMettreVenteAJour.Text = "Mettre à jour";
            this.btnMettreVenteAJour.UseVisualStyleBackColor = false;
            this.btnMettreVenteAJour.Click += new System.EventHandler(this.BtnMettreVenteAJour_Click);
            // 
            // txtLocaliteClient
            // 
            this.txtLocaliteClient.Location = new System.Drawing.Point(244, 64);
            this.txtLocaliteClient.Name = "txtLocaliteClient";
            this.txtLocaliteClient.ReadOnly = true;
            this.txtLocaliteClient.Size = new System.Drawing.Size(221, 27);
            this.txtLocaliteClient.TabIndex = 37;
            // 
            // txtMontantTotal
            // 
            this.txtMontantTotal.Location = new System.Drawing.Point(240, 129);
            this.txtMontantTotal.Name = "txtMontantTotal";
            this.txtMontantTotal.ReadOnly = true;
            this.txtMontantTotal.Size = new System.Drawing.Size(221, 27);
            this.txtMontantTotal.TabIndex = 37;
            // 
            // txtMontantPaye
            // 
            this.txtMontantPaye.Location = new System.Drawing.Point(477, 129);
            this.txtMontantPaye.Name = "txtMontantPaye";
            this.txtMontantPaye.Size = new System.Drawing.Size(221, 27);
            this.txtMontantPaye.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nom du client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Date de la transaction";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "Localité du client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 36;
            this.label7.Text = "Montant total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Montant payé";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Compte de trésorerie utilisé";
            // 
            // cbxListeComptes
            // 
            this.cbxListeComptes.DataSource = this.resComptesTresorerieBindingSource;
            this.cbxListeComptes.DisplayMember = "NomCompte";
            this.cbxListeComptes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxListeComptes.FormattingEnabled = true;
            this.cbxListeComptes.Location = new System.Drawing.Point(477, 62);
            this.cbxListeComptes.Name = "cbxListeComptes";
            this.cbxListeComptes.Size = new System.Drawing.Size(221, 29);
            this.cbxListeComptes.TabIndex = 35;
            this.cbxListeComptes.ValueMember = "CodeCompte";
            // 
            // resComptesTresorerieBindingSource
            // 
            this.resComptesTresorerieBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResComptesTresorerie);
            // 
            // cbxListeClients
            // 
            this.cbxListeClients.DataSource = this.ageClientBindingSource;
            this.cbxListeClients.DisplayMember = "NomClient";
            this.cbxListeClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxListeClients.FormattingEnabled = true;
            this.cbxListeClients.Location = new System.Drawing.Point(6, 127);
            this.cbxListeClients.Name = "cbxListeClients";
            this.cbxListeClients.Size = new System.Drawing.Size(224, 29);
            this.cbxListeClients.TabIndex = 34;
            this.cbxListeClients.ValueMember = "CodeClient";
            // 
            // ageClientBindingSource
            // 
            this.ageClientBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeClient);
            // 
            // dtpDateVente
            // 
            this.dtpDateVente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateVente.Location = new System.Drawing.Point(6, 64);
            this.dtpDateVente.Name = "dtpDateVente";
            this.dtpDateVente.Size = new System.Drawing.Size(224, 27);
            this.dtpDateVente.TabIndex = 33;
            // 
            // btnEnleverProduitDuPanier
            // 
            this.btnEnleverProduitDuPanier.BackColor = System.Drawing.Color.Maroon;
            this.btnEnleverProduitDuPanier.FlatAppearance.BorderSize = 0;
            this.btnEnleverProduitDuPanier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnleverProduitDuPanier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnleverProduitDuPanier.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnleverProduitDuPanier.Location = new System.Drawing.Point(428, 179);
            this.btnEnleverProduitDuPanier.Name = "btnEnleverProduitDuPanier";
            this.btnEnleverProduitDuPanier.Size = new System.Drawing.Size(67, 31);
            this.btnEnleverProduitDuPanier.TabIndex = 38;
            this.btnEnleverProduitDuPanier.Text = "Enlever";
            this.btnEnleverProduitDuPanier.UseVisualStyleBackColor = false;
            this.btnEnleverProduitDuPanier.Click += new System.EventHandler(this.BtnEnleverProduitDuPanier_Click);
            // 
            // btnAugmenterQuantite
            // 
            this.btnAugmenterQuantite.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAugmenterQuantite.FlatAppearance.BorderSize = 0;
            this.btnAugmenterQuantite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAugmenterQuantite.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAugmenterQuantite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAugmenterQuantite.Location = new System.Drawing.Point(447, 216);
            this.btnAugmenterQuantite.Name = "btnAugmenterQuantite";
            this.btnAugmenterQuantite.Size = new System.Drawing.Size(37, 31);
            this.btnAugmenterQuantite.TabIndex = 38;
            this.btnAugmenterQuantite.Text = "+";
            this.btnAugmenterQuantite.UseVisualStyleBackColor = false;
            this.btnAugmenterQuantite.Click += new System.EventHandler(this.BtnAugmenterQuantite_Click);
            // 
            // btnDiminuerQuantite
            // 
            this.btnDiminuerQuantite.BackColor = System.Drawing.Color.Maroon;
            this.btnDiminuerQuantite.FlatAppearance.BorderSize = 0;
            this.btnDiminuerQuantite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiminuerQuantite.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiminuerQuantite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDiminuerQuantite.Location = new System.Drawing.Point(447, 253);
            this.btnDiminuerQuantite.Name = "btnDiminuerQuantite";
            this.btnDiminuerQuantite.Size = new System.Drawing.Size(37, 31);
            this.btnDiminuerQuantite.TabIndex = 38;
            this.btnDiminuerQuantite.Text = "-";
            this.btnDiminuerQuantite.UseVisualStyleBackColor = false;
            this.btnDiminuerQuantite.Click += new System.EventHandler(this.BtnDiminuerQuantite_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAjouterAuPanier);
            this.groupBox3.Controls.Add(this.txtQuantite);
            this.groupBox3.Controls.Add(this.txtPU);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbxListeProduits);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(503, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 260);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajouter un autre produit au panier";
            // 
            // btnAjouterAuPanier
            // 
            this.btnAjouterAuPanier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnAjouterAuPanier.FlatAppearance.BorderSize = 0;
            this.btnAjouterAuPanier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterAuPanier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterAuPanier.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAjouterAuPanier.Location = new System.Drawing.Point(5, 221);
            this.btnAjouterAuPanier.Name = "btnAjouterAuPanier";
            this.btnAjouterAuPanier.Size = new System.Drawing.Size(181, 31);
            this.btnAjouterAuPanier.TabIndex = 45;
            this.btnAjouterAuPanier.Text = "Ajouter";
            this.btnAjouterAuPanier.UseVisualStyleBackColor = false;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(5, 186);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(181, 23);
            this.txtQuantite.TabIndex = 43;
            // 
            // txtPU
            // 
            this.txtPU.Location = new System.Drawing.Point(5, 128);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(181, 23);
            this.txtPU.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Liste des produits";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Quantité";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Prix unitaire";
            // 
            // cbxListeProduits
            // 
            this.cbxListeProduits.DisplayMember = "NomClient";
            this.cbxListeProduits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxListeProduits.FormattingEnabled = true;
            this.cbxListeProduits.Location = new System.Drawing.Point(5, 64);
            this.cbxListeProduits.Name = "cbxListeProduits";
            this.cbxListeProduits.Size = new System.Drawing.Size(183, 25);
            this.cbxListeProduits.TabIndex = 39;
            this.cbxListeProduits.ValueMember = "CodeClient";
            // 
            // UC_UpdateVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_UpdateVente";
            this.Size = new System.Drawing.Size(983, 596);
            this.Load += new System.EventHandler(this.UC_UpdateVente_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeVentes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageClientBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxListeClients;
        private System.Windows.Forms.DateTimePicker dtpDateVente;
        private System.Windows.Forms.DataGridView dgvListeVentes;
        private System.Windows.Forms.TextBox txtLocaliteClient;
        private System.Windows.Forms.TextBox txtMontantPaye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxListeComptes;
        private System.Windows.Forms.Button btnMettreVenteAJour;
        private System.Windows.Forms.BindingSource ageClientBindingSource;
        private System.Windows.Forms.Button btnAnnulerCorrection;
        private System.Windows.Forms.TextBox txtMontantTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource resComptesTresorerieBindingSource;
        private System.Windows.Forms.Button btnSupprimerVente;
        private System.Windows.Forms.ListView lvwPanier;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnDiminuerQuantite;
        private System.Windows.Forms.Button btnAugmenterQuantite;
        private System.Windows.Forms.Button btnEnleverProduitDuPanier;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAjouterAuPanier;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.TextBox txtPU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxListeProduits;
    }
}
