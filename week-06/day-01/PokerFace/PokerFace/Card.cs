using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerFace
{
    class Card
    {
        public char CardNumber;
        public char CardSuit;

        public Card(char cardNumber, char cardSuit)
        {
            CardNumber = cardNumber;
            CardSuit = cardSuit;
        }
    }
}
