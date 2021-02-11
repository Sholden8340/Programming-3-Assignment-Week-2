using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class WarCardGame : CardGame
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public WarCardGame(Player player1, Player player2)
        {
            this.Player1 = player1;
            this.Player2 = player2;
        }

        public void StartNewGame()
        {
            //Console.WriteLine(DeckOfCards.AllPlayingCards.Count);
            //Console.WriteLine();

            DeckOfCards.Shuffle();
            int count = 0;

            foreach (PlayingCard card in DeckOfCards.AllPlayingCards)
            {
                if (count % 2 == 0)
                {
                    Player2.AddCard(card);
                }
                else
                {
                    Player1.AddCard(card);
                }

                count++;
                //Console.WriteLine(card.ToString());
            }
        }

        public bool EndOfGame()
        {
            if (Player1.PlayerCards.Count == 0)
            {
                Console.WriteLine("{0} has won!", Player2.Name);
                return true;
            }
            else if (Player2.PlayerCards.Count == 0)
            {
                Console.WriteLine("{0} has won!", Player1.Name);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void NextCard()
        {
            PlayingCard player1Card = Player1.GetNextCard();
            PlayingCard player2Card = Player2.GetNextCard();

            // Rank should be enum?
            // Try to parse Rank as an int
            bool isPlayer1NumberRank = Int32.TryParse(player2Card.Rank, out int player2Rank);
            bool isPlayer2NumberRank = Int32.TryParse(player1Card.Rank, out int player1Rank);

            if (!isPlayer2NumberRank)
            {
                player2Rank = PictureCardToNumber(player2Card);
            }

            if (!isPlayer1NumberRank)
            {
                player1Rank = PictureCardToNumber(player1Card);
            }

            if (player1Rank > player2Rank)
            {
                Player1Wins();
            }
            else if (player1Rank < player2Rank)
            {
                Player2Wins();
            }
            else if (player1Rank == -1 || player2Rank == -1)
            {
                throw new Exception("Couldn't convert picture card to value");
            }
            else
            {
                Draw();
            }


            void Player1Wins()
            {
                ShowCards();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} got the cards", Player1.Name);
                Player1.AddCard(player1Card);
                Player1.AddCard(player2Card);
            }

            void Player2Wins()
            {
                ShowCards();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("{0} got the cards", Player2.Name);
                Player2.AddCard(player2Card);
                Player2.AddCard(player1Card);
            }

            void Draw()
            {
                ShowCards();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("2 cards lost...");
                Console.WriteLine("cards left: [{0}] {1}x, [{2}] {3}x", Player1.Name , Player1.PlayerCards.Count, Player2.Name , Player2.PlayerCards.Count);
            }

            void ShowCards()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[{0}] {1} - [{2}] {3}", Player1.Name, player1Card.ToString(), Player2.Name, player2Card.ToString());
            }

            int PictureCardToNumber(PlayingCard card)
            {
                if (card.Rank.Equals("Ace"))
                {
                    return 14;
                }

                if (card.Rank.Equals("King"))
                {
                    return 13;
                }

                if (card.Rank.Equals("Queen"))
                {
                    return 12;
                }

                if (card.Rank.Equals("Jack"))
                {
                    return 11;
                }

                return -1;
            }
        }
    }
}