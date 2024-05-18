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

       
        private void btnlogin_Click(object sender, EventArgs e)
        {
                  
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-2H8LHRK;Initial Catalog=RentaCar;Integrated Security=True;");
            
          

            try
            {
                if (comboBox1.SelectedIndex > -1)
                {
                    if (comboBox1.SelectedItem.ToString() == "Admin")
                    {
                        SqlCommand com = new SqlCommand();
                        connect.Open();
                        com.Connection = connect;
                        com.CommandText = "select * from Kullanici_Bilgi where kullanici_adi= '" + txtkullanici.Text +
                            "'and sifre='" + txtsifre.Text + "'";

                        SqlDataReader reader = com.ExecuteReader();
                        if (reader.Read())
                        {
                            messageBoxform.Show("Giris basarili!!!");
                            AnaForm ana = new AnaForm();
                            ana.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            messageBoxform.Show("Hatali kullanici adi veya sifre");
                        }
                        connect.Close();
                      
                    }
                    else
                    {
                        SqlCommand com2 = new SqlCommand();
                        connect.Open();
                        com2.Connection = connect;
                        com2.CommandText = "select * from musteri where tc = '" + txtkullanici.Text +"' and sifre = '" + txtsifre.Text + "'";

                        SqlDataReader reader = com2.ExecuteReader();
                        if (reader.Read())
                        {
                            messageBoxform2.Show("Giris basarili!!!");
                            formMusteri musteri = new formMusteri();
                            musteri.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Hatali kullanici adi veya sifre", "Yanlis Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                        }
                        connect.Close();
                    }
                }
                else 
                {
                    MessageBox.Show("Lutfen Rolunuzu secin", "Yanlis Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                messageBoxform.Show(error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
