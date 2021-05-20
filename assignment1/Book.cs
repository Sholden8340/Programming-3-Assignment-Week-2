using assignment1;

namespace Assignment1
{
    class Book : BookStoreItem
    {
        // book, the title, author and price
        public string Author { get; set; }

        public Book(string title, string author, double price) : base(title, price)
        {
            this.Author = author;
        }

        public override string ToString()
        {
            return $"[Book] '{this.Title}' by {this.Author}, {this.Price:##.00}";
        }
    }
}