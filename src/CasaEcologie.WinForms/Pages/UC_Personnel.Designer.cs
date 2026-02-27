namespace CasaEcologie.WinForms.Pages;

partial class UC_Personnel
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitre = new Label();
        dgvListePersonnel = new DataGridView();
        lblListeEmployes = new Label();
        lblAjouterEmploye = new Label();
        lblPrenomNom = new Label();
        lblPoste = new Label();
        txtPrenomNom = new TextBox();
        txtPosteEmploye = new TextBox();
        btnNouvelEmploye = new Button();
        // Feuille de présence
        grpFeuillePresence = new GroupBox();
        lblFeuillePresence = new Label();
        cbxTimeSheetNomEmploye = new ComboBox();
        lblDatePresence = new Label();
        dtpDate = new DateTimePicker();
        lblRemunerationJournaliere = new Label();
        txtRemunerationJournaliere = new TextBox();
        btnPresenceEmploye = new Button();
        // Temps et rémunération
        cbxTempsEtRemun = new ComboBox();
        dtpDebut = new DateTimePicker();
        dtpFin = new DateTimePicker();
        dgvTempsEtRemun = new DataGridView();
        // Paiement des salaires
        lblPaiementSalaires = new Label();
        lblDatePaiement = new Label();
        dtpDatePaiement = new DateTimePicker();
        lblComptePaiement = new Label();
        cbxComptePaiement = new ComboBox();
        lblSoldeCompte = new Label();
        txtSoldeCompte = new TextBox();
        lblRemunerationPeriode = new Label();
        txtRemunerationPeriod = new TextBox();
        lblPaiementFaitPar = new Label();
        cbxTresoriere = new ComboBox();
        btnPayerEmploye = new Button();
        // Stagiaires
        lblStagiaires = new Label();
        lblStagiaire = new Label();
        cbxStagiaires = new ComboBox();
        lblDatePaiementStagiaire = new Label();
        dtpDatePaiementIndemStagiaires = new DateTimePicker();
        lblPeriodeDu = new Label();
        dtpDeStagiaire = new DateTimePicker();
        lblAu = new Label();
        dtpAStagiaire = new DateTimePicker();
        lblMontantIndemnite = new Label();
        txtMontantIndemnite = new TextBox();
        lblCompteStagiaire = new Label();
        cbxComptePaiementStagiaire = new ComboBox();
        lblFaitPar = new Label();
        cbxPaiementFaitPar = new ComboBox();
        btnPayerIndemnite = new Button();
        // Separators
        pnlSeparateurHorizontal = new Panel();
        pnlSeparateurVertical1 = new Panel();
        pnlSeparateurVertical2 = new Panel();
        ((System.ComponentModel.ISupportInitialize)dgvListePersonnel).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvTempsEtRemun).BeginInit();
        grpFeuillePresence.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = true;
        lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
        lblTitre.Location = new Point(267, 15);
        lblTitre.Name = "lblTitre";
        lblTitre.Size = new Size(287, 32);
        lblTitre.Text = "Page de suivi du personnel";
        //
        // lblListeEmployes
        //
        lblListeEmployes.AutoSize = true;
        lblListeEmployes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblListeEmployes.Location = new Point(9, 47);
        lblListeEmployes.Name = "lblListeEmployes";
        lblListeEmployes.Size = new Size(151, 25);
        lblListeEmployes.Text = "Liste des employés";
        //
        // dgvListePersonnel
        //
        dgvListePersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        dgvListePersonnel.BackgroundColor = SystemColors.ButtonFace;
        dgvListePersonnel.BorderStyle = BorderStyle.None;
        dgvListePersonnel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvListePersonnel.Location = new Point(13, 77);
        dgvListePersonnel.Name = "dgvListePersonnel";
        dgvListePersonnel.ScrollBars = ScrollBars.Vertical;
        dgvListePersonnel.Size = new Size(551, 136);
        //
        // lblAjouterEmploye
        //
        lblAjouterEmploye.AutoSize = true;
        lblAjouterEmploye.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblAjouterEmploye.Location = new Point(678, 47);
        lblAjouterEmploye.Name = "lblAjouterEmploye";
        lblAjouterEmploye.Size = new Size(219, 25);
        lblAjouterEmploye.Text = "Ajouter un nouvel employé";
        //
        // lblPrenomNom
        //
        lblPrenomNom.AutoSize = true;
        lblPrenomNom.Location = new Point(568, 83);
        lblPrenomNom.Name = "lblPrenomNom";
        lblPrenomNom.Size = new Size(109, 20);
        lblPrenomNom.Text = "Prénom et nom";
        //
        // txtPrenomNom
        //
        txtPrenomNom.Location = new Point(682, 77);
        txtPrenomNom.Name = "txtPrenomNom";
        txtPrenomNom.Size = new Size(272, 27);
        //
        // lblPoste
        //
        lblPoste.AutoSize = true;
        lblPoste.Location = new Point(568, 115);
        lblPoste.Name = "lblPoste";
        lblPoste.Size = new Size(43, 20);
        lblPoste.Text = "Poste";
        //
        // txtPosteEmploye
        //
        txtPosteEmploye.Location = new Point(682, 109);
        txtPosteEmploye.Name = "txtPosteEmploye";
        txtPosteEmploye.Size = new Size(272, 27);
        //
        // btnNouvelEmploye
        //
        btnNouvelEmploye.BackColor = Color.FromArgb(40, 92, 41);
        btnNouvelEmploye.FlatAppearance.BorderSize = 0;
        btnNouvelEmploye.FlatStyle = FlatStyle.Flat;
        btnNouvelEmploye.ForeColor = Color.WhiteSmoke;
        btnNouvelEmploye.Location = new Point(682, 156);
        btnNouvelEmploye.Name = "btnNouvelEmploye";
        btnNouvelEmploye.Size = new Size(272, 35);
        btnNouvelEmploye.Text = "Ajouter un nouvel employé";
        btnNouvelEmploye.UseVisualStyleBackColor = false;
        btnNouvelEmploye.Click += BtnNouvelEmploye_Click;
        //
        // pnlSeparateurHorizontal
        //
        pnlSeparateurHorizontal.BackColor = Color.FromArgb(40, 92, 41);
        pnlSeparateurHorizontal.Location = new Point(-1, 217);
        pnlSeparateurHorizontal.Name = "pnlSeparateurHorizontal";
        pnlSeparateurHorizontal.Size = new Size(985, 5);
        //
        // grpFeuillePresence
        //
        grpFeuillePresence.BackColor = Color.FromArgb(255, 128, 0);
        grpFeuillePresence.Controls.Add(lblFeuillePresence);
        grpFeuillePresence.Controls.Add(cbxTimeSheetNomEmploye);
        grpFeuillePresence.Controls.Add(lblDatePresence);
        grpFeuillePresence.Controls.Add(dtpDate);
        grpFeuillePresence.Controls.Add(lblRemunerationJournaliere);
        grpFeuillePresence.Controls.Add(txtRemunerationJournaliere);
        grpFeuillePresence.Controls.Add(btnPresenceEmploye);
        grpFeuillePresence.Location = new Point(2, 224);
        grpFeuillePresence.Name = "grpFeuillePresence";
        grpFeuillePresence.Size = new Size(312, 173);
        //
        // lblFeuillePresence
        //
        lblFeuillePresence.AutoSize = true;
        lblFeuillePresence.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblFeuillePresence.Location = new Point(73, 4);
        lblFeuillePresence.Name = "lblFeuillePresence";
        lblFeuillePresence.Size = new Size(160, 25);
        lblFeuillePresence.Text = "Feuille de présence";
        //
        // cbxTimeSheetNomEmploye
        //
        cbxTimeSheetNomEmploye.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxTimeSheetNomEmploye.FormattingEnabled = true;
        cbxTimeSheetNomEmploye.Location = new Point(66, 23);
        cbxTimeSheetNomEmploye.Name = "cbxTimeSheetNomEmploye";
        cbxTimeSheetNomEmploye.Size = new Size(240, 28);
        //
        // lblDatePresence
        //
        lblDatePresence.AutoSize = true;
        lblDatePresence.Location = new Point(3, 54);
        lblDatePresence.Name = "lblDatePresence";
        lblDatePresence.Size = new Size(40, 20);
        lblDatePresence.Text = "Date";
        //
        // dtpDate
        //
        dtpDate.Location = new Point(66, 54);
        dtpDate.Name = "dtpDate";
        dtpDate.Size = new Size(240, 27);
        //
        // lblRemunerationJournaliere
        //
        lblRemunerationJournaliere.AutoSize = true;
        lblRemunerationJournaliere.Location = new Point(3, 81);
        lblRemunerationJournaliere.Name = "lblRemunerationJournaliere";
        lblRemunerationJournaliere.Size = new Size(170, 20);
        lblRemunerationJournaliere.Text = "Rémunération journalière";
        //
        // txtRemunerationJournaliere
        //
        txtRemunerationJournaliere.Location = new Point(14, 99);
        txtRemunerationJournaliere.Name = "txtRemunerationJournaliere";
        txtRemunerationJournaliere.Size = new Size(292, 27);
        //
        // btnPresenceEmploye
        //
        btnPresenceEmploye.BackColor = Color.FromArgb(40, 92, 41);
        btnPresenceEmploye.FlatAppearance.BorderSize = 0;
        btnPresenceEmploye.FlatStyle = FlatStyle.Flat;
        btnPresenceEmploye.ForeColor = Color.WhiteSmoke;
        btnPresenceEmploye.Location = new Point(14, 126);
        btnPresenceEmploye.Name = "btnPresenceEmploye";
        btnPresenceEmploye.Size = new Size(292, 35);
        btnPresenceEmploye.Text = "Enregistrer";
        btnPresenceEmploye.UseVisualStyleBackColor = false;
        btnPresenceEmploye.Click += BtnPresenceEmploye_Click;
        //
        // pnlSeparateurVertical1
        //
        pnlSeparateurVertical1.BackColor = Color.FromArgb(40, 92, 41);
        pnlSeparateurVertical1.Location = new Point(318, 225);
        pnlSeparateurVertical1.Name = "pnlSeparateurVertical1";
        pnlSeparateurVertical1.Size = new Size(5, 413);
        //
        // cbxTempsEtRemun
        //
        cbxTempsEtRemun.FormattingEnabled = true;
        cbxTempsEtRemun.Location = new Point(352, 253);
        cbxTempsEtRemun.Name = "cbxTempsEtRemun";
        cbxTempsEtRemun.Size = new Size(265, 28);
        cbxTempsEtRemun.SelectedIndexChanged += CbxTempsEtRemun_SelectedIndexChanged;
        //
        // dtpDebut
        //
        dtpDebut.Format = DateTimePickerFormat.Short;
        dtpDebut.Location = new Point(352, 288);
        dtpDebut.Name = "dtpDebut";
        dtpDebut.Size = new Size(123, 27);
        dtpDebut.ValueChanged += DtpDebut_ValueChanged;
        //
        // dtpFin
        //
        dtpFin.Format = DateTimePickerFormat.Short;
        dtpFin.Location = new Point(494, 288);
        dtpFin.Name = "dtpFin";
        dtpFin.Size = new Size(123, 27);
        dtpFin.ValueChanged += DtpFin_ValueChanged;
        //
        // dgvTempsEtRemun
        //
        dgvTempsEtRemun.BackgroundColor = SystemColors.ButtonFace;
        dgvTempsEtRemun.BorderStyle = BorderStyle.Fixed3D;
        dgvTempsEtRemun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTempsEtRemun.Location = new Point(352, 328);
        dgvTempsEtRemun.Name = "dgvTempsEtRemun";
        dgvTempsEtRemun.RowHeadersVisible = false;
        dgvTempsEtRemun.Size = new Size(325, 307);
        //
        // pnlSeparateurVertical2
        //
        pnlSeparateurVertical2.BackColor = Color.FromArgb(40, 92, 41);
        pnlSeparateurVertical2.Location = new Point(687, 225);
        pnlSeparateurVertical2.Name = "pnlSeparateurVertical2";
        pnlSeparateurVertical2.Size = new Size(5, 413);
        //
        // lblPaiementSalaires
        //
        lblPaiementSalaires.AutoSize = true;
        lblPaiementSalaires.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblPaiementSalaires.Location = new Point(723, 285);
        lblPaiementSalaires.Name = "lblPaiementSalaires";
        lblPaiementSalaires.Size = new Size(175, 25);
        lblPaiementSalaires.Text = "Paiement des salaires";
        //
        // lblDatePaiement
        //
        lblDatePaiement.AutoSize = true;
        lblDatePaiement.Location = new Point(707, 313);
        lblDatePaiement.Name = "lblDatePaiement";
        lblDatePaiement.Size = new Size(40, 20);
        lblDatePaiement.Text = "Date";
        //
        // dtpDatePaiement
        //
        dtpDatePaiement.Location = new Point(708, 333);
        dtpDatePaiement.Name = "dtpDatePaiement";
        dtpDatePaiement.Size = new Size(225, 27);
        dtpDatePaiement.ValueChanged += DtpDatePaiement_ValueChanged;
        //
        // lblComptePaiement
        //
        lblComptePaiement.AutoSize = true;
        lblComptePaiement.Location = new Point(707, 368);
        lblComptePaiement.Name = "lblComptePaiement";
        lblComptePaiement.Size = new Size(151, 20);
        lblComptePaiement.Text = "Compte de paiement";
        //
        // cbxComptePaiement
        //
        cbxComptePaiement.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxComptePaiement.FormattingEnabled = true;
        cbxComptePaiement.Location = new Point(710, 391);
        cbxComptePaiement.Name = "cbxComptePaiement";
        cbxComptePaiement.Size = new Size(223, 28);
        cbxComptePaiement.SelectedIndexChanged += CbxComptePaiement_SelectedIndexChanged;
        //
        // lblSoldeCompte
        //
        lblSoldeCompte.AutoSize = true;
        lblSoldeCompte.Location = new Point(707, 427);
        lblSoldeCompte.Name = "lblSoldeCompte";
        lblSoldeCompte.Size = new Size(120, 20);
        lblSoldeCompte.Text = "Solde du compte";
        //
        // txtSoldeCompte
        //
        txtSoldeCompte.Location = new Point(710, 448);
        txtSoldeCompte.Name = "txtSoldeCompte";
        txtSoldeCompte.ReadOnly = true;
        txtSoldeCompte.Size = new Size(223, 27);
        //
        // lblRemunerationPeriode
        //
        lblRemunerationPeriode.AutoSize = true;
        lblRemunerationPeriode.Location = new Point(705, 477);
        lblRemunerationPeriode.Name = "lblRemunerationPeriode";
        lblRemunerationPeriode.Size = new Size(190, 20);
        lblRemunerationPeriode.Text = "Rémunération de la période";
        //
        // txtRemunerationPeriod
        //
        txtRemunerationPeriod.Location = new Point(708, 498);
        txtRemunerationPeriod.Name = "txtRemunerationPeriod";
        txtRemunerationPeriod.ReadOnly = true;
        txtRemunerationPeriod.Size = new Size(223, 27);
        //
        // lblPaiementFaitPar
        //
        lblPaiementFaitPar.AutoSize = true;
        lblPaiementFaitPar.Location = new Point(707, 531);
        lblPaiementFaitPar.Name = "lblPaiementFaitPar";
        lblPaiementFaitPar.Size = new Size(125, 20);
        lblPaiementFaitPar.Text = "Paiement fait par:";
        //
        // cbxTresoriere
        //
        cbxTresoriere.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxTresoriere.FormattingEnabled = true;
        cbxTresoriere.Location = new Point(710, 551);
        cbxTresoriere.Name = "cbxTresoriere";
        cbxTresoriere.Size = new Size(223, 28);
        //
        // btnPayerEmploye
        //
        btnPayerEmploye.BackColor = Color.FromArgb(40, 92, 41);
        btnPayerEmploye.FlatAppearance.BorderSize = 0;
        btnPayerEmploye.FlatStyle = FlatStyle.Flat;
        btnPayerEmploye.ForeColor = Color.WhiteSmoke;
        btnPayerEmploye.Location = new Point(710, 582);
        btnPayerEmploye.Name = "btnPayerEmploye";
        btnPayerEmploye.Size = new Size(223, 35);
        btnPayerEmploye.Text = "Payer l'employé";
        btnPayerEmploye.UseVisualStyleBackColor = false;
        btnPayerEmploye.Click += BtnPayerEmploye_Click;
        //
        // Stagiaires section separator
        //
        var pnlSepStagiaire = new Panel();
        pnlSepStagiaire.BackColor = Color.FromArgb(40, 92, 41);
        pnlSepStagiaire.Location = new Point(0, 391);
        pnlSepStagiaire.Size = new Size(319, 5);
        //
        // lblStagiaires
        //
        lblStagiaires.AutoSize = true;
        lblStagiaires.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblStagiaires.Location = new Point(-4, 401);
        lblStagiaires.Name = "lblStagiaires";
        lblStagiaires.Size = new Size(248, 25);
        lblStagiaires.Text = "Paiement indemnités stagiaires";
        //
        // lblStagiaire
        //
        lblStagiaire.AutoSize = true;
        lblStagiaire.Location = new Point(2, 426);
        lblStagiaire.Name = "lblStagiaire";
        lblStagiaire.Size = new Size(64, 20);
        lblStagiaire.Text = "Stagiaire";
        //
        // cbxStagiaires
        //
        cbxStagiaires.FormattingEnabled = true;
        cbxStagiaires.Location = new Point(88, 426);
        cbxStagiaires.Name = "cbxStagiaires";
        cbxStagiaires.Size = new Size(217, 28);
        //
        // lblDatePaiementStagiaire
        //
        lblDatePaiementStagiaire.AutoSize = true;
        lblDatePaiementStagiaire.Location = new Point(2, 453);
        lblDatePaiementStagiaire.Name = "lblDatePaiementStagiaire";
        lblDatePaiementStagiaire.Size = new Size(40, 20);
        lblDatePaiementStagiaire.Text = "Date";
        //
        // dtpDatePaiementIndemStagiaires
        //
        dtpDatePaiementIndemStagiaires.Location = new Point(88, 457);
        dtpDatePaiementIndemStagiaires.Name = "dtpDatePaiementIndemStagiaires";
        dtpDatePaiementIndemStagiaires.Size = new Size(217, 27);
        //
        // lblPeriodeDu
        //
        lblPeriodeDu.AutoSize = true;
        lblPeriodeDu.Location = new Point(3, 485);
        lblPeriodeDu.Name = "lblPeriodeDu";
        lblPeriodeDu.Size = new Size(78, 20);
        lblPeriodeDu.Text = "Période du";
        //
        // dtpDeStagiaire
        //
        dtpDeStagiaire.Format = DateTimePickerFormat.Short;
        dtpDeStagiaire.Location = new Point(86, 483);
        dtpDeStagiaire.Name = "dtpDeStagiaire";
        dtpDeStagiaire.Size = new Size(96, 27);
        //
        // lblAu
        //
        lblAu.AutoSize = true;
        lblAu.Location = new Point(187, 488);
        lblAu.Name = "lblAu";
        lblAu.Size = new Size(25, 20);
        lblAu.Text = "Au";
        //
        // dtpAStagiaire
        //
        dtpAStagiaire.Format = DateTimePickerFormat.Short;
        dtpAStagiaire.Location = new Point(217, 485);
        dtpAStagiaire.Name = "dtpAStagiaire";
        dtpAStagiaire.Size = new Size(88, 27);
        //
        // lblMontantIndemnite
        //
        lblMontantIndemnite.AutoSize = true;
        lblMontantIndemnite.Location = new Point(2, 509);
        lblMontantIndemnite.Name = "lblMontantIndemnite";
        lblMontantIndemnite.Size = new Size(63, 20);
        lblMontantIndemnite.Text = "Montant";
        //
        // txtMontantIndemnite
        //
        txtMontantIndemnite.Location = new Point(84, 511);
        txtMontantIndemnite.Name = "txtMontantIndemnite";
        txtMontantIndemnite.Size = new Size(221, 27);
        //
        // lblCompteStagiaire
        //
        lblCompteStagiaire.AutoSize = true;
        lblCompteStagiaire.Location = new Point(3, 541);
        lblCompteStagiaire.Name = "lblCompteStagiaire";
        lblCompteStagiaire.Size = new Size(63, 20);
        lblCompteStagiaire.Text = "Compte";
        //
        // cbxComptePaiementStagiaire
        //
        cbxComptePaiementStagiaire.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxComptePaiementStagiaire.FormattingEnabled = true;
        cbxComptePaiementStagiaire.Location = new Point(84, 540);
        cbxComptePaiementStagiaire.Name = "cbxComptePaiementStagiaire";
        cbxComptePaiementStagiaire.Size = new Size(221, 28);
        //
        // lblFaitPar
        //
        lblFaitPar.AutoSize = true;
        lblFaitPar.Location = new Point(3, 573);
        lblFaitPar.Name = "lblFaitPar";
        lblFaitPar.Size = new Size(57, 20);
        lblFaitPar.Text = "Fait par";
        //
        // cbxPaiementFaitPar
        //
        cbxPaiementFaitPar.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxPaiementFaitPar.FormattingEnabled = true;
        cbxPaiementFaitPar.Location = new Point(84, 572);
        cbxPaiementFaitPar.Name = "cbxPaiementFaitPar";
        cbxPaiementFaitPar.Size = new Size(221, 28);
        //
        // btnPayerIndemnite
        //
        btnPayerIndemnite.BackColor = Color.FromArgb(40, 92, 41);
        btnPayerIndemnite.FlatAppearance.BorderSize = 0;
        btnPayerIndemnite.FlatStyle = FlatStyle.Flat;
        btnPayerIndemnite.ForeColor = Color.WhiteSmoke;
        btnPayerIndemnite.Location = new Point(5, 601);
        btnPayerIndemnite.Name = "btnPayerIndemnite";
        btnPayerIndemnite.Size = new Size(300, 35);
        btnPayerIndemnite.Text = "Enregistrer";
        btnPayerIndemnite.UseVisualStyleBackColor = false;
        btnPayerIndemnite.Click += BtnPayerIndemnite_Click;
        //
        // UC_Personnel
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(grpFeuillePresence);
        Controls.Add(txtSoldeCompte);
        Controls.Add(txtRemunerationPeriod);
        Controls.Add(txtMontantIndemnite);
        Controls.Add(cbxTempsEtRemun);
        Controls.Add(dgvTempsEtRemun);
        Controls.Add(dtpFin);
        Controls.Add(dtpDebut);
        Controls.Add(dtpDatePaiement);
        Controls.Add(dtpAStagiaire);
        Controls.Add(dtpDeStagiaire);
        Controls.Add(dtpDatePaiementIndemStagiaires);
        Controls.Add(pnlSeparateurVertical2);
        Controls.Add(pnlSeparateurVertical1);
        Controls.Add(pnlSepStagiaire);
        Controls.Add(pnlSeparateurHorizontal);
        Controls.Add(lblSoldeCompte);
        Controls.Add(lblRemunerationPeriode);
        Controls.Add(lblDatePaiement);
        Controls.Add(lblMontantIndemnite);
        Controls.Add(lblAu);
        Controls.Add(lblPeriodeDu);
        Controls.Add(lblDatePaiementStagiaire);
        Controls.Add(lblPaiementFaitPar);
        Controls.Add(cbxTresoriere);
        Controls.Add(lblFaitPar);
        Controls.Add(lblCompteStagiaire);
        Controls.Add(lblComptePaiement);
        Controls.Add(cbxPaiementFaitPar);
        Controls.Add(cbxComptePaiementStagiaire);
        Controls.Add(cbxComptePaiement);
        Controls.Add(lblStagiaire);
        Controls.Add(cbxStagiaires);
        Controls.Add(lblPaiementSalaires);
        Controls.Add(lblStagiaires);
        Controls.Add(btnPayerEmploye);
        Controls.Add(btnPayerIndemnite);
        Controls.Add(btnNouvelEmploye);
        Controls.Add(txtPosteEmploye);
        Controls.Add(txtPrenomNom);
        Controls.Add(lblPoste);
        Controls.Add(lblPrenomNom);
        Controls.Add(lblListeEmployes);
        Controls.Add(lblAjouterEmploye);
        Controls.Add(dgvListePersonnel);
        Controls.Add(lblTitre);
        Name = "UC_Personnel";
        Size = new Size(983, 635);
        Load += UC_Personnel_Load;
        ((System.ComponentModel.ISupportInitialize)dgvListePersonnel).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvTempsEtRemun).EndInit();
        grpFeuillePresence.ResumeLayout(false);
        grpFeuillePresence.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private DataGridView dgvListePersonnel;
    private Label lblListeEmployes;
    private Label lblAjouterEmploye;
    private Label lblPrenomNom;
    private Label lblPoste;
    private TextBox txtPrenomNom;
    private TextBox txtPosteEmploye;
    private Button btnNouvelEmploye;
    private GroupBox grpFeuillePresence;
    private Label lblFeuillePresence;
    private ComboBox cbxTimeSheetNomEmploye;
    private Label lblDatePresence;
    private DateTimePicker dtpDate;
    private Label lblRemunerationJournaliere;
    private TextBox txtRemunerationJournaliere;
    private Button btnPresenceEmploye;
    private ComboBox cbxTempsEtRemun;
    private DateTimePicker dtpDebut;
    private DateTimePicker dtpFin;
    private DataGridView dgvTempsEtRemun;
    private Label lblPaiementSalaires;
    private Label lblDatePaiement;
    private DateTimePicker dtpDatePaiement;
    private Label lblComptePaiement;
    private ComboBox cbxComptePaiement;
    private Label lblSoldeCompte;
    private TextBox txtSoldeCompte;
    private Label lblRemunerationPeriode;
    private TextBox txtRemunerationPeriod;
    private Label lblPaiementFaitPar;
    private ComboBox cbxTresoriere;
    private Button btnPayerEmploye;
    private Label lblStagiaires;
    private Label lblStagiaire;
    private ComboBox cbxStagiaires;
    private Label lblDatePaiementStagiaire;
    private DateTimePicker dtpDatePaiementIndemStagiaires;
    private Label lblPeriodeDu;
    private DateTimePicker dtpDeStagiaire;
    private Label lblAu;
    private DateTimePicker dtpAStagiaire;
    private Label lblMontantIndemnite;
    private TextBox txtMontantIndemnite;
    private Label lblCompteStagiaire;
    private ComboBox cbxComptePaiementStagiaire;
    private Label lblFaitPar;
    private ComboBox cbxPaiementFaitPar;
    private Button btnPayerIndemnite;
    private Panel pnlSeparateurHorizontal;
    private Panel pnlSeparateurVertical1;
    private Panel pnlSeparateurVertical2;
}
