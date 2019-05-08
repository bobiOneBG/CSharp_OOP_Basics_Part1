namespace _10_CarSalesman_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Engine> listOfEngine = new List<Engine>();
            List<Car> listOfCars = new List<Car>();

            GetEngineInfo(listOfEngine);

            GetCarInfo(listOfCars);

            foreach (Car car in listOfCars)
            {
                Console.WriteLine($"{car.Model}: ");
                Console.WriteLine($"    {car.CarEngine}: ");
                Console.WriteLine($"        Power: {listOfEngine.Where(e => e.Model == car.CarEngine).FirstOrDefault().Power}");
                Console.WriteLine($"        Displacement: {listOfEngine.Where(e => e.Model == car.CarEngine).FirstOrDefault().Displacement}");
                Console.WriteLine($"        Efficiency: {listOfEngine.Where(e => e.Model == car.CarEngine).FirstOrDefault().Efficiency}");
                Console.WriteLine($"    Weight: {car.Weight}");
                Console.WriteLine($"    Color: {car.Color}");
            }
        }

        private static void GetCarInfo(List<Car> listOfCars)
        {
            var carCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carCount; i++)
            {
                var carInfo = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var car = new Car(
                    carInfo[0]
                    , carInfo[1]);
                if (carInfo.Length > 2)
                {
                    if (IsDigit(carInfo[2]))
                        car.Weight = carInfo[2];
                    else
                        car.Color = carInfo[2];
                }

                if (carInfo.Length > 3)
                {
                    if (IsDigit(carInfo[3]))
                        car.Weight = carInfo[3];
                    else
                        car.Color = carInfo[3];
                }
                listOfCars.Add(car);
            }
        }

        private static bool IsDigit(string v)
        {
            if (char.IsDigit(v[0]))
                return true;
            else
                return false;

        }

        private static void GetEngineInfo(List<Engine> listOfEngine)
        {                        //engine count
            var engineCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineCount; i++)
            {
                var engineInfo = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var engine = new Engine(
                    engineInfo[0]
                    , engineInfo[1]
                    );
                if (engineInfo.Length > 2)
                {
                    if (IsDigit(engineInfo[2]))
                        engine.Displacement = engineInfo[2];
                    else
                        engine.Efficiency = engineInfo[2];
                }

                if (engineInfo.Length > 3)
                {
                    if (IsDigit(engineInfo[3]))
                        engine.Displacement = engineInfo[3];
                    else
                        engine.Efficiency = engineInfo[3];
                }
                listOfEngine.Add(engine);
            }
        }
    }
}
