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
    public partial class formMusteriArabaListesi : Form
    {
        Arac_kiralama arackiralama = new Arac_kiralama();
        public formMusteriArabaListesi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int musteriId = int.Parse(textBox1.Text);

            string connect = "Data Source=DESKTOP-BOU9IP8;Initial Catalog=RentaCar;Integrated Security=True";

            string query = "SELECT M.plaka, M.marka, M.seri, M.yil, M.renk, M.kiraucreti, M.gun, M.tutar, M.ctarih, M.dtarih FROM sozlesme M INNER JOIN arac A ON M.plaka = A.plaka WHERE M.tc = @ClientId";
            SqlCommand com = new SqlCommand(query);
            com.Parameters.AddWithValue("@ClientId", musteriId);

            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                com.Connection = connection;

                SqlDataAdapter adapter = new SqlDataAdapter(com);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                connection.Close();
            }
        }
    }
}
