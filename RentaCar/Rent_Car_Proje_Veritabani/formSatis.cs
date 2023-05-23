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
    public partial class formSatis : Form
    {
        Arac_kiralama arac = new Arac_kiralama();
        public formSatis()
        {
            InitializeComponent();
        }

        private void formSatis_Load(object sender, EventArgs e)
        {
            string query = "select * from satis";
            SqlDataAdapter adtr = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr, query);

            arac.satis_hesapla(label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YenileSatis()
        {
            string cumle = "select * from satis";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, cumle);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string query = " delete from satis where plaka='" + satir.Cells["plaka"].Value.ToString() + "'";
            SqlCommand com2 = new SqlCommand();
            arac.ekle_sil_guncelle(com2, query);
            YenileSatis();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string query = "select * from EnCokKiralananA_Markasi";
            SqlDataAdapter adtr3 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr3, query);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            YenileSatis();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string query2 = "truncate table satis";
            SqlDataAdapter adtr4 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr4, query2);
            //label1.Text = "0";
        }
    }
}
