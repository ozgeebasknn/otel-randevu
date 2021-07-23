using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Randevu
{
    public class YorumListe:BagliListe
    {
        public void YorumEkle(Yorum yorum)
        {
            Node tmpHead = new Node();
            tmpHead.yorum = yorum;


            if (Head == null)
                Head = tmpHead;
            else
            {
                tmpHead.Next = Head;
                Head = tmpHead;
            }
            Size++;
        }
        public void YorumSil(object position)
        {
            if (Head != null)
            {
                Node temp = Head;

                Node posPreNode = new Node();
                posPreNode = Head;

                if (((Yorum)temp.yorum).id == ((Yorum)position).id)
                {
                    Head = temp.Next;
                }
                while (temp != null)
                {
                    if (((Yorum)temp.yorum).id == ((Yorum)position).id)
                        posPreNode.Next = temp.Next;
                    else
                        posPreNode = temp;

                    temp = temp.Next;
                }
                Size--;
            }
        }
        public string YorumGoster()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += "->" + item.yorum.id;
                item = item.Next;
            }

            return temp;
        }

    }
}
