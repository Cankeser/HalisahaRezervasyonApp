using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HalisahaRezervasyonApp
{
    public partial class frmRezervasyonListe : Form
    {
        SqlConnection baglanti = new SqlConnection("Data source = DESKTOP-MV2GLCC\\SQLEXPRESS;initial catalog = DbHalısaha;integrated security = true");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adaptor = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public frmRezervasyonListe()
        {
            InitializeComponent();
        }

 

       private bool veriYuklendi=false;
        private void frmRezervasyonListe_Load(object sender, EventArgs e)
        {
            
            if (!veriYuklendi)
            {
                if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
                
                komut.CommandText = "SELECT RezervasyonID, Isim, Soyisim, Tarih, Saat, HalisahaAdi FROM rezervasyonlar INNER JOIN Halisahalar ON Rezervasyonlar.HalisahaID = Halisahalar.HalisahaID ORDER BY Tarih, Saat";
                komut.Connection = baglanti;

                using (SqlDataAdapter adapter = new SqlDataAdapter(komut))
                {
                    dt.Clear(); 
                    adapter.Fill(dt);
                }

                dgvRezervasyonListe.DataSource = dt;

                foreach (DataGridViewColumn column in dgvRezervasyonListe.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                veriYuklendi = true;
                baglanti.Close();
            }
        }




        private void dgvRezervasyonListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvRezervasyonListe.Rows[e.RowIndex];
                if (string.IsNullOrWhiteSpace(dtpTarihFiltresiGüncelle.Value.ToString()))
                {
                    dtpTarihFiltresiGüncelle.Value = DateTime.Parse(selectedRow.Cells["tarih"].Value.ToString());
                }
                txtIsimGüncelle.Text = selectedRow.Cells["Isim"].Value.ToString();
                txtSoyisimGüncelle.Text = selectedRow.Cells["Soyisim"].Value.ToString();
                cmbSaat.Text = selectedRow.Cells["Saat"].Value.ToString();
                cmbHalisaha.Text = selectedRow.Cells["halisahaAdi"].Value.ToString();
            }
        }

        private void btnRezervasyonGüncelle_Click(object sender, EventArgs e)
        {
           
            int halisahaId = 0;
            int seciliSatirIndex = dgvRezervasyonListe.CurrentRow.Index;
            int rezervasyonID = Convert.ToInt32(dgvRezervasyonListe.Rows[seciliSatirIndex].Cells["RezervasyonID"].Value);


            if (cmbHalisaha.Text == "Kapalı Saha")
            {
                halisahaId = 1;
            }
            else if (cmbHalisaha.Text == "Açık Saha")
            {
                halisahaId = 2;

            }

            if (RezervasyonVarMi(cmbSaat.Text, dtpTarihFiltresiGüncelle.Value, rezervasyonID, halisahaId))
            {
                MessageBox.Show("Aynı tarih ve saatte başka bir rezervasyon bulunmaktadır. Güncelleme yapılamaz.");
                baglanti.Close();
                return;
            }
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
            komut.CommandText = "UPDATE rezervasyonlar SET halisahaId=@halisaID ,Isim=@isim, Soyisim=@soyisim, Tarih=@tarih, Saat=@saat WHERE RezervasyonID=@rezervasyonID";
            komut.Connection = baglanti;

            komut.Parameters.Clear();
            if (string.IsNullOrWhiteSpace(txtIsimGüncelle.Text) || string.IsNullOrWhiteSpace(cmbSaat.Text) || string.IsNullOrWhiteSpace(txtSoyisimGüncelle.Text) || string.IsNullOrWhiteSpace(cmbHalisaha.Text))

            {
                MessageBox.Show("Boş geçilemez");
            }
            else
            {
                komut.Parameters.AddWithValue("@isim", txtIsimGüncelle.Text);
                komut.Parameters.AddWithValue("@soyisim", txtSoyisimGüncelle.Text);
                komut.Parameters.AddWithValue("@saat", cmbSaat.Text);
                komut.Parameters.AddWithValue("@tarih", dtpTarihFiltresiGüncelle.Value);
                komut.Parameters.AddWithValue("@rezervasyonID", rezervasyonID);
                komut.Parameters.AddWithValue("@halisaID", halisahaId);


                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt güncellendi");
                Temizle();

            }
            baglanti.Close();

            VeriyiYenile();
        }



        private bool RezervasyonVarMi(string saat, DateTime tarih, int guncellenenRezervasyonID, int halisahaID)
        {
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }

            komut.CommandText = "SELECT COUNT(*) FROM rezervasyonlar WHERE Saat = @saat AND Tarih = @tarih AND RezervasyonID <> @guncellenenRezervasyonID and halisahaId=@halisahaID";
            komut.Parameters.Clear();
            komut.Parameters.AddWithValue("@saat", saat);
            komut.Parameters.AddWithValue("@tarih", tarih);
            komut.Parameters.AddWithValue("@guncellenenRezervasyonID", guncellenenRezervasyonID);
            komut.Parameters.AddWithValue("@halisahaID", halisahaID);

            int rezervasyonSayisi = (int)komut.ExecuteScalar();

            baglanti.Close();

            // Eğer rezervasyonSayisi 0'dan büyükse, aynı tarih ve saatte başka bir rezervasyon var demektir.
            return rezervasyonSayisi > 0;
        }


        // DataGridView'i yenileme metodunu ayrı bir metot olarak tanımlayalım.
        private void VeriyiYenile()
        {
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }

            komut.CommandText = "SELECT RezervasyonID, Isim, Soyisim, Tarih, Saat, HalisahaAdi FROM rezervasyonlar INNER JOIN Halisahalar ON Rezervasyonlar.HalisahaID = Halisahalar.HalisahaID ORDER BY Tarih, Saat";
            komut.Connection = baglanti;

            dt.Clear(); // Önceki veriyi temizleyelim.

            using (SqlDataAdapter adapter = new SqlDataAdapter(komut))
            {
                adapter.Fill(dt);
            }

            dgvRezervasyonListe.DataSource = dt;
            foreach (DataGridViewColumn column in dgvRezervasyonListe.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dgvRezervasyonListe.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
            int seciliSatirIndex = dgvRezervasyonListe.CurrentRow.Index;
            int rezervasyonID = Convert.ToInt32(dgvRezervasyonListe.Rows[seciliSatirIndex].Cells["RezervasyonID"].Value);

            komut.CommandText = "Delete rezervasyonlar WHERE RezervasyonID=@rezervasyonID";
            komut.Connection = baglanti;

            komut.Parameters.Clear();
            komut.Parameters.AddWithValue("@rezervasyonID", rezervasyonID);

            komut.ExecuteNonQuery();
            MessageBox.Show("Rezervasyon Silindi");
            Temizle();

            baglanti.Close();

            VeriyiYenile();

        }
        private void Temizle()
        {
            txtIsimGüncelle.Clear();
            txtSoyisimGüncelle.Clear();
            cmbHalisaha.SelectedItem = null;
            cmbSaat.SelectedItem = null;
        }
    }
}
