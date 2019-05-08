namespace _05_PizzaCalories_
{
    using System;

    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public double Calories => this.CalcCaloriesPerGram();

        public string FlourType
        {
            get { return this.flourType; }
            private set
            {
                if (!value.Equals("White") &&
                    !value.Equals("Wholegrain"))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }

        }

        public string BakingTechnique
        {
            get { return this.bakingTechnique; }
            private set
            {
                if (!value.Equals("Crispy") &&
                    !value.Equals("Chewy") &&
                    !value.Equals("Homemade"))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }

        }

        public int Weight
        {
            get => this.weight;
            set
            {
                if (value < 1 && value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        private double CalcCaloriesPerGram()
        {
            var calories = 2.0;

            if (this.FlourType == "White")
            {
                calories *= 1.5;
            }
            else if (this.BakingTechnique == "Crispy")
            {
                calories *= 0.9;
            }
            else if (this.BakingTechnique == "Chewy")
            {
                calories *= 1.1;
            }

            return calories;
        }
    }
}
