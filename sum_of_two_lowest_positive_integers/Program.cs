using System;

namespace sum_of_two_lowest_positive_integers
{
    class Program
    {
        public static class Kata
        {
            public static int sumTwoSmallestNumbers(int[] numbers)
            {
                //Code here...
                int smallest = numbers[0];
                int secondSmallest = numbers[0];

                for (var i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < smallest)
                    {
                        smallest = numbers[i];
                    }
                }

                if (numbers[0] == smallest)
                {
                    secondSmallest = numbers[1];
                    for (var j = 1; j < numbers.Length; j++)
                    {
                        if (numbers[j] < secondSmallest)
                        {
                            secondSmallest = numbers[j];
                        }
                    }
                }
                else
                {
                    for (var k = 0; k < numbers.Length; k++)
                    {
                        if (numbers[k] > smallest && numbers[k] < secondSmallest)
                        {
                            secondSmallest = numbers[k];
                        }
                    }
                }

                return smallest + secondSmallest;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
