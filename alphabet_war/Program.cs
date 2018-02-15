using System;

namespace alphabet_war
{
    class Program
    {
        public static string AlphabetWar(string fight)
        {
            char[] characters = fight.ToCharArray();
            int left = 0;
            int right = 0;
            int x = characters.Length;

            // Note: the following two if statements are needed in order to
            // avoid an out of bounds error in the following for loop
            // if (characters[0] == '*') 
            // {
            //     characters[0] = '_'; 
            //     characters[1] = '_';
            // }

            // if (characters[x - 1] == '*') 
            // {
            //     characters[x-2] = '_';
            //     characters[x - 1] = '_'; 
            // }

            // iterate through the array and change all of the *s and the
            // adjacent characters to _
            for (int i = 0; i < x; i++)
            {
                if (i == 0)
                {
                    if (characters[i] == '*')
                    {
                        characters[i] = '_';
                        if (characters[i + 1] != '*')
                            characters[i + 1] = '_';
                    }
                }
                else if (i == x - 1)
                {
                    if (characters[i] == '*')
                    {
                        if (characters[i - 1] != '*')
                            characters[i - 1] = '_';
                        characters[i] = '_';
                    }
                }
                else
                {
                    if (characters[i] == '*')
                    {
                        if (characters[i - 1] != '*')
                            characters[i - 1] = '_';
                        characters[i] = '_';
                        if (characters[i + 1] != '*')
                            characters[i + 1] = '_';
                    }
                }
            }

            // loop through the array a second time and compute the left and right
            // score
            for (int j = 0; j < x; j++)
            {
                if (characters[j] == 'w')
                    left += 4;
                else if (characters[j] == 'p')
                    left += 3;
                else if (characters[j] == 'b')
                    left += 2;
                else if (characters[j] == 's')
                    left += 1;
                else if (characters[j] == 'm')
                    right += 4;
                else if (characters[j] == 'q')
                    right += 3;
                else if (characters[j] == 'd')
                    right += 2;
                else if (characters[j] == 'z')
                    right += 1;
            }

            // return result
            if (left > right)
                return "Left side wins!";
            else if (right > left)
                return "Right side wins!";
            else
                return "Let's fight again!";

        }
        static void Main(string[] args)
        {
            // run sample test cases from CodeWars
            Console.WriteLine(AlphabetWar("z"));
            Console.WriteLine(AlphabetWar("****"));
            Console.WriteLine(AlphabetWar("z*dq*mw*pb*s"));
            Console.WriteLine(AlphabetWar("zdqmwpbs"));
            Console.WriteLine(AlphabetWar("zz*zzs"));
            Console.WriteLine(AlphabetWar("*wwwwww*z*"));
        }
    }
}
