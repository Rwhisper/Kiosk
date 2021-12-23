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
    public partial class Form1 : Form
    {
        public static Session session;

        public Form1() 
        {
            InitializeComponent();
        }
        private Point mousePoint;
        private void btn_Start_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Form4 form4;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            form4 = new Form4();
            this.Hide();
            if (session ==  null)
            {
                session = new Session();
                form4.ShowDialog();
            }
            
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 showForm2 = new Form2();
            showForm2.ShowDialog();
            this.Close();
        }
    }
}
