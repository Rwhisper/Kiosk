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
        public Form2(List<Item> items)
        {
            int cnt = 0;
            InitializeComponent();
            tabCoffee.AutoScroll = true;
            if (items == null)
                return;
            foreach (var item in items)
            {
                DataGridViewButtonCell delBtn = new DataGridViewButtonCell();
                DataGridViewButtonCell addBtn = new DataGridViewButtonCell();
                orderDGView.Rows.Add(item.ItemName, item.Price, null, 1, null);
                orderDGView.Rows[cnt].Cells[2] = addBtn;
                orderDGView.Rows[cnt].Cells[2].Value = "▲";
                orderDGView.Rows[cnt].Cells[4] = delBtn;
                orderDGView.Rows[cnt].Cells[4].Value = "▼";
                cnt++;
            }
            SumPriceInsert();

        }
        private Point mousePoint;
        List<Item> itemList;
        List<Item> items;
        private void Form2_Load(object sender, EventArgs e)
        {
            items = new List<Item>()
            {
                new Item { ItemName = "아메리카노", Price = 2500 },
                new Item { ItemName = "카페라떼", Price = 2500 },
                new Item { ItemName = "바닐라라떼", Price = 2500 },
                new Item { ItemName = "에스프레소", Price = 2500 },
                new Item { ItemName = "돌체 콜드 브루", Price = 2500 },
                new Item { ItemName = "바닐라 크림 콜드 브루", Price = 2500 },
                new Item { ItemName = "돌체 라떼", Price = 2500 },
                new Item { ItemName = "콜드 브루", Price = 2500 },
                new Item { ItemName = "카페모카", Price = 2500 },
                new Item { ItemName = "카푸치노", Price = 2500 },
                new Item { ItemName = "토피넛 라떼", Price = 2500 },
                new Item { ItemName = "화이트 초콜릿 모카", Price = 2500 },

                new Item { ItemName = "자몽에이드", Price = 2500 },
                new Item { ItemName = "쿨 라임 피지오", Price = 2500 },
                new Item { ItemName = "민트 초콜릿 블렌디드", Price = 2500 },
                new Item { ItemName = "피치 레몬 블렌디드", Price = 2500 },
                new Item { ItemName = "패션 티 레모네이드", Price = 2500 },
                new Item { ItemName = "블랙 티 레모네이드", Price = 2500 },
                new Item { ItemName = "딸기 딜라이트 요거트", Price = 2500 },
                new Item { ItemName = "민트 초코칩 블렌디드", Price = 2500 },
                new Item { ItemName = "자몽에이드", Price = 2500 },
                new Item { ItemName = "자몽에이드", Price = 2500 },
                new Item { ItemName = "자몽에이드", Price = 2500 },
                new Item { ItemName = "자몽에이드", Price = 2500 },

                new Item { ItemName = "모카 프라푸치노", Price = 2500 },
                new Item { ItemName = "자바칩 프라푸치노", Price = 2500 },
                new Item { ItemName = "초코칩 프라푸치노", Price = 2500 },
                new Item { ItemName = "타이거 프라푸치노", Price = 2500 },
                new Item { ItemName = "자몽에이드", Price = 2500 },
                new Item { ItemName = "자몽에이드", Price = 2500 },
                new Item { ItemName = "자몽에이드", Price = 2500 },
                new Item { ItemName = "자몽에이드", Price = 2500 },
                new Item { ItemName = "자몽에이드", Price = 2500 },
                new Item { ItemName = "자몽에이드", Price = 2500 },
                new Item { ItemName = "자몽에이드", Price = 2500 },
                new Item { ItemName = "자몽에이드", Price = 2500 },

                new Item { ItemName = "라임 패션 티", Price = 2500 },
                new Item { ItemName = "민트 블렌디드 티", Price = 2500 },
                new Item { ItemName = "얼그레이 티", Price = 2500 },
                new Item { ItemName = "유스베리 티", Price = 2500 },
                new Item { ItemName = "유자 민트 티", Price = 2500 },
                new Item { ItemName = "자몽 허니 블랙 티", Price = 2500 },
                new Item { ItemName = "제주 카멜리아 티", Price = 2500 },
                new Item { ItemName = "푸를 청귤 민트 티", Price = 2500 },
                new Item { ItemName = "자몽 허니 블랙 티 Hot", Price = 2500 },
                new Item { ItemName = "제주 유기 녹차", Price = 2500 },
                new Item { ItemName = "캐모마일 블랜디드 티", Price = 2500 },
                new Item { ItemName = "패션 프루트 티", Price = 2500 },
            };
            // 주문할때 넘겨줄 itemList
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
        private List<Item> GetItems()
        {
            itemList.Clear();
            if (this.orderDGView.RowCount != 0)
            {
                for (int i = 0; i < this.orderDGView.RowCount; i++)
                {
                    Item item = new Item();
                    if (orderDGView.Rows[i].Cells[0].Value != null)
                    {
                        item.ItemName = orderDGView.Rows[i].Cells[0].Value.ToString();
                        item.Price = Convert.ToInt32(orderDGView.Rows[i].Cells[1].Value);
                        item.Count = Convert.ToInt32(orderDGView.Rows[i].Cells[3].Value);

                        itemList.Add(item);

                    }
                    else { return null; }

                }
                return itemList;

            }
            else
            {
                return null;
            }
            
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            Form3 showForm3 = new Form3(GetItems());
            showForm3.ShowDialog();

        }
        private void SelectItem(int i)
        {
            Item item = items[i-1]; 
            SearchAndAdd(item);
            SumPriceInsert();
        }
        private void SearchAndAdd(Item item)
        {
            int cnt = 0;
            if(this.orderDGView.RowCount != 0)
            {
                for(int i =0; i< this.orderDGView.RowCount; i++)
                {
                    if (orderDGView.Rows[i].Cells[0].Value != null)
                    {
                       
                        if (orderDGView.Rows[i].Cells[0].Value.ToString() == item.ItemName)
                        {
                            int price = 0;
                            int count = 0;
                            price = Convert.ToInt32(orderDGView.Rows[i].Cells[1].Value);
                            count = Convert.ToInt32(orderDGView.Rows[i].Cells[3].Value);

                            orderDGView.Rows[i].Cells[1].Value = price+ item.Price;
                            orderDGView.Rows[i].Cells[3].Value = count + 1;
                            
                            return;
                        }
                    }
                    cnt = i+1;
                }
                
            }
            DataGridViewButtonCell delBtn = new DataGridViewButtonCell();
            DataGridViewButtonCell addBtn = new DataGridViewButtonCell();
            orderDGView.Rows.Add(item.ItemName, item.Price, null, 1, null);
            orderDGView.Rows[cnt].Cells[2] = addBtn;
            orderDGView.Rows[cnt].Cells[2].Value = "▲";
            orderDGView.Rows[cnt].Cells[4] = delBtn;
            orderDGView.Rows[cnt].Cells[4].Value = "▼";
            
        }
      
        //private void AddDataInTable()
        //{
            
        //    DataTable table = new DataTable();
        //    foreach(Item i in _items.Values)
        //    {
        //        MessageBox.Show("여기까지 됨" + i.ItemName +  i.Price + i.Count);
        //        table.Rows.Add(i.ItemName, i.Price, i.Count);
        //    }
        //    orderDGView.DataSource = table;

        //}
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void tabCoffee_Click(object sender, EventArgs e)
        {

        }
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
            if (MessageBox.Show("바닐라라떼를 주문하시겟습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SelectItem(3);
            }
        }
        private void coffeePtBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("에스프레소를 주문하시겟습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SelectItem(4);
            }
        }
        private void coffeePtBox5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("돌체 콜드 브루를 주문하시겟습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SelectItem(5);
            }
        }
        private void coffeePtBox6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("바닐라 크림 콜드 브루를 주문하시겟습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SelectItem(6);
            }
        }
        private void coffeePtBox7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("돌체 라떼를 주문하시겟습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SelectItem(7);
            }
        }
        private void coffeePtBox8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("콜드 브루를 주문하시겟습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SelectItem(8);
            }
        }
        private void coffeePtBox9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("카페모카를 주문하시겟습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SelectItem(9);
            }
        }
        private void coffeePtBox10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("카푸치노를 주문하시겟습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SelectItem(10);
            }
            AddDataInTable();
        }
        private void coffeePtBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("토피넛라떼를 주문하시겟습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SelectItem(11);
            }
        }
        private void coffeePtBox12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("화이트 초콜릿 모카를 주문하시겟습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SelectItem(12);
            }
        }

        private void sfPtBox12_Click(object sender, EventArgs e)
        {
          
        }

        private void SumPriceInsert()
        {
            int sum = 0;
            if(this.orderDGView.RowCount == 0)
            {
                sumPriceLbl.Text = "총 금액 : " + 0;
                return;
            }
            for(int i = 0; i < orderDGView.RowCount; i++)
            {
                sum += Convert.ToInt32(orderDGView.Rows[i].Cells[1].Value);
            }
            sumPriceLbl.Text = "총 금액 : " + sum;
        }
        private void orderDGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(orderDGView.Columns[e.ColumnIndex].ToString());
            //MessageBox.Show(orderDGView.Columns[e.RowIndex].ToString());
            //MessageBox.Show(e.ColumnIndex.ToString());
            //MessageBox.Show(e.RowIndex.ToString());
            if(e.ColumnIndex == 2)
            {
                int price = Convert.ToInt32(orderDGView.Rows[e.RowIndex].Cells[1].Value);
                int count = Convert.ToInt32(orderDGView.Rows[e.RowIndex].Cells[3].Value);

                orderDGView.Rows[e.RowIndex].Cells[1].Value = price + (price / count);
                orderDGView.Rows[e.RowIndex].Cells[3].Value = count + 1;
            }
            else if(e.ColumnIndex == 4)
            {
                int price = Convert.ToInt32(orderDGView.Rows[e.RowIndex].Cells[1].Value);
                int count = Convert.ToInt32(orderDGView.Rows[e.RowIndex].Cells[3].Value);
                if ((count-1) == 0)
                {
                    if (MessageBox.Show("현재 품목을 장바구니에서 제거하시겟습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        orderDGView.Rows.RemoveAt(e.RowIndex);
                        SumPriceInsert();
                    }

                    return;
                }                    
                orderDGView.Rows[e.RowIndex].Cells[1].Value = price - (price / count);
                orderDGView.Rows[e.RowIndex].Cells[3].Value = count - 1;
            }
            SumPriceInsert();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (this.orderDGView.RowCount == 0)
                return;
            if (MessageBox.Show("전체 품목을 삭제하시겟습니까??", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = this.orderDGView.RowCount - 1; i >= 0; i--)
                {
                    this.orderDGView.Rows.RemoveAt(i);
                }
            }
           
           
        }
    }
}
