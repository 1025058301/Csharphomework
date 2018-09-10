using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string s;
        string s2;
        double a;
        double a2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = textBox1.Text;
            a = double.Parse(s);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            s2 = textBox2.Text;
            a2 = double.Parse(s2);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            double b = a * a2;
            label1.Text = "积是"+b;
        }
    }
}
