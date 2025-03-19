using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//It looks like you've set up a structure for a program that takes an input string and performs several operations on it,
//such as:
//Swap adjacent words.
//Reverse the words.
//Capitalize the first letter of each word.
//Remove punctuation.
//Count the number of characters (excluding punctuation).

namespace PractiseQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = GetInput("");
            string wordSwapped = SwapAdjacentWords(input);
            string reversed = ReverseWords(input);
            string capitalized = CapitalizeFirstLetter(input);
            string noPunctuation = RemovePunctuation(input);
            int characterCount = CountCharacters(noPunctuation);

            Console.WriteLine($"Word Swapped: {wordSwapped}");
            Console.WriteLine($"Reversed: {reversed}");
            Console.WriteLine($"Capitalized: {capitalized}");
            Console.WriteLine($"No Punctuation: {noPunctuation}");
            Console.WriteLine($"Character Count: {characterCount}");

        }
        static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
        private static int CountCharacters(string input)//string noPunctuation)
        {
            return input.Replace(" ", "").Length;
        }

        private static string RemovePunctuation(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private static string CapitalizeFirstLetter(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = Char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            return string.Join(" ", words);
        }

        private static string ReverseWords(string input)
        {
            string[] words = input.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        private static string SwapAdjacentWords(string input)
        {
            string[] words = input.Split(' ');

            // If the number of words is odd, leave the last word as it is
            for (int i = 0; i < words.Length - 1; i += 2)
            {
                // Swap adjacent words
                string temp = words[i];
                words[i] = words[i + 1];
                words[i + 1] = temp;
            }

            // Join the words back into a single string and return
            return string.Join(" ", words);
        }

        
    }
}
