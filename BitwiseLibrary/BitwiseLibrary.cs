using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseLibrary
{
    class BitwiseLibrary
    {
        static void Main(string[] args)
        {
            //ushort a = 3;                // 00000000 00000011
            //ushort b = 5;                // 00000000 00000101
            //Console.WriteLine(a | b);    // 00000000 00000111
            //Console.WriteLine(a & b);    // 00000000 00000001
            //Console.WriteLine(a ^ b);    // 00000000 00000110
            //Console.WriteLine(~a & b);   // 00000000 00000100
            //Console.WriteLine(a << 1);   // 00000000 00000110
            //Console.WriteLine(a >> 1);   // 00000000 00000001

            int p = 5;
            int n = 35;     
            
            int result = setBit(n, p);
            Console.WriteLine(result);
        }

        static int getBit(int number, int position) //How to get the bit at position p in a number n?
        {
            //int n = 35;                    // 00000000 00100011
            int mask = 1 << position;        // 00000000 00100000
            int nAndMask = number & mask;    // 00000000 00100000
            int bit = nAndMask >> position;  // 00000000 00000001
            return bit;                      // 1
        }

        static int setBit(int number, int position) //How to set the bit at position p to 0?
        {
            //int number = 35;            // 00000000 00100011
            int mask = ~(1 << position);  // 11111111 11011111
            int result = number & mask;   // 00000000 00000011
            return result;                // 3
        }

    }
}
