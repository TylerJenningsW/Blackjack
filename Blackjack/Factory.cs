using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    static class Factory
    {
        // card generation
        public static Card CreateCard(CardFaces face, CardSuit suit)
        {
            Card card = new Card(face, suit);
            return card;
        }
        public static Card CreateBlackjackCard(CardFaces face, CardSuit suit)
        {
            return new BlackjackCard(face, suit);
        }
    }
}
