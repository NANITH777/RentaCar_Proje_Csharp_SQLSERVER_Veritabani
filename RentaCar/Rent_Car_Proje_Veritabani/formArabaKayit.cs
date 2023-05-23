using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_Car_Proje_Veritabani
{
    
    public partial class formArabaKayit : Form
    {
        Arac_kiralama arackiralama = new Arac_kiralama();
        public formArabaKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formArabaKayit_Load(object sender, EventArgs e)
        {

        }

        private void btnresim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void markacombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sericombo.Items.Clear();
                if (markacombo.SelectedIndex == 0)
                {
                    sericombo.Items.Add("M3");
                    sericombo.Items.Add("M5");
                    sericombo.Items.Add("X3");
                    sericombo.Items.Add("X5");
                }
                else if (markacombo.SelectedIndex == 1)
                {
                    sericombo.Items.Add("Fiesta");
                    sericombo.Items.Add("Focus");
                    sericombo.Items.Add("Mustang");
                }
                else if (markacombo.SelectedIndex == 2)
                {
                    sericombo.Items.Add("Civic");
                    sericombo.Items.Add("Pilot");
                }
                else if (markacombo.SelectedIndex == 3)
                {
                    sericombo.Items.Add("Amg");
                    sericombo.Items.Add("Benz");
                }
                else if (markacombo.SelectedIndex == 4)
                {
                    sericombo.Items.Add("Maxima");
                    sericombo.Items.Add("Rogue");
                    sericombo.Items.Add("Titan");
                }
                else if (markacombo.SelectedIndex == 5)
                {
                    sericombo.Items.Add("Camry");
                    sericombo.Items.Add("Corolla");
                    sericombo.Items.Add("Prius");
                    sericombo.Items.Add("RAV4");
                    sericombo.Items.Add("Tunda");
                }
            }
            catch
            {
                throw;
            }
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            SqlCommand com2 = new SqlCommand();
            com2.CommandType = CommandType.StoredProcedure;
            com2.CommandText = "Arac_Kayit";

            com2.Parameters.AddWithValue("@plaka", plakatxt.Text);
            com2.Parameters.AddWithValue("@marka", markacombo.Text);
            com2.Parameters.AddWithValue("@seri", sericombo.Text);
            com2.Parameters.AddWithValue("@yil", yiltxt.Text);
            com2.Parameters.AddWithValue("@renk", renktxt.Text);


            com2.Parameters.AddWithValue("@koltuksayisi", int.Parse(txtkoltuk.Text));
            com2.Parameters.AddWithValue("@yakit", yakitcombo.Text);
            com2.Parameters.AddWithValue("@kiraucreti", int.Parse(ucrettxt.Text));
            com2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            com2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            com2.Parameters.AddWithValue("@durumu", "BOS");
            arackiralama.Ekle_Sil_Guncelle2(com2, "Arac_Kayit", CommandType.StoredProcedure);

            sericombo.Items.Clear();

            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";

        }
    }
}
