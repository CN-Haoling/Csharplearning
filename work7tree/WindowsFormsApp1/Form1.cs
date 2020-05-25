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
        public Form1()
        {
            InitializeComponent();
        }


 
        private Graphics graphics;
        int Depth;
        double leng;
        double th1;
        double th2;
        double per1;
        double per2;
        Pen pen;
        void drawCayleyTree(int n,double x0,double y0,double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {  
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(dep.Text, out Depth))
            {   
                MessageBox.Show("Invalid Depth");
                dep.Text = null;
                if(Depth>=20) MessageBox.Show("Depth should be less than 20"); 
            }
            if (!Double.TryParse(len.Text, out leng))
            {
                MessageBox.Show("Invalid Length");
                len.Text = null;
            }
            if (!Double.TryParse(ragl.Text, out th1))
            {
                MessageBox.Show("Invalid RightAngle");
                ragl.Text = null;
            }
            else
            {
                th1 = th1 * Math.PI / 180;
            }
            if (!Double.TryParse(lagl.Text, out th2))
            {
                MessageBox.Show("Invalid LeftAngle");
                if (graphics != null)
                    graphics.Clear(BackColor);
                lagl.Text = null;
            }
            else
            {
                th2 = th2 * Math.PI / 180;
            }
            if (!Double.TryParse(rlen.Text, out per1) || per1 > 1.0)
            {
                MessageBox.Show("RightLength MUST less then 1.0");
                rlen.Text = null;
            }
            if (!Double.TryParse(Llen.Text, out per2) || per2 > 1.0)
            {
                MessageBox.Show("LeftLength MUST less then 1.0");
                Llen.Text = null;
            }
            if (ColorCheck.Text == "RED") { pen = Pens.Red; }
            else if (ColorCheck.Text == "GREEN") { pen = Pens.Green; }
            else { pen = Pens.Blue; }
            if (graphics == null) graphics = panel1.CreateGraphics();
            else graphics.Clear(BackColor);
            drawCayleyTree(Depth, 200, 310, leng, -Math.PI / 2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}

