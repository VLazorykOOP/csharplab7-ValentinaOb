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
    }

    public class five : Figure
    {
        public Point[] Draw()
        {
            
            //Pen pen = new Pen(Color.Black);
            Random rnd = new Random();

            Point[] p = new Point[5];

            p[0].X = rnd.Next(0, 400);
            p[0].Y = rnd.Next(0, 280);
            p[1].X = rnd.Next(0, 400);
            p[1].Y = rnd.Next(0, 280);
            p[2].X = rnd.Next(0, 400);
            p[2].Y = rnd.Next(0, 280);
            p[3].X = rnd.Next(0, 400);
            p[3].Y = rnd.Next(0, 280);
            p[4].X = rnd.Next(0, 400);
            p[4].Y = rnd.Next(0, 280);

            //g.DrawPolygon(pen, p);
            return p;

        }
    }

    public class rectangle : Figure
    {
        int size;
        public int[] Draw()
        {
            Random rnd = new Random();
            size = rnd.Next(15,125);
            int x = rnd.Next(0, 305);
            int y = rnd.Next(0, 175);
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
        public Point[] Draw()
        {
            Random rnd = new Random();

            Point[] p = new Point[3];

            p[0].X = rnd.Next(0, 400);
            p[0].Y = rnd.Next(0, 280);
            p[1].X = rnd.Next(0, 400);
            p[1].Y = rnd.Next(0, 280);
            p[2].X = rnd.Next(0, 400);
            p[2].Y = rnd.Next(0, 280);

            return p;
        }
    }
    public class diamond : Figure
    {
        public Point[] Draw()
        {
            Random rnd = new Random();

            Point[] p = new Point[4];
 
            int r = rnd.Next(-25, 90);

            p[0].X = 100+r;
            p[0].Y = 100 + r;
            p[1].X = 0 + r;
            p[1].Y = 200 + r;

            p[2].X = 150 + r;
            p[2].Y = 200 + r;

            p[3].X = 250 + r;
            p[3].Y = 100 + r;

            return p;

        }
    }

}
