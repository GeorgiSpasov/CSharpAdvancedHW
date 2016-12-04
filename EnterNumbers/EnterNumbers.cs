using System;
using System.Collections.Generic;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {

            int start = 1;

            List<int> colection = new List<int>();

            colection.Add(start);

            int i = 1;

            try
            {
                while (i < 12)
                {
                    var end = i != 11 ? int.Parse(Console.ReadLine()) : 100;

                    if (ReadNumber(start, end))
                    {
                        throw new Exception();
                    }
                    colection.Add(end);

                    start = end;

                    i = i + 1;
                }
                Console.WriteLine(String.Join(" < ", colection));
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }

        private static bool ReadNumber(int start, int end)
        {
            return !(start < end);
        }
    }
}
