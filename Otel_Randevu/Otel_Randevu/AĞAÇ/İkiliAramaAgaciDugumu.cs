using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Randevu
{
    public class İkiliAramaAgaciDugumu
    {
        public OtelBilgileri veri;
        public İkiliAramaAgaciDugumu sol;
        public İkiliAramaAgaciDugumu sag;
        public string oteller;

        public İkiliAramaAgaciDugumu()
        {
        }

        public İkiliAramaAgaciDugumu(OtelBilgileri veri)
        {
            this.veri = veri;
        }
    }
}
