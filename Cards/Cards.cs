using System;
using System.Linq;
using System.Text;

namespace Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
            #region Input
            int handsNum = int.Parse(Console.ReadLine());

            UInt64[] hands = new UInt64[handsNum];

            for (int i = 0; i < handsNum; i++)
            {
                hands[i] = UInt64.Parse(Console.ReadLine());
            }
            string[] cards = { "2c", "3c", "4c", "5c",  "6c", "7c", "8c", "9c", "Tc", "Jc", "Qc", "Kc", "Ac",
                               "2d", "3d", "4d", "5d",  "6d", "7d", "8d", "9d", "Td", "Jd", "Qd", "Kd", "Ad",
                               "2h", "3h", "4h", "5h",  "6h", "7h", "8h", "9h", "Th", "Jh", "Qh", "Kh", "Ah",
                               "2s", "3s", "4s", "5s",  "6s", "7s", "8s", "9s", "Ts", "Js", "Qs", "Ks", "As"};
            //UInt64[] hands = { 8796093284353, 274878169096, 1168365322240, 8650760, 285873023221888 }; //example 
            #endregion

            #region CheckTheDeck
            // Check if the deck is full, full deck = 4503599627370495(52x1)
            UInt64 deck = 0;
            for (int i = 0; i < hands.Length; i++)
            {
                deck = deck | hands[i];
            }

            if (deck == 4503599627370495)
            {
                Console.WriteLine("Full deck");
            }
            else
            {
                Console.WriteLine("Wa wa!");
            }
            #endregion

            #region GetOddCards
            int[] cardAppearence = new int[52];
            string[] binaryHands = new string[hands.Length];//Hands to binary
            for (int i = 0; i < hands.Length; i++)
            {
                binaryHands[i] = BinaryHand(hands[i]);
                for (int k = binaryHands[i].Length - 1, j = 0; k >= 0; k--, j++)
                {
                    if ((binaryHands[i])[k] == '1')
                    {
                        ++cardAppearence[j];
                    }
                }
            }

            string[] oddCards = new string[52];
            for (int k = 0; k < cardAppearence.Length; k++)
            {
                if (cardAppearence[k] % 2 != 0)
                {
                    oddCards[k] = cards[k];
                }
            }
            Console.WriteLine(string.Join(" ", oddCards.Where(s => !string.IsNullOrEmpty(s)))); 
            #endregion
        }//End of main

        static string BinaryHand(UInt64 hand)
        {
            StringBuilder serialHand = new StringBuilder(52);
            while (hand > 0)
            {
                serialHand.Insert(0, Convert.ToString(hand % 2));
                hand /= 2;
            }
            return serialHand.ToString();
        }
    }
}
