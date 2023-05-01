using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_Car_Proje_Veritabani
{
    internal class Arac_kiralama
    {
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-BOU9IP8;Initial Catalog=RentaCar;Integrated Security=True");
        DataTable tablo;
        public void ekle_sil_guncelle(SqlCommand com, string query)
        {
            connect.Open();
            com.Connection = connect;
            com.CommandText = query;
            com.ExecuteNonQuery();
            connect.Close();
        }

        public DataTable listele(SqlDataAdapter adtr, string query)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(query, connect);
            adtr.Fill(tablo);
            connect.Close();
            return tablo;
        }
    }

}
