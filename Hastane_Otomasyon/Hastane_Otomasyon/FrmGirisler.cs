using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyon
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void Btnhastagiris_Click(object sender, EventArgs e)
        {
            FrmHastaGiris FrmHastaGiris = new FrmHastaGiris();
            FrmHastaGiris.Show();
         this.Hide();
        }

        private void BtnDoktorGiris_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris FrmDoktorGiris = new FrmDoktorGiris();
            FrmDoktorGiris.Show();
           this.Hide();
        }

        private void BtnSekreterGiris_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris FrmSekreterGiris = new FrmSekreterGiris();
            FrmSekreterGiris.Show();
         this.Hide();
        }
    }
}
