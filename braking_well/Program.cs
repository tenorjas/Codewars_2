using System;

namespace braking_well
{
    class Program
    {
        public static double Dist(double v, double mu)        // suppose reaction time is 1
        {
            // your code
            double g = 9.81; // gravity in m/s/s
            double t = 1;    // reaction time = 1 second
            double v1 = v * 0.27777777777777777778; // convert kph to mps

            double reactionDistance = v1 * t;
            double brakingDistance = v1 * v1 / (2 * mu * g);

            // Console.WriteLine(reactionDistance);
            // Console.WriteLine(brakingDistance);

            return reactionDistance + brakingDistance;
        }

        public static double Speed(double d, double mu)       // suppose reaction time is 1
        {
            // your code
            double g = 9.81;
            double t = 1;

            // now we have to do some algebra
            // namely find the positive root of a quadratic equation
            double determinant = t * t + 2 * d / (mu * g);
            double sqrtD = Math.Sqrt(determinant);

            // root of quadratic equation is initial velocity in mps
            double v1 = mu * g *(-1*t + sqrtD);
            // now convert to kph
            double v = v1 / 0.27777777777777777778;

            return v;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double d1 = Dist(100, 0.7);
            Console.WriteLine(d1);

            double v1 = Speed(83.9598760937531, 0.7);
            Console.WriteLine(v1);
        }
    }
}
