﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab7CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Timers.Timer timer;
        int s;

        /*
        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }
        */
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                label2.Text = "Second: " + s;
            }));
        }
        private void Timer_Elapsed1(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                label3.Text = "Second: " + Convert.ToString(s, 2);
            }));
        }
        private void Timer_Elapsed2(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                label4.Text = "Second: " + Convert.ToString(s, 16);
            }));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed1;
            timer.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed2;
            timer.Start();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Images|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    panel1.BackgroundImage = Image.FromFile(ofd.FileName);
            }
        }
        public Bitmap MakeGrayscale(Bitmap original)
        {
            Bitmap newBmp = new Bitmap(original.Width, original.Height);
            Graphics g = Graphics.FromImage(newBmp);
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                   new float[] {.3f, .3f, .3f, 0, 0},
                   new float[] {.59f, .59f, .59f, 0, 0},
                   new float[] {.11f, .11f, .11f, 0, 0},
                   new float[] {0, 0, 0, 1, 0},
                   new float[] {0, 0, 0, 0, 1}
               });
            ImageAttributes img = new ImageAttributes();
            img.SetColorMatrix(colorMatrix);
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel, img);
            g.Dispose();
            //newBmp.Save("Result");
            return newBmp;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = MakeGrayscale((Bitmap)panel1.BackgroundImage);
            SaveFileDialog s = new SaveFileDialog();

            if (s.ShowDialog() == DialogResult.OK)
            {
                panel2.BackgroundImage.Save(s.FileName+"."+ImageFormat.Jpeg);
            }

        }

        
        Point[] p = new Point[5];
        int[] p1 = new int[4];

        public void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked){
                Pen pen = new Pen(Color.Black);
                
                five f = new five();
                p = f.Draw();

                Graphics g;
                g = panel3.CreateGraphics();

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                g.DrawPolygon(pen, p);
            }
            if (radioButton2.Checked){
                Pen pen = new Pen(Color.Black);
                
                rectangle r = new rectangle();
                p1 = r.Draw();

                Graphics g;
                g = panel3.CreateGraphics();

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                //g.DrawRectangle(pen, x, y, width, height);
                g.DrawRectangle(pen, p1[0], p1[1], p1[2], p1[3]);
            }
            if (radioButton3.Checked){
                Pen pen = new Pen(Color.Black);
                triangle t = new triangle();
                p=t.Draw();

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                Graphics g;
                g = panel3.CreateGraphics();
                g.DrawPolygon(pen, p);

            }
            if (radioButton4.Checked){
                Pen pen = new Pen(Color.Black);
                //Point[] p = new Point[4];
                diamond d = new diamond();
                p=d.Draw();

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                Graphics g;
                g = panel3.CreateGraphics();
                g.DrawPolygon(pen, p);
            }
        }

        public void button8_Click(object sender, EventArgs e){
            if (radioButton1.Checked)
            {
                Pen pen = new Pen(Color.Black);
                five f = new five();

                int u = Convert.ToInt32(textBox1.Text);
                p = f.trans(u,0,p);

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                Graphics g;
                g = panel3.CreateGraphics();

                g.DrawPolygon(pen, p);
            }
            if (radioButton2.Checked)
            {
                Pen pen = new Pen(Color.Black);
                rectangle r = new rectangle();

                int u = Convert.ToInt32(textBox1.Text);
                p1 = r.trans(u, 0,p1);

                Graphics g;
                g = panel3.CreateGraphics();

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                //g.DrawRectangle(pen, x, y, width, height);
                g.DrawRectangle(pen, p1[0], p1[1], p1[2], p1[3]);
            }
            if (radioButton3.Checked)
            {
                Pen pen = new Pen(Color.Black);
                triangle t = new triangle();

                int u = Convert.ToInt32(textBox1.Text);
                p = t.trans(u, 0,p);

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                Graphics g;
                g = panel3.CreateGraphics();
                g.DrawPolygon(pen, p);

            }
            if (radioButton4.Checked){
                Pen pen = new Pen(Color.Black);
                diamond d = new diamond();

                int u = Convert.ToInt32(textBox1.Text);
                p = d.trans(u, 0,p);

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                Graphics g;
                g = panel3.CreateGraphics();
                g.DrawPolygon(pen, p);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Pen pen = new Pen(Color.Black);
                five f = new five();

                int u = Convert.ToInt32(textBox1.Text);
                p = f.trans(-u, 0,p);

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                Graphics g;
                g = panel3.CreateGraphics();

                g.DrawPolygon(pen, p);
            }
            if (radioButton2.Checked)
            {
                Pen pen = new Pen(Color.Black);
                int[] p = new int[4];
                rectangle r = new rectangle();

                int u = Convert.ToInt32(textBox1.Text);
                p1 = r.trans(-u, 0, p1);

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                Graphics g;
                g = panel3.CreateGraphics();

                //g.DrawRectangle(pen, x, y, width, height);
                g.DrawRectangle(pen, p1[0], p1[1], p1[2], p1[3]);
            }
            if (radioButton3.Checked)
            {
                Pen pen = new Pen(Color.Black);
                triangle t = new triangle();

                int u = Convert.ToInt32(textBox1.Text);
                p = t.trans(-u, 0, p);

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                Graphics g;
                g = panel3.CreateGraphics();
                g.DrawPolygon(pen, p);

            }
            if (radioButton4.Checked)
            {
                Pen pen = new Pen(Color.Black);
                diamond d = new diamond();

                int u = Convert.ToInt32(textBox1.Text);
                p = d.trans(-u, 0, p);

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                Graphics g;
                g = panel3.CreateGraphics();
                g.DrawPolygon(pen, p);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Pen pen = new Pen(Color.Black);
                //Point[] p = new Point[5];
                five f = new five();

                int u = Convert.ToInt32(textBox1.Text);
                p = f.trans(0,-u, p);

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                Graphics g;
                g = panel3.CreateGraphics();

                g.DrawPolygon(pen, p);
            }
            if (radioButton2.Checked)
            {
                Pen pen = new Pen(Color.Black);
                //int[] p = new int[4];
                rectangle r = new rectangle();

                int u = Convert.ToInt32(textBox1.Text);
                p1 = r.trans(0, -u, p1);

                Graphics g;
                g = panel3.CreateGraphics();

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                //g.DrawRectangle(pen, x, y, width, height);
                g.DrawRectangle(pen, p1[0], p1[1], p1[2], p1[3]);
            }
            if (radioButton3.Checked)
            {
                Pen pen = new Pen(Color.Black);
                //Point[] p = new Point[3];
                triangle t = new triangle();

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                int u = Convert.ToInt32(textBox1.Text);
                p = t.trans(0,-u, p);

                Graphics g;
                g = panel3.CreateGraphics();
                g.DrawPolygon(pen, p);

            }
            if (radioButton4.Checked)
            {
                Pen pen = new Pen(Color.Black);
                diamond d = new diamond();

                int u = Convert.ToInt32(textBox1.Text);
                p = d.trans(0, -u, p);

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                Graphics g;
                g = panel3.CreateGraphics();
                g.DrawPolygon(pen, p);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Pen pen = new Pen(Color.Black);
                //Point[] p = new Point[5];
                five f = new five();

                int u = Convert.ToInt32(textBox1.Text);
                p = f.trans(0, u, p);

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                Graphics g;
                g = panel3.CreateGraphics();

                g.DrawPolygon(pen, p);
            }
            if (radioButton2.Checked)
            {
                Pen pen = new Pen(Color.Black);
                //int[] p = new int[4];
                rectangle r = new rectangle();

                int u = Convert.ToInt32(textBox1.Text);
                p1 = r.trans(0, u, p1);

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                Graphics g;
                g = panel3.CreateGraphics();

                //g.DrawRectangle(pen, x, y, width, height);
                g.DrawRectangle(pen, p1[0], p1[1], p1[2], p1[3]);
            }
            if (radioButton3.Checked)
            {
                Pen pen = new Pen(Color.Black);
                //Point[] p = new Point[3];
                triangle t = new triangle();

                int u = Convert.ToInt32(textBox1.Text);
                p = t.trans(0, u, p);

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                Graphics g;
                g = panel3.CreateGraphics();
                g.DrawPolygon(pen, p);

            }
            if (radioButton4.Checked)
            {
                Pen pen = new Pen(Color.Black);
                //Point[] p = new Point[4];
                diamond d = new diamond();

                int u = Convert.ToInt32(textBox1.Text);
                p = d.trans(0, u, p);

                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                pen.Color = colorDialog.Color;

                Graphics g;
                g = panel3.CreateGraphics();
                g.DrawPolygon(pen, p);
            }
        }
    }

}
