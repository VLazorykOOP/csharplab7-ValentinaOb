using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7CSharp
{
    public abstract class Figure : Form1
    {
        public Point[] Draw() {
            Point[] p = new Point[5];
            return p; }
        public void Move() { }
    }

    public class five : Figure
    {
        int size;
        string color;

        public Point[] Draw()
        {
            
            //Pen pen = new Pen(Color.Black);
            Random rnd = new Random();

            Point[] p = new Point[5];

            p[0].X = rnd.Next(0, 518);
            p[0].Y = rnd.Next(0, 353);
            p[1].X = rnd.Next(0, 518);
            p[1].Y = rnd.Next(0, 353);
            p[2].X = rnd.Next(0, 518);
            p[2].Y = rnd.Next(0, 353);
            p[3].X = rnd.Next(0, 518);
            p[3].Y = rnd.Next(0, 353);
            p[4].X = rnd.Next(0, 518);
            p[4].Y = rnd.Next(0, 353);

            //g.DrawPolygon(pen, p);
            return p;

        }
    }

    public class rectangle : Figure
    {
        int size;
        string color;

        public int[] Draw()
        {
            Random rnd = new Random();
            size = rnd.Next(15,300);
            int x = rnd.Next(0, 518);
            int y = rnd.Next(0, 353);
            int width = size;
            int height = size;

            int[] p = new int[4];
            p[0] = x;
            p[1] = y;
            p[2] = width;
            p[3] = height;

            //g.DrawRectangle(pen, x, y, width, height);
            return p;
        }
    }

    public class triangle : Figure
    {
        int size;
        string color;

        public Point[] Draw()
        {
            Random rnd = new Random();

            Point[] p = new Point[3];

            p[0].X = rnd.Next(0, 518);
            p[0].Y = rnd.Next(0, 353);
            p[1].X = rnd.Next(0, 518);
            p[1].Y = rnd.Next(0, 353);
            p[2].X = rnd.Next(0, 518);
            p[2].Y = rnd.Next(0, 353);

            return p;
        }
    }
    public class diamond : Figure
    {
        int size;
        string color;

        public Point[] Draw()
        {
            Random rnd = new Random();

            Point[] p = new Point[4];

            p[0].X = rnd.Next(0, 518);
            p[0].Y = rnd.Next(0, 353);
            p[1].X = rnd.Next(0, 518);
            p[1].Y = rnd.Next(0, 353);

            p[2].X = p[1].X;
            p[2].Y = p[1].Y + (p[0].Y - p[1].Y);

            p[3].X = rnd.Next(0, 518);
            p[3].Y = rnd.Next(0, 353);


            return p;

        }
    }

}
