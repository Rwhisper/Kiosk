using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeProgram
{
    public class Order
    {
        public string ItemName;
        public int Price;
        public int Count;
		public string CardCode;
        public Order()
        {

        }
        Order(string itemName, int price, int count, int no, string CardCode)
        {
            this.ItemName = itemName;
            this.Price = price;
            this.Count = count;
			this.CardCode = CardCode;
        }
        	public void Read(ArraySegment<byte> segment, ref ushort count)
		{
			ushort ItemNameLen = BitConverter.ToUInt16(segment.Array, segment.Offset + count);
			count += sizeof(ushort);
			this.ItemName = Encoding.Unicode.GetString(segment.Array, segment.Offset + count, ItemNameLen);
			count += ItemNameLen;			
			this.Price = BitConverter.ToInt32(segment.Array, segment.Offset + count);
			count += sizeof(int);
			this.Count = BitConverter.ToInt32(segment.Array, segment.Offset + count);
			count += sizeof(int);
			ushort CardCodeeLen = BitConverter.ToUInt16(segment.Array, segment.Offset + count);
			count += sizeof(ushort);
			this.CardCode = Encoding.Unicode.GetString(segment.Array, segment.Offset + count, CardCodeeLen);
			count += CardCodeeLen;
		}
	
		public bool Write(ArraySegment<byte> segment, ref ushort count)
		{
			bool success = true;			
			
			ushort itemNameLen = (ushort)Encoding.Unicode.GetBytes(this.ItemName, 0, this.ItemName.Length, segment.Array, segment.Offset + count + sizeof(ushort));
			Array.Copy(BitConverter.GetBytes(itemNameLen), 0, segment.Array, segment.Offset + count, sizeof(ushort));
			count += sizeof(ushort);
			count += itemNameLen;
			Array.Copy(BitConverter.GetBytes(this.Price), 0, segment.Array, segment.Offset + count, sizeof(int));
			count += sizeof(int);
			Array.Copy(BitConverter.GetBytes(this.Count), 0, segment.Array, segment.Offset + count, sizeof(int));
			count += sizeof(int);
			ushort CardCodeLen = (ushort)Encoding.Unicode.GetBytes(this.CardCode, 0, this.CardCode.Length, segment.Array, segment.Offset + count + sizeof(ushort));
			Array.Copy(BitConverter.GetBytes(CardCodeLen), 0, segment.Array, segment.Offset + count, sizeof(ushort));
			count += sizeof(ushort);
			count += CardCodeLen;

			return success;
		}	

    }
}
