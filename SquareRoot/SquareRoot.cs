using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                double input = double.Parse(Console.ReadLine());
                if (input < 0)
                {
                    Console.WriteLine("Invalid number");
                }
                else
                {
                    Console.WriteLine("{0:f3}", Math.Sqrt(input));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
