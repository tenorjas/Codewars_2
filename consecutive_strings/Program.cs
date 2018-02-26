using System;

namespace consecutive_strings
{
    class Program
    {
        public static String LongestConsec(string[] strarr, int k)
        {
            // your code
            int n = strarr.Length;

            if (n == 0 || k > n || k <= 0)
            {
                return "";
            }
            else
            {
                // body goes here
            }

            return ""; // this will be deleted eventually
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
