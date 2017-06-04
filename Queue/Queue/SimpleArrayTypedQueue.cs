using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class SimpleArrayTypedQueue : IQueue // Basit kuyruk yapısı sadece ileri yönde hareket eder.
    {

        private object[] Queue;                 // Kuyruğumuzun Array i 
        private int front = -1;                 
        private int rear = -1;                     
        private int size = 0;
        private int count = 0;                 // Kuyruktaki eleman sayısı.

        public SimpleArrayTypedQueue(int size)
        {
            this.Queue = new object[size];
            this.size = size;
        }
        public void Insert(object value)
        {
            if ((count == size) || (rear == size - 1))
                throw new Exception("Hata! Queue Dolu !");


            if (front == -1) { front = 0; }

            Queue[++rear] = value;
            count++;
        }

        public bool IsEmpty()
        {
            return (count == 0) ? true : false;
        }

        public object Peek()
        {
            return Queue[front];
        }

        public object Remove()
        {
            if (IsEmpty()) { throw new Exception("Hata! Queue Boş"); }
            object temp = Queue[front];
            Queue[front] = null;

            front++;
            count--; 
            return temp;
        }
    }
}
