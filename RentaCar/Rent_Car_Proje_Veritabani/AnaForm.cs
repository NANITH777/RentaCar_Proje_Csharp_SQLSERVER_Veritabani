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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            formPersonelListele perlis = new formPersonelListele();
            perlis.ShowDialog();

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void tasker_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formMusteriEkle ekle = new formMusteriEkle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formMusteriListeleme liste = new formMusteriListeleme();
            liste.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formArabaKayit kayit = new formArabaKayit();
            kayit.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formAracListele liste = new formAracListele();
            liste.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formSozlesme sozlesme = new formSozlesme();
            sozlesme.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            formSatis satis = new formSatis();
            satis.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            formPersonelEkle personel = new formPersonelEkle();
            personel.ShowDialog();
        }

        private void btnsorgu_Click(object sender, EventArgs e)
        {
            formSorgular sorgu = new formSorgular();
            sorgu.ShowDialog();
        }
    }
}
