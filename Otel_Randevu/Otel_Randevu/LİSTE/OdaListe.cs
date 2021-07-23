using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Randevu
{
    public class OdaListe:BagliListe
    {
        public void OdaEkle(Oda oda)
        {
            Node tmpHead = new Node();
            tmpHead.oda = oda;


            if (Head == null)
                Head = tmpHead;
            else
            {
                tmpHead.Next = Head;
                Head = tmpHead;
            }
            Size++;
        }
        public void OdaSil(object position)
        {
            if (Head != null)
            {
                Node temp = Head;

                Node posPreNode = new Node();
                posPreNode = Head;

                if (((Oda)temp.oda).odaNo == ((Oda)position).odaNo)
                {
                    Head = temp.Next;
                }
                while (temp != null)
                {
                    if (((Oda)temp.oda).odaNo == ((Oda)position).odaNo)
                        posPreNode.Next = temp.Next;
                    else
                        posPreNode = temp;

                    temp = temp.Next;
                }
                Size--;
            }
        }
        public string OdaGoster()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += "->" + item.oda.odaNo;
                item = item.Next;
            }

            return temp;
        }
    }
}
