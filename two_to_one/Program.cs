using System;
using System.Collections.Generic;

/* Take 2 strings s1 and s2 including only letters from ato z. Return a new sorted string, the longest possible, containing distinct letters,

 */

namespace two_to_one
{
    class Program
    {
        public class TwoToOne
        {

            public static string Longest(string s1, string s2)
            {
                // your code
                List<char> lettersInStrings = new List<char>();
                char[] array1 = s1.ToCharArray();
                char[] array2 = s2.ToCharArray();

                foreach (var character1 in array1)
                {
                    Console.WriteLine(character1);
                    if (!lettersInStrings.Contains(character1))
                    {
                        lettersInStrings.Add(character1);
                    }
                }

                foreach (var character2 in array2)
                {
                    if (!lettersInStrings.Contains(character2))
                    {
                        lettersInStrings.Add(character2);
                    }
                }

                char[] arrayOfCharacters = lettersInStrings.ToArray();
                Array.Sort(arrayOfCharacters);

                // This is the step I had to look up:
                string finalString = new string(arrayOfCharacters);
                return finalString;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
