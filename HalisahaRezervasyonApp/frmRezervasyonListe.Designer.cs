namespace HalisahaRezervasyonApp
{
    partial class frmRezervasyonListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvRezervasyonListe = new System.Windows.Forms.DataGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            cmbSaat = new System.Windows.Forms.ComboBox();
            cmbHalisaha = new System.Windows.Forms.ComboBox();
            dtpTarihFiltresiGüncelle = new System.Windows.Forms.DateTimePicker();
            label7 = new System.Windows.Forms.Label();
            txtSoyisimGüncelle = new System.Windows.Forms.TextBox();
            txtIsimGüncelle = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            btnRezervasyonGüncelle = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvRezervasyonListe).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRezervasyonListe
            // 
            dgvRezervasyonListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvRezervasyonListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvRezervasyonListe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dgvRezervasyonListe.ColumnHeadersHeight = 30;
            dgvRezervasyonListe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            dgvRezervasyonListe.Location = new System.Drawing.Point(15, 17);
            dgvRezervasyonListe.Margin = new System.Windows.Forms.Padding(4);
            dgvRezervasyonListe.MultiSelect = false;
            dgvRezervasyonListe.Name = "dgvRezervasyonListe";
            dgvRezervasyonListe.ReadOnly = true;
            dgvRezervasyonListe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvRezervasyonListe.RowTemplate.Height = 25;
            dgvRezervasyonListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvRezervasyonListe.Size = new System.Drawing.Size(893, 266);
            dgvRezervasyonListe.TabIndex = 0;
            dgvRezervasyonListe.CellClick += dgvRezervasyonListe_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(cmbSaat);
            groupBox2.Controls.Add(cmbHalisaha);
            groupBox2.Controls.Add(dtpTarihFiltresiGüncelle);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtSoyisimGüncelle);
            groupBox2.Controls.Add(txtIsimGüncelle);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnRezervasyonGüncelle);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(15, 306);
            groupBox2.Margin = new System.Windows.Forms.Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4);
            groupBox2.Size = new System.Drawing.Size(893, 280);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rezervasyon Düzenle";
            // 
            // cmbSaat
            // 
            cmbSaat.FormattingEnabled = true;
            cmbSaat.Items.AddRange(new object[] { "10.00-11.00", "11.00-12.00", "12.00-13.00", "13.00-14.00", "14.00-15.00", "15.00-16.00", "16.00-17.00", "17.00-18.00", "18.00-19.00", "19.00-20.00", "20.00-21.00", "21.00-22.00", "22.00-23.00", "23.00-00.00", "00.00-01.00", "01.00-02.00" });
            cmbSaat.Location = new System.Drawing.Point(94, 145);
            cmbSaat.Name = "cmbSaat";
            cmbSaat.Size = new System.Drawing.Size(313, 29);
            cmbSaat.TabIndex = 6;
            // 
            // cmbHalisaha
            // 
            cmbHalisaha.FormattingEnabled = true;
            cmbHalisaha.Items.AddRange(new object[] { "Kapalı Saha", "Açık Saha" });
            cmbHalisaha.Location = new System.Drawing.Point(94, 203);
            cmbHalisaha.Name = "cmbHalisaha";
            cmbHalisaha.Size = new System.Drawing.Size(313, 29);
            cmbHalisaha.TabIndex = 6;
            // 
            // dtpTarihFiltresiGüncelle
            // 
            dtpTarihFiltresiGüncelle.CustomFormat = "dd.MM.yyyy";
            dtpTarihFiltresiGüncelle.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpTarihFiltresiGüncelle.Location = new System.Drawing.Point(555, 146);
            dtpTarihFiltresiGüncelle.Margin = new System.Windows.Forms.Padding(4);
            dtpTarihFiltresiGüncelle.Name = "dtpTarihFiltresiGüncelle";
            dtpTarihFiltresiGüncelle.Size = new System.Drawing.Size(313, 29);
            dtpTarihFiltresiGüncelle.TabIndex = 5;
            dtpTarihFiltresiGüncelle.Value = new System.DateTime(2024, 1, 27, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(495, 151);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(54, 21);
            label7.TabIndex = 4;
            label7.Text = "Tarih : ";
            // 
            // txtSoyisimGüncelle
            // 
            txtSoyisimGüncelle.Location = new System.Drawing.Point(555, 78);
            txtSoyisimGüncelle.Margin = new System.Windows.Forms.Padding(4);
            txtSoyisimGüncelle.Name = "txtSoyisimGüncelle";
            txtSoyisimGüncelle.Size = new System.Drawing.Size(313, 29);
            txtSoyisimGüncelle.TabIndex = 2;
            // 
            // txtIsimGüncelle
            // 
            txtIsimGüncelle.Location = new System.Drawing.Point(98, 78);
            txtIsimGüncelle.Margin = new System.Windows.Forms.Padding(4);
            txtIsimGüncelle.Name = "txtIsimGüncelle";
            txtIsimGüncelle.Size = new System.Drawing.Size(311, 29);
            txtIsimGüncelle.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 205);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 21);
            label1.TabIndex = 0;
            label1.Text = "Halısaha  : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(43, 148);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(51, 21);
            label8.TabIndex = 0;
            label8.Text = "Saat : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(467, 81);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(76, 21);
            label6.TabIndex = 0;
            label6.Text = "Soyisim : ";
            // 
            // btnRezervasyonGüncelle
            // 
            btnRezervasyonGüncelle.Location = new System.Drawing.Point(630, 195);
            btnRezervasyonGüncelle.Margin = new System.Windows.Forms.Padding(4);
            btnRezervasyonGüncelle.Name = "btnRezervasyonGüncelle";
            btnRezervasyonGüncelle.Size = new System.Drawing.Size(238, 56);
            btnRezervasyonGüncelle.TabIndex = 1;
            btnRezervasyonGüncelle.Text = "Rezervasyonu Güncelle";
            btnRezervasyonGüncelle.UseVisualStyleBackColor = true;
            btnRezervasyonGüncelle.Click += btnRezervasyonGüncelle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(44, 81);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 21);
            label5.TabIndex = 0;
            label5.Text = "İsim : ";
            // 
            // btnSil
            // 
            btnSil.BackColor = System.Drawing.Color.Red;
            btnSil.Location = new System.Drawing.Point(793, 29);
            btnSil.Name = "btnSil";
            btnSil.Size = new System.Drawing.Size(75, 36);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // frmRezervasyonListe
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(927, 612);
            Controls.Add(groupBox2);
            Controls.Add(dgvRezervasyonListe);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "frmRezervasyonListe";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Rezervasyon Listesi";
            Load += frmRezervasyonListe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRezervasyonListe).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRezervasyonListe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSoyisimGüncelle;
        private System.Windows.Forms.TextBox txtIsimGüncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRezervasyonGüncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTarihFiltresiGüncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHalisaha;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.Button btnSil;
    }
}