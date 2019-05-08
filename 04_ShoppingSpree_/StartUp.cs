namespace _04_ShoppingSpree_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            string[] personsData = Console.ReadLine()
               .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                foreach (string personInfo in personsData)
                {
                    string name = personInfo.Split("=")[0];
                    double money = double.Parse(personInfo.Split("=")[1]);

                    persons.Add(new Person(name, money));
                }

                string[] productData = Console.ReadLine().Split(";");
                foreach (string productInfo in productData)
                {
                    string name = productInfo.Split("=")[0];
                    double cost = double.Parse(productInfo.Split("=")[1]);

                    products.Add(new Product(name, cost));

                }

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] buyData = command.Split();

                    string personName = buyData[0];
                    string productName = buyData[1];

                    Person person = persons.First(p => p.Name == personName);
                    Product product = products.First(p => p.Name == productName);

                    person.BuyProduct(product);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            foreach (Person person in persons)
            {
                if (person.Products.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(p => p.Name))}");
                }

                else
                {
                    Console.WriteLine($"{person.Name} – Nothing bought");
                }
            }
        }
    }
}
