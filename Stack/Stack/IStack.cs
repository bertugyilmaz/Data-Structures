using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
    {
    public interface IStack
    {
        void Push(object item);  // Stack e ekler
        object Pop();            // Stack in üstündeki elemanı çıkarır.
        object Peek();           // Yığıtın üstündeki elemanı okur
        bool IsEmpty();          // Stack Boş mu Dolu mu kontrol eder..
        int Top { get; set; }    // Stack deki elamnın indisini gösterir. -1 Stack boş demektir. 
    }
}
