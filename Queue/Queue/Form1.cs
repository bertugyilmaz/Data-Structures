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
    }
}
