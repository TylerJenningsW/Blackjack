using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        public CardSuit Suit { get; private set; }
        public CardFaces Faces { get; private set; }
        public Card(CardFaces face, CardSuit suit)
        {
            Suit = suit;
            Faces = face;
        }
    }
}
