﻿using System;
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
    public partial class urunTuru : Form
    {
        public urunTuru()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\90553\\Documents\\StokTakip.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
        baglanti.Open();
            OleDbCommand ekleKomutu = new OleDbCommand("insert into urunekle (id,urunturu) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglanti);
            ekleKomutu.ExecuteNonQuery();
            baglanti.Close();

            label3.Text = textBox2.Text + "başarıyla kaydedildi";

            textBox1.Clear();
            textBox2.Clear();

        }
    }
}
