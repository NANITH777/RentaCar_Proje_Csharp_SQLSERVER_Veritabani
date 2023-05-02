using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void Bos_Araclar(ComboBox combo, string sorgu)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand(sorgu, connect);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());
            }
            connect.Close();
        }
        public void TC_Ara(TextBox tcara, TextBox tc, TextBox sifre, TextBox adsoyad, TextBox telefon, string sorgu)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand(sorgu, connect);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                sifre.Text = read["sifre"].ToString();
                adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();
            }
            connect.Close();
        }

    }

}
