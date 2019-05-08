namespace _07_SpeedRacing_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
      public  static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var model = carInfo[0];
                var fuelAmount = double.Parse(carInfo[1]);
                var fuelConsumption = double.Parse(carInfo[2]);

                cars.Add(new Car(model, fuelAmount, fuelConsumption));
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var commands = input.Split();

                var carModel = commands[1];
                var amountOfKm = double.Parse(commands[2]);

                var car = cars.FirstOrDefault(c => c.Model == carModel);

                car.CalculateCanMove(amountOfKm);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
