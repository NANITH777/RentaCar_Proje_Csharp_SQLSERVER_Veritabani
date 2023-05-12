namespace Rent_Car_Proje_Veritabani
{
    partial class formMusteri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboAraclar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucrettxt = new System.Windows.Forms.TextBox();
            this.txtkoltuk = new System.Windows.Forms.TextBox();
            this.renktxt = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.yiltxt = new System.Windows.Forms.TextBox();
            this.yakitcombo = new System.Windows.Forms.ComboBox();
            this.sericombo = new System.Windows.Forms.ComboBox();
            this.markacombo = new System.Windows.Forms.ComboBox();
            this.plakatxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmarkaAra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtrenkAra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtucretAra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtseriAra = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 24);
            this.label9.TabIndex = 89;
            this.label9.Text = "RentaCar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(1216, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 35);
            this.button1.TabIndex = 87;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(378, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(867, 524);
            this.dataGridView1.TabIndex = 86;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboAraclar
            // 
            this.comboAraclar.FormattingEnabled = true;
            this.comboAraclar.Items.AddRange(new object[] {
            "Tum Araclar",
            "Bos Araclar",
            "Dolu Araclar"});
            this.comboAraclar.Location = new System.Drawing.Point(1124, 55);
            this.comboAraclar.Name = "comboAraclar";
            this.comboAraclar.Size = new System.Drawing.Size(121, 21);
            this.comboAraclar.TabIndex = 84;
            this.comboAraclar.SelectedIndexChanged += new System.EventHandler(this.comboAraclar_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Kira Ucreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Yakit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "Koltuk Sayisi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Plaka";
            // 
            // ucrettxt
            // 
            this.ucrettxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucrettxt.Location = new System.Drawing.Point(129, 379);
            this.ucrettxt.Name = "ucrettxt";
            this.ucrettxt.Size = new System.Drawing.Size(173, 22);
            this.ucrettxt.TabIndex = 72;
            // 
            // txtkoltuk
            // 
            this.txtkoltuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkoltuk.Location = new System.Drawing.Point(129, 291);
            this.txtkoltuk.Name = "txtkoltuk";
            this.txtkoltuk.Size = new System.Drawing.Size(173, 22);
            this.txtkoltuk.TabIndex = 71;
            // 
            // renktxt
            // 
            this.renktxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renktxt.Location = new System.Drawing.Point(129, 248);
            this.renktxt.Name = "renktxt";
            this.renktxt.Size = new System.Drawing.Size(173, 22);
            this.renktxt.TabIndex = 70;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // yiltxt
            // 
            this.yiltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yiltxt.Location = new System.Drawing.Point(129, 205);
            this.yiltxt.Name = "yiltxt";
            this.yiltxt.Size = new System.Drawing.Size(173, 22);
            this.yiltxt.TabIndex = 69;
            // 
            // yakitcombo
            // 
            this.yakitcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yakitcombo.FormattingEnabled = true;
            this.yakitcombo.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+lpg"});
            this.yakitcombo.Location = new System.Drawing.Point(129, 334);
            this.yakitcombo.Name = "yakitcombo";
            this.yakitcombo.Size = new System.Drawing.Size(173, 24);
            this.yakitcombo.TabIndex = 68;
            // 
            // sericombo
            // 
            this.sericombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sericombo.FormattingEnabled = true;
            this.sericombo.Location = new System.Drawing.Point(129, 160);
            this.sericombo.Name = "sericombo";
            this.sericombo.Size = new System.Drawing.Size(173, 24);
            this.sericombo.TabIndex = 67;
            // 
            // markacombo
            // 
            this.markacombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markacombo.FormattingEnabled = true;
            this.markacombo.Items.AddRange(new object[] {
            "BMW",
            "Ford",
            "Honda",
            "Mercedes",
            "Nissan",
            "Toyota"});
            this.markacombo.Location = new System.Drawing.Point(129, 115);
            this.markacombo.Name = "markacombo";
            this.markacombo.Size = new System.Drawing.Size(173, 24);
            this.markacombo.TabIndex = 66;
            this.markacombo.SelectedIndexChanged += new System.EventHandler(this.markacombo_SelectedIndexChanged);
            // 
            // plakatxt
            // 
            this.plakatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plakatxt.Location = new System.Drawing.Point(129, 72);
            this.plakatxt.Name = "plakatxt";
            this.plakatxt.Size = new System.Drawing.Size(173, 22);
            this.plakatxt.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(823, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 25);
            this.label10.TabIndex = 91;
            this.label10.Text = "Ara";
            // 
            // txtmarkaAra
            // 
            this.txtmarkaAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarkaAra.Location = new System.Drawing.Point(450, 53);
            this.txtmarkaAra.Name = "txtmarkaAra";
            this.txtmarkaAra.Size = new System.Drawing.Size(87, 22);
            this.txtmarkaAra.TabIndex = 90;
            this.txtmarkaAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(450, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 92;
            this.label11.Text = "Markaya göre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(768, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 94;
            this.label12.Text = "Renke göre";
            // 
            // txtrenkAra
            // 
            this.txtrenkAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrenkAra.Location = new System.Drawing.Point(759, 54);
            this.txtrenkAra.Name = "txtrenkAra";
            this.txtrenkAra.Size = new System.Drawing.Size(87, 22);
            this.txtrenkAra.TabIndex = 93;
            this.txtrenkAra.TextChanged += new System.EventHandler(this.txtrenkAra_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(924, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 96;
            this.label13.Text = "Ücrete göre";
            // 
            // txtucretAra
            // 
            this.txtucretAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtucretAra.Location = new System.Drawing.Point(915, 54);
            this.txtucretAra.Name = "txtucretAra";
            this.txtucretAra.Size = new System.Drawing.Size(87, 22);
            this.txtucretAra.TabIndex = 95;
            this.txtucretAra.TextChanged += new System.EventHandler(this.txtucretAra_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(615, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 98;
            this.label14.Text = "Seriye göre";
            // 
            // txtseriAra
            // 
            this.txtseriAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtseriAra.Location = new System.Drawing.Point(603, 55);
            this.txtseriAra.Name = "txtseriAra";
            this.txtseriAra.Size = new System.Drawing.Size(87, 22);
            this.txtseriAra.TabIndex = 97;
            this.txtseriAra.TextChanged += new System.EventHandler(this.textseriAra_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Rent_Car_Proje_Veritabani.Properties.Resources.RentaCar;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(4, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 49);
            this.panel2.TabIndex = 88;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(796, 645);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 75);
            this.button2.TabIndex = 99;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(736, 617);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(205, 16);
            this.label15.TabIndex = 100;
            this.label15.Text = "Kıradıklarınız araba listesine gidin";
            // 
            // formMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1257, 732);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtseriAra);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtucretAra);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtrenkAra);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtmarkaAra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboAraclar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucrettxt);
            this.Controls.Add(this.txtkoltuk);
            this.Controls.Add(this.renktxt);
            this.Controls.Add(this.yiltxt);
            this.Controls.Add(this.yakitcombo);
            this.Controls.Add(this.sericombo);
            this.Controls.Add(this.markacombo);
            this.Controls.Add(this.plakatxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formMusteri";
            this.Load += new System.EventHandler(this.formMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboAraclar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ucrettxt;
        private System.Windows.Forms.TextBox txtkoltuk;
        private System.Windows.Forms.TextBox renktxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox yiltxt;
        private System.Windows.Forms.ComboBox yakitcombo;
        private System.Windows.Forms.ComboBox sericombo;
        private System.Windows.Forms.ComboBox markacombo;
        private System.Windows.Forms.TextBox plakatxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmarkaAra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtrenkAra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtucretAra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtseriAra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
    }
}