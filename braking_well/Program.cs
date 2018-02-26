using System;

namespace braking_well
{
    class Program
    {
        public static double Dist(double v, double mu)        // suppose reaction time is 1
        {
            // your code
            double g = 9.81;
            double t = 1;
            double v1 = v * 0.27777777777777777778;

            double reactionDistance = v1 * t;
            double brakingDistance = v1 * v1 / (2 * mu * g);

            // Console.WriteLine(reactionDistance);
            // Console.WriteLine(brakingDistance);

            return reactionDistance + brakingDistance;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double d1 = Dist(100,0.7);
            Console.WriteLine(d1);
        }
    }
}
