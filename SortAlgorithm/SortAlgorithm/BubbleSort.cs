using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class BubbleSort : BaseSort
    {
        public override void Sort(int[] items)
        {
            int iterator;
            bool swapped = false;

            for (iterator = 0;  iterator < items.Length; iterator++)
            {
                swapped = false;

                for (int i = 0; i < (items.Length - iterator -1); i++) // Zaten sıralanmış olanlar sona atıldığı için "-iterator" diyoruz.
                {
                    if (items[i] > items[i+1])
                    {
                        int temp;
                        temp = items[i];
                        items[i] = items[i + 1];
                        items[i + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) { break; }
            }
        }
    }
}
