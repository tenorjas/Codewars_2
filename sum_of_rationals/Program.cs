using System;
using System.Collections.Generic;

namespace sum_of_rationals
{
    class Program
    {
        public static string SumFracts(int[,] l)
        {
            // your code
            //decimal sum = 0;

            Console.WriteLine(l.Length);

            return "zero";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] m1 = new int[,] { {1,2}, {2,9}, {3,18}, {4,24}, {6,48} };
            SumFracts(m1);
        }
    }
}
