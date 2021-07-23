using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Randevu
{
    public class HeapRezervasyon
    {
        public HeapDugumu[] heapRezervasyon;
        private int maxSize;
        private int currentSize;

        public HeapRezervasyon(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            heapRezervasyon = new HeapDugumu[maxSize];
            currentSize = 0;

        }
        public bool IsEmpty()
        {
            return currentSize == 0;
        }

        public bool Ekle(Rezervasyon rezervasyon)
        {
            if (currentSize == maxSize)
                return false;
            HeapDugumu newHeapDugumu = new HeapDugumu(rezervasyon);
            heapRezervasyon[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }

        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugumu bottom = heapRezervasyon[index];
            while (index > 0 && (((Rezervasyon)heapRezervasyon[parent].Deger).rezNo) < ((Rezervasyon)bottom.Deger).rezNo)
            {
                heapRezervasyon[index] = heapRezervasyon[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapRezervasyon[index] = bottom;
        }

        public bool Ara(HeapRezervasyon items, Rezervasyon searchKey)
        {
            bool arama = false;
            for (int i = 0; i < currentSize; i++)
                if (((HeapDugumu)items.heapRezervasyon[i]) != null)
                {
                    if (((Rezervasyon)((HeapDugumu)items.heapRezervasyon[i]).Deger) == searchKey)
                    {
                        arama = true;
                        break;
                    }
                }
            return arama;
        }

        public string RezervasyonListele(HeapRezervasyon items)
        {
            string ilanlar = "";
            for (int i = 0; i < currentSize; i++)
                if (((HeapDugumu)items.heapRezervasyon[i]) != null)
                {
                    ilanlar += ((Rezervasyon)((HeapDugumu)items.heapRezervasyon[i]).Deger).rezNo;
                }
            return ilanlar;
        }
    }
}
