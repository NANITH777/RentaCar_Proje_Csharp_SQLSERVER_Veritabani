using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnkayit_Click(object sender, EventArgs e)
        {

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

        }

        private void YenileAraclistele()
        {
            string cumle = "select * from arac";
            sqldataAdaptater adtr2 = new sqldataAdaptater();
            arackiralama.listele(adtr2, cumle);
        }
    }
    
}
