using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arrayTypedStackBtn_Click(object sender, EventArgs e)
        {
            int stackSize = 10;
            ArrayTypedStack a = new ArrayTypedStack(stackSize);

            a.Push(10);
            a.Push(11);
            a.Push(12);
            a.Push(13);
            a.Push(14);

            MessageBox.Show("Top      : " + a.Top.ToString());          // Pop() dan önce ve sonrasındaki top değerlerine dikkat edin
            MessageBox.Show("Pop      : " + a.Pop().ToString());        
            MessageBox.Show("IsEmpty  : " + a.IsEmpty().ToString());
            MessageBox.Show("Top      : " + a.Top.ToString());
            MessageBox.Show("Peek     : " + a.Peek().ToString());       //Peek üsttekini sadece okur..
            MessageBox.Show("Top      : " + a.Top.ToString());
        }
    }
}
