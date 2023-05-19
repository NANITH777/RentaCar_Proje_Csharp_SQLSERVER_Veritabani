namespace Rent_Car_Proje_Veritabani
{
    partial class messageBoxform2
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
            this.lbltext = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnok = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext.ForeColor = System.Drawing.Color.Black;
            this.lbltext.Location = new System.Drawing.Point(55, 27);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(40, 15);
            this.lbltext.TabIndex = 0;
            this.lbltext.Text = "[TEXT]";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 34);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RentaCar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbltext);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(33, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 91);
            this.panel1.TabIndex = 6;
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.White;
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.Black;
            this.btnok.Location = new System.Drawing.Point(113, 129);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(60, 40);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Rent_Car_Proje_Veritabani.Properties.Resources.car_icon;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(44, 31);
            this.panel3.TabIndex = 1;
            // 
            // messageBoxform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(316, 174);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "messageBoxform2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentaCar";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Panel panel3;
    }
}