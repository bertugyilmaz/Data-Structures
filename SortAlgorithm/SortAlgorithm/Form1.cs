using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bubbleSortBtn_Click(object sender, EventArgs e)
        {
            int[] dizi = { 5, 0, 12, 3, 2, 21 };
            BubbleSort bs = new BubbleSort();
            MessageBox.Show("Sıralanmadan Önce : " + Environment.NewLine + bs.PrintItems(dizi));
            bs.Sort(dizi);
            MessageBox.Show("Sıralandıktan Sonra : " + Environment.NewLine + bs.PrintItems(dizi));
        }

        private void selectionSortBtn_Click(object sender, EventArgs e)
        {
            int[] dizi = { 10, 2, 3, 5, 77, 8, 2 };
            SelectionSort ss = new SelectionSort();

            MessageBox.Show("Sıralamadan Önce : " + Environment.NewLine + ss.PrintItems(dizi));
            ss.Sort(dizi);
            MessageBox.Show("Sıralandıktan Sonra : " + Environment.NewLine  + ss.PrintItems(dizi));

        }

        private void insertionSortBtn_Click(object sender, EventArgs e)
        {
            int[] dizi = { 20, 23, 45, 56, 78, 9, 0, 23, 1 };
            InsertionSort ins = new InsertionSort();

            MessageBox.Show("Sıralamadan Önce : " + Environment.NewLine + ins.PrintItems(dizi));
            ins.Sort(dizi);
            MessageBox.Show("Sıralandıktan Sonra : " + Environment.NewLine + ins.PrintItems(dizi));
        }

        private void quickSortBtn_Click(object sender, EventArgs e)
        {
            int[] dizi = { 2, 17, -4, 42, 9, 26, 11, 3, 5, 28 };
            QuickSort QS = new QuickSort();
            MessageBox.Show("Sıralanmadan Önce : " + Environment.NewLine + QS.PrintItems(dizi));
            QS.Sort(dizi);
            MessageBox.Show("Sıralandıktan Sonra : " + Environment.NewLine + QS.PrintItems(dizi));
        }
    }
}
