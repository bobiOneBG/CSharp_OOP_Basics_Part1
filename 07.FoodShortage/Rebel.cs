﻿namespace _07.FoodShortage
{
    public class Rebel : IBuyer
    {
        public Rebel(string name, string age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public int Food { get; private set; }

        public string Name { get; private set; }

        public string Age { get; private set; }

        public string Group { get; private set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}