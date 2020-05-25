using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ConsoleApp4
{
    class shape
    {
        public virtual double circult {
            get;
            set;
        }
        public virtual double area {
            get;
            set;
        }
        public virtual string Shape
        {
            get;
            set;
        }
    }
    class rect : shape
    {
        private double circult;
        private double area;
        private string Shape = "rect";
        private double Long
        {
            get;
            set;
        }
        private double Short
        {
            get;
            set;
        }
        public rect(double x, double y)
        {
            this.circult = 2 * x + 2 * y;
            this.area = x * y;
            if (x > y)
            {
                this.Long = x;
                this.Short = y;
            }
            else
            {
                this.Long = y;
                this.Short = x;
            }
            if (x <= 0 || y <= 0)
            {
                Console.WriteLine("invalid! You must input two positive number");
                this.circult = 0;
                this.area = 0;
                this.Shape = "invalid shape";
            }
        }

        public override string ToString()
        {
            return " Shape = " + Shape + " circult = " + circult + ", area = " + area;
        }
    }
    class round : shape
    { double pai = 3.14;
        private double circult;
        private double area;
        private string Shape = "Round";
        private double radius
        {
            get;
            set;
        }
        public round(double x)
        {
            this.radius = x;
            circult = 2 * pai * x;
            area = pai * x * x;
            if (x <= 0)
            {
                Console.WriteLine("invalid! You must input two positive number");
                this.circult = 0;
                this.area = 0;
                this.Shape = "invalid shape";
            }
        }
        public override string ToString()
        {
            return " Shape = " + Shape + " circult = " + circult + ", area = " + area;
        }
    }
    class triangle : shape
    {
        double pi = 3.14;
        private double area;
        private string Shape = "triangle";
        private double height;
        private double underline;

        public triangle(double underline, double height)
        {
            this.underline = underline;
            this.height = height;

            area = underline * height/2;
            if (underline <= 0 || height <= 0)
            {
                Console.WriteLine("invalid! You must input two positive number");
                this.circult = 0;
                this.area = 0;
                this.Shape = "invalid shape";
            }
        }
        public override string ToString()
        {
            return " Shape = " + Shape + ", underline = " + underline + ", height = " + height +  ", area = " + area;
        }
    }
    class ShapeFactory
    {
        public shape CreateShape(int type)
        {
            shape Shape = null;
            Random rd = new Random(), rj = new Random();

            double i = rd.NextDouble() * 10;
            Thread.Sleep(10);
            double j = rd.NextDouble() * 10;
            Thread.Sleep(10);
            double k = rd.NextDouble() * 10;
            Thread.Sleep(10);
            switch (type)
            {
                case 1:
                    Shape = new rect(i, j);
                    break;
                case 2:
                    Shape = new round(i);
                    break;
                case 3:
                    Shape = new triangle(i, j);
                    break;
            }

            return Shape;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            rect A = new rect(3, 5);
            Console.WriteLine("rect Info:- {0}", A);

            Random rtype = new Random();
            for (int j = 0; j < 10; j++) { 
            int type = rtype.Next(1, 4);
            shape myshape = new ShapeFactory().CreateShape(type);
            Console.WriteLine("shape Info:- {0}", myshape); }
            Console.ReadKey();
        }
    }
} 

