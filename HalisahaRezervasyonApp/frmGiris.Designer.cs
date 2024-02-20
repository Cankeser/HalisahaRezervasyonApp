namespace HalisahaRezervasyonApp
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnIkon = new System.Windows.Forms.Button();
            txtAdminSifre = new System.Windows.Forms.TextBox();
            txtAdminAd = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnGirisYap = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.Controls.Add(btnIkon);
            groupBox1.Controls.Add(txtAdminSifre);
            groupBox1.Controls.Add(txtAdminAd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGirisYap);
            groupBox1.ForeColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(75, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(387, 197);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Admin Giriş";
            // 
            // btnIkon
            // 
            btnIkon.BackgroundImage = Properties.Resources.password;
            btnIkon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnIkon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnIkon.Location = new System.Drawing.Point(335, 90);
            btnIkon.Name = "btnIkon";
            btnIkon.Size = new System.Drawing.Size(30, 28);
            btnIkon.TabIndex = 3;
            btnIkon.UseVisualStyleBackColor = true;
            btnIkon.Click += btnIkon_Click;
            // 
            // txtAdminSifre
            // 
            txtAdminSifre.Location = new System.Drawing.Point(115, 89);
            txtAdminSifre.Name = "txtAdminSifre";
            txtAdminSifre.PasswordChar = '*';
            txtAdminSifre.Size = new System.Drawing.Size(207, 29);
            txtAdminSifre.TabIndex = 2;
            // 
            // txtAdminAd
            // 
            txtAdminAd.Location = new System.Drawing.Point(115, 42);
            txtAdminAd.Name = "txtAdminAd";
            txtAdminAd.Size = new System.Drawing.Size(207, 29);
            txtAdminAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(59, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 21);
            label2.TabIndex = 1;
            label2.Text = "Şifre : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(6, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 21);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı : ";
            // 
            // btnGirisYap
            // 
            btnGirisYap.ForeColor = System.Drawing.Color.Black;
            btnGirisYap.Location = new System.Drawing.Point(171, 134);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new System.Drawing.Size(136, 35);
            btnGirisYap.TabIndex = 0;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(504, 319);
            Controls.Add(groupBox1);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(520, 358);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(520, 358);
            Name = "frmGiris";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "HALISAHA REZERVASYON UYGULAMSI";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdminSifre;
        private System.Windows.Forms.TextBox txtAdminAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnIkon;
    }
}