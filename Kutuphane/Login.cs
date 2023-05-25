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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        int hak = 3;

        private void button1_Click(object sender, EventArgs e)
        {
            //Giriş Butonu
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı ve/veya şifre yanlış", "Uyarı");
            }
            else
            {
                if (textBox1.Text == "Yönetici" && textBox2.Text == "444")
                {
                    // yönetici paneline yönlendirilir
                    Anasayfa anasayfa = new Anasayfa();
                    anasayfa.Show();
                    this.Hide();
                }
                else if (textBox1.Text == "Öğrenci" && textBox2.Text== "444")
                {
                    // öğrenci paneline yönlendirilir
                    OgrenciPaneli ogrenciPaneli = new OgrenciPaneli();
                    ogrenciPaneli.Show();
                    this.Hide();
                }
                else
                {
                    hak--;
                    MessageBox.Show("Kullanıcı Adı ve/veya şifre yanlış. Kalan hakkınız = " + hak, "Uyarı");
                    if (hak == 0)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Şifremi unuttum kısmı
            // Form3 frm = new Form3();
            // frm.ShowDialog();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //Kullanıcı girişi
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            //Şifre
            textBox2.Text = "";
        }
    }
}
