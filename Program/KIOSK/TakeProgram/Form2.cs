using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeProgram
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
        }
        List<Order> _orderList;
        public Form2(List<Order> orderList)
        {
            _orderList = orderList;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int sumPrice = 0;
            if (_orderList.Count > 0)
            {                
                foreach(var order in _orderList)
                {
                    takeGdView.Rows.Add(order.No, order.ItemName, order.Price, order.Count);
                    sumPrice += order.Count;
                }
            }
            sumPriceLbl.Text = sumPrice.ToString();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

      
    }
}
