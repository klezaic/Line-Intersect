using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LineIntersect
{
    public partial class Form1 : Form
    {
        int dotThickness = 2;
        int lineThickness = 1;
        
        List<Dot> dots = new List<Dot>();
        List<Line> lines= new List<Line>();

        public Form1()
        {
            InitializeComponent();

            dots.Clear();
            lines.Clear();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Stopwatch stw = new Stopwatch();
            Pen pn = new Pen(Color.Blue, dotThickness);
            int i = 0;
            lines.Clear();

            foreach (Dot dot in dots)
            {
                e.Graphics.DrawEllipse(pn, (int)dot.x, (int)dot.y, dotThickness, dotThickness);
                i++;
                if(i % 2 == 0)
                {
                    lines.Add(new Line(dots[i - 2], dots[i - 1]));
                }
            }

            pn = new Pen(Color.Black, lineThickness);

            foreach (Line line in lines)
            {
                e.Graphics.DrawLine(pn, new Point((int)line.a.x, (int)line.a.y), new Point((int)line.b.x, (int)line.b.y));
            }

            pn = new Pen(Color.Red, dotThickness);
            int brojac = 0;
            stw.Start();
            foreach (Line l1 in lines)
            {
                foreach (Line l2 in lines)
                {
                    Dot dot = Geometry.lineIntersect(l1, l2);
                    if( dot != null)
                    {
                        e.Graphics.DrawEllipse(pn, (int)dot.x, (int)dot.y, dotThickness, dotThickness);
                        brojac++;
                    }
                }
            }

            this.brojTocaka0ToolStripMenuItem.Text = "Broj Tocaka: " + dots.Count;
            this.brojLinija0ToolStripMenuItem.Text = "Broj Linija: " + lines.Count;
            this.brojKrizanjaToolStripMenuItem.Text = "Broj Krizanja: " + brojac / 2;
            this.vrijemeIzracunaToolStripMenuItem.Text = "Vrijeme Izracuna: " + stw.ElapsedMilliseconds + " ms";


        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            dots.Add(new Dot(e.X, e.Y));
            panel.Refresh();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tBrisanje!", "Zaslon očišćen!", MessageBoxButtons.OK);
            

            lines.Clear();
            dots.Clear();
            this.panel.Refresh();
        }


    }
}
