using System;

/* As a part of this Kata, you need to create a function that when provided with a triplet, returns the index of the numerical element that lies between the other two elements.

The input to the function will be an array of three distinct numbers (Haskell: a tuple).

For example:

gimme([2, 3, 1]) => 0
2 is the number that fits between 1 and 3 and the index of 2 in the input array is 0.

Another example (just to make sure it is clear):

gimme([5, 10, 14]) => 1
10 is the number that fits between 5 and 14 and the index of 10 in the input array is 1.
 */

namespace find_middle_value
{
    class Program
    {
        public class Kata
        {
            public static int Gimme(double[] inputArray)
            {
                // Implement this function
                double maximum = inputArray[0];
                double minimum = inputArray[0];
                int indexOfMiddle = 0;

                // find maximum value
                for (int i = 0; i < 3; i++)
                {
                    if (inputArray[i] > maximum)
                    {
                        maximum = inputArray[i];
                    }
                }

                // find minimum value
                for (int j = 0; j < 3; j++)
                {
                    if (inputArray[j] < minimum)
                    {
                        minimum = inputArray[j];
                    }
                }

                // find index of middle value
                for (int k = 0; k < 3; k++)
                {
                    if (inputArray[k] > minimum && inputArray[k] < maximum)
                    {
                        indexOfMiddle = k;
                    }
                }

                return indexOfMiddle;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
