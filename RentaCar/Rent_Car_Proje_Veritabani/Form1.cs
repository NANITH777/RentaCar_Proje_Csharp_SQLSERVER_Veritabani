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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-BOU9IP8;Initial Catalog=RentaCar;Integrated Security=True");
            SqlCommand com = new SqlCommand();
          

            try
            {
                if (comboBox1.SelectedIndex > -1)
                {
                    if (comboBox1.SelectedItem.ToString() == "Admin")
                    {
                        //SqlConnection connect = new SqlConnection("Data Source=DESKTOP-BOU9IP8;Initial Catalog=RentaCar;Integrated Security=True");
                        //SqlCommand com = new SqlCommand();
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
                    else
                    {
                        string query = "select * from musteri where tc = '" + txtkullanici.Text +
                            "' and sifre = '" + txtsifre.Text + "'";
                        connect.Open();

                        SqlDataAdapter adapt = new SqlDataAdapter(query, connect);
                        DataTable tablo = new DataTable();
                        adapt.Fill(tablo);

                        if (tablo.Rows.Count > 0)
                        {
                            formMusteri musteri = new formMusteri();
                            musteri.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hatali kullanici adi veya sifre", "Yanlis Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connect.Close();
                        }
                    }
                }
                else //IF the user has not choose a role it will show error MessageBox
                {
                    MessageBox.Show("Lutfen Rolunuzu secin", "Yanlis Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
