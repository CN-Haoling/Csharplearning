using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp5
{

    /**
     **/
    public class Order
    {
        private String customername;
        private int orderNumber;
        private List<Item> item = new List<Item>();
        private Customer customer;

        public String CustomerName
        {
            set { customername = value; }
            get { return customername; }
        }

        public int OrderNumber
        {
            set { orderNumber = value; }
            get { return orderNumber; }
        }
        public Customer Customer
        {
            set { customer = value; }
            get { return customer; }
        }
        public List<Item> Item
        {
            set { item = value; }
            get { return item; }
        }
        public Item SearchItem(String ItemtoFind)
        {
            return Item.Where(s => s.ItemName == ItemtoFind).First() as Item;
        }
        public bool itemDel(string itemdel)
        {

            foreach (Item items in item)
            {
                if (items.ItemName == itemdel)
                {
                    item.Remove(items);
                    return true;

                }



            }
            return false;

        }
        public bool itemAdd(Item itemadd)
        {
            bool isadded = false;
            foreach (Item items in item)
            {
                if (items.ItemName == itemadd.ItemName)//当所要的商品已经存在时
                {
                    Console.WriteLine("已经增加" + itemadd.ItemNum + "个" + itemadd.ItemName);
                    var a = from b in item
                            where b.ItemName == itemadd.ItemName
                            select b;
                    Item SameItem = a.First() as Item;
                    SameItem.ItemNum += itemadd.ItemNum;
                    if (SameItem.ItemNum <= 0)
                    { item.Remove(SameItem); }
                    isadded = true;
                    return true;
                }

            }
            if (isadded == false)
            {
                item.Add(itemadd);
                return true;
            }
            return false;
        }

        
        public void ChangeCustomer(string NewName)
        {
            this.Customer.CustomerName = NewName;
        }
    }
}
