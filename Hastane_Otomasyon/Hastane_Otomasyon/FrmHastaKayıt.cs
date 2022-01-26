﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Otomasyon
{
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void BtnKayıtYap_Click(object sender, EventArgs e)
        {
            SqlCommand Komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            Komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            Komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            Komut.Parameters.AddWithValue("@p3", MskTc.Text);
            Komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
            Komut.Parameters.AddWithValue("@p5", TxtSifre.Text);
            Komut.Parameters.AddWithValue("@p6", CmbCinsiyet.Text);
            Komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir şifreniz: "+TxtSifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
