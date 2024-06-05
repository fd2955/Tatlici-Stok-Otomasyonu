﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tatlıcı_Stok_Takip_Otomasyonu
{
    public partial class anamenu : Form
    {
        public anamenu()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yardim = new yardim();
            yardim.Show();
           
        }

        private void kategoriOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Formlar arası geçiş
            Form kategori = new kategori();
            kategori.Show();
        }

        private void urunTuru_Click(object sender, EventArgs e)
        {
            //Formlar arası geçiş
            Form urun = new urunTuru();
            urun.Show();
        }

        private void urunEkle_Click(object sender, EventArgs e)
        {
            //Formlar arası geçiş
            Form urunEkle = new urunEkle();
            urunEkle.Show();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Formlar arası geçiş
            Form kullaniciEkle = new kullaniciEkle();
            kullaniciEkle.Show();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Formlar arası geçiş
           Form musteriEkle = new musteriEkle();
            musteriEkle.Show();
        }

        private void menuEkle_Click(object sender, EventArgs e)
        {   //Formlar arası geçiş
            Form menuEkle = new menuekle();
            menuEkle.Show();
        }

        private void menuSil_Click(object sender, EventArgs e)
        {
            //Formlar arası geçiş
            Form menuSil= new menusil();
            menuSil.Show();



        }

        private void menüGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form menuGuncelle = new menuduzenle();
            menuGuncelle.Show();
        }

        private void aramaYaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aramaYap = new aramayap();
            aramaYap.Show();
        }
    }
}
