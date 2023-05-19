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
    public partial class formSorgular : Form
    {
        Arac_kiralama arackiralama = new Arac_kiralama();

        public formSorgular()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formSorgular_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string query = "select * from personel order by id";
            SqlDataAdapter adtr1 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr1, query);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string query = "select * from EnYuksekMaasliPersonel";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, query);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string query = "select * from Musteri_Listele";
            SqlDataAdapter adtr3 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr3, query);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string query = "select * from araclistele";
            SqlDataAdapter adtr4 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr4, query);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string query = "select * from sozlesme";
            SqlDataAdapter adtr4 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr4, query);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string query = "select * from satis";
            SqlDataAdapter adtr5 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr5, query);
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string query = "select * from EnCokKiralananA_Markasi";
            SqlDataAdapter adtr6 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr6, query);
        }
    }
}
