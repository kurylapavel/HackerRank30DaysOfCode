using System;
using System.Collections.Generic;
using System.Text;

namespace Day13
{
    class MyBook : Book
    {
        protected int price;
        public MyBook(string t, string a, int p) : base(t, a)
        {
            this.price = p;
        }

        public override void display()
        {
            string result = $"Title: {this.title}\nAuthor: {this.author}\nPrice: {this.price}";
            Console.WriteLine(result);
        }
    }
}
