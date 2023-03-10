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
        bool allDragged;
        int choice;
        Figure f;
        public Form1()
        {
            InitializeComponent();
            draw = false;
            allDragged = false;
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
                if (figs.Count > 2)
                {
                    CreateShape(e.Graphics);
                }
            }
        }

        private void CreateShape(Graphics e)
        {
            for (int i = 0; i < figs.Count; i++)
                figs[i].isInside = false;

            for (int i = 0; i < figs.Count - 1; i++)
            {
                for (int j = i + 1; j < figs.Count; j++)
                {
                    bool aboveShape = true;
                    bool belowShape = true;
                    for (int k = 0; k < figs.Count; k++)
                    {
                        if (k != j && k != i && i != j)
                        {
                            try
                            {
                                int x0 = figs[i].X;
                                int x1 = figs[j].X;
                                int x2 = figs[k].X;
                                int y0 = figs[i].Y;
                                int y1 = figs[j].Y;
                                int y2 = figs[k].Y;
                                if ((x2 * y1 - x2 * y0 - x0 * y1 + x0 * y0) / (x1 - x0) + y0 - y2 >= 0)
                                {
                                    aboveShape = false;
                                }
                                else
                                {
                                    belowShape = false;
                                }
                            }
                            catch
                            {
                                break;
                            }
                        }
                    }
                    if (aboveShape == true || belowShape == true)
                    {
                        if (choice == 1)
                            e.DrawLine(new Pen(Color.Black), figs[i].X, figs[i].Y, figs[j].X, figs[j].Y);
                        if (choice == 3)
                            e.DrawLine(new Pen(Color.Black), figs[i].X + 25, figs[i].Y + 25, figs[j].X + 25, figs[j].Y + 25);
                        figs[i].isInside = true;
                        figs[j].isInside = true;
                    }
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
                                fig.beingDragged = true;
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
                Refresh();
                if (figs.Count > 2 && figs[figs.Count - 1].isInside == false)
                {
                    figs.RemoveAt(figs.Count - 1);
                    allDragged = true;
                    foreach (Figure fig in figs)
                    {
                        fig.Dx = e.X - fig.X;
                        fig.Dy = e.Y - fig.Y;
                    }
                }
                Refresh();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (figs.Any())
            {
                if (allDragged)
                {
                    foreach (Figure fig in figs)
                    {
                        fig.beingDragged = true;
                    }
                }
                foreach (Figure fig in figs)
                {
                    if (fig.beingDragged)
                    {
                        fig.X = e.X - fig.Dx;
                        fig.Y = e.Y - fig.Dy;
                    }
                }
                Refresh();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (figs.Any())
            {
                allDragged = false;
                if (figs.Count > 2)
                {
                    for (int f = 0; f < figs.Count; f++)
                    {
                        if (figs[f].isInside == false)
                        {
                            figs.Remove(figs[f]);
                        }
                    }
                }
                foreach (Figure fig in figs)
                {
                    fig.beingDragged = false;
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