using System;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            
            int bracket1 = 0;
            int bracket2 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    bracket1++;
                }
                if (input[i] == ')')
                {
                    bracket2++;
                }
            }
            bool correctOrNot = bracket1 == bracket2;
            
            Console.WriteLine(correctOrNot ? "Correct" : "Incorrect");
        }
    }
}
