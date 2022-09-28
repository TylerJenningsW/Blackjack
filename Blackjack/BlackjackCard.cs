using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class BlackjackCard : Card
    {
        public int Value { get; set; }
        // Playing cards
        public BlackjackCard(CardFaces face, CardSuit suit) : base(face, suit)
        {
            switch (face)
            {
                case CardFaces.A:
                    Value = 11;
                    break;
                case CardFaces._2:
                    Value = 2;
                    break;
                case CardFaces._3:
                    Value = 3;
                    break;
                case CardFaces._4:
                    Value = 4;
                    break;
                case CardFaces._5:
                    Value = 5;
                    break;
                case CardFaces._6:
                    Value = 6;
                    break;
                case CardFaces._7:
                    Value = 7;
                    break;
                case CardFaces._8:
                    Value = 8;
                    break;
                case CardFaces._9:
                    Value = 9;
                    break;
                case CardFaces._10:
                    Value = 10;
                    break;
                case CardFaces.J:
                    Value = 10;
                    break;
                case CardFaces.Q:
                    Value = 10;
                    break;
                case CardFaces.K:
                    Value = 10;
                    break;
                default:
                    break;
            }
        }
    }
}
