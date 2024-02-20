
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalisahaRezervasyonApp
{
    public partial class frmGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data source = DESKTOP-MV2GLCC\\SQLEXPRESS;initial catalog = DbHalısaha;integrated security = true");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adaptor = new SqlDataAdapter();

        frmAnaSayfa frmAnaSayfa = new frmAnaSayfa();

        private Image mevcutIcon;
        private Image yeniIcon;
        public frmGiris()
        {
            InitializeComponent();
            mevcutIcon = Properties.Resources.password;
            yeniIcon = Properties.Resources.hide;

            iconDegistirme(mevcutIcon);
        }


        private void iconDegistirme(Image background)
        {
            btnIkon.BackgroundImage = background;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string ad = txtAdminAd.Text.ToLower();
            string sifre = txtAdminSifre.Text;

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Boş Olamaz");
                return;
            }


            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
            komut = new SqlCommand("select * from admin where adminAd=@ad and adminSifre=@sifre", baglanti);
            komut.Parameters.AddWithValue("@ad", ad);
            komut.Parameters.AddWithValue("@sifre", sifre);


            SqlDataReader reader = komut.ExecuteReader();


            if (reader.Read())
            {
                frmAnaSayfa.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya şifre yanlış");
            }

            baglanti.Close();
        }

        private void btnIkon_Click(object sender, EventArgs e)
        {

            if (btnIkon.BackgroundImage == mevcutIcon)
            {
                iconDegistirme(yeniIcon);
                txtAdminSifre.PasswordChar = '\0';

            }
            else
            {
                iconDegistirme(mevcutIcon);
                txtAdminSifre.PasswordChar = '*';
            }
        }
    }
}
