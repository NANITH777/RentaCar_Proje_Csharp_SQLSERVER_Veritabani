namespace Rent_Car_Proje_Veritabani
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtkullanici = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "rentacar_icon.png");
            this.ımageList1.Images.SetKeyName(1, "car_icon.png");
            this.ımageList1.Images.SetKeyName(2, "login_icon.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 382);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Macerayı yaşayın";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Araba kiralayın";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "RentaCar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(345, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "LOGIN";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(487, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Musteri"});
            this.comboBox1.Location = new System.Drawing.Point(316, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(266, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Rol";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.White;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnlogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlogin.ImageIndex = 2;
            this.btnlogin.ImageList = this.ımageList1;
            this.btnlogin.Location = new System.Drawing.Point(350, 296);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(82, 74);
            this.btnlogin.TabIndex = 19;
            this.btnlogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsifre.Location = new System.Drawing.Point(316, 268);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(165, 22);
            this.txtsifre.TabIndex = 18;
            // 
            // txtkullanici
            // 
            this.txtkullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkullanici.Location = new System.Drawing.Point(317, 233);
            this.txtkullanici.Name = "txtkullanici";
            this.txtkullanici.Size = new System.Drawing.Size(164, 22);
            this.txtkullanici.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(264, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sifre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(236, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kullanici";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::Rent_Car_Proje_Veritabani.Properties.Resources._15860335521644989902_641;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(339, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(106, 100);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Rent_Car_Proje_Veritabani.Properties.Resources.bg3;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(40, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 147);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Rent_Car_Proje_Veritabani.Properties.Resources.car_icon;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 49);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(520, 382);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullanici);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentaCar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtkullanici;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

