using System;
using System.Linq;

namespace consecutive_k_primes
{
    class Program
    {
        public static int ConsecKprimes(int k, long[] arr)
        {
            // your code
            int numberOfConsecutives = 0;

            // this is an internal function that calculates the number of prime factors of a number
            int NumberOfPrimes(long number, int i = 0, int numPrimes = 1)
            {
                long[] primes = new long[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997 };
                // base condition
                if (primes.Contains(number))
                {
                    return numPrimes;
                }

                if (number % primes[i] == 0)
                {
                    number = number / primes[i];
                    numPrimes++;
                    return NumberOfPrimes(number, i, numPrimes);
                }
                else
                {
                    i++; // move on to the next prime number
                    return NumberOfPrimes(number, i, numPrimes);
                }
            }

            // this is the "main" part of ConsecKprimes
            for (var j = 0; j < arr.Length - 1; j++)
            {
                int a = NumberOfPrimes(arr[j]);
                int b = NumberOfPrimes(arr[j + 1]);

                if (a == k && a == b)
                {
                    numberOfConsecutives++;
                }
            }

            return numberOfConsecutives;
        }
        static void Main(string[] args)
        {
            // this is dummy code just to have something in the Main function
            // Console.WriteLine("Hello World!");
            // int[] primes = { 2, 3, 5, 7 };

            // for (var i = 0; i < primes.Length; i++)
            // {
            //     Console.WriteLine(primes[i]);
            // }

            // this is actual testing code
            long[] array1 = { 10005, 10030, 10026, 10008, 10016, 10028, 10004 };
            int k1 = 4;

            int consec1 = ConsecKprimes(k1, array1);

            Console.WriteLine("According to calculations, array1 contains {0} consecutive {1}-primes.", consec1, k1);
            Console.WriteLine("Expected value is 3.");

        }
    }
}
