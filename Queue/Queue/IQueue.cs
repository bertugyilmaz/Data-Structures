using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public interface IQueue
    {
        void Insert(object value); // Kuyruğun sonuna(rear) eleman ekler
        object Remove();           // Kuyruğun başından(front) eleman siler()
        object Peek();             // Kuyruğun önündeki elamanı döndürür
        bool IsEmpty();            // Kuyruğun dolu veya boş olduğunu kontrol eder. *front -1 ise kuyruk boştur 
        
    }
}
