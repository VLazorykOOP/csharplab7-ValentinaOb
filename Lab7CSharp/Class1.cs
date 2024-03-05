using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7CSharp
{
    public class Figure : Form1
    {
        public Point[] Draw() {
            Point[] p = new Point[5];
            return p; }

        public void trans(double dx, double dy, int[] l){
        }

        public Point[] data
        {
            get { Point[] p = new Point[5]; 
                return p; }
        }
    }

    public class five : Figure
    {
        public Point[] p = new Point[5];
        public Point[] Draw(){
            Random rnd = new Random();            

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
            /*
            this.p[0].X = p[0].X;
            this.p[0].Y = p[0].Y;
            this.p[1].X = p[1].X;
            this.p[1].Y = p[1].Y;
            this.p[2].X = p[2].X;
            this.p[2].Y = p[2].Y;
            this.p[3].X = p[3].X;
            this.p[3].Y = p[3].Y;
            this.p[4].X = p[4].X;
            this.p[4].Y = p[4].Y;
            */
            //g.DrawPolygon(pen, p);
            return p;
        }
        public Point[] trans(int dx, int dy, Point[]k)
        {
            for (int i = 0; i < p.Length; i++){
                p[i].X = k[i].X + dx;
                p[i].Y = k[i].Y + dy;
            }

            return p;
        }
    }
    public class rectangle : Figure
    {
        int size;
        public int[] p = new int[4];

        public int[] Draw()
        {
            Random rnd = new Random();
            size = rnd.Next(15,125);
            int x = rnd.Next(0, 295);
            int y = rnd.Next(0, 175);
            int width = size;
            int height = size;

            p[0] = x;
            p[1] = y;
            p[2] = width;
            p[3] = height;
            
            //g.DrawRectangle(pen, x, y, width, height);
            return p;
        }

        public int[] trans(int dx, int dy, int[]k)
        {
            p[0] = k[0] + dx;
            p[1] = k[1] + dy;
            p[2] = k[2];
            p[3] = k[3];

            return p;
        }
    }
    public class triangle : Figure
    {
        public Point[] p = new Point[3];
        public Point[] Draw(){
            Random rnd = new Random();

            p[0].X = rnd.Next(0, 400);
            p[0].Y = rnd.Next(0, 280);
            p[1].X = rnd.Next(0, 400);
            p[1].Y = rnd.Next(0, 280);
            p[2].X = rnd.Next(0, 400);
            p[2].Y = rnd.Next(0, 280);

            /*
            this.p[0].X = p[0].X;
            this.p[0].Y = p[0].Y;
            this.p[1].X = p[1].X;
            this.p[1].Y = p[1].Y;
            this.p[2].X = p[2].X;
            this.p[2].Y = p[2].Y;
            */

            return p;
        }
        public Point[] trans(int dx, int dy, Point[] k)
        {
            for (int i = 0; i < p.Length; i++)
            {
                p[i].X = k[i].X +dx;
                p[i].Y = k[i].Y+ dy;
            }
            return p;
        }
    }
    public class diamond : Figure
    {
        public Point[] p = new Point[4];
        public Point[] Draw(){
            Random rnd = new Random();
 
            int r = rnd.Next(-20, 100);
            int r1 = rnd.Next(-11, 90);

            p[0].X = 100 + r1;
            p[0].Y = 100 + r;
            p[1].X = 0 + r1;
            p[1].Y = 200 + r;

            p[2].X = 150 + r1;
            p[2].Y = 200 + r;

            p[3].X = 250 + r1;
            p[3].Y = 100 + r;

            return p;

        }
        public Point[] trans(int dx, int dy, Point[]k)
        {
            for (int i = 0; i < p.Length; i++)
            {
                p[i].X = k[i].X + dx;
                p[i].Y = k[i].Y+ dy;
            }
            return p;
        }
    }

}
