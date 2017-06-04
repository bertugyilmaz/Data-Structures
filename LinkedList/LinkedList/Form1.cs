using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LinkedList l = new LinkedList();
        
        private void testBtn_Click(object sender, EventArgs e)
        {
            Person p = new Person()
            {
                name = "Bertuğ",
                surname = "Yılmaz",
                age = 21
            };
        

            l.InsertFirst(p.name);
            Console.WriteLine("p Eklendi.");

            Person p2 = new Person()
            {
                name = "Bertuğ2",
                surname = "Yılmaz2",
                age = 22
            };
            l.InsertLast(p2.name);
            Console.WriteLine("p2 Listenin Sonuna Eklendi.");


            Person p3 = new Person()
            {
                name = "Bertuğ3",
                surname = "Yılmaz3",
                age = 23
            };
            l.InsertFirst(p3.name);
            Console.WriteLine("p3 Listenin Başına Eklendi.");

            MessageBox.Show(l.DisplayElements());

        }
    }
}
