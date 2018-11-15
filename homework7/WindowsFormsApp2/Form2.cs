using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sixthhomework;
using WindowsFormsApp2;
using System.Text.RegularExpressions;


namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        private string dindannumber;
        private string clientname;
        private string ordername;
        private string ordermoney;
       
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
                dindannumber = textBox1.Text;
           
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            clientname = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ordername = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ordermoney = textBox4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pattern = "^[0-9]{4}[0-9]{2}[0-9]{2}[0-9]{2}";
            Regex rx = new Regex(pattern);
            Match m = rx.Match(dindannumber);
            if (m.Success)
            {
                Form1.A.Addorder(Int32.Parse(dindannumber), ordername, clientname, Int32.Parse(ordermoney));
            }
            else
            {
                MessageBox.Show("the number is wrong", "Warn");
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.A.Deleteorder1(Int32.Parse(dindannumber));
        }

        private  void button3_Click(object sender, EventArgs e)
        {
            if (dindannumber != null && ordername == null && clientname == null)
            {
                foreach(Order i in Form1.A.list)
                {
                    if (i.ordernumber == Int32.Parse(dindannumber))
                    {
                        textBox5.Text = i.ordername;
                        textBox6.Text = i.orderclientname;
                    }
                }
            }
            if (dindannumber == null && ordername != null && clientname == null)
            {
                foreach (Order i in Form1.A.list)
                {
                    if (i.ordername == ordername)
                    {
                        textBox5.Text = i.ordernumber.ToString();
                        textBox6.Text = i.orderclientname;
                    }
                }
            }
            if (dindannumber == null && ordername == null && clientname != null)
            {
                foreach (Order i in Form1.A.list)
                {
                    if (i.orderclientname == clientname)
                    {
                        textBox5.Text = i.ordernumber.ToString();
                        textBox6.Text = i.ordername;
                    }
                }
            }
        }
    }
}

