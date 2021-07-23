using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Randevu
{
    public class Yetkili : Kullanici
    {
        public Yetkili(string kullaniciAdi, string sifre)
        {
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
        }
        public void OtelEkle(OtelBilgileri otel, İkiliAramaAgaci agac)
        {
            try
            {
                agac.Ekle(otel);
            }
            catch (Exception)
            {
                //MessageBox.Show("basarisiz");
                throw;
            }
        }
        public string PreOrderYazdir(İkiliAramaAgaci agac)
        {
            agac.PreOrder();
            return agac.DugumleriYazdir();
        }
        public string InOrderYazdir(İkiliAramaAgaci agac)
        {
            agac.InOrder();
            return agac.DugumleriYazdir();
        }
        public string PostOrderYazdir(İkiliAramaAgaci agac)
        {
            agac.PostOrder();
            return agac.DugumleriYazdir();

        }
        public İkiliAramaAgaciDugumu OtelAra(int otelid, İkiliAramaAgaci agac)
        {
            return agac.Ara(otelid);
        }
        public void OtelGuncelle(İkiliAramaAgaciDugumu dugum, int anahtar, İkiliAramaAgaci agac)
        {
            agac.Guncelle(dugum, anahtar);
        }
        public void OtelSil(int otelid, İkiliAramaAgaci agac)
        {
            agac.Sil(otelid);
        }
        public void PersonelEkle(OtelBilgileri otel, Personel personel)
        {
            otel.personelListe.PersonelEkle(personel);
        }
        public string PersonelListele(OtelBilgileri otel )
        {
            return otel.personelListe.PersonelGoster();
        }
        public void PersonelSil(OtelBilgileri otel,int tc)
        {
            otel.personelListe.PersonelSil(tc);
        }
        
    }
}
