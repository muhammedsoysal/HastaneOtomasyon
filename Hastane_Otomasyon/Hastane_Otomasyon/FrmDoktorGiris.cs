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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@d1 and DoktorSifre=@d2", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", MskTc.Text);
            komut.Parameters.AddWithValue("@d2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            {
                FrmDoktorDetay FrmDoktorDetay = new FrmDoktorDetay();
                FrmDoktorDetay.tc = MskTc.Text;
                FrmDoktorDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC Veya Sifre ", "Hata", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }

    }
}
