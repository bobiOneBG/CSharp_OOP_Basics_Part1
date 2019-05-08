namespace _01_RawData_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RawData
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();

            int lines = int.Parse(Console.ReadLine());

            CreateCar(lines, cars);

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                PrintCaseFragile(cars);
            }
            else
            {
                PrintCaseFlamable(cars);
            }
        }

        private static void PrintCaseFlamable(List<Car> cars)
        {
            List<string> flamable = cars
                            .Where(x => x.cargoType == "flamable" && x.enginePower > 250)
                            .Select(x => x.model)
                            .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, flamable));
        }

        private static void PrintCaseFragile(List<Car> cars)
        {
            List<string> fragile = cars
                        .Where(x => x.cargoType == "fragile")
                        .Where(x => x.Tires.All(t => t.Key < 1))
                        .Select(x => x.model)
                        .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, fragile));
        }

        private static void CreateCar(int lines, List<Car> cars)
        {
            for (int i = 0; i < lines; i++)
            {
                string[] prmtrs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var car = new Car(prmtrs[0], prmtrs[1],
                    int.Parse(prmtrs[2]), prmtrs[3],
                    prmtrs[4]
                    );

                SetTires(prmtrs, car);
                cars.Add(car);
            }
        }

        private static void SetTires(string[] prmtrs, Car car)
        {
            for (int i = 0, k = 5; i < 4; i++, k += 2)
            {
                car.Tires[i] = new KeyValuePair<double, int>(double.Parse(prmtrs[5]), int.Parse(prmtrs[k + 1]));
            }

        }
    }
}
