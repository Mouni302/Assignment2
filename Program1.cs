using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program1
    {
         public static int CountCharacters(string sentence)
         {
            //String name = sentence;
            int count = 0;
            foreach (char c in sentence)
            {
                if (c != ' ')
                {
                    count++;
                }
            }
            return count;
         }

    
        public static int CountWords(string sentence)
        {
            string[] words = sentence.Split(" ");
            return words.Length;
        }

    
        public static string ReverseSentence(string sentence)
        {
            char[] charArray = sentence.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    
        public static bool IsPalindrome(string sentence)
        {
            string name = sentence.Replace(" ", "").ToLower();
            string reversed = ReverseSentence(name);
            return name == reversed;
        }

    
        public static (int vowels, int consonants, int integers, int specialChars) CountElements(string sentence)
        {
            int vowels = 0, consonants = 0, integers = 0, specialChars = 0;

            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                {
                    if ("aeiouAEIOU".IndexOf(c) >= 0)
                        vowels++;
                    else
                        consonants++;
                }
                else if (char.IsDigit(c))
                {
                    integers++;
                }
                else if (!char.IsWhiteSpace(c))
                {
                    specialChars++;
                }
            }

            return (vowels, consonants, integers, specialChars);
        }

    
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.WriteLine($"\n1. Number of characters: {CountCharacters(sentence)}");
            Console.WriteLine($"2. Number of words: {CountWords(sentence)}");
            Console.WriteLine($"3. Reversed sentence: {ReverseSentence(sentence)}");
            Console.WriteLine($"4. Is palindrome: {(IsPalindrome(sentence) ? "Yes" : "No")}");

            
            var (vowels, consonants, integers, specialChars) = CountElements(sentence);
            Console.WriteLine($"5. Vowels: {vowels}, Consonants: {consonants}, Integers: {integers}, Special Characters: {specialChars}");
        }
    }
}
