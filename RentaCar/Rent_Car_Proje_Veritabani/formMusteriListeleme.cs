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
    public partial class formMusteriListeleme : Form
    {
        Arac_kiralama arackiralama = new Arac_kiralama();
        public formMusteriListeleme()
        {
            InitializeComponent();
        }

        private void formMusteriListeleme_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        private void YenileListele()
        {
            string cumle = " select * from musteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cumle);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "SIFRE";
            dataGridView1.Columns[2].HeaderText = "ADSOYAD";
            dataGridView1.Columns[3].HeaderText = "TELEFON";
            dataGridView1.Columns[4].HeaderText = "ADRES";
            dataGridView1.Columns[5].HeaderText = "EMAIL";
            dataGridView1.Columns[6].HeaderText = "DOGUMTARIHI";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cumle = "select * from Musteri_Listele where tc like '%" + textBox1.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cumle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cumle = " delete from  musteri where tc= '" + satir.Cells["tc"].Value.ToString() + "' ";
            SqlCommand query2 = new SqlCommand();
            arackiralama.ekle_sil_guncelle(query2, cumle);
            YenileListele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string cumle = "update musteri set sifre=@sifre, adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc";
            SqlCommand query2 = new SqlCommand();
            query2.Parameters.AddWithValue("@tc", txtTc.Text);
            query2.Parameters.AddWithValue("@sifre", txtsifre.Text);
            query2.Parameters.AddWithValue("@adsoyad", txtad.Text);
            query2.Parameters.AddWithValue("@telefon", txttel.Text);
            query2.Parameters.AddWithValue("@adres", txtadres.Text);
            query2.Parameters.AddWithValue("@email", txtemail.Text);
            arackiralama.ekle_sil_guncelle(query2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtTc.Text = satir.Cells[0].Value.ToString();
            txtsifre.Text = satir.Cells[1].Value.ToString();
            txtad.Text = satir.Cells[2].Value.ToString();
            txttel.Text = satir.Cells[3].Value.ToString();
            txtadres.Text = satir.Cells[4].Value.ToString();
            txtemail.Text = satir.Cells[5].Value.ToString();
            datedogum.Text = satir.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
