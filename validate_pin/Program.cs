using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace validate_pin
{
    class Program
    {
        public class Kata
        {
            public static bool ValidatePin(string pin)
            {
                bool validLength = false;
                bool allDigits = pin.All(Char.IsDigit);

                if (pin.Length == 4 || pin.Length == 6)
                {
                    validLength = true;
                }

                return validLength && allDigits;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
