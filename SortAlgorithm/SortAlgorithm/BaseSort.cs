using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public abstract class BaseSort
    {
        public abstract void Sort(int[] items);
        public string PrintItems(int[] items)
        {
            string temp = "";
            for (int i = 0; i < items.Length; i++)
            {
                temp += "items[" + i + "] = " + items[i] + Environment.NewLine;
            }
            return temp;
        }
    }
}
