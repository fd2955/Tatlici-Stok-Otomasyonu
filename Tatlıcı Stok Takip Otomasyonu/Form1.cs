using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tatlıcı_Stok_Takip_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\90553\\Documents\\StokTakip.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("Bütün alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select * from kullanicibilgi where id='" + textBox1.Text + "'", baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                if (okuyucu.Read() == true)
                {
                    if (textBox1.Text == okuyucu["id"].ToString() && textBox2.Text==okuyucu["sifre"].ToString())
                    {
                        MessageBox.Show("Hoşgeldin Sayın " + okuyucu["adsoyad"].ToString());
                        Form form = new anamenu();
                        form.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Giriş bilgilerinizi kontrol edin!");
                    }


                }
                else
                {
                    MessageBox.Show("Giriş bilgilerinizi kontrol edin!");
                }
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
