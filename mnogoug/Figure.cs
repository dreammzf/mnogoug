using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace mnogoug
{
    abstract class Figure
    {
        protected static int r;
        protected static Color clr;
        protected int x;
        protected int y;
        protected int dx;
        protected int dy;

        static Figure()
        {
            r = 30;
            clr = Color.Black;
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public int Dx
        {
            get
            {
                return dx;
            }
            set
            {
                dx = value;
            }
        }
        public int Dy
        {
            get
            {
                return dy;
            }
            set
            {
                dy = value;
            }
        }

        public bool beingDragged { get; set; }
        public bool isInside { get; set; }

        public static int R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }
        public static Color Clr
        {
            get
            {
                return clr;
            }
            set
            {
                clr = value;
            }
        }
        public abstract bool Check(int xm, int ym);
        public abstract void Draw(Graphics g);
    }

    class Circle : Figure
    {
        public Circle()
        {
            this.x = 50;
            this.y = 100;
        }
        public Circle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(clr), x - r, y - r, 2 * r, 2 * r);
        }
        public override bool Check(int xm, int ym)
        {
            double xx = Math.Pow(x - xm, 2);
            double yy = Math.Pow(y - ym, 2);
            if (xx + yy <= Math.Pow(2 * r / 2, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Square : Figure
    {
        public Square()
        {
            this.x = 50;
            this.y = 50;
        }
        public Square(int x, int y)
        {
            this.x = x - r;
            this.y = y - r;
        }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(clr), x, y, 2 * r, 2 * r);
        }
        public override bool Check(int xm, int ym)
        {
            if (x + 2 * r > xm && xm > x)
            {
                if (y + 2 * r > ym && ym > y)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
    class Triangle : Figure
    {
        public Triangle()
        {
            this.x = 50;
            this.y = 50;
        }
        public Triangle(int x, int y)
        {
            this.x = x - r;
            this.y = y;
        }
        public override void Draw(Graphics g)
        {
            Point[] p = { new Point(x + r, y - r), new Point(x, y + r), new Point(x + 2 * r, y + r) };
            g.FillPolygon(new SolidBrush(clr), p);
        }
        public override bool Check(int xm, int ym)
        {
            if (xm < x + 2 * r && xm > x && ym > y - r && ym < y + r)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}