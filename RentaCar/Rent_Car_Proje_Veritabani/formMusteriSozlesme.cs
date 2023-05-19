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
    public partial class formMusteriSozlesme : Form
    {
        Arac_kiralama arackiralama = new Arac_kiralama();
        public formMusteriSozlesme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formMusteriSozlesme_Load(object sender, EventArgs e)
        {
            BOS_Araclar();
        }

        private void BOS_Araclar()
        {
            string query2 = "select * from arac where durumu='BOS'";
            arackiralama.Bos_Araclar(araccombo, query2);
        }

        private void tctxt_TextChanged(object sender, EventArgs e)
        {
            if (tctxt.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string query3 = " select * from musteri where tc like '" + tctxt.Text + "'";
            arackiralama.TC_Ara(tctxt, adtxt, teltxt, query3);
        }

        private void araccombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query2 = "select * from arac where plaka like '" + araccombo.SelectedItem + "'";
            arackiralama.CombodanGetir(araccombo, markatxt, seritxt, yiltxt, renktxt, query2);
        }

        private void kiracombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from arac where plaka like '" + araccombo.SelectedItem + "'";
            arackiralama.Ucret_Hesapla(kiracombo, kiratxt, query);
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(datedonus.Text) - DateTime.Parse(datecikis.Text);
            int gun2 = gun.Days;
            guntxt.Text = gun2.ToString();
            tutartxt.Text = (gun2 * int.Parse(kiratxt.Text)).ToString();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            datecikis.Text = DateTime.Now.ToShortDateString();
            datedonus.Text = DateTime.Now.ToShortDateString();
            kiracombo.Text = "";
            kiratxt.Text = "";
            guntxt.Text = "";
            tutartxt.Text = "";
            araccombo.Text = "";
            markatxt.Text = "";
            seritxt.Text = "";
            yiltxt.Text = "";
            renktxt.Text = "";
            tctxt.Text = "";
            adtxt.Text = "";
            teltxt.Text = "";
            elinotxt.Text = "";
            elitartxt.Text = "";
            eliyertxt.Text = "";
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string query2 = "insert into sozlesme(tc, adsoyad, telefon, ehliyetno, e_tarih, e_yer, plaka, marka, seri, yil, renk, kirasekli, kiraucreti, gun,tutar, ctarih, dtarih) values(@tc, @adsoyad, @telefon, @ehliyetno, @e_tarih, @e_yer, @plaka, @marka, @seri, @yil, @renk, @kirasekli, @kiraucreti, @gun, @tutar, @ctarih, @dtarih)";
            SqlCommand com2 = new SqlCommand();
            com2.Parameters.AddWithValue("@tc", tctxt.Text);
            com2.Parameters.AddWithValue("@adsoyad", adtxt.Text);
            com2.Parameters.AddWithValue("@telefon", teltxt.Text);
            com2.Parameters.AddWithValue("@ehliyetno", elinotxt.Text);
            com2.Parameters.AddWithValue("@e_tarih", elitartxt.Text);
            com2.Parameters.AddWithValue("@e_yer", eliyertxt.Text);
            com2.Parameters.AddWithValue("@plaka", araccombo.Text);
            com2.Parameters.AddWithValue("@marka", markatxt.Text);
            com2.Parameters.AddWithValue("@seri", seritxt.Text);
            com2.Parameters.AddWithValue("@yil", yiltxt.Text);
            com2.Parameters.AddWithValue("@renk", renktxt.Text);
            com2.Parameters.AddWithValue("@kirasekli", kiracombo.Text);
            com2.Parameters.AddWithValue("@kiraucreti", int.Parse(kiratxt.Text));
            com2.Parameters.AddWithValue("@gun", int.Parse(guntxt.Text));
            com2.Parameters.AddWithValue("@tutar", int.Parse(tutartxt.Text));
            com2.Parameters.AddWithValue("@ctarih", datecikis.Text);
            com2.Parameters.AddWithValue("@dtarih", datedonus.Text);
            arackiralama.ekle_sil_guncelle(com2, query2);

            string query3 = "update arac set durumu='DOLU' where plaka= '" + araccombo.Text + "' ";
            SqlCommand com3 = new SqlCommand();
            arackiralama.ekle_sil_guncelle(com3, query3);
            araccombo.Items.Clear();
            BOS_Araclar();

            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            araccombo.Text = "";
            Temizle();

            messageBoxform2.Show("Sozlesme eklendi");
        }
    }
}
