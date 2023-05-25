using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class OgrenciPaneli : Form
    {
        public OgrenciPaneli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kitap işlemleri butonu
            Ogrenci_paneli_kitap_islemleri ogrenci_Paneli_Kitap_Islemleri = new Ogrenci_paneli_kitap_islemleri();
            ogrenci_Paneli_Kitap_Islemleri.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Öğrenci emanet listesi butonu
            Ogrenci_paneli_emanet ogrenci_Paneli_Emanet = new Ogrenci_paneli_emanet();
            ogrenci_Paneli_Emanet.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Grafik buttonu
            Kitap_grafik_ogrenci_paneli kitap_Grafik_Ogrenci_Paneli = new Kitap_grafik_ogrenci_paneli();
            kitap_Grafik_Ogrenci_Paneli.Show();
            this.Hide();
        }
    }
}
