using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class PlayingCard
    {
        public CardSuit Suit { get; private set; }
        public int Rank { get; private set; }

        public PlayingCard (int rank, CardSuit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string output;

            switch (Rank)
            {
                case 11:
                    output = "Jack";
                    break;
                case 12:
                    output = "Queen";
                    break;
                case 13:
                    output = "King";
                    break;
                case 14:
                    output = "Ace";
                    break;
                default:
                    output = $"{this.Rank}";
                    break;
            }

            output += $" of {this.Suit}";
            return output;


        }
    }
}
