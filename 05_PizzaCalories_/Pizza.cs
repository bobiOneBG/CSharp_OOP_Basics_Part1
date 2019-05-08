namespace _05_PizzaCalories_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        private string name;
        private readonly Dough dough;
        private readonly List<Topping> toppings;
        private int numberOfToppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
            this.toppings = new List<Topping>();
            this.numberOfToppings = this.toppings.Count;
        }

        public double TotalCalories =>
            this.dough.Calories * this.dough.Weight +
            this.toppings.Sum(t => t.Calories * t.Weight);

        public string Name
        {
            get => this.name;

            private set
            {
                if (value.Length > 15 || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public int NumberOfToppings
        {
            get => this.numberOfToppings;
            private set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentException
                        ("Number of toppings should be in range [0..10].");
                }
                this.numberOfToppings = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
            this.NumberOfToppings++;
        }
    }
}
