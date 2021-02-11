using assignment1;

namespace Assignment1
{
    class Book : BookStoreItem
    {
        // book, the title, author and price
        public string Author { get; set; }

        public Book(string title, string author, double price) : this(title, price)
        {
            this.Author = author;
        }

        public Book(string title, double price)
        {
            this.Title = title;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"'{this.Title}' by {this.Author}, {this.Price:##.00}";
        }
    }
}