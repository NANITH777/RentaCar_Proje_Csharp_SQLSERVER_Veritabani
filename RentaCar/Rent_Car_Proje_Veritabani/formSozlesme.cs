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
    public partial class formSozlesme : Form
    {
        Arac_kiralama arackiralama = new Arac_kiralama();
        public formSozlesme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formSozlesme_Load(object sender, EventArgs e)
        {
            BOS_Araclar();
            Yenile();
        }

        private void BOS_Araclar()
        {
            string query2 = "select * from arac where durumu='BOS'";
            arackiralama.Bos_Araclar(araccombo, query2);
        }

        private void Yenile()
        {
            string query3 = "select * from sozlesme";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, query3);
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
            Yenile();

            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            araccombo.Text = "";
            Temizle();

            messageBoxform.Show("Sozlesme eklendi");

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string query2 = "update sozlesme set tc=@tc, adsoyad=@adsoyad, telefon=@telefon, ehliyetno=@ehliyetno, e_tarih=@e_tarih, e_yer=@e_yer, marka=@marka, seri=@seri, yil=@yil, renk=@renk, kirasekli=@kirasekli, kiraucreti=@kiraucreti, gun=@gun, tutar=@tutar, ctarih=@ctarih, dtarih=@dtarih where plaka=@plaka";
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


            araccombo.Items.Clear();
            BOS_Araclar();
            Yenile();

            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            araccombo.Text = "";
            Temizle();

            messageBoxform.Show("Sozlesme guncellendi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            tctxt.Text = satir.Cells[0].Value.ToString();
            adtxt.Text = satir.Cells[1].Value.ToString();
            teltxt.Text = satir.Cells[2].Value.ToString();
            elinotxt.Text = satir.Cells[3].Value.ToString();
            elitartxt.Text = satir.Cells[4].Value.ToString();
            eliyertxt.Text = satir.Cells[5].Value.ToString();
            araccombo.Text = satir.Cells[6].Value.ToString();
            markatxt.Text = satir.Cells[7].Value.ToString();
            seritxt.Text = satir.Cells[8].Value.ToString();
            yiltxt.Text = satir.Cells[9].Value.ToString();
            renktxt.Text = satir.Cells[10].Value.ToString();
            kiracombo.Text = satir.Cells[11].Value.ToString();
            kiratxt.Text = satir.Cells[12].Value.ToString();
            guntxt.Text = satir.Cells[13].Value.ToString();
            tutartxt.Text = satir.Cells[14].Value.ToString();
            datecikis.Text = satir.Cells[15].Value.ToString();
            datedonus.Text = satir.Cells[16].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;

            // Gun farki hesapla
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime donus = DateTime.Parse(satir.Cells["dtarih"].Value.ToString());
            int ucret = int.Parse(satir.Cells["kiraucreti"].Value.ToString());
            TimeSpan gunfarki = bugun - donus;
            int _gunfarki = gunfarki.Days;
            int ucretfarki;

            // ucret farkli hesapla
            ucretfarki = _gunfarki * ucret;
            txtextra.Text = ucretfarki.ToString();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtextra.Text) >= 0 || int.Parse(txtextra.Text) < 0)
            {
                DataGridViewRow satir = dataGridView1.CurrentRow;

                DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ucret = int.Parse(satir.Cells["kiraucreti"].Value.ToString());
                int tutar = int.Parse(satir.Cells["tutar"].Value.ToString());
                DateTime cikis = DateTime.Parse(satir.Cells["ctarih"].Value.ToString());
                TimeSpan gun = bugun - cikis;
                int _gun = gun.Days;
                int toplamtutar = _gun * ucret;

                string query1 = " delete from sozlesme where plaka= '" + satir.Cells["plaka"].Value.ToString() + "'";
                SqlCommand com = new SqlCommand();
                arackiralama.ekle_sil_guncelle(com, query1);

                //// veritabanindaki Arac tablosuna guncelleme yapmak ////
                string query2 = " update arac set durumu='BOS' where plaka='" + satir.Cells["plaka"].Value.ToString() + "'";
                SqlCommand com2 = new SqlCommand();
                arackiralama.ekle_sil_guncelle(com2, query2);

                //// veritabanindaki Satis tablosuna değerleri ekleme sorgusu////
                string query3 = "insert into satis(tc, adsoyad, plaka, marka, seri, yil, renk, gun, fiyat, tutar, tarih1, tarih2) values(@tc, @adsoyad, @plaka, @marka, @seri, @yil, @renk, @gun, @fiyat, @tutar, @tarih1, @tarih2)";
                SqlCommand com3 = new SqlCommand();
                com3.Parameters.AddWithValue("@tc", satir.Cells["tc"].Value.ToString());
                com3.Parameters.AddWithValue("@adsoyad", satir.Cells["adsoyad"].Value.ToString());
                com3.Parameters.AddWithValue("@plaka", satir.Cells["plaka"].Value.ToString());
                com3.Parameters.AddWithValue("@marka", satir.Cells["marka"].Value.ToString());
                com3.Parameters.AddWithValue("@seri", satir.Cells["seri"].Value.ToString());
                com3.Parameters.AddWithValue("@yil", satir.Cells["yil"].Value.ToString());
                com3.Parameters.AddWithValue("@renk", satir.Cells["renk"].Value.ToString());
                com3.Parameters.AddWithValue("@gun", _gun);
                com3.Parameters.AddWithValue("@fiyat", ucret);
                com3.Parameters.AddWithValue("@tutar", toplamtutar);
                com3.Parameters.AddWithValue("@tarih1", satir.Cells["ctarih"].Value.ToString());
                com3.Parameters.AddWithValue("@tarih2", DateTime.Now.ToShortDateString());

                arackiralama.ekle_sil_guncelle(com3, query3);
                messageBoxform.Show("Arac teslim edildi");
                araccombo.Text = "";
                araccombo.Items.Clear();
                BOS_Araclar();
                Yenile();

                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                araccombo.Text = "";
                Temizle();

                txtextra.Text = "";
            }
            else
            {
                MessageBox.Show("lutfen secim yapiniz", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
