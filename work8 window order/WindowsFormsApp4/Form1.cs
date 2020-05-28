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
    public partial class Form1 : Form
    {
        OrderService mainos = new OrderService();
        public OrderService Mainos{ get { return mainos; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.ShowDialog();
            mainos.TotalOrder.Add(form2.Neworder);
            orderBindingSource.DataSource = mainos.TotalOrder;
            orderBindingSource.ResetBindings(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainos.TotalOrder.Count == 0)
            { MessageBox.Show("没有订单可以删除"); }
            else
            {
                bool isfind=false;
                int a;
                int.TryParse(textBox1.Text, out a);
                foreach (Order od in mainos.TotalOrder) {
                    if (od.OrderNumber == a) {
                        isfind = true;
                        break;
                    }
                }
                if (isfind)
                {
                    mainos.DelectOrder(a);
                    orderBindingSource.DataSource = mainos.TotalOrder;
                    orderBindingSource.ResetBindings(true);
                }
                else {

                    MessageBox.Show("找不到对应订单");
                }
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(mainos);
            form3.ShowDialog();
            while (form3.isComplete == true) {

                orderBindingSource.DataSource = mainos.TotalOrder;
                orderBindingSource.ResetBindings(true);
                break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int No = 0;
            if (int.TryParse(textBox2.Text, out int no))
            { No = no;
                orderBindingSource.DataSource = mainos.FindOrder(No);


            }
            else
            { MessageBox.Show("非法输入！"); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
