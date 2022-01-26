using System;
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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTc=@p1 and HastaSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay FrmHastaDetay = new FrmHastaDetay();
                FrmHastaDetay.tc = MskTc.Text;
                FrmHastaDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Sifre", "Hata", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }

        private void LnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt FrmHastaKayıt = new FrmHastaKayıt();
            FrmHastaKayıt.Show();
        }
    }
}
