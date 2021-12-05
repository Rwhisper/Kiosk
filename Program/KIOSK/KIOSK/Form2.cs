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

        //Dictionary<int, Item> _items = new Dictionary<int, Item>(); 
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
        private void SelectItem(int i)
        {
            Item item = new Item();
                       
            switch (i)
            {
                case 1:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 2:
                    item.ItemName = "카페라떼";
                    item.Price = 3000;
                    break;
                case 3:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 4:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 5:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 6:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 7:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 8:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 9:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 10:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 11:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 12:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 13:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 14:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 15:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 16:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 17:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 18:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 19:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 20:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 21:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 22:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 23:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                case 24:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
                default:
                    item.ItemName = "아메리카노";
                    item.Price = 2500;
                    break;
            }
            SearchAndAdd(item);

            //if (_items.ContainsKey(i))
            //{
            //    if (_items.TryGetValue(i, out Item item))
            //    {
            //        item.Price += price;
            //        item.Count += 1;
            //    }               
            //}
            //else
            //{
            //    Item item = new Item();
            //    item.ItemName = s;
            //    item.Price = price;
            //    item.Count = 1;
            //    item.ItemName = "아메리카노";
            //    _items.Add(i, item);
            //    MessageBox.Show("추가 완료");
            //    AddDataInTable();
            //}

        }
      
        /// <summary>
        /// GridView에서 아이템을 검색해서 존재하면 
        /// </summary>
        /// <param name="item"></param>
        private void SearchAndAdd(Item item)
        {
            if (this.orderDGView.RowCount != 0)
            {
                for (int i = 0; i < this.orderDGView.RowCount; i++)
                {
                    if(orderDGView.Rows[i].Cells[0].Value != null)
                    {
                        MessageBox.Show(orderDGView.Rows[i].Cells[0].Value.ToString());
                        if (orderDGView.Rows[i].Cells[0].Value.ToString() == item.ItemName)
                        {
                            int price = 0;
                            int count = 0;
                            price = Convert.ToInt32(orderDGView.Rows[i].Cells[1].Value);
                            count = Convert.ToInt32(orderDGView.Rows[i].Cells[2].Value);

                            orderDGView.Rows[i].Cells[1].Value = price + item.Price;
                            orderDGView.Rows[i].Cells[2].Value = count + 1;
                            return;
                        }
                    }                    
                }
            }
           
            orderDGView.Rows.Add(item.ItemName, item.Price, 1);

        }
        //private void AddDataInTable()
        //{

        //    //DataTable table = new DataTable();
        //    //table. = orderDGView.Columns;
        //    foreach(Item i in _items.Values)
        //    {
        //        MessageBox.Show("여기까지 됨" + i.ItemName +  i.Price + i.Count);
        //        orderDGView.Rows.Add(i.ItemName, i.Price, i.Count);
        //    }
        //    //orderDGView.DataSource = table;

        //}
        private void coffeePtBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("아메리카노를 주문하시겟습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SelectItem(1);
            }
        }
        private void coffeePtBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("카페라떼를 주문하시겟습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SelectItem(2);
            }
        }
        private void coffeePtBox3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void tabCoffee_Click(object sender, EventArgs e)
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

        private void coffeePtBox8_Click(object sender, EventArgs e)
        {

        }

        private void orderDGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
