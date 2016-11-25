using System;
using System.Linq;

namespace NumberAsArray
{
    class NumberAsArray
    {
        static void SumArr()
        {
            string input = Console.ReadLine();
            string inputString1 = Console.ReadLine();
            string inputString2 = Console.ReadLine();

            int[] intArray1 = inputString1.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] intArray2 = inputString2.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int temp = 0;
            int[] result = (intArray1.Length >= intArray2.Length)? intArray1: intArray2;

            for (int i = 0; i < ((intArray1.Length <= intArray2.Length) ? intArray1.Length : intArray2.Length); i++)
            {
                if (intArray1.Length >= intArray2.Length)
                {
                    temp = result[i] + intArray2[i];
                    result[i] = temp % 10;
                }
                else
                {
                    temp = result[i] + intArray1[i];
                    result[i] = temp % 10;
                }
                if (i+1<result.Length)
                {
                    result[i + 1] = result[i + 1] + temp / 10;
                }
            }
            Console.WriteLine(string.Join(" ", result));           
        }

        static void Main(string[] args)
        {
            while (true)
            {
                SumArr();
            }
        }
    }
}
