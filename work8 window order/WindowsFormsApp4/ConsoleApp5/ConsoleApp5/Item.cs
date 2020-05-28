using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
   
    
        [Serializable]
        public class Item
        {
            private string itemName;
            private int itemNum;
            private double perprice;
            public string ItemName
            {
                set { itemName = value; }
                get { return itemName; }
            }
            public int ItemNum
            {
                set { itemNum = value; }
                get { return itemNum; }
            }
            public double Perprice
            {
                set { perprice = value; }
                get { return perprice; }
            }
            public double ItemTotalPirce
            {
                get { return perprice * itemNum; }
            }
            public override bool Equals(object obj)
            {
                if (!(obj is Item)) { throw new System.ArgumentException(); }
                Item rec = obj as Item;
                return (rec.ItemName == ItemName);
            }
            public override string ToString()
            {
                return ("商品名：" + ItemName + "。" + Environment.NewLine + "商品数：" + ItemNum + Environment.NewLine + "单价：" + perprice);
            }
        }
    }

