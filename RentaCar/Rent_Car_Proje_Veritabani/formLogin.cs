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

            //SqlConnection connect = new SqlConnection("Data Source=DESKTOP-BOU9IP8;Initial Catalog=RentaCar;Integrated Security=True");
            //SqlCommand com = new SqlCommand();
            //connect.Open();
            //com.Connection = connect;
            //com.CommandText = "select * from Kullanici_Bilgi where kullanici_adi= '" + txtkullanici.Text +
            //    "'and sifre='" + txtsifre.Text + "'";

            //SqlDataReader reader = com.ExecuteReader();
            //if (reader.Read())
            //{
            //    MessageBox.Show("Giris basarili!!!");
            //    AnaForm ana = new AnaForm();
            //    ana.ShowDialog();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Hatali kullanici adi veya sifre");
            //}
            //connect.Close();

            try
            {
                if (comboBox1.SelectedIndex > -1)
                {
                    if (comboBox1.SelectedItem.ToString() == "Admin")
                    {
                        if (txtkullanici.Text == "Admin" && txtsifre.Text == "admin")
                        {

                            AnaForm ad = new AnaForm();
                            this.Hide();                          //
                            ad.Show();
                        }
                        else
                        {
                            MessageBox.Show("USER NAME= Admin  ||  PASSWORD : admin", "Miss Id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        //string query = "SELECT * FROM \"users\" WHERE \"username\" = '" + usernametxt.Text + "' and \"password\"= '" + passwordtxt.Text + "'";
                        //NpgsqlCommand command = new NpgsqlCommand(query, connection);
                        //connection.Open();
                        ////NpgsqlDataReader reader = command.ExecuteReader();
                        //NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(query, connection);
                        //DataTable table = new DataTable();
                        //adapt.Fill(table);

                        //if (table.Rows.Count > 0)
                        //{
                        //    Form1 fr = new Form1();
                        //    fr.Show();
                        //    this.Hide();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Wrong Username or Password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    connection.Close();
                        //}
                    }
                }
                else //IF the user has not choose a role it will show error MessageBox
                {
                    MessageBox.Show("Please Select Role", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
