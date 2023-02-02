using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mnogoug
{
    public partial class Form1 : Form
    {
        List<Figure> figs = new List<Figure>();
        bool draw;
        int choice;
        Figure f;
        public Form1()
        {
            InitializeComponent();
            draw = false;
            choice = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (figs.Any())
            {
                foreach (Figure fig in figs)
                {
                    fig.Draw(e.Graphics);
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bool check = false;
            if (figs.Any())
            {
                foreach (Figure fig in figs)
                {
                    if (draw == true)
                    {
                        if (fig.Check(e.X, e.Y) == true)
                        {
                            check = true;
                            if (e.Button == MouseButtons.Left)
                            {
                                fig.BeingDragged = true;
                                fig.Dx = e.X - fig.X;
                                fig.Dy = e.Y - fig.Y;
                            }
                            if (e.Button == MouseButtons.Right)
                            {
                                figs.Remove(fig);
                                Refresh();
                                break;
                            }
                        }
                    }
                }
            }
            if (e.Button == MouseButtons.Left && check == false)
            {
                draw = true;
                switch (choice)
                {
                    case 1:
                        f = new Circle(e.X, e.Y);
                        break;
                    case 2:
                        f = new Triangle(e.X, e.Y);
                        break;
                    case 3:
                        f = new Square(e.X, e.Y);
                        break;
                }
                figs.Add(f);
            }
            Refresh();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (figs.Any())
            {
                foreach (Figure fig in figs)
                {
                    if (fig.BeingDragged)
                    {
                        fig.X = e.X - fig.Dx;
                        fig.Y = e.Y - fig.Dy;
                    }
                }
            }
            Refresh();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (figs.Any())
            {
                foreach (Figure fig in figs)
                {
                    fig.BeingDragged = false;
                }
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (draw)
            {
                Invalidate();
            }
        }


        private void окружностьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            choice = 1;
        }

        private void треугольникToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            choice = 2;
        }

        private void квадратToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            choice = 3;
        }
    }
}