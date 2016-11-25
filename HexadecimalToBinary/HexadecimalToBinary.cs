using System;

namespace HexadecimalToBinary
{
    class HexadecimalToBinary
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            Console.WriteLine(Convert.ToString(Convert.ToInt64(hex, 16), 2));
        }
    }
}