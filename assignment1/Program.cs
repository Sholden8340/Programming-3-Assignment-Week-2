using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Bookstore = new Program();
            Bookstore.Start();
        }

        void Start()
        {
            BookStore store1 = new BookStore();

            
            Book b1 = new Book("Dracula", "Bram Stoker", 15);
            Book b2 = new Book("Joe speedboot", "Tommy Wieringa", 12.50);
            Book b3 = new Book("The hobbit", "J.R.R. Tolkien", 12.50);
            Magazine m1 = new Magazine("Time", 3.90, "Friday");
            Magazine m2 = new Magazine("Donald Duck", 2.50, "Thursday");

            store1.Add(b1);
            store1.Add(b2);
            store1.Add(m1);
            store1.Add(m2);
            store1.Add(b3);

            store1.PrintCompleteStock();
            Console.ReadKey();

        }
    }
}
