using System;

namespace StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            char[] inputAsChar = new char[20];
            for (int i = 0; i < inputAsChar.Length; i++)
            {
                if (i < input.Length)
                {
                    inputAsChar[i] = input[i];
                }
                else
                {
                    inputAsChar[i] = '*';
                }
            }
            
            Console.WriteLine(inputAsChar);
        }
    }
}
