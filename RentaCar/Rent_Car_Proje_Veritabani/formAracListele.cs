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
    public partial class formAracListele : Form
    {
        Arac_kiralama arackiralama = new Arac_kiralama();
        public formAracListele()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            plakatxt.Text = satir.Cells["plaka"].Value.ToString();
            markacombo.Text = satir.Cells["marka"].Value.ToString();
            sericombo.Text = satir.Cells["seri"].Value.ToString();
            yiltxt.Text = satir.Cells["yil"].Value.ToString();
            renktxt.Text = satir.Cells["renk"].Value.ToString();
            txtkoltuk.Text = satir.Cells["koltuksayisi"].Value.ToString();
            yakitcombo.Text = satir.Cells["yakit"].Value.ToString();
            ucrettxt.Text = satir.Cells["kiraucreti"].Value.ToString();
            pictureBox2.ImageLocation = satir.Cells["resim"].Value.ToString();
        }

        private void formAracListele_Load(object sender, EventArgs e)
        {
            YenileAraclistele();
            comboAraclar.SelectedIndex = 0;

        }

        private void YenileAraclistele()
        {
            string query = "select * from arac";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource= arackiralama.listele(adtr2, query);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnguncelle_Click_1(object sender, EventArgs e)
        {
            string query = " update arac set marka=@marka, seri=@seri, yil=@yil, renk=@renk, koltuksayisi=@koltuksayisi, yakit=@yakit, kiraucreti=@kiraucreti, resim=@resim, tarih=@tarih  where plaka=@plaka";
            SqlCommand com = new SqlCommand();
            com.Parameters.AddWithValue("@plaka", plakatxt.Text);
            com.Parameters.AddWithValue("@marka", markacombo.Text);
            com.Parameters.AddWithValue("@seri", sericombo.Text);
            com.Parameters.AddWithValue("@yil", yiltxt.Text);
            com.Parameters.AddWithValue("@renk", renktxt.Text);
            com.Parameters.AddWithValue("@koltuksayisi", int.Parse(txtkoltuk.Text));
            com.Parameters.AddWithValue("@yakit", yakitcombo.Text);
            com.Parameters.AddWithValue("@kiraucreti", int.Parse(ucrettxt.Text));
            com.Parameters.AddWithValue("@resim", pictureBox2.ImageLocation);
            com.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

            arackiralama.ekle_sil_guncelle(com, query);
            sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";
            pictureBox2.ImageLocation = "";
            YenileAraclistele();
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

        private void comboAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboAraclar.SelectedIndex == 0)
                {
                    YenileAraclistele();
                }
                if (comboAraclar.SelectedIndex == 1)
                {
                    string query = " select * from arac where durumu= 'BOS'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, query);
                }
                if (comboAraclar.SelectedIndex == 2)
                {
                    string query = " select * from arac where durumu= 'DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, query);
                }
            }
            catch
            {
                throw;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string query = " delete from arac where plaka='" + satir.Cells["plaka"].Value.ToString() + "'";
            SqlCommand com2 = new SqlCommand();
            arackiralama.ekle_sil_guncelle(com2, query);
            YenileAraclistele();
            pictureBox2.ImageLocation = "";
            sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
        }

        
    }
    
}
