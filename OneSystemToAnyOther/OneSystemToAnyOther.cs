using System;

namespace OneSystemToAnyOther
{
    class OneSystemToAnyOther
    {
        //Turns S base number to Dec based
        static ulong TurnS_BaseToDec(int s, string inputSbasedNumber)
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
                result = result * (ulong)s + (ulong)currentDigit;
            }
            return result;
        }
        //Turns Dec based number to D based number
        static string TurnDecToBaseD(int baseD, ulong inputDec)
        {
            string result = "";
            while (inputDec > 0)
            {
                string currentDigit = "";
                if (inputDec % (ulong)baseD < 10)
                {
                    currentDigit = ((inputDec % (ulong)baseD)).ToString();
                }
                else
                {
                    currentDigit = ((char)((inputDec % (ulong)baseD) + 55)).ToString();
                }
                result = currentDigit + result;
                inputDec = inputDec / (ulong)baseD;
            }
            if (result == "")
            {
                result = "0";
            }
            return result;
        }
        static void Main()
        {
            int baseS = int.Parse(Console.ReadLine());
            string inputNumber = Console.ReadLine();
            int baseD = int.Parse(Console.ReadLine());
            Console.WriteLine(TurnDecToBaseD(baseD, TurnS_BaseToDec(baseS, inputNumber)));
        }
    }
}
