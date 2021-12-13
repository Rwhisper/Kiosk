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
        public int take;
        List<Order> _orderList;
        public List<Order> orderLsit { get { return _orderList; } set { _orderList = value; } }
        public int cnt { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            int sumPrice = 0;
            if (_orderList.Count > 0)
            {                
                foreach(var order in _orderList)
                {
                    takeGdView.Rows.Add(cnt, order.ItemName, order.Price, order.Count);
                    sumPrice += order.Price;
                }
                
            }
            if(take == 1)
            {
                takeLbl.Text = "포장";
            }
            else
            {
                takeLbl.Text = "매장";
            }

            sumPriceLbl.Text = "총금액 : " + sumPrice.ToString();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

      
    }
}
