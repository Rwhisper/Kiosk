using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIOSK
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void storeRButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            this.storeRButton.Checked = true;
        }

        private void packButton_Click(object sender, EventArgs e)
        {
            this.packRButton.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
