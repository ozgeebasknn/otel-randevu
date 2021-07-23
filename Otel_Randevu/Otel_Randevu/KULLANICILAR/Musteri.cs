using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Randevu
{
    public class Musteri : Kullanici
    {
        public Musteri(string kullaniciAdi, string sifre)
        {
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
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
        public void RezervasyonAl(Rezervasyon rezervasyon, HashChain hash)
        {
            hash.RezervasyonAl(rezervasyon.rezNo);
        }
        public string DerinlikBul(İkiliAramaAgaci agac)
        {
            return agac.DerinlikBul().ToString();
        }
        public string ElemanSayisiBul(İkiliAramaAgaci agac)
        {
            return agac.DugumSayisi().ToString();
        }

    }
}
