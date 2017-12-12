using System;
using System.Collections.Generic;
using System.Linq;

namespace array_diff
{
    class Program
    {
        public class Kata
        {
            public static int[] ArrayDiff(int[] a, int[] b)
            {
                // Your brilliant solution goes here
                // It's possible to pass random tests in about a second ;)
                List<int> finalList = new List<int>();

                for (var i = 0; i < a.Length; i++)
                {
                    if (!b.Contains(a[i]))
                    {
                        finalList.Add(a[i]);
                    }
                }

                int[] finalArray = new int[finalList.Count];
                finalArray = finalList.ToArray();
                return finalArray;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
