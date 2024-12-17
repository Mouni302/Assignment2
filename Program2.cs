using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program2
    {
        public static bool CompareStrings(string str1, string str2)
        {
            return str1 == str2;
        }

        
        public static string CopyString1(string str1, string str2)
        {
            str1 = str2;
            return str1;
        }

        public static string CopyString2(string str1, string str2)
        {
            str2 = str1;
            return str2;
        }


        public static string CombineStrings(string str1, string str2)
        {
            return str1 + str2;
        }

        // Main method
        static void Main(string[] args)
        {
            Console.Write("Enter the first string: ");
            string string1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string string2 = Console.ReadLine();

            // Perform operations
            Console.WriteLine($"\n1. Are the two strings equal? {(CompareStrings(string1, string2) ? "Yes" : "No")}");

            string copiedString1 = CopyString1(string1, string2);
            Console.WriteLine($"2. Copying the second string in first string: {copiedString1}");

            string copiedString2 = CopyString2(string1, string2);
            Console.WriteLine($"3. Copying the first string in the second string: {copiedString2}");

            string combinedString = CombineStrings(string1, string2);
            Console.WriteLine($"4. Combining the two strings: {combinedString}");
        }
    }
}
