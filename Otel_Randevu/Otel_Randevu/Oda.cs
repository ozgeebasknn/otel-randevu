using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Randevu
{
    public class Oda
    {
        public Oda(int odaNo, int telefon, int kisiSayisi, string manzara, bool rezDurumu, int fiyat, Personel calisan)
        {
            this.odaNo = odaNo;
            this.telefon = telefon;
            this.kisiSayisi = kisiSayisi;
            this.manzara = manzara;
            this.rezDurumu = rezDurumu;
            this.fiyat = fiyat;
            this.calisan = calisan;
        }

        public int odaNo { get; set; }
        public int telefon { get; set; }
        public int kisiSayisi { get; set; }
        public string manzara { get; set; }// dag deniz orman
        public bool rezDurumu { get; set; }
        public int fiyat { get; set; }
        public Personel calisan { get; set; }

    }
}
