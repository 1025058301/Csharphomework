using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            for(double i = 2; i <= 100; i++)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 ) { System.Console.Write(i + " "); }
                if(i / 2 == 1 || i / 3 == 1 || i / 5 == 1 || i / 7 == 1) { System.Console.Write(i + " "); }
            }
        }
    }
}
