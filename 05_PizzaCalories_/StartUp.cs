namespace _05_PizzaCalories_
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var pizzaName = Console.ReadLine().Split()[1];
            Pizza pizza = null;
            string input;
            try
            {
                while ((input = Console.ReadLine()) != "END")
                {
                    var args = input.Split();

                    if (args[0] == "Dough")
                    {
                        Dough dough = new Dough(args[1], args[2], int.Parse(args[3]));
                        pizza = new Pizza(pizzaName, dough);
                    }

                    else if (args[0] == "Topping")
                    {
                        Topping topping = new Topping(args[1], int.Parse(args[2]));
                        pizza.AddTopping(topping);
                    }
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
