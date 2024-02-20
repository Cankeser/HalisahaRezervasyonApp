using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HalisahaRezervasyonApp
{
    public partial class frmRezervasyon : Form
    {
        SqlConnection baglanti = new SqlConnection("Data source = DESKTOP-MV2GLCC\\SQLEXPRESS;initial catalog = DbHalısaha;integrated security = true");
        SqlCommand komut = new SqlCommand();


        public frmRezervasyon()
        {
            InitializeComponent();
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
            string isim = txtIsim.Text;
            string soyisim = txtSoyisim.Text;
            DateTime seciliTarih = DateTime.Parse(dtpTarihFiltresi.Value.ToString(""));
            string saat = txtSaat.Text;
            int halisahaId = 0;

            if (string.IsNullOrWhiteSpace(isim) || string.IsNullOrWhiteSpace(soyisim) || string.IsNullOrWhiteSpace(saat))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }
            else
            {
                halisahaId = int.Parse(lblSahaId.Text);
                komut = new SqlCommand("INSERT INTO rezervasyonlar (HalisahaID, Tarih, Saat, Isim, Soyisim) VALUES (@HaliSahaID, @Tarih, @Saat, @Isim, @Soyisim )", baglanti);
                komut.Parameters.AddWithValue("@HaliSahaID", halisahaId);
                komut.Parameters.AddWithValue("@Tarih", seciliTarih);
                komut.Parameters.AddWithValue("@Saat", saat);
                komut.Parameters.AddWithValue("@Isim", isim);
                komut.Parameters.AddWithValue("@Soyisim", soyisim);

                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Rezervasyon Yapıldı");

                RenkleriGuncelle(halisahaId, seciliTarih);
                txtIsim.Clear();
                txtSaat.Clear();
                txtSoyisim.Clear();
            }

        }


        private void picture_Click(object sender, EventArgs e)
        {



            if (sender is PictureBox clickedPictureBox)
            {
               grbSaatler.Visible = true;
                int id = 0;

                if (clickedPictureBox.Name == "pbKapaliSaha")
                {
                    id = 1;
                    lblSahaId.Text = id.ToString();
                    grbSaatler.Text = lblKapaliSaha.Text + " Rezervasyon Bilgileri";

                }
                else if (clickedPictureBox.Name == "pbAcikSaha")
                {
                    id = 2;
                    lblSahaId.Text = id.ToString();
                    grbSaatler.Text = lblAcikSaha.Text + " Rezervasyon Bilgileri";
                }

                // grbSaatler içindeki tüm butonların rengini sıfırla
                RenkleriSifirla();
                DateTime seciliTarih = DateTime.Parse(dtpTarihFiltresi.Value.ToString(""));
                if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
                komut = new SqlCommand("SELECT * FROM rezervasyonlar WHERE HalisahaId = @HalisahaId and Tarih= @tarih", baglanti);
                komut.Parameters.AddWithValue("@HalisahaId", id);
                komut.Parameters.AddWithValue("@tarih", seciliTarih);

                SqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    string reservedHour = reader["Saat"].ToString();

                    // grbSaatler içindeki sadece ilgili saate ait butonu kırmızı yap
                    Button matchingButton = grbSaatler.Controls.OfType<Button>().FirstOrDefault(button => button.Text == reservedHour);

                    if (matchingButton != null)
                    {
                        matchingButton.BackColor = System.Drawing.Color.Red;
                    }
                }
              
                baglanti.Close();
            }
        }




        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            grbSaatler.Visible = false;
            RenkleriSifirla();
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }

            komut = new SqlCommand("select * from halisahalar", baglanti);
            SqlDataReader reader = komut.ExecuteReader();



            List<string> halisahaBilgileri = new List<string>();

            while (reader.Read())
            {

                if (reader["halisahaID"].ToString() == "1")
                {
                    byte[] resimVerisi = (byte[])reader["Resim"];

                    using (MemoryStream stream = new MemoryStream(resimVerisi))
                    {
                        pbKapaliSaha.Image = Image.FromStream(stream);
                        // Diğer PictureBox'lara da aynı şekilde ekleyebilirsiniz.
                    }
                }
                else if (reader["halisahaID"].ToString() == "2")
                {
                    byte[] resimVerisi = (byte[])reader["Resim"];

                    using (MemoryStream stream = new MemoryStream(resimVerisi))
                    {
                        pbAcikSaha.Image = Image.FromStream(stream);
                        // Diğer PictureBox'lara da aynı şekilde ekleyebilirsiniz.
                    }
                }


                string halisahaBilgi = $"{reader["HalisahaAdi"].ToString()} / {reader["kapasite"].ToString()}";
                string halisahaUcret = $"Fiyat : {reader["ücret"].ToString()} TL";


                halisahaBilgileri.Add($"{halisahaBilgi} - {halisahaUcret}");
            }

            if (halisahaBilgileri.Count > 0)
            {
                lblKapaliSahaBilgi.Text = halisahaBilgileri[0];


            }

            if (halisahaBilgileri.Count > 1)
            {
                lblAcikSahaBilgi.Text = halisahaBilgileri[1];

            }

            baglanti.Close();
        }

        private void SaatButton_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (button.BackColor != Color.Red)
            {
                txtSaat.Text = button.Text;
            }
            else
            {
                MessageBox.Show("Bu saat dolu lütfen başka bir saat seçiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtpTarihFiltresi_ValueChanged(object sender, EventArgs e)
        {

            RenkleriSifirla();


            DateTime seciliTarih = DateTime.Parse(dtpTarihFiltresi.Value.ToString());
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }


            komut = new SqlCommand("SELECT * FROM rezervasyonlar WHERE tarih = @Tarih", baglanti);
            komut.Parameters.AddWithValue("@Tarih", seciliTarih);

            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                string reservedHour = reader["saat"].ToString();

                // grbSaatler içindeki sadece ilgili saate ait butonu kırmızı yap
                Button matchingButton = grbSaatler.Controls.OfType<Button>().FirstOrDefault(button => button.Text == reservedHour);

                if (matchingButton != null)
                {
                    matchingButton.BackColor = System.Drawing.Color.Red;
                }
            }

            baglanti.Close();


        }
        private void RenkleriSifirla()
        {
            foreach (Button button in grbSaatler.Controls.OfType<Button>())
            {
                button.BackColor = System.Drawing.Color.Green;
            }
        }

        private void RenkleriGuncelle(int halisahaId, DateTime tarih)
        {
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }

            komut = new SqlCommand("SELECT * FROM rezervasyonlar WHERE HalisahaId = @HalisahaId and Tarih= @tarih", baglanti);
            komut.Parameters.AddWithValue("@HalisahaId", halisahaId);
            komut.Parameters.AddWithValue("@tarih", tarih);

            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                string reservedHour = reader["Saat"].ToString();

                // grbSaatler içindeki sadece ilgili saate ait butonu kırmızı yap
                Button matchingButton = grbSaatler.Controls.OfType<Button>().FirstOrDefault(button => button.Text == reservedHour);

                if (matchingButton != null)
                {
                    matchingButton.BackColor = System.Drawing.Color.Red;
                }
            }

            baglanti.Close();
        }

    }
}
