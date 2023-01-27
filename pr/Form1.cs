using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace demo
{
    public partial class Form1 : Form
    {
        bool draw;
        int a;
        List<Circle> versh = new List<Circle>();
        public Form1()
        {
            InitializeComponent();
            draw = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (versh.Any())
            {
                foreach (Circle fig in versh)
                {
                    fig.Draw(e.Graphics);
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (versh.Any())
            {
                foreach (Circle fig in versh)
                {
                    if (draw == true)
                    {
                        if (fig.Check(e.X, e.Y) == true)
                        {
                            if (e.Button == MouseButtons.Left)
                            {
                                fig.beingDragged = true;
                                fig.dx = e.X - fig.x;
                                fig.dy = e.Y - fig.y;
                            }
                            else if (e.Button == MouseButtons.Right)
                            {
                                draw = false;
                                Refresh();
                                versh.Remove(fig);
                                break;
                            }
                        }
                    }
                }
            }
            if (e.Button == MouseButtons.Left && fig.Check(e.X, e.Y) == false)
            {
                draw = true;
                Circle fig = new Circle(e.X, e.Y);
                versh.Add(fig);
            }

            Refresh();
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (versh.Any())
            {
                foreach (Circle fig in versh)
                {
                    if (fig.beingDragged)
                    {

                        fig.x = e.X - fig.dx;
                        fig.y = e.Y - fig.dy;
                    }
                    Refresh();
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (versh.Any())
            {
                foreach (Circle fig in versh)
                {
                    fig.beingDragged = false;
                }
            }
        }

        private void выборToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 1;
        }

        private void треугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 2;
        }

        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 3;
        }
    }
    class Circle
    {
        public Circle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x { get; set; }
        public int y { get; set; }
        public int dx { get; set; }
        public int dy { get; set; }
        public bool beingDragged { get; set; }
        public void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Lime), x - 25, y - 25, 50, 50);
        }
        public bool Check(int xm, int ym)
        {
            double xx = Math.Pow(x - xm, 2);
            double yy = Math.Pow(y - ym, 2);
            if (xx + yy <= Math.Pow(50f / 2, 2)) return true;
            else return false;
        }
    }
}
