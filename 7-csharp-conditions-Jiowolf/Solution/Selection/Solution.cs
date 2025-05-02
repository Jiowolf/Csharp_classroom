using System;
using System.Diagnostics.Metrics;

namespace Selection
{
    public class Solution
    {

        public static int GetValidatedAge(string input)
        {
            try
            {
                //Console.Write("Hello, what is your age?");
                int age = int.Parse(input);
                if (age >= 100)
                {
                    throw new FormatException ("Invalid Age");
                }
                else if (age <= 0)
                {
                    throw new FormatException ("Invalid Age");
                }
                else
                {
                    return age;
                }
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid Age");
            }
            catch (ArgumentException)
            {
                throw;
            }
            

        }
        public static string CanEnterInTheCasino()
        {
            Console.Write("Hello, what is your age?");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
                {
                    return "You can enter! Be welcome!";
                }
                else
                {
                    return "Sorry, you can't enter! Be patient!";
                }
        }


        public static string SignOfNumber(int sign)
        {
            try
            {
                //Console.Write("Give me a number");
                //int userInput = int.Parse(Console.ReadLine());
                string result = sign switch
                {
                    > 0 => "The number is positive.",
                    < 0 => "The number is negative.",
                    0 => "The number is zero.",
                };
                return result;
            }
            catch (FormatException )
            {
                return "That's not a number";
            }
            catch (Exception )
            {
                return "Invalid number";
            }
        }

        public static double DiscountPriceCalculator(int index,double price)
        {
            try
            {
                double reduc = index switch
                {
                    1 => 0.1,
                    2 => 0.05,
                    3 => 0.2,
                    _ => throw new ArgumentException("Invalid choice. Please enter a number between 1 and 3.")
                };
                double discount = price - (price * reduc);
                return discount;
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid Age");
            }
        }

        public static string TriangleClassification(int aSide,int bSide,int cSide)
        {
            try
            {
                if (aSide == bSide && aSide == cSide)
                {
                    return "The triangle is equilateral.";
                }
                else if (aSide == bSide ^ aSide == cSide ^ bSide == cSide)
                {
                    return "The triangle is isosceles.";
                }
                else
                {
                    return "The triangle is scalene.";
                }
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid Age");
            }
            
        }
    }
}
