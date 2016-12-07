using System;
using System.Linq;
using System.Text;
using System.Numerics;

namespace SecretNumeralSystem
{
    class SecretNumeralSystem
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            // Decode numbers
            string[] decodedNumbers = new string[GetCodedInts(input).Length];
            for (int i = 0; i < GetCodedInts(input).Length; i++)
            {
                decodedNumbers[i] = DecodeString(GetCodedInts(input)[i]);
            }
            
            // Convert seven base to decimal
            ulong[] decimalInts = new ulong[decodedNumbers.Length];
            for (int i = 0; i < decodedNumbers.Length; i++)
            {
                decimalInts[i] = SevenToDec(decodedNumbers[i]);
            }

            //Multiply
            BigInteger result = 1;
            for (int i = 0; i < GetCodedInts(input).Length; i++)
            {
                result = result * decimalInts[i];
            }
            Console.WriteLine(result);
        }

        static string[] GetCodedInts(string input)
        {
            string[] codedInts = input.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            return codedInts;
        }

        static string DecodeString(string codedInts)
        {
            //string[] code = { "hristo", "tosho", "pesho", "hristofor", "vlad", "haralampi", "zoro", "vladimir" }; //original
            string result = codedInts;
            StringBuilder res = new StringBuilder(codedInts);
            

            string[] code = { "hristofor", "hristo", "tosho", "pesho", "vladimir", "vlad", "haralampi", "zoro" };
            foreach (string c in code)
            {
                switch (c)
                {
                    case "hristofor":
                        res.Replace(c, "3");
                        break;
                    case "hristo":
                        res.Replace(c, "0");
                        break;
                    case "tosho":
                        res.Replace(c, "1");
                        break;
                    case "pesho":
                        res.Replace(c, "2");
                        break;
                    case "vladimir":
                        res.Replace(c, "7");
                        break;
                    case "vlad":
                        res.Replace(c, "4");
                        break;
                    case "haralampi":
                        res.Replace(c, "5");
                        break;
                    case "zoro":
                        res.Replace(c, "6");
                        break;
                    default:
                        break;
                }
            }
            return res.ToString();
        }

        static ulong SevenToDec(string inputSbasedNumber)
        {
            ulong result = 0;
            for (int i = 0; i < inputSbasedNumber.Length; i++)
            {
                int currentDigit;
                if (inputSbasedNumber[i] < 58)
                {
                    currentDigit = inputSbasedNumber[i] - 48;
                }
                else
                {
                    currentDigit = inputSbasedNumber[i] - 55;
                }
                result = result * 8 + (ulong)currentDigit;
            }
            return result;
        }
    }
}
