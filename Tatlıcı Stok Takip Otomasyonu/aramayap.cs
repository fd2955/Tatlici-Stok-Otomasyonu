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
    public partial class aramayap : Form
    {
        public aramayap()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\90553\\Documents\\StokTakip.accdb");
        DataTable Musteritablosu = new DataTable();
        DataTable Menutablosu = new DataTable();

        private void aramayap_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Müşteri")
            {
                baglanti.Open();
                Musteritablosu.Clear();
                OleDbDataAdapter musteriAdapter = new OleDbDataAdapter("select * from musteri", baglanti);
                musteriAdapter.Fill(Musteritablosu);
                dataGridView1.DataSource = Musteritablosu;
                baglanti.Close();

            }
            else if (comboBox1.Text == "Menü")
            {
                baglanti.Open();
                Menutablosu.Clear();
                OleDbDataAdapter menuAdapter = new OleDbDataAdapter("select * from menu", baglanti);
                menuAdapter.Fill(Menutablosu);
                dataGridView1.DataSource = Menutablosu;
                baglanti.Close();


            }



        }

        private void button1_Click(object sender, EventArgs e)
        {   if (comboBox1.Text == "Müşteri")
            {


            

                baglanti.Open();
                Musteritablosu.Clear();
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from musteri where ad like '"+textBox1.Text+"'",baglanti);
                adapter.Fill(Musteritablosu);
                dataGridView1.DataSource = Musteritablosu;
                baglanti.Close();

            }

            else if(comboBox1.Text == "Menü")
            {
                baglanti.Open();
                Menutablosu.Clear();
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from menu where ad like '" + textBox1.Text + "'", baglanti);
                adapter.Fill(Menutablosu);
                dataGridView1.DataSource = Menutablosu;
                baglanti.Close();


            }







        }

    }
}
