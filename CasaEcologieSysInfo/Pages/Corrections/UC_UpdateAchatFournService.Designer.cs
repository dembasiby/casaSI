namespace CasaEcologieSysInfo.Pages.Corrections
{
    partial class UC_UpdateAchatFournService
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
            this.cbxTresorieres = new System.Windows.Forms.ComboBox();
            this.ageEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDateAchatServFourn = new System.Windows.Forms.DateTimePicker();
            this.cbxComptePaiement = new System.Windows.Forms.ComboBox();
            this.resComptesTresorerieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxNomFournServFourn = new System.Windows.Forms.ComboBox();
            this.ageFournisseursServicesFournituresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxNomServFourniture = new System.Windows.Forms.ComboBox();
            this.resServicesFournitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSoldeCompte = new System.Windows.Forms.TextBox();
            this.txtMontantPayeServFourn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtMontantServFourn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNomFournisseur = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.Label();
            this.BtnSupprimerTransaction = new System.Windows.Forms.Button();
            this.btnMettreTransactionAJour = new System.Windows.Forms.Button();
            this.ageEmployeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dgvListeTransactionsServices = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxRespServFournitures = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFournisseursServicesFournituresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resServicesFournitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeTransactionsServices)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.cbxRespServFournitures);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxTresorieres);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpDateAchatServFourn);
            this.groupBox1.Controls.Add(this.cbxComptePaiement);
            this.groupBox1.Controls.Add(this.cbxNomFournServFourn);
            this.groupBox1.Controls.Add(this.cbxNomServFourniture);
            this.groupBox1.Controls.Add(this.txtSoldeCompte);
            this.groupBox1.Controls.Add(this.txtMontantPayeServFourn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtMontantServFourn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblNomFournisseur);
            this.groupBox1.Controls.Add(this.p);
            this.groupBox1.Controls.Add(this.BtnSupprimerTransaction);
            this.groupBox1.Controls.Add(this.btnMettreTransactionAJour);
            this.groupBox1.Location = new System.Drawing.Point(378, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 544);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails de la transaction";
            // 
            // cbxTresorieres
            // 
            this.cbxTresorieres.DataSource = this.ageEmployeBindingSource;
            this.cbxTresorieres.DisplayMember = "PrenomNom";
            this.cbxTresorieres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTresorieres.FormattingEnabled = true;
            this.cbxTresorieres.Location = new System.Drawing.Point(260, 313);
            this.cbxTresorieres.Margin = new System.Windows.Forms.Padding(5);
            this.cbxTresorieres.Name = "cbxTresorieres";
            this.cbxTresorieres.Size = new System.Drawing.Size(306, 29);
            this.cbxTresorieres.TabIndex = 60;
            this.cbxTresorieres.ValueMember = "CodeEmploye";
            // 
            // ageEmployeBindingSource
            // 
            this.ageEmployeBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 321);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 21);
            this.label10.TabIndex = 58;
            this.label10.Text = "Décaissement fait par";
            // 
            // dtpDateAchatServFourn
            // 
            this.dtpDateAchatServFourn.Checked = false;
            this.dtpDateAchatServFourn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateAchatServFourn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAchatServFourn.Location = new System.Drawing.Point(260, 165);
            this.dtpDateAchatServFourn.Name = "dtpDateAchatServFourn";
            this.dtpDateAchatServFourn.Size = new System.Drawing.Size(306, 27);
            this.dtpDateAchatServFourn.TabIndex = 57;
            // 
            // cbxComptePaiement
            // 
            this.cbxComptePaiement.DataSource = this.resComptesTresorerieBindingSource;
            this.cbxComptePaiement.DisplayMember = "NomCompte";
            this.cbxComptePaiement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComptePaiement.FormattingEnabled = true;
            this.cbxComptePaiement.Location = new System.Drawing.Point(260, 354);
            this.cbxComptePaiement.Margin = new System.Windows.Forms.Padding(5);
            this.cbxComptePaiement.Name = "cbxComptePaiement";
            this.cbxComptePaiement.Size = new System.Drawing.Size(306, 29);
            this.cbxComptePaiement.TabIndex = 54;
            this.cbxComptePaiement.ValueMember = "CodeCompte";
            // 
            // resComptesTresorerieBindingSource
            // 
            this.resComptesTresorerieBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResComptesTresorerie);
            // 
            // cbxNomFournServFourn
            // 
            this.cbxNomFournServFourn.DataSource = this.ageFournisseursServicesFournituresBindingSource;
            this.cbxNomFournServFourn.DisplayMember = "NomFournisseurServiceFourniture";
            this.cbxNomFournServFourn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNomFournServFourn.FormattingEnabled = true;
            this.cbxNomFournServFourn.Location = new System.Drawing.Point(260, 122);
            this.cbxNomFournServFourn.Margin = new System.Windows.Forms.Padding(5);
            this.cbxNomFournServFourn.Name = "cbxNomFournServFourn";
            this.cbxNomFournServFourn.Size = new System.Drawing.Size(306, 29);
            this.cbxNomFournServFourn.TabIndex = 52;
            this.cbxNomFournServFourn.ValueMember = "CodeFournisseurServiceFourniture";
            // 
            // ageFournisseursServicesFournituresBindingSource
            // 
            this.ageFournisseursServicesFournituresBindingSource.DataMember = "AgeFournisseursServicesFournitures";
            this.ageFournisseursServicesFournituresBindingSource.DataSource = typeof(CasaEcologieSysInfo.CasaDBDataSetAll);
            // 
            // cbxNomServFourniture
            // 
            this.cbxNomServFourniture.DataSource = this.resServicesFournitureBindingSource;
            this.cbxNomServFourniture.DisplayMember = "NomServiceFourniture";
            this.cbxNomServFourniture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNomServFourniture.FormattingEnabled = true;
            this.cbxNomServFourniture.Location = new System.Drawing.Point(260, 47);
            this.cbxNomServFourniture.Margin = new System.Windows.Forms.Padding(5);
            this.cbxNomServFourniture.Name = "cbxNomServFourniture";
            this.cbxNomServFourniture.Size = new System.Drawing.Size(306, 29);
            this.cbxNomServFourniture.TabIndex = 55;
            this.cbxNomServFourniture.ValueMember = "CodeServiceFourniture";
            // 
            // resServicesFournitureBindingSource
            // 
            this.resServicesFournitureBindingSource.DataSource = typeof(CasaEcologieSysInfo.ResServicesFourniture);
            // 
            // txtSoldeCompte
            // 
            this.txtSoldeCompte.Location = new System.Drawing.Point(260, 390);
            this.txtSoldeCompte.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoldeCompte.Name = "txtSoldeCompte";
            this.txtSoldeCompte.ReadOnly = true;
            this.txtSoldeCompte.Size = new System.Drawing.Size(306, 27);
            this.txtSoldeCompte.TabIndex = 49;
            // 
            // txtMontantPayeServFourn
            // 
            this.txtMontantPayeServFourn.Location = new System.Drawing.Point(260, 238);
            this.txtMontantPayeServFourn.Margin = new System.Windows.Forms.Padding(5);
            this.txtMontantPayeServFourn.Name = "txtMontantPayeServFourn";
            this.txtMontantPayeServFourn.Size = new System.Drawing.Size(306, 27);
            this.txtMontantPayeServFourn.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 396);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Solde Compte";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(260, 86);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(307, 27);
            this.txtDescription.TabIndex = 51;
            // 
            // txtMontantServFourn
            // 
            this.txtMontantServFourn.Location = new System.Drawing.Point(260, 202);
            this.txtMontantServFourn.Margin = new System.Windows.Forms.Padding(5);
            this.txtMontantServFourn.Name = "txtMontantServFourn";
            this.txtMontantServFourn.Size = new System.Drawing.Size(306, 27);
            this.txtMontantServFourn.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 244);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 21);
            this.label9.TabIndex = 41;
            this.label9.Text = "Montant Payé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "Montant";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(39, 171);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(145, 21);
            this.lblDate.TabIndex = 43;
            this.lblDate.Text = "Date Transaction";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 362);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 21);
            this.label11.TabIndex = 46;
            this.label11.Text = "Compte de paiement";
            // 
            // lblNomFournisseur
            // 
            this.lblNomFournisseur.AutoSize = true;
            this.lblNomFournisseur.Location = new System.Drawing.Point(39, 130);
            this.lblNomFournisseur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomFournisseur.Name = "lblNomFournisseur";
            this.lblNomFournisseur.Size = new System.Drawing.Size(131, 21);
            this.lblNomFournisseur.TabIndex = 44;
            this.lblNomFournisseur.Text = "Nom fournisseur";
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Location = new System.Drawing.Point(39, 55);
            this.p.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(213, 21);
            this.p.TabIndex = 48;
            this.p.Text = "Nom Service ou Fourniture";
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
            this.BtnSupprimerTransaction.Location = new System.Drawing.Point(337, 441);
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
            this.btnMettreTransactionAJour.Location = new System.Drawing.Point(45, 441);
            this.btnMettreTransactionAJour.Name = "btnMettreTransactionAJour";
            this.btnMettreTransactionAJour.Size = new System.Drawing.Size(259, 36);
            this.btnMettreTransactionAJour.TabIndex = 39;
            this.btnMettreTransactionAJour.Text = "Mettre la transaction à jour";
            this.btnMettreTransactionAJour.UseVisualStyleBackColor = false;
            this.btnMettreTransactionAJour.Click += new System.EventHandler(this.BtnMettreTransactionAJour_Click);
            // 
            // ageEmployeBindingSource1
            // 
            this.ageEmployeBindingSource1.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "Au";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 21);
            this.label7.TabIndex = 44;
            this.label7.Text = "Du";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(241, 45);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(131, 27);
            this.dtpFin.TabIndex = 42;
            this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFin_ValueChanged);
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(43, 45);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(131, 27);
            this.dtpDebut.TabIndex = 41;
            this.dtpDebut.ValueChanged += new System.EventHandler(this.DtpDebut_ValueChanged);
            // 
            // dgvListeTransactionsServices
            // 
            this.dgvListeTransactionsServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListeTransactionsServices.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvListeTransactionsServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListeTransactionsServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeTransactionsServices.Location = new System.Drawing.Point(11, 78);
            this.dgvListeTransactionsServices.Name = "dgvListeTransactionsServices";
            this.dgvListeTransactionsServices.ReadOnly = true;
            this.dgvListeTransactionsServices.RowHeadersVisible = false;
            this.dgvListeTransactionsServices.Size = new System.Drawing.Size(361, 515);
            this.dgvListeTransactionsServices.TabIndex = 40;
            this.dgvListeTransactionsServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListeTransactionsServices_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(534, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Mettre à jour une dépense de fournitures ou service";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 283);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 58;
            this.label1.Text = "Transaction faite par";
            // 
            // cbxRespServFournitures
            // 
            this.cbxRespServFournitures.DataSource = this.ageEmployeBindingSource1;
            this.cbxRespServFournitures.DisplayMember = "PrenomNom";
            this.cbxRespServFournitures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRespServFournitures.FormattingEnabled = true;
            this.cbxRespServFournitures.Location = new System.Drawing.Point(260, 275);
            this.cbxRespServFournitures.Margin = new System.Windows.Forms.Padding(5);
            this.cbxRespServFournitures.Name = "cbxRespServFournitures";
            this.cbxRespServFournitures.Size = new System.Drawing.Size(306, 29);
            this.cbxRespServFournitures.TabIndex = 60;
            this.cbxRespServFournitures.ValueMember = "CodeEmploye";
            // 
            // UC_UpdateAchatFournService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.dgvListeTransactionsServices);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_UpdateAchatFournService";
            this.Size = new System.Drawing.Size(983, 596);
            this.Load += new System.EventHandler(this.UC_UpdateAchatFournService_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resComptesTresorerieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFournisseursServicesFournituresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resServicesFournitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeTransactionsServices)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvListeTransactionsServices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateAchatServFourn;
        private System.Windows.Forms.ComboBox cbxComptePaiement;
        private System.Windows.Forms.ComboBox cbxNomFournServFourn;
        private System.Windows.Forms.ComboBox cbxNomServFourniture;
        private System.Windows.Forms.TextBox txtSoldeCompte;
        private System.Windows.Forms.TextBox txtMontantPayeServFourn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMontantServFourn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNomFournisseur;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.BindingSource resServicesFournitureBindingSource;
        private System.Windows.Forms.BindingSource resComptesTresorerieBindingSource;
        private System.Windows.Forms.BindingSource ageFournisseursServicesFournituresBindingSource;
        private System.Windows.Forms.ComboBox cbxTresorieres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxRespServFournitures;
        private System.Windows.Forms.Label label1;
    }
}
