using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class PlayingCard
    {
        public CardSuit Suit { get; private set; }
        public string Rank { get; private set; }

        public PlayingCard (string rank, CardSuit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public override string ToString()
        {
            return $"{this.Rank} of {this.Suit}";
        }
    }
}
