using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class SelectionSort : BaseSort
    {
        public override void Sort(int[] items)
        {
            int minIndis = 0;
            for (int i = 0; i < items.Length; i++)
            {
                //minimumum i olarak ayarla
                minIndis = i;
                //i'den sonraki tüm elemanları tara
                for (int j = i + 1; j < items.Length; j++)
                {
                    //daha küçük eleman bulursan indisini sakla
                    if (items[j] < items[minIndis])
                        minIndis = j;
                }
                //en küçük indis değiştiyse, yani i'den sonraki elemanlardan birisi i'den küçükse

                //takas işlemi gerçekleştir
                if (minIndis != i)
                {
                    int temp = items[i];
                    items[i] = items[minIndis];
                    items[minIndis] = temp;
                }
            }
        }
    }
}
