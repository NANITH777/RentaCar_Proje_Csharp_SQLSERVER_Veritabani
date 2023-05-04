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

        public void Bos_Araclar(ComboBox combo, string query)
        {
            connect.Open();
            SqlCommand com = new SqlCommand(query, connect);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());
            }
            connect.Close();
        }
        public void TC_Ara(/*TextBox tcara, */TextBox tc, /*TextBox sifre,*/ TextBox adsoyad, TextBox telefon, string query)
        {
            connect.Open();
            SqlCommand com = new SqlCommand(query, connect);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                //sifre.Text = read["sifre"].ToString();
                adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();
            }
            connect.Close();
        }

        public void Ucret_Hesapla(ComboBox kiracombo, TextBox ucret, string query)
        {
            connect.Open();
            SqlCommand com = new SqlCommand(query, connect);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                if (kiracombo.SelectedIndex == 0)
                {
                    ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 1).ToString();
                }
                if (kiracombo.SelectedIndex == 1)
                {
                    ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.80).ToString();
                }
                if (kiracombo.SelectedIndex == 2)
                {
                    ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.60).ToString();
                }
            }
            connect.Close();
        }

        public void CombodanGetir(ComboBox Araclar, TextBox marka, TextBox seri, TextBox yil, TextBox renk, string query)
        {
            connect.Open();
            SqlCommand com = new SqlCommand(query, connect);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                yil.Text = read["yil"].ToString();
                renk.Text = read["renk"].ToString();
            }
            connect.Close();
        }

        public void satis_hesapla(Label lbl)
        {
            connect.Open();
            SqlCommand com = new SqlCommand(" select sum (tutar) from satis", connect);
            lbl.Text = "Toplam Tutar=" + com.ExecuteScalar() + " TL";
            connect.Close();
        }
    }

}
