using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class BlackjackDeck : Deck
    {
        public override void CreateAllCards()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Card card = Factory.CreateBlackjackCard((CardFaces)j, (CardSuit)i);
                    this._cards.Add(card);

                }

            }
        }
    }
}
