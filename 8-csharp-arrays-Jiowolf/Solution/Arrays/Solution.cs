using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Solution
    {
        public static string FirstArray()
        {
            int[] num = new int[10];
            string arr = "";

            for (int i = 0; i< num.Length; i++)
            {
                Random rnd = new Random();
                int rand = rnd.Next(1, 10);
                num[i] = rand;
                arr += rand;
            }

            return arr;
        }

        public static int Sum(int[] numbers)
        {
            int sum = 0;

            foreach (int item in numbers)
            {
                sum += item;
            }
            return sum;
        }

        public static double Average(int[] numbers)
        {
            int sum = Sum(numbers);

            double average = sum / (double)numbers.Length;

            return average;
        }

        public static void MaxAndMin(int[] numbers, out int max, out int min)
        {
            max = numbers.Max();
            min = numbers.Min();
        }

        public static int[] SortAndArray(int[] numbers)
        {
            Array.Sort(numbers);

            return numbers;
        }

        public static string Palindrome(int[] numbers)
        {
            int[] comparate = new int[numbers.Length];
            Array.Copy(numbers,comparate,numbers.Length);
            Array.Reverse(comparate);
            
            if (comparate.SequenceEqual(numbers) == true)
            {
                return "The array is a palindrome";
            }else
            {
                return "The array is not a palindrome";
            }


            
        }
    }
}
