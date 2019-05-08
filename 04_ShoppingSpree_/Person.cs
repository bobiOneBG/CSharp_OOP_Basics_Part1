namespace _04_ShoppingSpree_
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private double money;
        private List<Product> products;

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<Product>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                Validator.Validatename(value);

                this.name = value;
            }
        }

        public double Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public List<Product> Products { get => this.products; set => this.products = value; }

        public void BuyProduct(Product product)
        {
            if (this.Money >= product.Cost)
            {
                Console.WriteLine($"{this.Name} bought {product.Name}");
                this.Money -= product.Cost;
                this.products.Add(product);
            }

            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }
    }
}
