using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalisahaRezervasyonApp
{
    public partial class frmAnaSayfa : Form
    {
        frmRezervasyon rezervasyon = new frmRezervasyon();
        frmRezervasyonListe rezervasyonListe = new frmRezervasyonListe();

        frmSahaGuncelle frmSahaGuncelle = new frmSahaGuncelle();
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            if (rezervasyonListe != null || rezervasyonListe.IsDisposed)
            {
                rezervasyon.ShowDialog();
            }
        }

        private void btnRezervasyonListe_Click(object sender, EventArgs e)
        {
            if (rezervasyonListe != null || rezervasyonListe.IsDisposed)
            {
                rezervasyonListe.ShowDialog();

            }
        }



        private void btnHalisaha_Click(object sender, EventArgs e)
        {
            if (rezervasyonListe != null || rezervasyonListe.IsDisposed)
            {
                frmSahaGuncelle.ShowDialog();
            }
        }
    }
}
