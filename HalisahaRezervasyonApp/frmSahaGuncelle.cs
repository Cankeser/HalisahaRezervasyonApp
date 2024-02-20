using HalisahaRezervasyonApp.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HalisahaRezervasyonApp
{
    public partial class frmSahaGuncelle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data source = DESKTOP-MV2GLCC\\SQLEXPRESS;initial catalog = DbHalısaha;integrated security = true");
        SqlCommand komut = new SqlCommand();
        byte[] resim;
        int id;

        public frmSahaGuncelle()
        {
            InitializeComponent();
        }

        private void frmRezervasyonIstatistik_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.none;
        }

        private void btnSaha_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "Kapalı Saha")
            {
                id = 1;
                pictureBox1.Image = Resources.kapalisaha;
            }
            else if (button.Text == "Açık Saha")
            {
                id = 2;
                pictureBox1.Image = Resources.indir__14_;
            }

            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }

            komut.CommandText = "Select kapasite, ücret,resim from Halisahalar where halisahaID=@SahaId";
            komut.Connection = baglanti;
            komut.Parameters.Clear();
            komut.Parameters.AddWithValue("@SahaId", id);

            SqlDataReader reader = komut.ExecuteReader();

            if (reader.Read())
            {
                txtKapasite.Text = reader["kapasite"].ToString();
                txtUcret.Text = reader["ücret"].ToString();

                byte[] resimVerisi = (byte[])reader["Resim"];

                using (MemoryStream stream = new MemoryStream(resimVerisi))
                {
                    pictureBox1.Image = Image.FromStream(stream);

                }

            }

            baglanti.Close();
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim Dosyaları (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|Tüm dosyalar (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    string dosyaYolu = openFileDialog1.FileName;

                    using (FileStream fs = new FileStream(dosyaYolu, FileMode.Open, FileAccess.Read))
                    {
                        resim = new byte[fs.Length];
                        fs.Read(resim, 0, resim.Length);

                        using (MemoryStream stream = new MemoryStream(resim))
                        {
                            pictureBox1.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Resim yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }

            komut.CommandText = "UPDATE Halisahalar SET kapasite=@kapasite, ücret=@ücret, resim=@ResimVerisi WHERE halisahaID=@SahaId";
            komut.Connection = baglanti;

            komut.Parameters.Clear();
            komut.Parameters.AddWithValue("@kapasite", txtKapasite.Text);
            komut.Parameters.AddWithValue("@ücret", txtUcret.Text);

            // Resim değeri null değilse ekleyin, null ise DBNull.Value kullanın
            if (resim != null)
                komut.Parameters.AddWithValue("@ResimVerisi", resim);
            else
                komut.Parameters.AddWithValue("@ResimVerisi", DBNull.Value);

            komut.Parameters.AddWithValue("@SahaId", id);
            komut.ExecuteNonQuery();


            MessageBox.Show("Kayıt Güncellendi");
            txtKapasite.Clear();
            txtUcret.Clear();
            openFileDialog1.ClientGuid = Guid.Empty;

            baglanti.Close();
        }

    }
}
