using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Randevu
{
    public class OtelBilgileri
    {
        public OtelBilgileri()
        {
        }

        public OtelBilgileri(int id, string ad, string il, string ilce, string adres, string eposta, double tel, float yildiz, int odaSayisi)
        {
            this.id = id;
            this.ad = ad;
            this.il = il;
            this.ilce = ilce;
            this.adres = adres;
            this.eposta = eposta;
            this.tel = tel;
            this.yildiz = yildiz;
            this.odaSayisi = odaSayisi;
        }

        public int id { get; set; }
        public string ad { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string adres { get; set; }
        public string eposta { get; set; }
        public double tel { get; set; }
        public float yildiz { get; set; }
        public int odaSayisi { get; set; }
        public float puan { get; set; }
        public OdaListe odaliste;
        public PersonelListe personelListe;
        public YorumListe yorumListe;
    }
}
