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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            //Ad Soyad Cekme
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Gecmisi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTc=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branslari Cekme

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBranş.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular Where RandevuBrans='" + CmbBranş.Text + "'" +"and RandevuDoktor='"+CmbDoktor.Text+"' and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);    
            dataGridView2.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void CmbBranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans =@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBranş.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void LnkBilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle FrmBilgiDüzenle = new FrmBilgiDüzenle();
            FrmBilgiDüzenle.tcno = LblTC.Text;
            FrmBilgiDüzenle.Show(); 

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular set RandevuDurum=1,HastaTc=@p1,HastaSikayet=@p2 where  RandevuId=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            komut.Parameters.AddWithValue("@p2", RchSikayet.Text);
            komut.Parameters.AddWithValue("@p3",TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         
        }


       
    }
}
