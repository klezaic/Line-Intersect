using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineIntersect
{
    public class Dot
    {
        public double x { get; set; }
        public double y { get; set; }

        public Dot(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public string toString(string delim)
        {
            return "X: " + x + delim + "Y: " + y;
        }
    }

    public class Line
    {
        public Dot a { get; set; }
        public Dot b { get; set; }

        public Line()
        {

        }

        public Line(Dot a, Dot b)
        {
            this.a = a;
            this.b = b;
        }

        public Boolean dotInLine(Dot d)
        {
            if (((a.x <= d.x && d.x <= b.x) || (b.x <= d.x && d.x <= a.x)) && ((a.y <= d.y && d.y <= b.y) || (b.y <= d.y && d.y <= a.y)))
                return true;
            else
                return false;
        }

        public string toString(string delim1, string delim2)
        {
            return "Line: " + delim1 + a.toString(delim2) + delim1 + b.toString(delim2);
        }

    }

    public class Vector2D
    {
        public double x { get; set; }
        public double y { get; set; }

        public Vector2D()
        {

        }

        public Vector2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static double dotProduct(Vector2D a, Vector2D b)
        {
            double r = (a.x * b.x + a.y * b.y);
            return r;
        }
    }

    public class Geometry
    {
        public static Dot lineIntersect (Line l1, Line l2)
        {         
            //E = B-A = (Bx-Ax, By-Ay)
            //F = D-C = (Dx-Cx, Dy-Cy)
            //G = (A-C) = (Ax-Cx, Ay-Cy)
            //P = (-Ey, Ex)
            //h = (G * P) / (F*P)
            //res = C + F*h
            Vector2D E = new Vector2D(l1.b.x - l1.a.x, l1.b.y - l1.a.y);
            Vector2D F = new Vector2D(l2.b.x - l2.a.x, l2.b.y - l2.a.y);
            if ((E.x == F.x && E.y == F.y) || (-E.x == F.x && -E.y == F.y))
                return null;

            Vector2D G = new Vector2D(l1.a.x - l2.a.x, l1.a.y - l2.a.y);
            Vector2D P = new Vector2D(-(E.y), E.x);

            if (Vector2D.dotProduct(F, P) == 0)
                return null;

            double h = Vector2D.dotProduct(G, P) / Vector2D.dotProduct(F, P);

            Dot C = l2.a;
            Dot res = new Dot(C.x + F.x * h, C.y + F.y * h);

            if (l1.dotInLine(res) && l2.dotInLine(res))
                return res;
            else
                return null;
        }
    }
}
