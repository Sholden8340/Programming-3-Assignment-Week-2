using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program cardProgram = new Program();
            cardProgram.Start();
        }

        void Start()
        {
            DeckOfCards cards = new DeckOfCards();
            cards.Print();
            cards.Shuffle();

            Console.WriteLine();
            cards.Print();
            Console.ReadKey();
        }
    }
}
