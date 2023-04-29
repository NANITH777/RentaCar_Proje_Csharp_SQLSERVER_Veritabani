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
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnmusteri = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "RentaCar Firmamiza \r\n        HOSGELDINIZ";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "adminicon.jpeg");
            this.ımageList1.Images.SetKeyName(1, "admin_icon.jpeg");
            this.ımageList1.Images.SetKeyName(2, "client_icon.jpeg");
            this.ımageList1.Images.SetKeyName(3, "admincon2.jpeg");
            this.ımageList1.Images.SetKeyName(4, "admincon.jpeg");
            this.ımageList1.Images.SetKeyName(5, "adcon1.jpeg");
            // 
            // btnmusteri
            // 
            this.btnmusteri.BackColor = System.Drawing.Color.White;
            this.btnmusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmusteri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmusteri.ImageIndex = 2;
            this.btnmusteri.ImageList = this.ımageList1;
            this.btnmusteri.Location = new System.Drawing.Point(264, 283);
            this.btnmusteri.Name = "btnmusteri";
            this.btnmusteri.Size = new System.Drawing.Size(162, 106);
            this.btnmusteri.TabIndex = 4;
            this.btnmusteri.Text = "MUSTERI";
            this.btnmusteri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmusteri.UseVisualStyleBackColor = false;
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.Color.White;
            this.btnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmin.ImageIndex = 0;
            this.btnadmin.ImageList = this.ımageList1;
            this.btnadmin.Location = new System.Drawing.Point(22, 283);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(151, 106);
            this.btnadmin.TabIndex = 3;
            this.btnadmin.Text = "ADMIN";
            this.btnadmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmusteri);
            this.Controls.Add(this.btnadmin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentaCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnmusteri;
        private System.Windows.Forms.Button btnadmin;
    }
}

