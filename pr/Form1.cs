using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace pr
{
    public partial class Form1 : Form
    {
        bool draw;
        List<Circle> figs = new List<Circle>();
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
            if (figs.Any())
            {
                foreach (Circle fig in figs)
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
                                if ((figs[k].y - figs[j].y) * (figs[i].x - figs[j].x) - (figs[i].y - figs[j].y) * (figs[k].x - figs[j].x) >= 0)
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
                        e.DrawLine(new Pen(Color.Black), figs[i].x, figs[i].y, figs[j].x, figs[j].y);
                    }
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bool check = false;
            if (figs.Any())
            {
                foreach (Circle fig in figs)
                {
                    if (draw == true)
                    {
                        if (fig.Check(e.X, e.Y) == true)
                        {
                            check = true;
                            if (e.Button == MouseButtons.Left)
                            {
                                fig.beingDragged = true;
                                fig.dx = e.X - fig.x;
                                fig.dy = e.Y - fig.y;
                            }
                            else if (e.Button == MouseButtons.Right)
                            {
                                Refresh();
                                figs.Remove(fig);
                                break;
                            }
                        }
                    }
                }
            }
            if (e.Button == MouseButtons.Left && check == false)
            {
                draw = true;
                Circle fig = new Circle(e.X, e.Y);
                figs.Add(fig);
            }

            Refresh();
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (figs.Any())
            {
                foreach (Circle fig in figs)
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
            if (figs.Any())
            {
                foreach (Circle fig in figs)
                {
                    fig.beingDragged = false;
                }
            }
        }

        private void выборToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
        public bool isInside { get; set; }
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