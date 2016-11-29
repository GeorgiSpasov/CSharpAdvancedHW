using System;
using System.Linq;

namespace SumIntegers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] intArray = input.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(intArray.Sum());
        }
    }
}
