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

        public abstract override string ToString();
    }
}
