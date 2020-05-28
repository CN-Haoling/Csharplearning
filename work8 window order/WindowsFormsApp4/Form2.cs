using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp5;
namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Order Neworder;
        static int OrderNo = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            List<Item> allItem = new List<Item>();
            Customer a = new Customer() { CustomerName = textBox1.Text };
            
            
            int Ordernum = ++OrderNo;

                string Itemname = textBox2.Text;
                int Itemnum=0;
            if (int.TryParse(textBox3.Text, out int itemnum))
                { Itemnum = itemnum; }
            else
                { MessageBox.Show("非法输入！"); }
            Double Itemprice=0;
            if (Double.TryParse(textBox4.Text, out Double price))
            { Itemprice = price; }
            else
            { MessageBox.Show("非法输入！"); }


            Item NewItem = new Item()
                {
                    ItemName = Itemname,
                    ItemNum = Itemnum,
                    Perprice = Itemprice

                };
                allItem.Add(NewItem);
           
            Order t = new Order()
            {
                OrderNumber = Ordernum,
                Customer = a,
                Item = allItem,
                CustomerName=a.CustomerName
            };
            Neworder = t;

            MessageBox.Show("该商品添加完成，该订单的订单号为：" + Ordernum);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
