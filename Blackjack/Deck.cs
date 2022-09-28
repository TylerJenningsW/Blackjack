using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Deck
    {
        protected List<Card> _cards;
        public Deck()
        {
            this._cards = new List<Card>();
            CreateAllCards();
            Shuffle();
        }
        public virtual void CreateAllCards()
        {
            // suits
            for (int i = 0; i < 4; i++)
            {
                // faces
                for (int j = 0; j < 13; j++)
                {
                    Card newcard = Factory.CreateCard((CardFaces)j, (CardSuit)i);
                    _cards.Add(newcard);

                }

            }

        }

        public Card Deal()
        {
            // if we have nothing to deal then refill the deck
            if (_cards.Count == 0)
            {
                CreateAllCards();
                Shuffle();
            }
            Card toReturn = _cards[0];
            _cards.RemoveAt(0);
            return toReturn;
            
        }
        public void Shuffle()
        {
            Random random = new Random();
            int deck = _cards.Count;
            for (int i = 0; i < deck; ++i)
            {
                int temp = random.Next(0, deck);
                if (_cards[temp] != null)
                {
                    Card tempCard = _cards[i];
                    _cards[i] = _cards[temp];
                    _cards[temp] = tempCard;
                }

            }
        }
    }
}
