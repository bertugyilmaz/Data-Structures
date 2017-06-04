using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public class BinarySearch : BaseSearch
    {
        public override int Search(int[] items, int searchKey)
        {
            int baslangic = 0, bitis = items.GetUpperBound(0), orta = baslangic + bitis / 2;
            while (baslangic <= bitis)
            {
                orta = (baslangic + bitis) / 2;
                if (items[orta] > searchKey)
                {
                    bitis = orta - 1;
                }
                else if (items[orta] < searchKey)
                {
                    baslangic = orta + 1;
                }
                else
                {
                    return orta;
                }
            }
            return -1;
        }
    }
}
