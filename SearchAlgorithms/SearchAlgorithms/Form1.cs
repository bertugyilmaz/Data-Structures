using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchAlgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] RandomDiziOlustur(int count)
        {
            int[] dizi = new int[count];
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                dizi[i] = r.Next(-100, 100);
            }

            return dizi;
        }

        private void DiziyiYazdir(int[] dizi)
        {
            string temp = "";
            for (int i = 0; i < dizi.Length; i++)
            {
                temp += "dizi[" + i + "] = " + dizi[i] + Environment.NewLine;
            }
            MessageBox.Show(temp);
        }
        private void linearSearchBtn_Click(object sender, EventArgs e)
        {
            int[] dizi = RandomDiziOlustur(100);
            //DiziyiYazdir(dizi);

            LinearSearch ls = new LinearSearch();
            int indis = ls.Search(dizi, Convert.ToInt32(txtArananSayi.Text));

            if (indis == -1)
                MessageBox.Show("Aranan sayı bulunamadı...");
            else
                MessageBox.Show("Arana sayı bulundu, dizi indisi: " + indis);
        }

        private void binarySearchBtn_Click(object sender, EventArgs e)
        {
            int[] dizi = RandomDiziOlustur(100);
            //DiziyiYazdir(dizi);

            BinarySearch BS = new BinarySearch();
            int indis = BS.Search(dizi, Convert.ToInt32(txtArananSayi.Text));

            if (indis == -1)
                MessageBox.Show("Aranan sayı bulunamadı...");
            else
                MessageBox.Show("Arana sayı bulundu, dizi indisi: " + indis);
        }
    }
}
