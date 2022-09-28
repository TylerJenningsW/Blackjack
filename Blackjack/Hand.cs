using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Hand
    {
        protected List<Card> _cards;
        public Hand()
        {
            _cards = new List<Card>();
        }
        // methods to override
        public virtual void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public virtual void RemoveCards()
        {
            _cards.Clear();
        }
    }
    
}
