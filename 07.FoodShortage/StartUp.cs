namespace _07.FoodShortage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<IBuyer> buyers = new List<IBuyer>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var buyer = Console.ReadLine().Split();

                if (buyer.Length == 4)
                {
                    buyers.Add(new Citiizen(buyer[0], buyer[1], buyer[2], buyer[3]));
                }

                else if (buyer.Length == 3)
                {
                    buyers.Add(new Rebel(buyer[0], buyer[1], buyer[2]));
                }
            }

            string buyerName;
            while ((buyerName = Console.ReadLine()) != "End")
            {
                if (buyers.Any(b => b.Name == buyerName))
                {
                    buyers.First(b => b.Name == buyerName).BuyFood();
                }
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}
