using System;
using System.Collections.Generic;
using System.Linq;

/* Input:

a string strng
an array of strings arr
Output of function contain_all_rots(strng, arr) (or containAllRots or contain-all-rots):

a boolean true if all rotations of strng are included in arr (C returns 1)
false otherwise (C returns 0) */

namespace all_inclusive
{
    class Program
    {
        public class Rotations
        {
            public static Boolean ContainAllRots(string strng, List<string> arr)
            {
                // your code
                Console.WriteLine(strng);

                if (strng == "")
                {
                    return true;
                }
                else
                {
                    List<bool> testResults = new List<bool>();

                    // Step 1: check if arr contains the original string
                    if (arr.Contains(strng))
                    {
                        testResults.Add(true);
                    }
                    else
                    {
                        testResults.Add(false);
                    }

                    // Step 2: loop through the rotations of strng
                    if (strng.Length > 1)
                    {
                        for (var i = 1; i < strng.Length; i++)
                        {
                            // compute the i'th rotation of strng
                            string rotation = strng.Remove(0, i) + strng.Substring(0, i);
                            Console.WriteLine(rotation);

                            // check if arr contains the rotation
                            if (arr.Contains(rotation))
                            {
                                testResults.Add(true);
                            }
                            else
                            {
                                testResults.Add(false);
                            }

                        }
                    }

                    Console.WriteLine(testResults.Count());
                    foreach (var item in testResults)
                    {
                        Console.WriteLine(item);
                    }

                    // check if all members of testResults are true
                    if (testResults.All(c => c == true))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
