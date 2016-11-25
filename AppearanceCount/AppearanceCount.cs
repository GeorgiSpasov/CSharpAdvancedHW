using System;
using System.Linq;

namespace AppearanceCount
{
    class AppearanceCount
    {
        static void IntCounter()
        {
            int counter = 0;
            int n = int.Parse(Console.ReadLine());
            //int[] intArray = new int[n];
            string input = Console.ReadLine();
            int[] intArray = input.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int x = int.Parse(Console.ReadLine());


            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == x)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }

        static void Main(string[] args)
        {
            IntCounter();
        }
    }
}
