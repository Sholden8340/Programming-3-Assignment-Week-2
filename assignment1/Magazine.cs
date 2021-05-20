using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment1;

namespace Assignment1
{

    class Magazine : BookStoreItem
    {

        public string ReleaseDay { get; set; }

        public Magazine(string title, double price, string releaseDay) : base(title, price)
        {
            this.ReleaseDay = releaseDay;
        }

        public override string ToString()
        {
            return $"[Magazine] {this.Title} - release day:{this.ReleaseDay}, {this.Price:##.00}";
        }
    }
}
