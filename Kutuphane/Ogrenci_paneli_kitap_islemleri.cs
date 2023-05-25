using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITYLAYER;
using BLL;

namespace Kutuphane
{
    public partial class Ogrenci_paneli_kitap_islemleri : Form
    {
        public Ogrenci_paneli_kitap_islemleri()
        {
            InitializeComponent();
        }

        private void Btn_anasayfa_Click(object sender, EventArgs e)
        {
            OgrenciPaneli ogrenciPaneli = new OgrenciPaneli();
            ogrenciPaneli.Show();
            this.Hide();
        }

        BllKitap Islem = new BllKitap();
        string konum = " ";

        void VeriCek()
        {
            //kitaplar listesinden sütun bilgilerini çekip datagridview'e aktarır.
            List<KitapVarlik> ktp = Islem.KitapGoster();
            KitapListele.DataSource = ktp;
        }

        private void Btn_kitap_ara_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfından kitap_goster fonksiyonu çalıştırılarak kitap bilgileri
            //datagridview'e aktarılır.
            try
            {
                List<KitapVarlik> ktp2 = Islem.KitapGoster(Txt_kitap_ara.Text, konum);
                KitapListele.DataSource = ktp2;
                MessageBox.Show("Arama sonuçları listelendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz!");
            }
        }

        private void Btn_listele_Click(object sender, EventArgs e)
        {
            //veri_cek fonksiyonu ile tüm kitap bilgileri datagridview'e aktarılır.
            VeriCek();
            MessageBox.Show("Tüm kayıtlar listelendi");
        }

        private void Txt_kitap_ara_Click(object sender, EventArgs e)
        {
            Txt_kitap_ara.Text = "";
        }

        private void Cmb_kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            //konum değeri textbox içersindeki seçilen değere eşitlenir.
            konum = Cmb_kategori.SelectedItem.ToString();
        }
    }
}
