using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._4
{
    internal class Article
    {
        private string name;
        private string store;
        private decimal price;

        public string Name { get { return name; } }
        public string Store { get { return store; } }
        public decimal Price { get { return price; } }
        public Article(string name, string store, decimal price)
        {
            this.name = name;
            this.store = store;
            this.price = price;
        }
    }
}
