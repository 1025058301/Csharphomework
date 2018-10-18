using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace painttree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(10, 200, 310, 100, -Math.PI/2);
        }
        private Graphics graphics;
        double th1 ;
        double th2 ;
        double per1;
        double per2;
        string k;
        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
          
            if (k == "Blue")
            {
                graphics.DrawLine(

      Pens.Blue,
      (int)x0, (int)y0, (int)x1, (int)y1);
            }
            if (k == "Red")
            {
                graphics.DrawLine(

     Pens.Red,
     (int)x0, (int)y0, (int)x1, (int)y1);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string s = textBox2.Text;
            double s1 = double.Parse(s);
            th1 = s1 * Math.PI / 180;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            double s2 = double.Parse(s);
            th2 = s2 * Math.PI / 180;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string s = textBox3.Text;
            per1 = double.Parse(s);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string s = textBox4.Text;
            per2 = double.Parse(s);
        }

        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            k = textBox5.Text;

        }
    }
}
