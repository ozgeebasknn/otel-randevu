using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Randevu
{
    public partial class FrmMusteri : Form
    {
        public Musteri musteri;
        public İkiliAramaAgaci agac = new İkiliAramaAgaci();
        public FrmMusteri()
        {
            InitializeComponent();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            txtOtelListe.Text = musteri.PreOrderYazdir(agac);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            txtOtelListe.Text = musteri.InOrderYazdir(agac);
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            txtOtelListe.Text = musteri.PostOrderYazdir(agac);
        }

        private void btnDerinlikbul_Click(object sender, EventArgs e)
        {
            MessageBox.Show(musteri.DerinlikBul(agac));
        }

        private void btnElemanSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(musteri.ElemanSayisiBul(agac));
        }
    }
}
