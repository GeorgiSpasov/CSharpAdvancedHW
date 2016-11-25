using System;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void NumberReverser()
        {
            string number = Console.ReadLine();
            //char[] reversedNumber = new char[number.Length];
            for (int i = number.Length - 1, j = 0; i >= 0; i--, j++)
            {
                //reversedNumber[j] = number[i];
                Console.Write(number[i]);
            }
        }

        static void Main(string[] args)
        {
            NumberReverser();
        }
    }
}
