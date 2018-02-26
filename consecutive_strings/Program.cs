using System;

namespace consecutive_strings
{
    class Program
    {
        public static String LongestConsec(string[] strarr, int k)
        {
            // your code
            int n = strarr.Length; // we'll be using this a lot

            if (n == 0 || k > n || k <= 0)
            {
                return "";
            }
            else
            {
                // body goes here
                int startIndex = 0; // will be the index of the beginning of the result string
                int resultLength = 0; // length of result string
                string resultString = ""; // will be the result string that is returned

                for (int i = 0; i < n - k + 1; i++)
                {
                    string testString = "";

                    for (int j = i; j < i + k; j++)
                    {
                        //Console.WriteLine("i = {0}, j = {1}", i, j);
                        testString += strarr[j];
                    }
                    //Console.WriteLine("testString = {0}", testString);


                    if (testString.Length > resultLength)
                    {
                        resultLength = testString.Length;
                        startIndex = i;
                    }
                }

                // now form the result string
                for (int m = startIndex; m < startIndex + k; m++)
                {
                    resultString += strarr[m];
                }

                return resultString;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] array1 = { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" };
            int k1 = 2;
            Console.WriteLine(LongestConsec(array1, k1));

            string[] array2 = { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" };
            int k2 = 1;
            Console.WriteLine(LongestConsec(array2, k2));

            string[] array3 = { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" };
            int k3 = 2;
            Console.WriteLine(LongestConsec(array3, k3));
        }
    }
}
