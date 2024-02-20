namespace HalisahaRezervasyonApp
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            btnRezervasyon = new System.Windows.Forms.Button();
            btnRezervasyonListe = new System.Windows.Forms.Button();
            btnHalisaha = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRezervasyon
            // 
            btnRezervasyon.BackColor = System.Drawing.Color.Azure;
            btnRezervasyon.Location = new System.Drawing.Point(29, 248);
            btnRezervasyon.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnRezervasyon.Name = "btnRezervasyon";
            btnRezervasyon.Size = new System.Drawing.Size(446, 144);
            btnRezervasyon.TabIndex = 0;
            btnRezervasyon.Text = "Revervasyon Sayfası";
            btnRezervasyon.UseVisualStyleBackColor = false;
            btnRezervasyon.Click += btnRezervasyon_Click;
            // 
            // btnRezervasyonListe
            // 
            btnRezervasyonListe.BackColor = System.Drawing.Color.Azure;
            btnRezervasyonListe.Location = new System.Drawing.Point(521, 248);
            btnRezervasyonListe.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnRezervasyonListe.Name = "btnRezervasyonListe";
            btnRezervasyonListe.Size = new System.Drawing.Size(446, 144);
            btnRezervasyonListe.TabIndex = 0;
            btnRezervasyonListe.Text = "Aktif Rezervasyonlar";
            btnRezervasyonListe.UseVisualStyleBackColor = false;
            btnRezervasyonListe.Click += btnRezervasyonListe_Click;
            // 
            // btnHalisaha
            // 
            btnHalisaha.BackColor = System.Drawing.Color.Azure;
            btnHalisaha.Location = new System.Drawing.Point(278, 417);
            btnHalisaha.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnHalisaha.Name = "btnHalisaha";
            btnHalisaha.Size = new System.Drawing.Size(446, 144);
            btnHalisaha.TabIndex = 0;
            btnHalisaha.Text = "Halı Saha Bilgi Güncelleme";
            btnHalisaha.UseVisualStyleBackColor = false;
            btnHalisaha.Click += btnHalisaha_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label1.Font = new System.Drawing.Font("Georgia", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(-2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(940, 53);
            label1.TabIndex = 1;
            label1.Text = "HALI SAHA REZERVASYON UYGULAMASI";
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(29, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(938, 220);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // frmAnaSayfa
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(995, 600);
            Controls.Add(groupBox1);
            Controls.Add(btnHalisaha);
            Controls.Add(btnRezervasyonListe);
            Controls.Add(btnRezervasyon);
            Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "frmAnaSayfa";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ana Sayfa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.Button btnRezervasyonListe;
        private System.Windows.Forms.Button btnHalisaha;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}