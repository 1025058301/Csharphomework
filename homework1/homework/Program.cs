using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please input an int");
            string a = System.Console.ReadLine();
            int a1 = Int32.Parse(a);
            System.Console.WriteLine("second int");
            string b = System.Console.ReadLine();
            int b1= Int32.Parse(b);
            int c = a1 * b1;
            System.Console.WriteLine("result is :" + c);
        }
    }
}
