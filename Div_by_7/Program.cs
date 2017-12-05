using System;
using System.Linq;

namespace Div_by_7
{
    class Program
    {
        public static long count = 0;

        public static long[] Seven(long m)
        {
            // your code
            long[] numbersDivisibleBySeven = { 7, 14, 21, 28, 35, 42, 49, 56, 63, 70, 77, 84, 91, 98 };

            if (m <= 98)
            {
                if (numbersDivisibleBySeven.Contains(m))
                {
                    return new long[] { m, count };
                }
                else
                {
                    return new long[] { 0, 0 };
                }
            }
            else
            {
                long lastDigit = m % 10;
                long tenX = m - lastDigit;
                long x = tenX / 10;
                long intermediateResult = x - 2 * lastDigit;
                count++;
                return Seven(intermediateResult);
            }
        }

        static void Main(string[] args)
        {
            long[] result = Seven(371);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}