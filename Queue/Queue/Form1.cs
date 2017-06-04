using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleQueueBtn_Click(object sender, EventArgs e)
        {
            int queueSize = 10;
            SimpleArrayTypedQueue sq = new SimpleArrayTypedQueue(queueSize);
            sq.Insert('A');
            sq.Insert('B');
            sq.Insert('C');
            MessageBox.Show("Silinen : " + sq.Remove().ToString());
            sq.Remove();
            MessageBox.Show("Silinen-3 : " + sq.Remove().ToString());
            sq.Insert('D');
            sq.Insert('E');
            sq.Insert('F');
            MessageBox.Show("Sıradaki(Peek) : " + sq.Peek().ToString());
        }

        private void circularQueueBtn_Click(object sender, EventArgs e)
        {
            int queueSize = 10;
            CircularArrayTypedQueue cq = new CircularArrayTypedQueue(queueSize);
            cq.Insert('A');
            cq.Insert('B');
            cq.Insert('C');
            MessageBox.Show("Silinen : " + cq.Remove().ToString());
            cq.Remove();
            cq.Insert('D');
            cq.Insert('E');
            cq.Insert('F');
            cq.Remove();
            cq.Insert('G');
            MessageBox.Show("Sıradaki (Peek) : " + cq.Peek());
        }

        private void priorityQueueBtn_Click(object sender, EventArgs e)
        {
            int queueSize = 10;
            PriorityArrayTypedQueue pq = new PriorityArrayTypedQueue(queueSize); //Küçük sayı öncelikli kuyruk.
            pq.Insert(33);
            pq.Insert(55);
            pq.Insert(11);
            pq.Remove();
            pq.Insert(44);
            MessageBox.Show("Silinen : " + pq.Remove().ToString());
            pq.Insert(22);
            MessageBox.Show("Sıradaki(Peek) :  " +  pq.Peek().ToString());
        }
    }
}
