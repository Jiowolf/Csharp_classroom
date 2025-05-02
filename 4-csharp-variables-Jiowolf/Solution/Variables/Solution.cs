using System;

namespace Variables
{
    public class Solution
    {
        public static string SayHello(string name)
        {
            return $"Hello {name}";
        }

        public static float AgeToFloat(float age)
        {
            float miAge = age / 2;

            return miAge;
        }

        public static decimal CelciusToFarenheit(decimal celcius)
        {
            decimal farenheit = (celcius * 9 / 5) + 32;

            return farenheit;
        }

        public static double KilometersToMiles(int kilometers)
        {
            double miles = kilometers * 0.6;

            return miles;
        }

        public static int MathRandom()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 11);

            return random;
        }
    }
}
