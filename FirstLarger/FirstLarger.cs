using System;
using System.Linq;

namespace FirstLarger
{
    class FirstLarger
    {
        static void LargerIndex()
        {
            int index = 0;
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] intArray = input.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 1; i < intArray.Length - 1; i++)
            {
                if (intArray[i - 1] < intArray[i] && intArray[i] > intArray[i + 1])
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine(index);
        }

        static void Main(string[] args)
        {
            LargerIndex();
        }
    }
}
