using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        int statOfCacu;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_clk_1_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double.TryParse(textBox_insert1.Text, out num1);
            double.TryParse(textBox_insert2.Text, out num2);
            if (!double.TryParse(textBox_insert1.Text, out num1) && !double.TryParse(textBox_insert2.Text, out num2))
                textBox_result.Text = "invalid input";

            switch (statOfCacu) {
                case 1:
                    textBox_result.Text = $"{num1 + num2}";
                    break;
                case 2:
                    textBox_result.Text = $"{num1 - num2}";
                    break;
                case 3:
                    textBox_result.Text = $"{num1 * num2}";
                    break;
                case 4:
                    if (num2 != 0)
                        textBox_result.Text = $"{num1 / num2}";
                    else
                        textBox_result.Text = "invalid input";
                    break;
                  



            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            statOfCacu = 1;
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            statOfCacu = 2;
        }

        private void button_mut_Click(object sender, EventArgs e)
        {
            statOfCacu = 3;
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            statOfCacu = 4;
        }
    }


}
