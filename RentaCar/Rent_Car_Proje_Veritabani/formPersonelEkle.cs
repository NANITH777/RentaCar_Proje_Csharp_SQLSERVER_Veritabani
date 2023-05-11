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
    public partial class formPersonelEkle : Form
    {
        Arac_kiralama arackiralama = new Arac_kiralama();
        public formPersonelEkle()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string cumle = "insert into personel (tc, id, ad, soyad, dogumtarihi, tel, adres, mail, post, maas ) values(@tc, @id, @ad, @soyad,@dogumtarihi, @tel, @adres, @mail,@post, @maas)";
            SqlCommand query2 = new SqlCommand();
            DateTime dateValue = datedogum.Value;
            query2.Parameters.AddWithValue("@tc", txtTc.Text);
            query2.Parameters.AddWithValue("@id", txtid.Text);
            query2.Parameters.AddWithValue("@ad", txtad.Text);
            query2.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            query2.Parameters.AddWithValue("@dogumtarihi", dateValue.Date);
            query2.Parameters.AddWithValue("@tel", txttel.Text);
            query2.Parameters.AddWithValue("@adres", txtadres.Text);
            query2.Parameters.AddWithValue("@mail", txtmail.Text);
            query2.Parameters.AddWithValue("@post", txtpost.Text);
            query2.Parameters.AddWithValue("@maas", float.Parse(txtmaas.Text));


            arackiralama.ekle_sil_guncelle(query2, cumle);
            messageBoxform.Show("Personel Eklendi!!!!");
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is RichTextBox) item.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
