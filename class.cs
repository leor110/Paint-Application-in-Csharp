using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_App
{
    public abstract class Brush
    {
        //public static Point px, py;
        //public int X, Y, sX, sY, eX, eY;
        static short status;
        static Color color;
        static Pen p;
        static bool switc;
        static short size;
        public Brush()
        {
            if (status > 6 && status < 1)
            {
                status = 1;
                switc = false;
                size = 1;
                color = Color.White;
            }
            p = new Pen(color, size);
        }
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                    p.Color = value;
                    color = value;
            }
        }
        public short Status // use only 2 bits
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
                if (status == 2)
                {
                    this.Color = Color.White;
                    Size = 1;
                }
                else
                    Size = 1;
            }
        }
        public short Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                if (status == 2)
                {
                    p.Width = 10 * value;
                }
                else if (status != 3)
                {
                    p.Width = value;
                }
            }
        }
        public bool Switch
        {
            get
            {
                return switc;
            }
            set
            {
                switc = value;
            }
        }
        public Pen pen
        {
            get
            {
                return p;
            }
        }
        public abstract void Draw(Graphics g);
    }
    public abstract class Shape : Brush
    {
        public Point p1, p2;
        public int Width, Height;
        public Shape()
        {
            p1 = p2 = new Point(0, 0);
            Width = Height = 0;
        }
    }
    public class Stright_Line :Brush
    {
        public Point pstart, pend;
        int lengh;
        public Stright_Line()
        {
            pstart = pend = default;
            lengh = 0;
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, pstart.X, pstart.Y, pend.X, pend.Y);
            lengh = pend.X - pstart.X + pend.Y - pstart.Y;
        }
    }
    public class Ellipse : Shape
    {
        public int radius;
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, p1.X, p1.Y, Width, Height);
            //https://www.vcalc.com/wiki/vCalc/Ellipse+-+Mean+Radius
            radius = (Width * 2 + Height) / 3;
        }
        public void Draw(Graphics g, int sx,int sy,int width, int hight)
        {
            p2.X = sx;
            p2.Y = sy;
            Width = width;
            Height = hight;
            Draw(g);
        }
        public int Radius
        {
            get
            {
                return radius;
            }
        }
    }
    public class Line : Shape
    {
        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, p1, p2);
        }
        public void Draw(Graphics g,Point start,Point end)
        {
            p1 = start;
            p2 = end;
            Draw(g);
        }
    }

    public class myRectangle : Shape
    {
        double area, scope;
        public double Scope
        {
            get
            {
                return scope;
            }
        }
        public double Area
        {
            get
            {
                return area;
            }
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(pen, p1.X, p1.Y, Width,Height);
            area = Height * Width;
            scope = area * area;
        }
        public void Draw(Graphics g, Point start, int width, int height)
        {
            //p1 = start;
            Width = width;
            Height = height;
            Draw(g);
        }
    }
}
