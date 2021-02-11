using System;

namespace assignment3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var warProgram = new Program();
            warProgram.Start();
        }

        private void Start()
        {
            var player1 = new Player("John");
            var player2 = new Player("Emma");
            // create game and play it
            var war = new WarCardGame(player1, player2);
            PlayTheGame(war);

            Console.ReadKey();
        }

        private void PlayTheGame(WarCardGame war)
        {
            war.StartNewGame();
            while (!war.EndOfGame()) war.NextCard();

            // TODO: display who has won the game...
        }
    }
}