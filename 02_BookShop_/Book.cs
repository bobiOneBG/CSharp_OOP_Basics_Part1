using System;
using System.Collections.Generic;
using System.Text;

namespace _02_BookShop_
{
    using System;
    using System.Text;
    public class Book
    {
        private string author;
        private string title;
        private double price;

        public Book(string author, string title, double price)
        {
            this.author = author;
            this.title = title;
            this.price = price;
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                var authorNames = value.Split();
                if (authorNames.Length > 1 && Char.IsDigit(authorNames[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                author = value;
            }
        }

        public virtual double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {this.GetType().Name}")
               .AppendLine($"Title: {this.Title}")
               .AppendLine($"Author: {this.Author}")
               .AppendLine($"Price: {this.Price:f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
