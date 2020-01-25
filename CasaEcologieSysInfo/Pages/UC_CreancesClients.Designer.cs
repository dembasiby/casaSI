namespace CasaEcologieSysInfo.Pages
{
    partial class UC_CreancesClients
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
            this.lbxListeClients = new System.Windows.Forms.ListBox();
            this.dgvDetailsClient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalCreances = new System.Windows.Forms.TextBox();
            this.btnImprimerTableau = new System.Windows.Forms.Button();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.ageClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Créances clients";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbxListeClients
            // 
            this.lbxListeClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxListeClients.FormattingEnabled = true;
            this.lbxListeClients.ItemHeight = 17;
            this.lbxListeClients.Location = new System.Drawing.Point(15, 103);
            this.lbxListeClients.Margin = new System.Windows.Forms.Padding(2);
            this.lbxListeClients.Name = "lbxListeClients";
            this.lbxListeClients.Size = new System.Drawing.Size(228, 323);
            this.lbxListeClients.TabIndex = 26;
            this.lbxListeClients.SelectedValueChanged += new System.EventHandler(this.ListBox1_SelectedValueChanged);
            // 
            // dgvDetailsClient
            // 
            this.dgvDetailsClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailsClient.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDetailsClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetailsClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailsClient.Location = new System.Drawing.Point(256, 86);
            this.dgvDetailsClient.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetailsClient.Name = "dgvDetailsClient";
            this.dgvDetailsClient.Size = new System.Drawing.Size(712, 440);
            this.dgvDetailsClient.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fiche créance client - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Liste des clients";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Total créances clients";
            // 
            // txtTotalCreances
            // 
            this.txtTotalCreances.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalCreances.Enabled = false;
            this.txtTotalCreances.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCreances.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtTotalCreances.Location = new System.Drawing.Point(14, 456);
            this.txtTotalCreances.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalCreances.Name = "txtTotalCreances";
            this.txtTotalCreances.ReadOnly = true;
            this.txtTotalCreances.Size = new System.Drawing.Size(162, 27);
            this.txtTotalCreances.TabIndex = 29;
            this.txtTotalCreances.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnImprimerTableau
            // 
            this.btnImprimerTableau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnImprimerTableau.FlatAppearance.BorderSize = 0;
            this.btnImprimerTableau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerTableau.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerTableau.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimerTableau.Location = new System.Drawing.Point(745, 8);
            this.btnImprimerTableau.Name = "btnImprimerTableau";
            this.btnImprimerTableau.Size = new System.Drawing.Size(223, 30);
            this.btnImprimerTableau.TabIndex = 60;
            this.btnImprimerTableau.Text = "Imprimer le tableau";
            this.btnImprimerTableau.UseVisualStyleBackColor = false;
            this.btnImprimerTableau.Click += new System.EventHandler(this.BtnImprimerTableau_Click);
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomClient.Location = new System.Drawing.Point(564, 55);
            this.lblNomClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(0, 19);
            this.lblNomClient.TabIndex = 28;
            // 
            // ageClientBindingSource
            // 
            this.ageClientBindingSource.DataSource = typeof(CasaEcologieSysInfo.AgeClient);
            // 
            // UC_CreancesClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnImprimerTableau);
            this.Controls.Add(this.txtTotalCreances);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetailsClient);
            this.Controls.Add(this.lbxListeClients);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_CreancesClients";
            this.Size = new System.Drawing.Size(983, 635);
            this.Load += new System.EventHandler(this.UC_CreancesClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageClientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxListeClients;
        private System.Windows.Forms.BindingSource ageClientBindingSource;
        private System.Windows.Forms.DataGridView dgvDetailsClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalCreances;
        private System.Windows.Forms.Button btnImprimerTableau;
        private System.Windows.Forms.Label lblNomClient;
    }
}
