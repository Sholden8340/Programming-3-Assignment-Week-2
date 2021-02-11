using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Player
    {
        public string Name { get; set; }
        public List<PlayingCard> PlayerCards { get; set; }

        public Player(string name)
        {
            this.Name = name;
            PlayerCards = new List<PlayingCard>();
        }

        public void AddCard(PlayingCard card)
        {
            PlayerCards.Add(card);
        }

        public PlayingCard GetNextCard()
        {
            PlayingCard firstCard = PlayerCards[0];
            PlayerCards.RemoveAt(0);

            return firstCard;
        }
    }
}