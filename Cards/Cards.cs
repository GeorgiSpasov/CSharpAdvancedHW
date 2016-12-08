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
            //int handsNum = int.Parse(Console.ReadLine());

            //UInt64[] hands = new UInt64[handsNum];

            //for (int i = 0; i < handsNum; i++)
            //{
            //    hands[i] = UInt64.Parse(Console.ReadLine());
            //}
            string[] cards = { "2c", "3c", "4c", "5c",  "6c", "7c", "8c", "9c", "Tc", "Jc", "Qc", "Kc", "Ac",
                               "2d", "3d", "4d", "5d",  "6d", "7d", "8d", "9d", "Td", "Jd", "Qd", "Kd", "Ad",
                               "2h", "3h", "4h", "5h",  "6h", "7h", "8h", "9h", "Th", "Jh", "Qh", "Kh", "Ah",
                               "2s", "3s", "4s", "5s",  "6s", "7s", "8s", "9s", "Ts", "Js", "Qs", "Ks", "As"};
            UInt64[] hands = { 272661674162173, 2814457708837951, 4204527946760119 }; //example 
            #endregion

            #region Check the Deck
            // Check if the deck is full, full deck = 4503599627370495
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

            // Hands to binary
            string[] binaryHands = new string[hands.Length];
            for (int i = 0; i < hands.Length; i++)
            {
                binaryHands[i] = BinaryHand(hands[i]);
            }

            //Check appearence
            UInt64[] cardAppearence = new UInt64[52];
            for (int handIndex = 0; handIndex < hands.Length; handIndex++) //check every hand
            {
                for (int cardIndex = binaryHands[handIndex].Length-1; cardIndex >= 0; cardIndex--)
                {
                    if ((binaryHands[handIndex])[cardIndex] == '1')
                    {
                        cardAppearence[cardIndex] = cardAppearence[cardIndex] + 1;
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
            //Console.WriteLine(string.Join(" ", oddCards.Where(s => !string.IsNullOrEmpty(s))));
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
