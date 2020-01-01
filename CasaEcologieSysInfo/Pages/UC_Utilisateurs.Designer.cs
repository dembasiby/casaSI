namespace CasaEcologieSysInfo.Pages
{
    partial class UC_Utilisateurs
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
            this.dgvListeUtilisateurs = new System.Windows.Forms.DataGridView();
            this.ageEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxListeEmployes = new System.Windows.Forms.ComboBox();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnNouvelUtilisateur = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModifierUser = new System.Windows.Forms.Button();
            this.btnChargerListe = new System.Windows.Forms.Button();
            this.btnSupprimerUser = new System.Windows.Forms.Button();
            this.txtNouveauMotDePasse = new System.Windows.Forms.TextBox();
            this.txtUserAModifier = new System.Windows.Forms.TextBox();
            this.cbxListeAChanger = new System.Windows.Forms.ComboBox();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ageEmployeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtAncienMotDePasse = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeUtilisateurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Gestion des utilisateurs";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListeUtilisateurs);
            this.groupBox1.Location = new System.Drawing.Point(15, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 199);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des utilisateurs";
            // 
            // dgvListeUtilisateurs
            // 
            this.dgvListeUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeUtilisateurs.Location = new System.Drawing.Point(7, 27);
            this.dgvListeUtilisateurs.Name = "dgvListeUtilisateurs";
            this.dgvListeUtilisateurs.ReadOnly = true;
            this.dgvListeUtilisateurs.RowHeadersVisible = false;
            this.dgvListeUtilisateurs.Size = new System.Drawing.Size(378, 166);
            this.dgvListeUtilisateurs.TabIndex = 0;
            // 
            // ageEmployeBindingSource
            // 
            this.ageEmployeBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxListeEmployes);
            this.groupBox2.Controls.Add(this.txtPasswordConfirm);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.btnNouvelUtilisateur);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(455, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 199);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Créer un nouvel utilisateur";
            // 
            // cbxListeEmployes
            // 
            this.cbxListeEmployes.DataSource = this.ageEmployeBindingSource;
            this.cbxListeEmployes.DisplayMember = "PrenomNom";
            this.cbxListeEmployes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxListeEmployes.FormattingEnabled = true;
            this.cbxListeEmployes.Location = new System.Drawing.Point(214, 30);
            this.cbxListeEmployes.Name = "cbxListeEmployes";
            this.cbxListeEmployes.Size = new System.Drawing.Size(274, 29);
            this.cbxListeEmployes.TabIndex = 35;
            this.cbxListeEmployes.ValueMember = "CodeEmploye";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(214, 132);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '*';
            this.txtPasswordConfirm.Size = new System.Drawing.Size(274, 27);
            this.txtPasswordConfirm.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(214, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(274, 27);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(214, 65);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(274, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // btnNouvelUtilisateur
            // 
            this.btnNouvelUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(31)))), ((int)(((byte)(20)))));
            this.btnNouvelUtilisateur.FlatAppearance.BorderSize = 0;
            this.btnNouvelUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouvelUtilisateur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvelUtilisateur.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNouvelUtilisateur.Location = new System.Drawing.Point(260, 165);
            this.btnNouvelUtilisateur.Name = "btnNouvelUtilisateur";
            this.btnNouvelUtilisateur.Size = new System.Drawing.Size(228, 31);
            this.btnNouvelUtilisateur.TabIndex = 4;
            this.btnNouvelUtilisateur.Text = "Enregistrer";
            this.btnNouvelUtilisateur.UseVisualStyleBackColor = false;
            this.btnNouvelUtilisateur.Click += new System.EventHandler(this.BtnNouvelUtilisateur_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Confirmer Mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom d\'utilisateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employés";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnModifierUser);
            this.groupBox3.Controls.Add(this.btnChargerListe);
            this.groupBox3.Controls.Add(this.btnSupprimerUser);
            this.groupBox3.Controls.Add(this.txtAncienMotDePasse);
            this.groupBox3.Controls.Add(this.txtNouveauMotDePasse);
            this.groupBox3.Controls.Add(this.txtUserAModifier);
            this.groupBox3.Controls.Add(this.cbxListeAChanger);
            this.groupBox3.Location = new System.Drawing.Point(37, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 271);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestion des utilisateurs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 21);
            this.label8.TabIndex = 37;
            this.label8.Text = "Nouveau mot de passe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nom d\'utilisateur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Nom de l\'employé";
            // 
            // btnModifierUser
            // 
            this.btnModifierUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(31)))), ((int)(((byte)(20)))));
            this.btnModifierUser.FlatAppearance.BorderSize = 0;
            this.btnModifierUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnModifierUser.Location = new System.Drawing.Point(22, 228);
            this.btnModifierUser.Name = "btnModifierUser";
            this.btnModifierUser.Size = new System.Drawing.Size(188, 31);
            this.btnModifierUser.TabIndex = 36;
            this.btnModifierUser.Text = "Modifier";
            this.btnModifierUser.UseVisualStyleBackColor = false;
            this.btnModifierUser.Click += new System.EventHandler(this.BtnModifierUser_Click);
            // 
            // btnChargerListe
            // 
            this.btnChargerListe.BackColor = System.Drawing.Color.Silver;
            this.btnChargerListe.FlatAppearance.BorderSize = 0;
            this.btnChargerListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChargerListe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChargerListe.ForeColor = System.Drawing.Color.Black;
            this.btnChargerListe.Location = new System.Drawing.Point(216, 26);
            this.btnChargerListe.Name = "btnChargerListe";
            this.btnChargerListe.Size = new System.Drawing.Size(243, 31);
            this.btnChargerListe.TabIndex = 33;
            this.btnChargerListe.Text = "Charger la liste";
            this.btnChargerListe.UseVisualStyleBackColor = false;
            this.btnChargerListe.Click += new System.EventHandler(this.BtnChargerListe_Click);
            // 
            // btnSupprimerUser
            // 
            this.btnSupprimerUser.BackColor = System.Drawing.Color.DarkRed;
            this.btnSupprimerUser.FlatAppearance.BorderSize = 0;
            this.btnSupprimerUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSupprimerUser.Location = new System.Drawing.Point(231, 228);
            this.btnSupprimerUser.Name = "btnSupprimerUser";
            this.btnSupprimerUser.Size = new System.Drawing.Size(228, 31);
            this.btnSupprimerUser.TabIndex = 36;
            this.btnSupprimerUser.Text = "Supprimer l\'utilisateur";
            this.btnSupprimerUser.UseVisualStyleBackColor = false;
            this.btnSupprimerUser.Click += new System.EventHandler(this.BtnSupprimerUser_Click);
            // 
            // txtNouveauMotDePasse
            // 
            this.txtNouveauMotDePasse.Location = new System.Drawing.Point(216, 184);
            this.txtNouveauMotDePasse.Name = "txtNouveauMotDePasse";
            this.txtNouveauMotDePasse.PasswordChar = '*';
            this.txtNouveauMotDePasse.Size = new System.Drawing.Size(243, 27);
            this.txtNouveauMotDePasse.TabIndex = 1;
            // 
            // txtUserAModifier
            // 
            this.txtUserAModifier.Location = new System.Drawing.Point(216, 112);
            this.txtUserAModifier.Name = "txtUserAModifier";
            this.txtUserAModifier.Size = new System.Drawing.Size(243, 27);
            this.txtUserAModifier.TabIndex = 1;
            // 
            // cbxListeAChanger
            // 
            this.cbxListeAChanger.DataSource = this.utilisateurBindingSource;
            this.cbxListeAChanger.DisplayMember = "CodeEmploye";
            this.cbxListeAChanger.FormattingEnabled = true;
            this.cbxListeAChanger.Location = new System.Drawing.Point(216, 72);
            this.cbxListeAChanger.Name = "cbxListeAChanger";
            this.cbxListeAChanger.Size = new System.Drawing.Size(243, 29);
            this.cbxListeAChanger.TabIndex = 0;
            this.cbxListeAChanger.ValueMember = "CodeEmploye";
            this.cbxListeAChanger.SelectedIndexChanged += new System.EventHandler(this.CbxListeAChanger_SelectedIndexChanged);
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataSource = typeof(CasaEcologieSysInfo.Utilisateur);
            // 
            // ageEmployeBindingSource1
            // 
            this.ageEmployeBindingSource1.DataSource = typeof(CasaEcologieSysInfo.AgeEmploye);
            // 
            // txtAncienMotDePasse
            // 
            this.txtAncienMotDePasse.Location = new System.Drawing.Point(216, 145);
            this.txtAncienMotDePasse.Name = "txtAncienMotDePasse";
            this.txtAncienMotDePasse.PasswordChar = '*';
            this.txtAncienMotDePasse.Size = new System.Drawing.Size(243, 27);
            this.txtAncienMotDePasse.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 21);
            this.label9.TabIndex = 37;
            this.label9.Text = "Ancien mot de passe";
            // 
            // UC_Utilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_Utilisateurs";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_Utilisateurs_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeUtilisateurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListeUtilisateurs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNouvelUtilisateur;
        private System.Windows.Forms.ComboBox cbxListeEmployes;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnModifierUser;
        private System.Windows.Forms.Button btnChargerListe;
        private System.Windows.Forms.Button btnSupprimerUser;
        private System.Windows.Forms.TextBox txtNouveauMotDePasse;
        private System.Windows.Forms.TextBox txtUserAModifier;
        private System.Windows.Forms.ComboBox cbxListeAChanger;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource1;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAncienMotDePasse;
    }
}
