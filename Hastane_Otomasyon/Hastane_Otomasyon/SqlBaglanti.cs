using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Otomasyon
{
    class SqlBaglanti
    {
        //public string baglanti= System.IO.File.ReadAllText(@"C:\Test.txt");
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-NLD05HG\\SQLEXPRESS;Initial Catalog=Hastane_Proje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
