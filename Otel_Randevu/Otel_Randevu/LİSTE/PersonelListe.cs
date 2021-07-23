using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Randevu
{
    public class PersonelListe:BagliListe
    {
        public void PersonelEkle(Personel yenipersonel)
        {
            Node tmpHead = new Node();
            tmpHead.personel = yenipersonel;


            if (Head == null)
                Head = tmpHead;
            else
            {
                tmpHead.Next = Head;
                Head = tmpHead;
            }
            Size++;

        }
        public void PersonelSil(object position)
        {
            if (Head != null)
            {
                Node temp = Head;

                Node posPreNode = new Node();
                posPreNode = Head;

                if (((Personel)temp.personel).tc == ((Personel)position).tc)
                {
                    Head = temp.Next;
                }
                while (temp != null)
                {
                    if (((Personel)temp.personel).tc == ((Personel)position).tc)
                        posPreNode.Next = temp.Next;
                    else
                        posPreNode = temp;

                    temp = temp.Next;
                }
                Size--;
            }
        }
        public string PersonelGoster()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += item.personel.tc + " " + item.personel.ad + " " + item.personel.departman + "\n";
                item = item.Next;
            }

            return temp;
        }


    }
}
