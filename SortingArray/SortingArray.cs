using System;
using System.Linq;

namespace SortingArray
{
    class SortingArray
    {
        static void ArrSorter()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] intArray = input.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Array.Sort(intArray);
            Console.WriteLine(String.Join(" ", intArray));


        }

        static void Main(string[] args)
        {
            ArrSorter();
        }
    }
}
