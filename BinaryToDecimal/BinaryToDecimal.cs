using System;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            Console.WriteLine(Convert.ToUInt64(binary, 2).ToString());
        }
    }
}
