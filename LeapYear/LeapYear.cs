using System;

namespace LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(input)? "Leap": "Common");
        }
    }
}
