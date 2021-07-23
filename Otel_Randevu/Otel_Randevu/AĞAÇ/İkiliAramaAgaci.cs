using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Randevu
{
    public class İkiliAramaAgaci
    {
        
        private İkiliAramaAgaciDugumu kok;
        private string dugumler;
        public İkiliAramaAgaci() { }
        public İkiliAramaAgaci(İkiliAramaAgaciDugumu kok)
        {
            this.kok = kok;
        }
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi(İkiliAramaAgaciDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }
        public int YaprakSayisi(İkiliAramaAgaciDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null) && (dugum.sag == null))
                    count = 1;
                else
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
            }
            return count;
        }
        public void Ekle(OtelBilgileri otel)
        {
            İkiliAramaAgaciDugumu tempParent = new İkiliAramaAgaciDugumu();
            İkiliAramaAgaciDugumu tempSearch = kok;
            İkiliAramaAgaciDugumu eklenecekOtel = new İkiliAramaAgaciDugumu(otel);
            if (kok == null)
            {
                kok = eklenecekOtel;
            }
            else
            {
                int sonuc = 0;
                while (tempSearch != null)
                {
                    tempParent = tempSearch;
                    sonuc = String.Compare(otel.ad, tempSearch.veri.ad);
                    if (Equals(otel.ad, tempSearch.veri.ad))
                    {
                        MessageBox.Show("otel mevcut");
                    }
                    else
                    {
                        if (sonuc < 0)
                        {
                            tempSearch = tempSearch.sol;
                        }
                        else
                        {
                            tempSearch = tempSearch.sag;
                        }
                    }
                }

                if (sonuc < 0)
                    tempParent.sol = eklenecekOtel;
                else
                    tempParent.sag = eklenecekOtel;
            }

        }
        public string DugumleriYazdir()
        {
            return dugumler ;
        }
        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok) ;
        }
        private void PreOrderInt(İkiliAramaAgaciDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(İkiliAramaAgaciDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(İkiliAramaAgaciDugumu dugum)
        {
            dugumler += dugum.veri.id + "\t" + dugum.veri.ad + "\n" ;
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(İkiliAramaAgaciDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
        public İkiliAramaAgaciDugumu Ara(int anahtar)
        {
            return AraInt(kok, anahtar);
        }
        private İkiliAramaAgaciDugumu AraInt(İkiliAramaAgaciDugumu dugum, int anahtar)
        {
            if (dugum == null)
                return null;
            else if (((OtelBilgileri)dugum.veri).id == anahtar)
                return dugum;
            else if (((OtelBilgileri)dugum.veri).id > anahtar)
                return (AraInt(dugum.sol, anahtar));    
            else
                return (AraInt(dugum.sag, anahtar));
        }
        public İkiliAramaAgaciDugumu Guncelle(İkiliAramaAgaciDugumu dugum, int anahtar)
        {
            Ara(anahtar).veri.ad = dugum.veri.ad;
            return dugum;
        }
        private İkiliAramaAgaciDugumu Successor(İkiliAramaAgaciDugumu silDugum)
        {
            İkiliAramaAgaciDugumu ParentSuccessor = silDugum;
            İkiliAramaAgaciDugumu current = silDugum.sag;
            İkiliAramaAgaciDugumu successor = silDugum;
            while (!(current == null))
            {
                ParentSuccessor = current;
                successor = current;
                current = current.sol;
            }
            if (!(successor == silDugum.sag))
            {
                ParentSuccessor.sol = successor.sag;
                successor.sag = silDugum.sag;
            }
            return successor;

        }
        public bool Sil(int deger)
        {
            İkiliAramaAgaciDugumu current = kok;
            İkiliAramaAgaciDugumu parent = kok;
            bool issol = true;
            //DÜĞÜMÜ BUL
            while (((OtelBilgileri)current.veri).id != deger)
            {
                parent = current;
                if (deger < ((OtelBilgileri)current.veri).id)
                {
                    issol = true;
                    current = current.sol;
                }
                else
                {
                    issol = false;
                    current = current.sag;
                }
                if (current == null)
                    return false;
            }
            //DURUM 1: YAPRAK DÜĞÜM
            if (current.sol == null && current.sag == null)
            {
                if (current == kok)
                {
                    kok = null;
                }
                else if (issol)
                {
                    parent.sol = null;
                }
                else
                {
                    parent.sag = null;
                }
            }
            //DURUM 2: TEK ÇOCUKLU DÜĞÜM
            else if (current.sag == null)
            {
                if (current == kok)
                {
                    if (current == kok)
                    {
                        kok = current.sol;
                    }
                    else if (issol)
                    {
                        parent.sol = current.sol;
                    }
                    else
                    {
                        parent.sag = current.sol;
                    }
                }
            }
            else if (current.sol == null)
            {
                if (current == kok)
                {
                    kok = current.sag;
                }
                else if (issol)
                {
                    parent.sol = current.sag;
                }
                else
                {
                    parent.sag = current.sag;
                }
            }
            //DURUM 3: İKİ ÇOCUKLU DÜĞÜM
            else
            {
                İkiliAramaAgaciDugumu successor = Successor(current);
                if (current == kok)
                {
                    kok = successor;
                }
                else if (issol)
                {
                    parent.sol = successor;
                }
                else
                {
                    parent.sag = successor;
                }
                successor.sol = current.sol;
            }
            return true;
        }
        private int DerinlikBulInt(İkiliAramaAgaciDugumu dugum)
        {
            if (dugum == null)
                return 0;
            else
            {
                int solDer = 0, sagDer = 0;
                solDer = DerinlikBulInt(dugum.sol);
                sagDer = DerinlikBulInt(dugum.sag);
                if (solDer > sagDer)
                    return solDer + 1;
                else
                    return sagDer + 1;
            }
        }
        public int DerinlikBul()
        {
            return DerinlikBulInt(kok);
        }
        public int ElemanSayisi()
        {
            return ElemanSayisiInt(kok);
        }
        private int ElemanSayisiInt(İkiliAramaAgaciDugumu dugum)
        {
            int elemanSayisi = 0;
            if (dugum != null)
            {
                elemanSayisi = 1;
                elemanSayisi += ElemanSayisiInt(dugum.sol);
                elemanSayisi += ElemanSayisiInt(dugum.sag);
            }
            return elemanSayisi;
        }
    }
}
