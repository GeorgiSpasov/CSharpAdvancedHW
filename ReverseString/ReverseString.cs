using System;
using System.Text;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder reverser = new StringBuilder(10000);

            for (int i = input.Length -1; i >= 0; i--)
            {
                reverser.Append(input[i]);
            }
            Console.WriteLine(reverser);
        }
    }
}
