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
    public partial class messageBoxform : Form
    {
        public messageBoxform()
        {
            InitializeComponent();
        }

        public static DialogResult Show(string Text)
        {
            messageBoxform messageBox = new messageBoxform();
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
