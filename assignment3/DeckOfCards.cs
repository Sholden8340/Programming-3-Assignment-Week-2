using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class DeckOfCards
    {
        public List<PlayingCard> AllPlayingCards { get; private set; }

        public DeckOfCards()
        {
            AllPlayingCards = new List<PlayingCard>();
            InitCards();
        }

        private void InitCards()
        {
            for (int suit = 0; suit < 4; suit++)
            {
                for (int rank = 2; rank < 11; rank++)
                {
                    AllPlayingCards.Add(new PlayingCard(rank.ToString(), (CardSuit) suit));
                }

                AllPlayingCards.Add(new PlayingCard("Jack", (CardSuit) suit));
                AllPlayingCards.Add(new PlayingCard("Queen", (CardSuit) suit));
                AllPlayingCards.Add(new PlayingCard("King", (CardSuit) suit));
                AllPlayingCards.Add(new PlayingCard("Ace", (CardSuit) suit));
            }
        }

        public void Print()
        {
            foreach (PlayingCard card in AllPlayingCards)
            {
                Console.WriteLine(card);
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            for (int i = 0; i < 100; i++)
            {
                int index = rng.Next(0, 52);
                int index2 = rng.Next(0, 52);

                var temp = AllPlayingCards[index];
                AllPlayingCards[index] = AllPlayingCards[index2];
                AllPlayingCards[index2] = temp;

            }

        }
    }
}