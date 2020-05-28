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
    public partial class Form3 : Form
    {
        OrderService oc;
        int OrderNum;
        public bool isComplete=false;
        public Form3(OrderService Oc)
        {
            InitializeComponent();
            oc = Oc;
            

        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out OrderNum);
            if (oc.FindOrder(OrderNum) == null) {

                MessageBox.Show("订单不存在");

            }
            else{
                //

                string Itemname = textBox4.Text;

                int Itemnum =0 ;
                if(int.TryParse(textBox5.Text, out int itemnum))
                { Itemnum = itemnum; }
                 else
                { MessageBox.Show("非法输入！"); }
                Double Itemprice = 0;
                if (Double.TryParse(textBox6.Text, out Double price))
                { Itemprice = price; }
                else
                { MessageBox.Show("非法输入！"); }

                Item NewItem = new Item()
                {
                    ItemName = Itemname,
                    ItemNum = Itemnum,
                    Perprice = Itemprice
                };
                oc.FindOrder(OrderNum).itemAdd(NewItem);
                isComplete = true;
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
