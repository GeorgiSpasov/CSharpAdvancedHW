using System;
using System.Numerics;

namespace NFactorial
{
    class NFactorial
    {
        static BigInteger FactorialNCalc(int n)
        {
            BigInteger result = n;
            if (n != 0)
            {
                for (int i = 1; i < n; i++)
                {
                    result = result * i;
                }
            }
            else
            {
                result = 1;
            }
            return result;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FactorialNCalc(n));
        }
    }
}
