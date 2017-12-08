using System;
using System.Collections.Generic;

/* Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits. */

namespace counting_duplicates
{
    class Program
    {
        public class Kata
        {
            public static int DuplicateCount(string str)
            {
                string lowerCase = str.ToLower();
                char[] characters = lowerCase.ToCharArray();
                int numberOfDuplicates = 0;
                List<char> searchedCharacters = new List<char>();

                for (var i = 0; i < characters.Length; i++)
                {
                    if (!searchedCharacters.Contains(characters[i]))
                    {
                        int tempCount = 1; // each character occurs at least one time in the string

                        for (var j = i + 1; j < characters.Length; j++)
                        {
                            if (characters[j] == characters[i])
                            {
                                tempCount++; // if the character occurs more than once, increment tempCount
                            }
                        }

                        if (tempCount > 1) // if the character occurs more than once,
                        {
                            numberOfDuplicates++; // increment numberOfDuplicates
                        }

                        searchedCharacters.Add(characters[i]);

                    }
                }

                return numberOfDuplicates;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
