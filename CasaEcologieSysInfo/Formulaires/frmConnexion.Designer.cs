namespace CasaEcologieSysInfo
{
    partial class frmConnexion
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnexion));
            this.pnlTopConnexion = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelConn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.txtNomUtilisateur = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dragControl1 = new CasaEcologieSysInfo.DragControl();
            this.pnlTopConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopConnexion
            // 
            this.pnlTopConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(31)))), ((int)(((byte)(20)))));
            this.pnlTopConnexion.Controls.Add(this.pictureBox2);
            this.pnlTopConnexion.Controls.Add(this.labelConn);
            this.pnlTopConnexion.Controls.Add(this.pictureBox1);
            this.pnlTopConnexion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopConnexion.ForeColor = System.Drawing.Color.White;
            this.pnlTopConnexion.Location = new System.Drawing.Point(0, 0);
            this.pnlTopConnexion.Name = "pnlTopConnexion";
            this.pnlTopConnexion.Size = new System.Drawing.Size(1200, 55);
            this.pnlTopConnexion.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CasaEcologieSysInfo.Properties.Resources.Shutdown_32px;
            this.pictureBox2.Location = new System.Drawing.Point(1159, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // labelConn
            // 
            this.labelConn.AutoSize = true;
            this.labelConn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConn.Location = new System.Drawing.Point(88, 18);
            this.labelConn.Name = "labelConn";
            this.labelConn.Size = new System.Drawing.Size(334, 16);
            this.labelConn.TabIndex = 1;
            this.labelConn.Text = "Système d\'information du GIE Casa Ecologie de Bignona";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CasaEcologieSysInfo.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Veuillez vous connecter !";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom d\'utilisateur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mot de passe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 412);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 27);
            this.textBox1.TabIndex = 3;
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(31)))), ((int)(((byte)(20)))));
            this.btnSeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeConnecter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeConnecter.ForeColor = System.Drawing.Color.White;
            this.btnSeConnecter.Location = new System.Drawing.Point(406, 521);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(229, 32);
            this.btnSeConnecter.TabIndex = 3;
            this.btnSeConnecter.Text = "Se connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = false;
            this.btnSeConnecter.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtNomUtilisateur
            // 
            this.txtNomUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtNomUtilisateur.Location = new System.Drawing.Point(406, 412);
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.Size = new System.Drawing.Size(415, 27);
            this.txtNomUtilisateur.TabIndex = 1;
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtMotDePasse.Location = new System.Drawing.Point(406, 477);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.PasswordChar = '*';
            this.txtMotDePasse.Size = new System.Drawing.Size(415, 27);
            this.txtMotDePasse.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(31)))), ((int)(((byte)(20)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(687, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CasaEcologieSysInfo.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(490, 144);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 181);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.pnlTopConnexion;
            // 
            // frmConnexion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSeConnecter);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtNomUtilisateur);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pnlTopConnexion);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page de connexion";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Connexion_MouseDown);
            this.pnlTopConnexion.ResumeLayout(false);
            this.pnlTopConnexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopConnexion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelConn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.TextBox txtNomUtilisateur;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button button2;
        private DragControl dragControl1;
    }
}

