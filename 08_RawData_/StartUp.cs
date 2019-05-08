namespace _08_RawData_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var amountOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < amountOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var car = new Car();
                var engine = new Engine();
                var cargo = new Cargo();

                var tireList = new List<Tire>();
                car.Model = carInfo[0];

                engine.EngineSpeed = int.Parse(carInfo[1]);
                engine.EnginePower = int.Parse(carInfo[2]);

                cargo.CargoWeight = int.Parse(carInfo[3]);
                cargo.CargoType = carInfo[4];

                for (int j = 0, k = 5; j < 4; j++, k += 2)
                {
                    var tire = new Tire(double.Parse(carInfo[k]), int.Parse(carInfo[k + 1]));
                    tireList.Add(tire);
                }

                car.Engine = engine;
                car.Cargo = cargo;
                car.Tires = tireList;

                cars.Add(car);
            }
            var command = Console.ReadLine();


            Console.WriteLine(string.Join(Environment.NewLine, cars.
                Where(c => c.Cargo.CargoType == command
                && command == "fragile"
                ? c.Tires
                .Where(t => t.TirePresure < 1).FirstOrDefault() != null :
                c.Engine.EnginePower > 250)
                .Select(c => c.Model)));
        }
    }
}
