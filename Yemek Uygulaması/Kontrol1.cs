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
    public partial class Kontrol1 : UserControl
    {
        public Kontrol1()
        {
            InitializeComponent();
        }

        //Siparişi Veriniz Butonu Kodu
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz Alındı.Lütfen Adres ve Telefon Bilgilerini Giriniz!");
        }
    }
}
