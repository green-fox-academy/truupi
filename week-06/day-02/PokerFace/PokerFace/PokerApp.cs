using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerFace
{
    public class PokerApp
    {
        static void Main(string[] args)
        {
        }

        public bool CheckHand(string card)
        {
            string[] hand = card.Split(' ');
            if (CheckHandLength(hand) && CheckCardValidation(hand) && CheckCardDuplicates(hand))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckCardDuplicates(string[] hand)
        {
            for (int i = 0; i < hand.Length; i++)
            {
                for (int j = 0; j < hand.Length; j++)
                {
                    if (i != j && hand[i] == hand[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool CheckCardValidation(string[] hand)
        {
            foreach (var item in hand)
            {
                if (!IsCardValid(item))
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckHandLength(string[] hand)
        {
            if (hand.Length == 5)
            {
                return true;
            }
            return false;
        }

        public bool IsCardValid(string card)
        {
            char[] cardSuit = { 'C', 'D', 'H', 'S' };
            char[] cardNumber = { '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A' };
            
            if (card.Length == 2 && cardSuit.Contains(card[1]) && cardNumber.Contains(card[0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
