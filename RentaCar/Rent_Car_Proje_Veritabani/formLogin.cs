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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-BOU9IP8;Initial Catalog=RentaCar;Integrated Security=True");
            SqlCommand com = new SqlCommand();
            connect.Open();
            com.Connection = connect;
            com.CommandText = "select * from Kullanici_Bilgi where kullanici_adi= '" + txtkullanici.Text +
                "'and sifre='" + txtsifre.Text + "'";

            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Giris basarili!!!");
                AnaForm ana = new AnaForm();
                ana.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali kullanici adi veya sifre");
            }
            connect.Close();
        }
    }
}
