using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Randevu
{
    public class HashChain
    {
         int tableSize = 10;
         HashChainEntry[] table;

        public HashChain()
        {
            table = new HashChainEntry[tableSize];
            for (int i = 0; i < tableSize; i++)
                table[i] = null;
        }
        public void RezervasyonEkle(int key, object value)
        {
            int hash = (key % tableSize);
            if (table[hash] == null)
                table[hash] = new HashChainEntry(key, value);
            else
            {
                HashChainEntry entry = table[hash];
                while (entry.Next != null && entry.Anahtar != key)
                    entry = entry.Next;
                if (entry.Anahtar == key)
                    entry.Deger = value;
                else
                    entry.Next = new HashChainEntry(key, value);
            }
        }
        public Rezervasyon RezervasyonAl(int key)
        {
            int hash = (key % tableSize);
            if (table[hash] == null)
                return null;
            else
            {
                HashChainEntry entry = table[hash];
                while (entry != null && entry.Anahtar != key)
                    entry = entry.Next;
                if (entry == null)
                    return null;
                else
                    return (Rezervasyon)entry.Deger;
            }
        }
    }
}
