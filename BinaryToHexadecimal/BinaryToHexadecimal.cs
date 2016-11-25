using System;

namespace BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            string hex = Convert.ToInt64(binary, 2).ToString("X");
            Console.WriteLine(hex);
        }
    }
}
