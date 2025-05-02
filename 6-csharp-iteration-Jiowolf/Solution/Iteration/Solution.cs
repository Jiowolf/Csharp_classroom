using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Iteration
{
    public class Solution
    {
        public static int SumOfNumbers()
        {
            int sum = 0;
            for(int i = 1; i <= 100; i++)
            {
                sum+= i;
            }
            return sum;
        }
        
        public static int Factorial(int num)
        {
            try
            {
                if(num >= 0)
                {

                int factorial = 1;
                int i = 1;
                while (i < num+1)
                {
                    factorial = factorial * i;
                    i++;
                }

                return factorial;
                }else
                {
                    throw new ArgumentException("Nop it dosen't work");
                }
            }
            catch (ArgumentException) 
            {
                throw;
            }
        }

        public static string Nested()
        {
            string table = "";

            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    table += i+" x "+j+" = "+(i*j)+"\n" ;
                }
            }


            return table;
        }

        public static string Validate()
        {
            string result;
            int input;
            do
            {
                Console.Write("Ecrivez un nombre de 1 à 10 : ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out input)) 
                {
                    if (input >= 1 && input <= 10)
                    {
                        result = "is OK";
                        break; 
                    }
                    else
                    {
                        result = "Le nombre doit être entre 1 et 10 AGAIN !";
                        Console.WriteLine(result); 
                    }
                }
                else
                {
                    result = "Un nombre svp ";
                    Console.WriteLine(result); 
                }
            } while (result != "is OK");

            return result;
        }

        public static int Smol()
        {
            int smol;
            try
            {
                Console.Write("Ecrivez un nombre ");
                int userInput = int.Parse(Console.ReadLine());
                smol = userInput;
                while (userInput != 0)
                {
                    try
                    {
                        Console.Write("Ecrivez un nombre ");
                        userInput = int.Parse(Console.ReadLine());
                        smol = (userInput < smol) ? userInput : smol;
                    }
                    catch
                    {
                        Console.Write("J'ai dis un nombre !essaye encore \n");
                    }

                }
            }
            catch 
            {
                Console.Write("J'ai dis un nombre ! nb essai : ");
                return 1;
            }
            return smol;
        }
    }
}
