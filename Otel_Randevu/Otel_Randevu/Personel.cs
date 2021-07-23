using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Randevu
{
    public class Personel
    {
        public Personel()
        {
        }

        public Personel(int tc, string ad, string soyad, string adres, string eposta, int telefon, string departman, string pozisyon)
        {
            this.tc = tc;
            this.ad = ad;
            this.soyad = soyad;
            this.adres = adres;
            this.eposta = eposta;
            this.telefon = telefon;
            this.departman = departman;
            this.pozisyon = pozisyon;
        }
        public int tc { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string adres { get; set; }
        public string eposta { get; set; }
        public int telefon { get; set; }
        public string departman { get; set; }
        public string pozisyon { get; set; }

    }
}
