using System;
using System.Collections.Generic;
using System.Text;

namespace _04_ShoppingSpree_
{
    using System;

    public class Product
    {
        private double cost;
        private string name;

        public Product(string name, double cost)
        {
            this.Name = name;
            this.cost = cost;
        }

        public string Name
        {
            get { return name; }
            set
            {
                Validator.Validatename(value);

                name = value;
            }
        }

        public double Cost { get { return this.cost; } }
    }
}
