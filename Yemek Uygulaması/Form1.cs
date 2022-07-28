using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yemek_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //kontrol1 ve kontrol2 form1 açıldıgında göstermicek
            kontrol11.Hide();
            kontrol21.Hide();
            //kontrol from1 açılınca göstericek
            kontrol1.Show();
            kontrol1.BringToFront();
        }

        private void kontrol11_Load(object sender, EventArgs e)
        {

        }

        private void kontrol21_Load(object sender, EventArgs e)
        {

        }

        private void kontrol1_Load(object sender, EventArgs e)
        {

        }

        //Menü Butonu Kodu
        private void button2_Click(object sender, EventArgs e)
        {
            //Kontrol ve kontrol2 form1 menü butonuna tıklayınca ve açılınca gözükmicek
            kontrol1.Hide();
            kontrol21.Hide();

            //Kontrol1  form1 açılınca menü butonuna tıklayıp  açılınca gözükecektir
            kontrol11.Show();
            kontrol11.BringToFront();
        }

        //Anasayfa Butonu Kodları
        private void button1_Click(object sender, EventArgs e)
        {
            //Kontrol1 ve kontrol2 form1 anasayfa butonuna tıklayınca ve açılınca gözükmicek
            kontrol11.Hide();
            kontrol21.Hide();

            //Kontrol  form1 açılınca anasayfa butonuna tıklayıp  açılınca gözükecektir
            kontrol1.Show();
            kontrol1.BringToFront();
        }


        //Adres Butonu Kodları
        private void button3_Click(object sender, EventArgs e)
        {
            //Kontrol ve kontrol1 form1 adres butonuna tıklayınca ve açılınca gözükmicek
            kontrol1.Hide();
            kontrol11.Hide();

            //Kontrol2  form1 açılınca adres butonuna tıklayıp  açılınca gözükecektir
            kontrol21.Show();
            kontrol21.BringToFront();
        }

        //Çıkış Butonu Kodları
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
