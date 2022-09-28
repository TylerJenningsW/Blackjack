using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class BlackjackHand : Hand
    {
        public int Score { get; private set; }
        public bool IsDealer { get; set; }
        public BlackjackHand(bool isDealer = false)
        {
            IsDealer = isDealer;
        }
        public override void AddCard(Card card)
        {
            // reset score
            Score = 0;
            // cast blackjackcard
            base.AddCard((BlackjackCard)card);
            
            // iterate through list of cards
            foreach (BlackjackCard blackjackcard in base._cards)
            {
                Score += blackjackcard.Value;

                
            }
            if (Score > 21)
            {
                foreach (BlackjackCard blackjackcard2 in base._cards)
                {
                    if ((blackjackcard2.Faces == CardFaces.A) && (Score > 21))
                    {
                        Score -= 10;
                    }
                }
            }
        }

        public override void RemoveCards()
        {
            base.RemoveCards();
            Score = 0;
        }
    }
}
