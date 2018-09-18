using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem8
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int GetMax(int[] A)
        {
            int Max = A[0];
            foreach (int i in A)
            {
                if (i > Max) { Max = i; }

            }
            return Max;

        }
        public int GetMin(int[] A)
        {
            int Min = A[0];
            foreach(int i in A)
            {
                if (i < Min) { Min = i; }
            }
            return Min;
        }
        public int GetSum(int[] A)
        {
            int sum = 0;
            foreach(int i in A)
            {
                sum += i;
            }
            return sum;

        }
        public int GetAverage(int[] A)
        {
            int sum = 0;
            int n = 0;
            int average = 0;
            foreach(int i in A)
            {
                sum = sum + i;
                n++;

            }
            average = sum / n;
            return average;

        }

    }
}
