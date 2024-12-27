using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizi_listeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Dizi de ki negatif sayıları listele
        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 21, -12, 38, -41, 97, -8, 27, 52, -63, -19 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] < 0)
                    listBox1.Items.Add(sayilar[i]);
            }
        }

        //Dizi de ki pozitif sayıları listele
        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 21, -12, 38, -41, 97, -8, 27, 52, -63, -19 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > 0)
                    listBox2.Items.Add(sayilar[i]);
            }
        }

        //Dizi eleman sayısını bul
        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 21, -12, 38, -41, 97, -8, 27, 52, -63, -19 };
            button3.Text = sayilar.Length.ToString();
        }

        //Dizide ki elamanların ortalamasını yaz
        private void button4_Click(object sender, EventArgs e)
        {
            double ortalama;
            int[] sayilar = { 21, -12, 38, -41, 97, -8, 27, 52, -63, -19 };
            ortalama = sayilar.Average();
            button4.Text = ("Dizinin ortalaması = " + ortalama.ToString());
        }
    }
}
