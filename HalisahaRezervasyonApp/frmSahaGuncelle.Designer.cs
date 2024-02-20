namespace HalisahaRezervasyonApp
{
    partial class frmSahaGuncelle
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtUcret = new System.Windows.Forms.TextBox();
            txtKapasite = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            btnGuncelle = new System.Windows.Forms.Button();
            btnResimDegis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(16, 53);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(295, 216);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(410, 134);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 21);
            label1.TabIndex = 1;
            label1.Text = "Ücret :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(389, 89);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 21);
            label2.TabIndex = 1;
            label2.Text = "Kapasite :";
            // 
            // txtUcret
            // 
            txtUcret.Location = new System.Drawing.Point(470, 131);
            txtUcret.Margin = new System.Windows.Forms.Padding(4);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new System.Drawing.Size(127, 29);
            txtUcret.TabIndex = 2;
            // 
            // txtKapasite
            // 
            txtKapasite.Location = new System.Drawing.Point(470, 89);
            txtKapasite.Margin = new System.Windows.Forms.Padding(4);
            txtKapasite.Name = "txtKapasite";
            txtKapasite.Size = new System.Drawing.Size(127, 29);
            txtKapasite.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(16, 13);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(135, 32);
            button1.TabIndex = 5;
            button1.Text = "Kapalı Saha";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSaha_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(176, 13);
            button2.Margin = new System.Windows.Forms.Padding(4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(135, 32);
            button2.TabIndex = 5;
            button2.Text = "Açık Saha";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSaha_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.HelpRequest += btnResimSec_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new System.Drawing.Point(503, 187);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new System.Drawing.Size(94, 45);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnResimDegis
            // 
            btnResimDegis.Location = new System.Drawing.Point(181, 276);
            btnResimDegis.Name = "btnResimDegis";
            btnResimDegis.Size = new System.Drawing.Size(130, 45);
            btnResimDegis.TabIndex = 6;
            btnResimDegis.Text = "Resmi Değiştir";
            btnResimDegis.UseVisualStyleBackColor = true;
            btnResimDegis.Click += btnResimSec_Click;
            // 
            // frmSahaGuncelle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(610, 335);
            Controls.Add(btnResimDegis);
            Controls.Add(btnGuncelle);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtKapasite);
            Controls.Add(txtUcret);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "frmSahaGuncelle";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = " ";
            Load += frmRezervasyonIstatistik_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox txtKapasite;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnResimDegis;
    }
}