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
    public partial class Form1 : Form
    {
        public Musteri musteri = new Musteri("emin", "123");
        public Yetkili yetkili = new Yetkili("berfin", "123");
        public İkiliAramaAgaci agac = new İkiliAramaAgaci();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == musteri.kullaniciAdi && txtSifre.Text == musteri.sifre)
            {
                FrmMusteri frmMusteri = new FrmMusteri();
                frmMusteri.musteri = musteri;
                frmMusteri.agac = agac;
                frmMusteri.Show();
                this.Hide();
            }
            else if(txtKullaniciAdi.Text == yetkili.kullaniciAdi && txtSifre.Text == yetkili.sifre)
            {
                FrmYetkili frmYetkili = new FrmYetkili();
                frmYetkili.yetkili = yetkili;
                frmYetkili.agac = agac;
                frmYetkili.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OtelBilgileri otel = new OtelBilgileri(1, "dedeman", "gaziantep", "sehitkamil", "sehitkamil/gaziantep", "dedeman@otel.com", 545454, 5, 10);
            Personel personel = new Personel(1, "merve", "yesil", "gaziantep", "merve@xxx.com", 111, "yonetim", "yonetici");
            PersonelListe personelListe = new PersonelListe();
            otel.personelListe = personelListe;
            otel.personelListe.PersonelEkle(personel);

            Yorum yorum = new Yorum(1, "sumru", "ozdemir", "sumru@xxx.com", "cok guzel", 5);
            YorumListe yorumListe = new YorumListe();
            otel.yorumListe = yorumListe;
            otel.yorumListe.YorumEkle(yorum);

            Oda oda1 = new Oda(1, 444, 2, "orman", false, 300, personel);
            Oda oda2 = new Oda(2, 445, 1, "orman", false, 200, personel);
            OdaListe odaListe = new OdaListe();
            otel.odaliste = odaListe;
            odaListe.OdaEkle(oda1);

            otel.odaliste.OdaEkle(oda2);
            yetkili.OtelEkle(otel, agac);

            OtelBilgileri otel1 = new OtelBilgileri();
            otel1.id = 3;
            otel1.ad = "bbb";
            yetkili.OtelEkle(otel1, agac);
        }
    }
}
