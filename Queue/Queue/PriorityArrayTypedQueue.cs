using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class PriorityArrayTypedQueue : IQueue
    {
        private object[] Queue;
        private int size = 0;
        private int count = 0;
        private int front = -1;
        //   private int rear = -1;                    Bu kuyruk tipinde rear sürekli 0 dır. Kullanmak gerekmez.

        public PriorityArrayTypedQueue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object value)
        {
            if (count == size ) { throw new Exception("Hata! Queue Dolu."); }

            if (IsEmpty())
            {
                front++;
                Queue[front] = value;
            }
            else
            {
                int i;
                for ( i = count - 1; i >= 0; i--)
                {                    
                    if ((int)value > (int)Queue[i])         //Küçük sayı öncelikli kuyruk
                    {                                       
                        Queue[i + 1] = Queue[i];
                    }
                    else
                        break;
                }

                Queue[i + 1] = value;
                front++;
            }
            count++;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public object Peek()
        {
            return Queue[front];
        }

        public object Remove()
        {
            if (IsEmpty()) { throw new Exception("Hata! Kuyruk Boş"); }
            
            object temp = Queue[front];
            Queue[front] = null;
            front--;
            count--;

            return temp;
        }
    }
}
