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
    public partial class formMusteri : Form
    {
        Arac_kiralama arackiralama = new Arac_kiralama();
        public formMusteri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            pictureBox1.ImageLocation = satir.Cells["resim"].Value.ToString();
        }

        private void formMusteri_Load(object sender, EventArgs e)
        {
            YenileAraclistele();
            comboAraclar.SelectedIndex = 0;
        }

        private void YenileAraclistele()
        {
            string cumle = "select * from arac";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cumle);
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
                    string cumle = " select * from arac where durumu= 'BOS'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, cumle);
                }
                if (comboAraclar.SelectedIndex == 2)
                {
                    string cumle = " select * from arac where durumu= ' DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, cumle);
                }
            }
            catch
            {
                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cumle = "select * from arac where marka like '%" + txtmarkaAra.Text + "%'";
            SqlDataAdapter adtr3 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr3, cumle);
        }

        private void txtrenkAra_TextChanged(object sender, EventArgs e)
        {
            string cumle = "select * from arac where renk like '%" + txtrenkAra.Text + "%'";
            SqlDataAdapter adtr4 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr4, cumle);
        }

        private void txtucretAra_TextChanged(object sender, EventArgs e)
        {
            string cumle = "select * from arac where kiraucreti like '%" + txtucretAra.Text + "%'";
            SqlDataAdapter adtr5 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr5, cumle);
        }

        private void textseriAra_TextChanged(object sender, EventArgs e)
        {
            string cumle = "select * from arac where seri like '%" + txtseriAra.Text + "%'";
            SqlDataAdapter adtr5 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr5, cumle);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            formMusteriArabaListesi araba = new formMusteriArabaListesi();
            araba.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formMusteriSozlesme mus_sozlesme = new formMusteriSozlesme();
            mus_sozlesme.ShowDialog();
        }
    }
}
