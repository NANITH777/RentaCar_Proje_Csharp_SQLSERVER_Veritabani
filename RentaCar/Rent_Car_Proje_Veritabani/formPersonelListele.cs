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
    public partial class formPersonelListele : Form
    {
        Arac_kiralama arackiralama = new Arac_kiralama();
        public formPersonelListele()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formPersonelListele_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        private void YenileListele()
        {
            string cumle = " select * from personel";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cumle);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "ID";
            dataGridView1.Columns[2].HeaderText = "AD";
            dataGridView1.Columns[3].HeaderText = "SOYAD";
            dataGridView1.Columns[4].HeaderText = "DOGUMTARIHI";
            dataGridView1.Columns[5].HeaderText = "TELEFON";
            dataGridView1.Columns[6].HeaderText = "ADRES";
            dataGridView1.Columns[7].HeaderText = "EMAIL";
            dataGridView1.Columns[8].HeaderText = "POZİSYON";
            dataGridView1.Columns[9].HeaderText = "MAAŞ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cumle = "select * from personel where tc like '%" + textBox1.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cumle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cumle = " delete from  personel where tc= '" + satir.Cells["tc"].Value.ToString() + "' ";
            SqlCommand query2 = new SqlCommand();
            arackiralama.ekle_sil_guncelle(query2, cumle);
            YenileListele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string cumle = "update personel set id=@id, ad=@ad, soyad=@soyad, tel=@tel,adres=@adres, mail=@mail, post=@post, maas=@maas where tc=@tc";
            SqlCommand query2 = new SqlCommand();
            query2.Parameters.AddWithValue("@tc", txtTc.Text);
            query2.Parameters.AddWithValue("@id", txtid.Text);
            query2.Parameters.AddWithValue("@ad", txtad.Text);
            query2.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            query2.Parameters.AddWithValue("@adres", txtadres.Text);
            query2.Parameters.AddWithValue("@mail", txtmail.Text);
            query2.Parameters.AddWithValue("@post", txtpost.Text);
            query2.Parameters.AddWithValue("@maas", float.Parse(txtmaas.Text));
            arackiralama.ekle_sil_guncelle(query2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtTc.Text = satir.Cells[0].Value.ToString();
            txtid.Text = satir.Cells[1].Value.ToString();
            txtad.Text = satir.Cells[2].Value.ToString();
            txtsoyad.Text = satir.Cells[3].Value.ToString();
            datedogum.Text = satir.Cells[4].Value.ToString();
            txttel.Text = satir.Cells[5].Value.ToString();
            txtadres.Text = satir.Cells[6].Value.ToString();
            txtmail.Text = satir.Cells[7].Value.ToString();
            txtpost.Text = satir.Cells[8].Value.ToString();
            txtmaas.Text = satir.Cells[9].Value.ToString();
        }

    }
}
