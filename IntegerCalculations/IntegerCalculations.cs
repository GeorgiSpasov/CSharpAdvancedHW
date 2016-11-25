using System;
using System.Linq;

namespace IntegerCalculations
{
    class IntegerCalculations
    {
        static void Minimum(string input)
        {
            double[] numbers = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Console.WriteLine(numbers.Min());
        }
        static void Maximum(string input)
        {
            double[] numbers = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Console.WriteLine(numbers.Max());
        }
        static void Average(string input)
        {
            double[] numbers = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Console.WriteLine("{0:f2}", numbers.Average());
        }
        static void Sum(string input)
        {
            double[] numbers = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Console.WriteLine(numbers.Sum());
        }
        static void Product(string input)
        {
            int[] numbers = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            long product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            Console.WriteLine(product);
        }

        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Minimum(inputString);
            Maximum(inputString);
            Average(inputString);
            Sum(inputString);
            Product(inputString);
        }
    }
}
