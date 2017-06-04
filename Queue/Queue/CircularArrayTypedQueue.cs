using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class CircularArrayTypedQueue : IQueue
    {
        private object[] Queue;
        private int count = 0;
        private int size = 0;
        private int rear = -1;
        private int front = -1;
        public CircularArrayTypedQueue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object value)
        {
            if (count == size ) { throw new Exception("Hata! Queue Dolu."); }

            if (front == -1) { front = 0; }

            if (rear == size - 1)
            {
                rear = 0;
                Queue[++rear] = value;
            }
            else
                Queue[++rear] = value;

            count++;
        }

        public bool IsEmpty()
        {
            return (front == -1) ? true : false;
        }

        public object Peek()
        {
            return Queue[front];
        }

        public object Remove()
        {
            if (IsEmpty()) { throw new Exception("Hata! Queue Dolu !"); }

            object temp = Queue[front];
            Queue[front] = null;

            if (front == size - 1)
            {
                front = 0;
            }
            else
                front++;

            count--;
            return temp;
        }
    }
}
