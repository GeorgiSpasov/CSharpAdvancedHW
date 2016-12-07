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

            int p = 4;
            int n = 35;

            PrintBinary(n);
            int rotated = RotateRight(n, 2);
            PrintBinary(rotated);
        }


        static int GetBit(int number, int position) //How to get the bit at position p in a number n?
        {
            //int position = 5;
            //int n = 35;                    // 00000000 00100011
            int mask = 1 << position;        // 00000000 00100000
            int nAndMask = number & mask;    // 00000000 00100000
            int bit = nAndMask >> position;  // 00000000 00000001
            return bit;                      // 1
        }

        static int SetBit0(int number, int position) //How to set the bit at position p to 0?
        {
            //int position = 5;
            //int number = 35;            // 00000000 00100011
            int mask = ~(1 << position);  // 11111111 11011111
            int result = number & mask;   // 00000000 00000011
            return result;                // 3
        }

        static int SetBit1(int number, int position) //How to set the bit at position p to 1?
        {
            //int position = 4;
            //int number = 35;           // 00000000 00100011
            int mask = 1 << position;    // 00000000 00010000
            int result = number | mask;  // 00000000 00110011
            return result;               // 51
        }

        static void PrintBinary(int number) //How to print a binary number to the console?
        {
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            // 00000000000000000000000000110011
        }

        public static int RotateLeft(int value, int count)
        {
            uint val = (uint)value;
            return (int)((val << count) | (val >> (32 - count)));
        }

        public static int RotateRight(int value, int count)
        {
            uint val = (uint)value;
            return (int)((value >> count) | (value << (32 - count)));
        }

        public static byte RotateLeft(byte value, int count) //Overloads on shorter int values
        {
            // Note that if you want to create overloads that operate on shorter integral values, you need to add an extra step, as shown in:
            // Unlike the RotateLeft( uint, int ) and RotateLeft( ulong, int ) 
            // overloads, we need to mask out the required bits of count 
            // manually, as the shift operaters will promote a byte to uint, 
            // and will not mask out the correct number of count bits.
            // The masking operation is not needed for the 32-bit and 64-bit overloads, as the shift operators themselves take care of it for those sizes of left-hand operands.
            count &= 0x07;
            return (byte)((value << count) | (value >> (8 - count)));
        }

        // If you are using strings
        public static int RotateRightString(int number)
        {
            string str = Convert.ToString(number, 2);
            str = str.PadLeft(32, '0');
            str = str.PadLeft(33, str[str.Length - 1]);
            str = str.Remove(str.Length - 1);
            return number = Convert.ToInt32(str, 2);
        }

        public static int RotateLeftString(int number)
        {
            string str = Convert.ToString(number, 2);
            str = str.PadLeft(32, '0');
            str = str.PadRight(33, str[0]);
            str = str.Remove(0, 1);
            return number = Convert.ToInt32(str, 2);
        }
    }

}
