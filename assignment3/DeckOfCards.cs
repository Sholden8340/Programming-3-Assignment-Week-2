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
                for (int rank = 2; rank < 15; rank++) // 11 = Jack 12 = Queen 13 = King 14 = Ace
                {
                    AllPlayingCards.Add(new PlayingCard(rank, (CardSuit) suit));
                }
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