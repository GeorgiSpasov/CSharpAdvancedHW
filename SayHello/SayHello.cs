using System;

namespace SayHello
{
    class SayHello
    {
        public static void SayHi(String name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            SayHi(name);
        }
    }
}
