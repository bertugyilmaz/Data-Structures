using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList : LinkedListADT
    {
        public override void DeleteFirst()
        {
            if (Head != null)              // Head boş değilse ...
            {
                Node headNext = Head.Next; // Head den sonraki düğümü headNext değişkenine atanıyor.
                
                if (headNext == null)      // Head in next i boş ise liste de bir eleman var demek oluyor 
                {
                    Head = null;           // Buyüzden Head e null atanıyor.
                }
                else
                    Head = headNext;       // Listede Birden fazla eleman olması durumunda 
                Size--;                    //ilk düğüm bu şekilde siliniyor.
            }
        }

        public override void DeleteLast()
        {
            Node tempLastPrev = null;
            Node lastNode = Head;

            while (true)
            {
                if (lastNode.Next != null)
                {
                    tempLastPrev = lastNode; // Son düğümün bir öncesi tempLastPrev de saklanıyor.
                    lastNode = lastNode.Next;
                }
                else
                    lastNode = null;        // Son node bulunup null atanıyor.
                    break;
            }

            Size--;                         // Listenin düğüm sayısı bir azalıyor.
                
            if (tempLastPrev != null)       // tempLastPrev null değilse sonraki düğümüne null atar
            {
                tempLastPrev.Next = null;   
            }
            else
                Head = null;                // tempLastPrev null ise listede tek bir eleman olduğu anlamına gelir
                                            //buyüzden Head de null atanmaktadır.
        }

        public override void DeletePos(int position)
        {
            Node temp = null;
            Node tempPosition = Head;

            int i = 1;

            while (tempPosition != null)         // Listeyi dolaşmamı sağlar. 
            {
                if (position == i)               // istenilen pozisyona geldiğimizde
                {
                    if (tempPosition.Next == null) // Son düğümdemiyiz?
                    {
                        DeleteLast();               // Son düğümdeysek DeleteLast() func kullanılabilir.
                        break;                      
                    }
                    else
                    {                               // Son düğümde değilsek 
                        temp = tempPosition.Next;   // Bulunduğun poziyonun next ini temp e at.
                        tempPosition = null;        // Silinmesi istenilen pozisyona null ata.
                        tempPosition = temp;        // listenin devamını ekle.
                        break;
                    }
                }
                tempPosition = tempPosition.Next;
                i++;
            }

            Size--;
        }

        public override string DisplayElements()
        {
            string temp = "";
            Node traverse = Head;
            int i = 1;
            while (traverse != null)
            {
                temp += i + ". Düğüm : " + traverse.Data.ToString() + Environment.NewLine;
                i++;
                traverse = traverse.Next;
            }
            
            return temp;
        }

        public override void InsertFirst(object value)
        {
            Node tmpHead = new Node { Data = value };

            if (Head == null) { Head = tmpHead; }          //Head boş(NULL) ise iteratörü atar
            else { tmpHead.Next = Head; Head = tmpHead; }  //tmpHead in next i Head i göstermeli. Yeni Head tmpHead olmuştur.

            Size++;                                        // Listedeki Eleman sayısı arttı
        }

        public override void InsertLast(object value)
        {
            Node oldLast = Head;

            if (oldLast == null) { InsertFirst(value); }    //Head null sa kayıt eklenmemiştir buyüzden InsertFirst çağırılabilir.
            else
            {
                Node newLast = new Node { Data = value };  //Yeni eklenicek sonuncu node yaratıldı.

                while (oldLast != null)                     
                {
                    if (oldLast.Next != null)
                    {
                        oldLast = oldLast.Next;
                    }                                   
                    else break;
                }                                          // Son düğüm bulundu.

                oldLast.Next = newLast;                    // Son düğümün Next ine yeni node eklenir.

                Size++;                                    //Listedeki eleman sayısı arttı
            }

        }

        public override void InsertPos(int position, object value)
        {
            Node newNode = new Node { Data = value };      // Eklenicek Node un Data sına parametre olarak gelen value atanıyor
            
            int i = 1;
            if (Head == null) { InsertFirst(value); }      //Head null sa kayıt eklenmemiştir buyüzden InsertFirst çağırılabilir.
            else
            {
                Node posNode = Head;
                Node tempNext = null;
                
                while (posNode != null)
                {   
                    if (position == i)
                    {
                        if (posNode.Next == null)         // Son düğümdemiyiz?
                        {
                            InsertLast(value);            // Son düğümdeysek InsertLast() func kullanılabilir.
                            break;
                        }
                        else
                        {                                // Son düğümde değilsek 
                            tempNext = posNode.Next;     // Bulunduğun poziyonun next ini temp e at.
                            newNode.Next = tempNext;         // Silinmesi istenilen pozisyona null ata.
                            posNode.Next = newNode;         // listenin devamını ekle.
                            break;
                        }

                        posNode = posNode.Next;
                        i++;
                    }
                }
            }
        }
    }
}
