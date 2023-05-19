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
    public partial class messageBoxform2 : Form
    {
        public messageBoxform2()
        {
            InitializeComponent();
        }

        public static DialogResult Show(string Text)
        {
            messageBoxform2 messageBox = new messageBoxform2();
            messageBox.lbltext.Text = Text;
            messageBox.ShowDialog();

            return messageBox.DialogResult;
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
