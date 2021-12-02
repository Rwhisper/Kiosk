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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            tabCoffee.AutoScroll = true;


        }
        private Point mousePoint;
        List<Item> itemList;
        private void Form2_Load(object sender, EventArgs e)
        {
            itemList = new List<Item>();
        }
        private void tapAde_Click(object sender, EventArgs e)
        {

        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //지금 윈도우의 좌표저장 }           
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                Location = new Point(this.Left - x, this.Top - y);
            }
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 showForm3 = new Form3();
            showForm3.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void coffeePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabCoffee_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void coffeePtBox12_Click(object sender, EventArgs e)
        {

        }

        private void coffeePtBox2_Click(object sender, EventArgs e)
        {

        }

        private void sfPtBox12_Click(object sender, EventArgs e)
        {

        }

        private void teaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void coffeePanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
