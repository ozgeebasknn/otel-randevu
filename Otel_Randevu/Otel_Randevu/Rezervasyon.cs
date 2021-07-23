using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Randevu
{
    public class Rezervasyon
    {
        public int rezNo { get; set; }
        public OtelBilgileri otel { get; set; }
        public int odaNo { get; set; }
        public int gunSayisi { get; set; }
        public float topUcret { get; set; }
        //kisi bilgileri heap agacında tutulacak??
        public int kisiSayisi { get; set; }

        public HeapRezervasyon heapRezervasyon;

        public Rezervasyon(HeapRezervasyon heapRezervasyon)
        {
            heapRezervasyon = new HeapRezervasyon(kisiSayisi);
        }

        public Rezervasyon()
        {
        }
    }
}
