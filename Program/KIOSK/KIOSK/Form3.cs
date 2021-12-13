using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIOSK
{
    public partial class Form3 : Form
    {
        List<Item> _items;
        C_OrderList orderListpkt;
        Socket socket;
        public Form3(List<Item> items)
        {
            InitializeComponent();
            _items = items;
        }
   
        private void Form3_Load(object sender, EventArgs e)
        {
            int sum=0;
            int cnt = 0;
            orderListpkt = new C_OrderList();
            if (_items == null)
                return;
            foreach(var item in _items)
            {
                Order order = new Order();
                order.ItemName = item.ItemName;
                order.Price = item.Price;
                order.Count = item.Count;
                orderListpkt.orders.Add(order);

                orderGridView2.Rows.Add(item.ItemName, item.Price, item.Count, "▲", "▼");
                sum += item.Price;               

                cnt ++;
            }
            sumPriceLbl.Text = "총금액 : " + sum;
        }
      


        private Point mousePoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void sumPriceLbl_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2(_items);
            this.Hide();
            form2.ShowDialog();           
            this.Close();
        }

  

        private void SendOrder(int _take, string card_code)
        {
            orderListpkt.take = _take;
            for(int i = 0; i < orderListpkt.orders.Count; i++)
            {
                orderListpkt.orders[i].CardCode = card_code;
            }           
            Form1.session.Send(orderListpkt.Write());
        }
        private void paymentBtn_Click(object sender, EventArgs e)
        {
            if(storeRButton.Checked == true)
            {                
                //Order();
                PaymentPage payment = new PaymentPage();
                payment.ShowDialog();
                this.Hide();
                SendOrder(1, "1234-4567-1234-0000");

                Form1 form1 = new Form1();
                form1.ShowDialog();
              
                this.Close();
            }
            else if (packRButton.Checked == true)
            {
                //Order();
                PaymentPage payment = new PaymentPage();
                payment.ShowDialog();
                this.Hide();
                SendOrder(2, "1234-4567-1234-0000");

                Form1 form1 = new Form1();
                form1.ShowDialog();

                this.Close();

            }
            else
            {
                MessageBox.Show("포장, 매장 식사 중에 선택하여 주세요");
            }
        }
        


       
    }
}
