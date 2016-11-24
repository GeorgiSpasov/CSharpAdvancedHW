using System;
using System.Linq;

namespace GetLargestNumber
{
    class GetLargestNumber
    {
        public static void GetMax()
        {

            string list = Console.ReadLine();
            //char[] separators = new char[] { ',', ' ', '.' };
            //int[] nums = list.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] nums = list.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int a = nums[0];
            int b = nums[1];
            int c = nums[2];

            Console.WriteLine((a>b && a>c)?a:((b>c)?b:c));
        }

        static void Main(string[] args)
        {
            GetMax();
        }
    }
}
