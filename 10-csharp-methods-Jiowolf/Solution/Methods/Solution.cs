using System;
using System.Diagnostics.CodeAnalysis;

namespace Methods
{
    public class Solution
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static string Whos(string firstName, string lastName, int age)
        {
            return $"Firstname : {firstName}\nLastname : {lastName}\nAge : {age}";
        }

        public static void SumAndProduct(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a* b;
        }

        public static (int quotient, int remainder) QuotientAndRemainder(int a, int b)
        {
                return (a / b, a % b);
        }

        public static int MethodWithDefaultValue(int nbr = 10)
        {
            //if (nbr == 10)
            //{
            //    return "The result with no provided value should be 20 (10 by default multiplied by 2).";
            //}
            //else
            //{
            //    return $"The result with a value of {nbr} should be {nbr * 2}.";
            //}
            return nbr * 2;
        }
    }
}
