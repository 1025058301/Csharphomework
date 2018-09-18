using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[15];
            System.Console.Write("Please input a data");
            string s = Console.ReadLine();
            int n = Int32.Parse(s);
            while (n != 1)
            {
                for (int i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        n /= i;
                        System.Console.Write(i + " ");
                        break;
                    }
                }
            }
        }
    }
}
