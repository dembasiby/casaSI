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
            this.dtpArrivee = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDepart = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNouvelEmploye = new System.Windows.Forms.Button();
            this.ageEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btnPresenceEmploye.Location = new System.Drawing.Point(13, 447);
            this.btnPresenceEmploye.Name = "btnPresenceEmploye";
            this.btnPresenceEmploye.Size = new System.Drawing.Size(223, 31);
            this.btnPresenceEmploye.TabIndex = 30;
            this.btnPresenceEmploye.Text = "Enregistrer";
            this.btnPresenceEmploye.UseVisualStyleBackColor = false;
            this.btnPresenceEmploye.Click += new System.EventHandler(this.btnPresenceEmploye_Click);
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
            this.panel1.Location = new System.Drawing.Point(-1, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 10);
            this.panel1.TabIndex = 34;
            // 
            // dtpArrivee
            // 
            this.dtpArrivee.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpArrivee.Location = new System.Drawing.Point(13, 403);
            this.dtpArrivee.Name = "dtpArrivee";
            this.dtpArrivee.Size = new System.Drawing.Size(99, 23);
            this.dtpArrivee.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 383);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Arrivée";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 383);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Départ";
            // 
            // dtpDepart
            // 
            this.dtpDepart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDepart.Location = new System.Drawing.Point(137, 403);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.Size = new System.Drawing.Size(99, 23);
            this.dtpDepart.TabIndex = 35;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(272, 282);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(499, 282);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(423, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 150);
            this.dataGridView1.TabIndex = 40;
            // 
            // UC_Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtpDepart);
            this.Controls.Add(this.dtpArrivee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxTimeSheetNomEmploye);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.ageEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpArrivee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDepart;
        private System.Windows.Forms.BindingSource ageEmployeBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNouvelEmploye;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
