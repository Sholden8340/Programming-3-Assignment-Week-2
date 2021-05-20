using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    abstract class BookStoreItem
    {
        public string Title { get; set; }
        public double Price { get; set; }

        protected BookStoreItem(string title, double price)
        {
            this.Price = price;
            this.Title = title;
        }

        public abstract override string ToString();
    }
}
