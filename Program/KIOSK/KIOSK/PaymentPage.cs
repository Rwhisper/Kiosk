using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIOSK
{
    public partial class PaymentPage : Form
    {
        public PaymentPage()
        {
            InitializeComponent();
        }
        int cnt;
        private void PaymentPage_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
       

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cnt += 1;
            if (cnt > 30 && cnt <= 40)
            {
                titleLbl.Text = "결제중.";
            }
            else if(cnt > 40 && cnt <= 50)
            {
                titleLbl.Text = "결제중..";
            }
            else if (cnt > 50 && cnt <= 60)
            {
                titleLbl.Text = "결제중...";
            }
            else if (cnt > 60 && cnt <= 70)
            {
                titleLbl.Text = "결제되었습니다.";
            }
            else if ( cnt > 70)
            {
                timer1.Enabled = false;

                if (MessageBox.Show("영수증을 출력하시겟습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                }

                this.Close();
            }
        }
    }
}
