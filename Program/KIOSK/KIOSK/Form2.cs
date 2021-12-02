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

        Dictionary<int, Item> _items = new Dictionary<int, Item>(); 
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
            string s;
            int price;
            switch (i)
            {
                case 1:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 2:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 3:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 4:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 5:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 6:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 7:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 8:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 9:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 10:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 11:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 12:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 13:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 14:s = "아메리카노";
                    price = 2500;
                    break;
                case 15:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 16:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 17:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 18:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 19:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 20:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 21:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 22:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 23:
                    s = "아메리카노";
                    price = 2500;
                    break;
                case 24:
                    s = "아메리카노";
                    price = 2500;
                    break;
                default:
                    s = "";
                    price = 0;
                    break;
            }

            if (_items.ContainsKey(i))
            {
                if (_items.TryGetValue(i, out Item item))
                {
                    item.Price += price;
                    item.Count += 1;
                }               
            }
            else
            {
                Item item = new Item();
                item.ItemName = s;
                item.Price = price;
                item.Count = 1;
                item.ItemName = "아메리카노";
                _items.Add(i, item);
                MessageBox.Show("추가 완료");
            }
            AddDataInTable();
        }
        private void coffeePtBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("아메리카노를 주문하시겟습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SelectItem(1);
            }            
        }
        private void AddDataInTable()
        {
            
            DataTable table = new DataTable();
            foreach(Item i in _items.Values)
            {
                MessageBox.Show("여기까지 됨" + i.ItemName +  i.Price + i.Count);
                table.Rows.Add(i.ItemName, i.Price, i.Count);
            }
            orderDGView.DataSource = table;

        }

        private void coffeePtBox2_Click(object sender, EventArgs e)
        {

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
