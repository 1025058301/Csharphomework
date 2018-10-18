using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    class Order
    {
        public int ordernumber;
        public string ordername;
        public string orderclientname;
        public int ordermoney;
        public Order(int a, string b, string c,int d)
        {
            ordernumber = a;
            ordername = b;
            orderclientname = c;
            ordermoney = d;

        }

    }
    class OrderService
    {
        
        List<Order> list = new List<Order>();
        public void Addorder(int a1, string b2, string c2,int d2)
        {
            Order neworder = new Order(a1, b2, c2,d2);
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
            foreach(var n in m)
            {
                Console.WriteLine(n.ordernumber+"  "+ n.orderclientname);
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
            foreach(var n in m)
            {
                Console.WriteLine(n.ordernumber + "  " + n.ordername + "  " + n.orderclientname);
                time++;
            }
            if (time == 0)
            {
                Console.WriteLine("no one order's money > 10000");
            }
        }
        public void Reviseorder()
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
        }
        public static void Main()
        {
            OrderService order = new OrderService();
            order.Addorder(1, "苹果", "lcy",10000);
            Order a = order.list[0];
            order.EnquiroEnquiroderfromordernameLQ("苹果");

        }

    }
}
