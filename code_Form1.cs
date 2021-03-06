using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lucrarea3_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int alfa_g;// unghiul in grade
        double pi = System.Math.PI;

        void F1(int x0)
        {
            int x, y;
            int y0 = Height / 3;
            int xc = x0 + y0 / 2;
            int yc = y0 * 3 / 2;
            System.Drawing.Graphics Desen;
            System.Drawing.Pen Creion_Green, Creion_Red;
            Desen = CreateGraphics();
            Creion_Green = new System.Drawing.Pen(System.Drawing.Color.Green, 2);
            Creion_Red = new System.Drawing.Pen(System.Drawing.Color.Red, 2);
            Desen.DrawLine(Creion_Green, x0 + y0 / 2, 10, x0 + y0 / 2, y0);
            for (alfa_g = 0; alfa_g < 360; alfa_g += 6)
            {
                double alfa_r = 2 * pi * alfa_g / 360;// unghiul in radiani
                x = System.Convert.ToInt32(xc + y0 / 2 * System.Math.Cos(alfa_r));
                y = System.Convert.ToInt32(yc - y0 / 2 * System.Math.Sin(alfa_r));
                Desen.DrawLine(Creion_Red, xc, yc, x, y);
            }
        }
        void F2(int x0)
        {
            int x, y;
            int y0 = this.Height / 3;
            int xc = x0 + y0 / 2;
            int yc = y0 * 3 / 2;
            System.Drawing.Graphics Desen;
            System.Drawing.Pen Creion_Green, Creion_Pink, Creion_Gray;
            Desen = CreateGraphics();
            Creion_Green = new System.Drawing.Pen(System.Drawing.Color.Green, 2);
            Creion_Pink = new System.Drawing.Pen(System.Drawing.Color.Pink, 3);
            Creion_Gray = new System.Drawing.Pen(System.Drawing.Color.Gray, 2);
            Desen.DrawEllipse(Creion_Gray, x0, y0, y0, y0);
            Desen.DrawLine(Creion_Green, x0 + y0 / 2, 10, x0 + y0 / 2, y0);
            for (alfa_g = 0; alfa_g < 360; alfa_g += 30)
            {
                double alfa_r = 2 * pi * alfa_g / 360;// unghiul in radiani
                x = System.Convert.ToInt32(xc + y0 / 2 * System.Math.Cos(alfa_r));
                y = System.Convert.ToInt32(yc - y0 / 2 * System.Math.Sin(alfa_r));
                Desen.DrawLine(Creion_Pink, xc, yc, x, y);
            }
        }
        void F3(int x0)
        {
            int x, y;
            int y0 = this.Height / 3;
            int xc = x0 + y0 / 2;
            int yc = y0 * 3 / 2;
            System.Drawing.Graphics Desen;
            System.Drawing.Pen Creion_Green, Creion_Gold;
            Desen = CreateGraphics();
            Creion_Green = new System.Drawing.Pen(System.Drawing.Color.Green, 2);
            Creion_Gold = new System.Drawing.Pen(System.Drawing.Color.Gold, 3);
            Desen.DrawEllipse(Creion_Green, x0, y0, y0, y0);
            Desen.DrawLine(Creion_Green, x0 + y0 / 2, 10, x0 + y0 / 2, y0);
            for (alfa_g = 0; alfa_g < 360; alfa_g += 9)
            {
                double alfa_r = 2 * pi * alfa_g / 360;// unghiul in radiani
                x = System.Convert.ToInt32(xc + y0 / 2 * System.Math.Cos(alfa_r));
                y = System.Convert.ToInt32(yc - y0 / 2 * System.Math.Sin(alfa_r));
                if (alfa_g % 36 == 0)
                    Desen.DrawLine(Creion_Gold, xc, yc, x, y);
                else
                    Desen.DrawLine(Creion_Green, xc, yc, x, y);
            }
        }
        void F4(int x0)
        {
            int x, y;
            int y0 = this.Height / 3;
            int xc = x0 + y0 / 2;
            int yc = y0 * 3 / 2;
            System.Drawing.Graphics Desen;
            System.Drawing.Pen Creion_Green, Creion_Blue;
            Desen = CreateGraphics();
            Creion_Green = new System.Drawing.Pen(System.Drawing.Color.Green, 2);
            Creion_Blue = new System.Drawing.Pen(System.Drawing.Color.Blue, 5);
            Desen.DrawLine(Creion_Green, x0 + y0 / 2, 10, x0 + y0 / 2, y0);
            for (alfa_g = 0; alfa_g < 360; alfa_g += 30)
            {
                double alfa_r = 2 * pi * alfa_g / 360;// unghiul in radiani
                x = System.Convert.ToInt32(xc + y0 / 2 * System.Math.Cos(alfa_r));
                y = System.Convert.ToInt32(yc - y0 / 2 * System.Math.Sin(alfa_r));
                Desen.DrawLine(Creion_Blue, xc, yc, x, y);
            }
        }
        void F5(int x0)
        {
            int x, y;
            int y0 = this.Height / 3;
            int xc = x0 + y0 / 2;
            int yc = y0 * 3 / 2;
            System.Drawing.Graphics Desen;
            System.Drawing.Pen Creion_Green, Creion_Orange, Creion_Gray;
            Desen = CreateGraphics();
            Creion_Green = new System.Drawing.Pen(System.Drawing.Color.Green, 2);
            Creion_Orange = new System.Drawing.Pen(System.Drawing.Color.Orange, 3);
            Creion_Gray = new System.Drawing.Pen(System.Drawing.Color.LightGray, 3);
            Desen.DrawEllipse(Creion_Gray, x0, y0, y0, y0);
            Desen.DrawLine(Creion_Green, x0 + y0 / 2, 10, x0 + y0 / 2, y0);
            for (alfa_g = 60; alfa_g < 360; alfa_g += 120)
            {
                double alfa_r = 2 * pi * alfa_g / 360;// unghiul in radiani
                x = System.Convert.ToInt32(xc + y0 / 2 * System.Math.Cos(alfa_r));
                y = System.Convert.ToInt32(yc - y0 / 2 * System.Math.Sin(alfa_r));
                Desen.DrawLine(Creion_Gray, xc, yc, x, y);
                Desen.DrawLine(Creion_Orange, xc + 10, yc + 10, x, y);
            }
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics Desen;
            System.Drawing.Pen Creion_Green;
            Desen = CreateGraphics();
            Creion_Green = new System.Drawing.Pen(System.Drawing.Color.Green, 2);
            Desen.Clear(BackColor);
            Desen.DrawLine(Creion_Green, 1, 10, this.Width, 10);

            int k = 10;
            Random rd = new Random();
            int rand_num = rd.Next(3, 10);
            do
            {
                rand_num = rd.Next(3, 10);
                if (rand_num % 5 == 0) { F1(k); }
                else if (rand_num % 5 == 1) { F2(k); }
                else if (rand_num % 5 == 2) { F3(k); }
                else if (rand_num % 5 == 3) { F4(k); }
                else if (rand_num % 5 == 4) { F5(k); }
                k += 150;
            }
            while (k < this.Width);
        }
    }
}
