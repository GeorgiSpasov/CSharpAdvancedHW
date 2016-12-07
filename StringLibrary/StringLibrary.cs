using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLibrary
{
    class StringLibrary
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(StringToIntArray(input).Sum());
        }

        public static int[] StringToIntArray(string input)
        {
            int[] intArray = input.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            return intArray;
        }

        public static string Decode(string encoded)
        {
            var result = "";

            for (var i = 0; i < encoded.Length; i++)
            {
                var currentRepeat = "";

                while (char.IsDigit(encoded[i]))
                {
                    currentRepeat += encoded[i];
                    i++;
                }

                if (currentRepeat == "")
                {
                    currentRepeat = "1";
                }

                var amount = int.Parse(currentRepeat);

                result += new String(encoded[i], amount);
            }

            return result;
        }
    }
}
