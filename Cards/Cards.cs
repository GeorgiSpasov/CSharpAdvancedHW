using System;
using System.Linq;
using System.Text;

namespace Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
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
            UInt64[] hands = { 272661674162173, 2814457708837951, 4204527946760119 };

            UInt64 deck = 0;
            for (int i = 0; i < hands.Length; i++)
            {
                deck = deck | hands[i];
            }
            //Console.WriteLine(deck); //full deck = 4503599627370495

            if (deck == 4503599627370495)
            {
                Console.WriteLine("Full deck");
            }
            else
            {
                Console.WriteLine("Wa wa!");
            }

            // Hands to binary
            string[] binaryHands = new string[hands.Length];
            for (int i = 0; i < hands.Length; i++)
            {
                binaryHands[i] = BinaryHand(hands[i]);
            }
                       

            UInt64[] appearence = new UInt64[52];
            for (int handIndex = 0; handIndex < hands.Length; handIndex++) //check every hand
            {
                for (int cardsIndex = 0; cardsIndex < binaryHands[handIndex].Length; cardsIndex++)
                {
                    if ((binaryHands[handIndex])[cardsIndex] == '1')
                    {
                        appearence[cardsIndex] = appearence[cardsIndex] + 1;
                    }
                }
            }
            UInt64[] revappearence = new UInt64[52];
            for (int i = 0, j=appearence.Length-1; i < appearence.Length; i++, j--)
            {
                revappearence[i] = appearence[j];
            }
            
            string[] oddCards = new string[52];
            for (int i = revappearence.Length-1; i >= 0; i--)
            {
                if (revappearence[i] % 2 != 0 && revappearence[i] != 0)
                {
                    oddCards[i] = cards[i];
                }
            }

            Console.WriteLine(string.Join(" ", oddCards.Where(s => !string.IsNullOrEmpty(s))));

            ////decimal to binary
            //StringBuilder binaryDeck = new StringBuilder(64);
            //while (deck > 0)
            //{
            //    binaryDeck.Insert(0, Convert.ToString(deck % 2));
            //    deck /= 2;
            //}

            //// Print cards
            //string deckCheck = binaryDeck.ToString();
            //string[] availableCards = new string[52];
            //for (int i = 0; i < 52; i++)
            //{
            //    if (binaryDeck[i] == '1')
            //    {
            //        availableCards[i] = cards[i];
            //    }
            //}

            //Console.WriteLine(string.Join(" ", availableCards.Where(s => !string.IsNullOrEmpty(s))));


        } //End of main

        static string BinaryHand(UInt64 hand)
        {
            StringBuilder hand2 = new StringBuilder(64);

            while (hand > 0)
            {
                hand2.Insert(0, Convert.ToString(hand % 2));
                hand /= 2;
            }
            return hand2.ToString();
        }
    }
}
