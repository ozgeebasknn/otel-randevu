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
    public partial class FrmYetkili : Form
    {
        public Yetkili yetkili;
        public İkiliAramaAgaci agac = new İkiliAramaAgaci();
        public FrmYetkili()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OtelBilgileri yeniOtel = new OtelBilgileri();
            yeniOtel.ad = txtOtelAd.Text;
            yeniOtel.adres = txtOtelAdres.Text;
            yeniOtel.eposta = txtOtelEmail.Text;
            yeniOtel.il = txtOtelSehir.Text;
            yeniOtel.ilce = txtOtelIlce.Text;
            yeniOtel.odaSayisi = Convert.ToInt32(txtOtelOdaSayisi.Text);
            yeniOtel.tel = Convert.ToInt32(txtOtelTelefon.Text);
            yeniOtel.yildiz = Convert.ToInt32(txtOtelYildiz.Text);
            Random rand = new Random();
            yeniOtel.id = rand.Next(3, 50);
            try
            {
                yetkili.OtelEkle(yeniOtel, agac);
                MessageBox.Show("basarili");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            txtOtelListe.Text = yetkili.PreOrderYazdir(agac);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            txtOtelListe.Text = yetkili.InOrderYazdir(agac);
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            txtOtelListe.Text = yetkili.PostOrderYazdir(agac);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int aranan = Convert.ToInt32(txtAra.Text);
            OtelBilgileri bulunanOtel = yetkili.OtelAra(aranan, agac).veri;
            txtaraad.Text = bulunanOtel.ad;
            txtaraadres.Text = bulunanOtel.adres;
            txtaraiil.Text = bulunanOtel.il;
            txtarailce.Text = bulunanOtel.ilce;
            txtaramail.Text = bulunanOtel.eposta;
            txtaraoda.Text = bulunanOtel.odaSayisi.ToString();
            txtarayildiz.Text = bulunanOtel.yildiz.ToString();
            txtaratel.Text = bulunanOtel.tel.ToString();
        }

        private void btnotelguncelle_Click(object sender, EventArgs e)
        {
            OtelBilgileri guncellenecek = new OtelBilgileri();
            guncellenecek.ad = txtaraad.Text;
            guncellenecek.adres = txtaraadres.Text;
            guncellenecek.il = txtaraiil.Text;
            guncellenecek.ilce = txtarailce.Text;
            guncellenecek.eposta = txtaramail.Text;
            guncellenecek.odaSayisi = Convert.ToInt32(txtaraoda.Text);
            guncellenecek.yildiz = Convert.ToInt32(txtarayildiz.Text);
            guncellenecek.tel = Convert.ToInt32(txtaratel.Text);
            İkiliAramaAgaciDugumu dugumm = new İkiliAramaAgaciDugumu();
            dugumm.veri = guncellenecek;
            try
            {
                yetkili.OtelGuncelle(dugumm, Convert.ToInt32(txtAra.Text), agac);
                MessageBox.Show("guncellendi");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnOtelSil_Click(object sender, EventArgs e)
        {
            int silinecek = Convert.ToInt32(txtAra.Text);
            try
            {
                yetkili.OtelSil(silinecek, agac);
                MessageBox.Show("silindi");
            }
            catch (Exception)
            {
                MessageBox.Show("silinemedi");
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.ad = txtpersonelad.Text;
            personel.adres = txtpersoneladres.Text;
            personel.departman = txtperoneldepartman.Text;
            personel.eposta = txtpersonelmail.Text;
            personel.pozisyon = txtpersonelpozisyon.Text;
            personel.soyad = txtpersonelsoyad.Text;
            personel.tc = Convert.ToInt32(txtpersoneltc.Text);
            personel.telefon = Convert.ToInt32(txtpersoneltelefon.Text);
            OtelBilgileri bulunanOtel = yetkili.OtelAra(Convert.ToInt32(txtOtelId.Text), agac).veri;
            try
            {
                yetkili.PersonelEkle(bulunanOtel, personel);
                MessageBox.Show("Personel Eklendi...");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            OtelBilgileri arananotel = new OtelBilgileri();
            arananotel = yetkili.OtelAra(Convert.ToInt32(txtAra.Text),agac).veri;
            txtPersonellistele.Text = yetkili.PersonelListele(arananotel);
        }

        private void btnpersonelsil_Click(object sender, EventArgs e)
        {
            OtelBilgileri arananotel = new OtelBilgileri();
            arananotel = yetkili.OtelAra(Convert.ToInt32(txtAra.Text),agac).veri;
            yetkili.PersonelSil(arananotel, Convert.ToInt32(txtpersonelsil.Text));

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            
        }
    }
}
