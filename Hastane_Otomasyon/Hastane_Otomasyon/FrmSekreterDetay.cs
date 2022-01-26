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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string tcnumara;
        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tcnumara;

            //Ad Soyad
            SqlCommand komut1 = new SqlCommand("select SekreterAdSoyad From Tbl_Sekreter Where SekreterTc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //Brans DataGride Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select BransAd From Tbl_Branslar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları Listeye Akterma

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd +' '+DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı combobox a aktarma

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("Insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2 ,@r3,@r4)",bgl.baglanti());
            komutKaydet.Parameters.AddWithValue("@r1", MskTarih.Text);
            komutKaydet.Parameters.AddWithValue("@r2",MskSaat.Text);
            komutKaydet.Parameters.AddWithValue("@r3",CmbBrans.Text);
            komutKaydet.Parameters.AddWithValue("@r4",CmbDoktor.Text);
            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd ,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Duyurular (Duyuru) Values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", RchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RchDuyuru.Clear();
        }

        private void BtnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli FrmDoktorPaneli = new FrmDoktorPaneli();
            FrmDoktorPaneli.Show();
        }

        private void BtnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBrans FrmBrans = new FrmBrans();
            FrmBrans.Show();
        }

        private void BtnRandevu_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi FrmRandevuListesi = new FrmRandevuListesi();
            FrmRandevuListesi.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular FrmDuyurular = new FrmDuyurular();
            FrmDuyurular.Show();
        }
       
    }
}
