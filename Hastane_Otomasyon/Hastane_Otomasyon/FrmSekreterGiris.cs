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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM TBL_SEKRETER WHERE SEKRETERTC=@P1 AND SEKRETERSİFRE=@P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            {
                FrmSekreterDetay FrmSekreterDetay = new FrmSekreterDetay();
                FrmSekreterDetay.tcnumara = MskTc.Text;
                FrmSekreterDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre","Bilgi",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information);
            }
            bgl.baglanti().Close();
        }

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
