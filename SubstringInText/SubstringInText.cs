using System;

namespace SubstringInText
{
    class SubstringInText
    {
        static void Main(string[] args)
        {
            string substring = Console.ReadLine().ToLower();
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(SubStringInText(substring, input));
        }

        static int SubStringInText(string pattern, string inputSentence)
        {
            int counter = 0;
            int i = 0;
            while ((i = inputSentence.IndexOf(pattern, i)) != -1)
            {
                counter++;
                i++;
            }
            return counter;
        }
    }
}
