using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Randevu
{
    public class Yorum
    {
        public Yorum(int id, string ad, string soyad, string eposta, string yorum, int puan)
        {
            this.id = id;
            this.ad = ad;
            this.soyad = soyad;
            this.eposta = eposta;
            this.yorum = yorum;
            this.puan = puan;
        }

        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string eposta { get; set; }
        public string yorum { get; set; }
        public int puan { get; set; }

    }
}
