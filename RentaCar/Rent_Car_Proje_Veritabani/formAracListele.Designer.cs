namespace Rent_Car_Proje_Veritabani
{
    partial class formAracListele
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAracListele));
            this.btnguncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.yiltxt = new System.Windows.Forms.TextBox();
            this.yakitcombo = new System.Windows.Forms.ComboBox();
            this.sericombo = new System.Windows.Forms.ComboBox();
            this.markacombo = new System.Windows.Forms.ComboBox();
            this.plakatxt = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.comboAraclar = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.White;
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.ImageIndex = 1;
            this.btnguncelle.ImageList = this.ımageList1;
            this.btnguncelle.Location = new System.Drawing.Point(310, 610);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(112, 63);
            this.btnguncelle.TabIndex = 55;
            this.btnguncelle.Text = "Guncelle";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click_1);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "delete_icon.png");
            this.ımageList1.Images.SetKeyName(1, "update_icon.png");
            this.ımageList1.Images.SetKeyName(2, "back_icon.png");
            this.ımageList1.Images.SetKeyName(3, "add_image.png");
            this.ımageList1.Images.SetKeyName(4, "delete_car.png");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Kira Ucreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Yakit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Koltuk Sayisi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Plaka";
            // 
            // ucrettxt
            // 
            this.ucrettxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucrettxt.Location = new System.Drawing.Point(131, 394);
            this.ucrettxt.Name = "ucrettxt";
            this.ucrettxt.Size = new System.Drawing.Size(173, 22);
            this.ucrettxt.TabIndex = 46;
            // 
            // txtkoltuk
            // 
            this.txtkoltuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkoltuk.Location = new System.Drawing.Point(131, 306);
            this.txtkoltuk.Name = "txtkoltuk";
            this.txtkoltuk.Size = new System.Drawing.Size(173, 22);
            this.txtkoltuk.TabIndex = 45;
            // 
            // renktxt
            // 
            this.renktxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renktxt.Location = new System.Drawing.Point(131, 263);
            this.renktxt.Name = "renktxt";
            this.renktxt.Size = new System.Drawing.Size(173, 22);
            this.renktxt.TabIndex = 44;
            // 
            // yiltxt
            // 
            this.yiltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yiltxt.Location = new System.Drawing.Point(131, 220);
            this.yiltxt.Name = "yiltxt";
            this.yiltxt.Size = new System.Drawing.Size(173, 22);
            this.yiltxt.TabIndex = 43;
            // 
            // yakitcombo
            // 
            this.yakitcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yakitcombo.FormattingEnabled = true;
            this.yakitcombo.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+lpg"});
            this.yakitcombo.Location = new System.Drawing.Point(131, 349);
            this.yakitcombo.Name = "yakitcombo";
            this.yakitcombo.Size = new System.Drawing.Size(173, 24);
            this.yakitcombo.TabIndex = 42;
            // 
            // sericombo
            // 
            this.sericombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sericombo.FormattingEnabled = true;
            this.sericombo.Location = new System.Drawing.Point(131, 175);
            this.sericombo.Name = "sericombo";
            this.sericombo.Size = new System.Drawing.Size(173, 24);
            this.sericombo.TabIndex = 41;
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
            this.markacombo.Location = new System.Drawing.Point(131, 130);
            this.markacombo.Name = "markacombo";
            this.markacombo.Size = new System.Drawing.Size(173, 24);
            this.markacombo.TabIndex = 40;
            this.markacombo.SelectedIndexChanged += new System.EventHandler(this.markacombo_SelectedIndexChanged);
            // 
            // plakatxt
            // 
            this.plakatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plakatxt.Location = new System.Drawing.Point(131, 87);
            this.plakatxt.Name = "plakatxt";
            this.plakatxt.Size = new System.Drawing.Size(173, 22);
            this.plakatxt.TabIndex = 39;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.ImageIndex = 4;
            this.btnsil.ImageList = this.ımageList1;
            this.btnsil.Location = new System.Drawing.Point(380, 25);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(82, 64);
            this.btnsil.TabIndex = 59;
            this.btnsil.Text = "Sil";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // comboAraclar
            // 
            this.comboAraclar.FormattingEnabled = true;
            this.comboAraclar.Items.AddRange(new object[] {
            "Tum Araclar",
            "Bos Araclar",
            "Dolu Araclar"});
            this.comboAraclar.Location = new System.Drawing.Point(783, 48);
            this.comboAraclar.Name = "comboAraclar";
            this.comboAraclar.Size = new System.Drawing.Size(121, 21);
            this.comboAraclar.TabIndex = 58;
            this.comboAraclar.SelectedIndexChanged += new System.EventHandler(this.comboAraclar_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 320);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 24);
            this.label9.TabIndex = 63;
            this.label9.Text = "RentaCar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList2;
            this.button1.Location = new System.Drawing.Point(866, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 35);
            this.button1.TabIndex = 61;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "back_icon.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 3;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(310, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 72);
            this.button2.TabIndex = 64;
            this.button2.Text = "resim \r\nekle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(428, 432);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 266);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 432);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Rent_Car_Proje_Veritabani.Properties.Resources.car_icon;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 49);
            this.panel1.TabIndex = 1;
            // 
            // formAracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(919, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.comboAraclar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnguncelle);
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
            this.Name = "formAracListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formAracListele";
            this.Load += new System.EventHandler(this.formAracListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguncelle;
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
        private System.Windows.Forms.TextBox yiltxt;
        private System.Windows.Forms.ComboBox yakitcombo;
        private System.Windows.Forms.ComboBox sericombo;
        private System.Windows.Forms.ComboBox markacombo;
        private System.Windows.Forms.TextBox plakatxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.ComboBox comboAraclar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Panel panel1;
    }
}