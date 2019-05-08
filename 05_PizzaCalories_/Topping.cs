namespace _05_PizzaCalories_
{
    using System;

    public class Topping
    {
        private int weight;
        private string toppingType;

        public Topping(string topping, int weight)
        {
            this.Weight = weight;
            this.ToppingType = topping;
        }

        public double Calories => this.CalcCaloriesPerGram();

        public string ToppingType
        {
            get => this.toppingType;
            private set
            {
                if (!value.Equals("Meat") &&
                    !value.Equals("Veggies") &&
                    !value.Equals("Cheese") &&
                    !value.Equals("Sauce"))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.toppingType = value;
            }
        }

        public int Weight
        {
            get => this.weight;

            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.toppingType} weight should be in the range [1..50]");
                }

                this.weight = value;
            }
        }

        private double CalcCaloriesPerGram()
        {
            double calories = 2.0;

            if (this.ToppingType == "Meat")
            {
                calories *= 1.2;
            }

            else if (this.ToppingType == "Veggies")
            {
                calories *= 0.8;
            }

            else if (this.ToppingType == "Cheese")
            {
                calories *= 1.1;
            }

            else if (this.ToppingType == "Sauce")
            {
                calories *= 0.9;
            }

            return calories;
        }
    }
}
