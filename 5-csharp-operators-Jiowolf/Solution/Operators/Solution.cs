using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Solution
    {
        public static string IsAdult(int age)
        {
            string result = (age >= 18) ? "You are an adult" : "You are a child";

            return result;
        }


        public static string EvenOrOdd(int num)
        {
            string result = (num%2 == 0) ? "Even" : "Odd";
            return result;
        }

        public static int Add(int a, int b) 
        { 
            return a + b;
        }

        public static int Max(int a, int b) 
        {
            return Math.Max(a, b);
        }
    }

    
}
