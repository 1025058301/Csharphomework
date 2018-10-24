using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;



namespace sixthhomework
{
     public class Order
    {
        public int ordernumber;
        public string ordername;
        public string orderclientname;
        public int ordermoney;
        public Order()
        {

        }
        public Order(int a, string b, string c, int d)
        {
            ordernumber = a;
            ordername = b;
            orderclientname = c;
            ordermoney = d;

        }

    }
    public class OrderService
    {

        public List<Order> list = new List<Order>();
        public void Addorder(int a1, string b2, string c2, int d2)
        {
            Order neworder = new Order(a1, b2, c2, d2);
            list.Add(neworder);

        }
        public void Deleteorder(int a)
        {
            foreach (Order i in list)
            {
                if (i.ordernumber == a)
                {
                    list.Remove(i);
                }

            }
        }
        public void Enquirorderfromnumber(int a)
        {
            foreach (Order i in list)
            {
                if (i.ordernumber == a)
                {
                    Console.WriteLine("订单名称：", i.ordername, "客户名称：", i.orderclientname);
                }

            }
        }
        public void Enquiroderfromordername(string a)
        {
            int time = 0;
            foreach (Order i in list)
            {
                if (i.ordername == a)
                {
                    Console.WriteLine("订单号：", i.ordernumber, "客户名称：", i.orderclientname);
                    time++;
                }
            }
            if (time == 0)
            {
                Console.WriteLine("SORRY,NO THIS ORDER");
            }
        }
        public void EnquiroEnquiroderfromordernameLQ(string a)
        {
            int time = 0;
            var m = from n in list
                    where n.ordername == a
                    select n;
            foreach (var n in m)
            {
                Console.WriteLine(n.ordernumber + "  " + n.orderclientname);
                time++;

            }
            if (time == 0)
            {
                Console.WriteLine("Sorrry,No this order");
            }

        }
        public void Enquiroderfromclientname(string a)
        {
            foreach (Order i in list)
            {
                if (i.orderclientname == a)
                {
                    Console.WriteLine("订单号：", i.ordernumber, "订单名称：", i.ordername);
                }
            }
        }
        public void EnquiroEnquiroderfromclientordernameLQ(string a)
        {
            int time = 0;
            var m = from n in list
                    where n.orderclientname == a
                    select n;
            foreach (var n in m)
            {
                Console.WriteLine(n.ordernumber + "  " + n.ordername);
                time++;

            }
            if (time == 0)
            {
                Console.WriteLine("Sorrry,No this order");
            }

        }
        public void Enquirordermoney()
        {
            int time = 0;
            var m = from n in list
                    where n.ordermoney >= 10000
                    select n;
            foreach (var n in m)
            {
                Console.WriteLine(n.ordernumber + "  " + n.ordername + "  " + n.orderclientname);
                time++;
            }
            if (time == 0)
            {
                Console.WriteLine("no one order's money > 10000");
            }
        }
       /* public void Reviseorder()
        {
            int time = 0;
            Console.WriteLine("please input the order number which you want to revise");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("do you want to revise the ordername? if yes please input the new name");
            string b = Console.ReadLine();
            Console.WriteLine("do you want to revise the clientname? if yes please input the new name");
            string c = Console.ReadLine();
            foreach (Order i in list)
            {
                if (i.ordernumber == a)
                {
                    i.ordername = b;
                    i.orderclientname = c;
                    time++;
                }
            }
            if (time == 0)
            {
                Console.WriteLine("SORRY,NO THIS ORDER");
            }
        }*/
        public void Export(string a) {
            string path = a;
            XmlDocument xmlDoc = new XmlDocument();//创立类型声明节点
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDoc.AppendChild(node);//创立根节点
            XmlNode root = xmlDoc.CreateElement("Order");
            xmlDoc.AppendChild(root);
            foreach (Order i in list) {
                XmlElement ordernumber = xmlDoc.CreateElement("ordernumber");
                ordernumber.InnerText = i.ordernumber.ToString();
            }
            xmlDoc.Save(a);//保存在某一个文件中



        }
        public void Export2()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(@"f:\Git\1.xml", FileMode.Create))
            {
                xs.Serialize(fs, list);
            }
            using (FileStream fs = new FileStream(@"f:\Git\1.xml", FileMode.Open))
            {
                List<Order> pl = (List<Order>)xs.Deserialize(fs);
                pl.ForEach(p => Console.WriteLine(p.ToString()));
            }
        }
        /*public  List<Order> Import(string a)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(a);
            List<Order> list1 = new List<Order>();
            XmlNodeList list2 = doc.SelectNodes("/Order/ordernumber");
            foreach(XmlNodeList item in list2)
            {
                Order order = new Order ();
                order.ordernumber = Int32.Parse( item[0].InnerText);
                order.ordername = item[1].InnerText;
                order.orderclientname = item[2].InnerText;
                order.ordermoney = Int32.Parse(item[3].InnerText);
                list1.Add(order);
            }
            return list1;

        }*/
        public List<Order> Import(string a)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(a);
      
            XmlNode xm = doc.SelectSingleNode("ArrayOfOrder");
            XmlNodeList xnl = xm.ChildNodes;
            List<Order> list1 = new List<Order>();
            foreach(XmlNode i in xnl)
            {
                Order order1 = new Order();
                XmlElement xe = (XmlElement)i;
                XmlNodeList xn2 = xe.ChildNodes;
                order1.ordernumber = Int32.Parse(xn2.Item(0).InnerText);
                order1.ordername = xn2.Item(1).InnerText;
                order1.orderclientname = xn2.Item(2).InnerText;
                order1.ordermoney = Int32.Parse(xn2.Item(3).InnerText);
                list1.Add(order1);


            }
            return list1;
        }

        public static void Main()
        {
            OrderService order = new OrderService();
            order.Addorder(1, "苹果", "lcy", 10000);
            order.Addorder(2, "菠萝", "lcy", 1000);
            Order a = order.list[0];
            order.EnquiroEnquiroderfromordernameLQ("苹果");
            order.Export2();
            List<Order> list4 = new List<Order>();
            list4= order.Import(@"f:\Git\1.xml");
        }
            

        }
    } 
