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
    public partial class FrmBrans : Form
    {   
        public FrmBrans()
        {
            InitializeComponent();
        } 
        void Listeleme()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *From TBL_Branslar ", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtBransAd.Focus();
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", TxtBransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listeleme();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Branslar where BransId=@b1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listeleme();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Branslar set BransAd=@b1 where BransId=@b2", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", TxtBransAd.Text);
            komut.Parameters.AddWithValue("@b2", Txtid.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Brans Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listeleme();
        }
    }
}
