using System;

namespace EnglishDigit
{
    class EnglishDigit
    {
        static void IntToWord()
        {
            string input = Console.ReadLine();
            int lastDigit = Convert.ToInt32(input[input.Length - 1] - '0');
            string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine(words[lastDigit]);
        }

        static void Main(string[] args)
        {
            IntToWord();
        }
    }
}
