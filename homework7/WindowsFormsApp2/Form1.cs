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
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent(); }
             
        Form2 frm = new Form2();
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
         public static OrderService A = new OrderService();
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            A.Export2();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"f:\Git\1.xml");

                XPathNavigator nav = doc.CreateNavigator();
                nav.MoveToRoot();

                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(@"f:\Git\order.xslt");

                FileStream outFileStream = File.OpenWrite(@"f:\Git\order.html");
                XmlTextWriter writer =
                    new XmlTextWriter(outFileStream, System.Text.Encoding.UTF8);
                xt.Transform(nav, null, writer);

            
            }
            catch (XmlException er)
            {
                Console.WriteLine("XML Exception:" + er.ToString());
            }
            catch (XsltException er)
            {
                Console.WriteLine("XSLT Exception:" + er.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"f:\Git\order.html");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

