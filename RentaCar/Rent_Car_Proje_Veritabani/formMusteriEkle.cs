using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_Car_Proje_Veritabani
{
    public partial class formMusteriEkle : Form
    {
        Arac_kiralama arac_kiralama = new Arac_kiralama();
        public formMusteriEkle()
        {
            InitializeComponent();
        }

       
        private void btnekle_Click(object sender, EventArgs e)
        {
            string cumle = "insert into musteri (tc, sifre, adsoyad, telefon, adres, email, dogumtarihi) values(@TC, @sifre, @adsoyad, @telefon, @adres, @email, @dogumtarihi)";
            SqlCommand query2 = new SqlCommand();
            DateTime dateValue = datedogum.Value;
            query2.Parameters.AddWithValue("@tc", txtTc.Text);
            query2.Parameters.AddWithValue("@sifre", txtsifre.Text);
            query2.Parameters.AddWithValue("@adsoyad", txtad.Text);
            query2.Parameters.AddWithValue("@telefon", txttel.Text);
            query2.Parameters.AddWithValue("@adres", txtadres.Text);
            query2.Parameters.AddWithValue("@email", txtemail.Text);
            query2.Parameters.AddWithValue("@dogumtarihi", dateValue.Date);

            arac_kiralama.ekle_sil_guncelle(query2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
