using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeProgram
{
    public class Order
    {
        private string _ItemName;
        private int _Price;
        private int _Count;
        private int _No;

        public string ItemName { get { return _ItemName; } set { _ItemName = value; } }
        public int Price { get { return _Price; } set { _Price = value; } }
        public int Count { get { return _Count; } set { _Count = value; } }
        public int No { get { return _No; } set { _No = value; } }

        Order()
        {

        }

        Order(string itemName, int price, int count, int no)
        {
            this.ItemName = itemName;
            this.Price = price;
            this.Count = count;
            this.No = no;
        }
    }
}
