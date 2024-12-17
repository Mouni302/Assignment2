using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program3
    {
        //public static (int sum, int difference, int product, double quotient) PerformOperations(int num1, int num2)
        //{
        //    int sum = num1 + num2;
        //    int difference = num2 - num1;
        //    int product = num1 * num2;
        //    double quotient = num2 != 0 ? (double)num1 / num2 : double.NaN; 
        //    return (sum, difference, product, quotient);
        //}
        
        public static void Addition(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }

        public static void Subtraction(int num1, int num2)
        {
            int sub = num2 - num1;
            Console.WriteLine(sub);
        }

        public static void Multiplication(int num1, int num2)
        {
            int mul = num1 * num2;
            Console.WriteLine(mul);
        }

        public static void Quotient(int num1, int num2)
        {
            int quotient = num1/num2;
            Console.WriteLine(quotient);
        } 

        public static void PrintTables(int start, int end)
        {
            for (int i = Math.Min(start, end); i <= Math.Max(start, end); i++)
            {
                Console.WriteLine($"\nTable for {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }

        
        public static void PrintPrimes(int start, int end)
        {
            Console.WriteLine("\nPrime numbers:");
            for (int i = Math.Min(start, end); i <= Math.Max(start, end); i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        
        private static bool IsPrime(int num)
        {
            if (num < 2) return false; 

            for (int i = 2; i < num; i++) 
            {
                if (num % i == 0) 
                {
                    return false; 
                }
            }
            return true; 
        }

        
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

           
            //var (sum, difference, product, quotient) = PerformOperations(num1, num2);
            //Console.WriteLine($"\n1. Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}");

            Console.WriteLine("\n2. Addition of Numbers:");
            Addition(num1, num2);

            Console.WriteLine("\n2. Subtraction of Numbers:");
            Subtraction(num1, num2);

            Console.WriteLine("\n2. Multiplication of Numbers:");
            Multiplication(num1, num2);

            Console.WriteLine("\n2. Quotient of Numbers:");
            Quotient(num1, num2);

            Console.WriteLine("\n2. Multiplication tables:");
            PrintTables(num1, num2);

            Console.WriteLine("\n3. Prime numbers between the two:");
            PrintPrimes(num1, num2);
        }
    }
}
