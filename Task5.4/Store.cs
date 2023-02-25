using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._4
{
    internal class Store
    {
        private Article[] articles;
        public Store(Article[] articles)
        {
            this.articles = articles;
        }

        public Article this[int index]
        {
            get { return articles[index]; }
            set { articles[index] = value; }
        }

        public Article this[string name]
        {
            get
            {
                foreach(var item in articles)
                {
                    if(item.Name == name)
                        return item;
                }
                return null;
            }
        }

    }
}
