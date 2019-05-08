namespace _06_Animals_
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            while (true)
            {
                for (int i = 0; i < 2; i++)
                {
                    var animalType = Console.ReadLine();
                    if (animalType == "Beast!")
                    {
                        break;
                    }

                    var animalData = Console.ReadLine().Split();

                    string name = animalData[0];
                    int age = int.Parse(animalData[1]);
                    string gender = animalData[2];

                    Animal animal = null;

                    try
                    {

                        var animalFactory = new AnimalFactory();

                        animal = animalFactory.CreateAnimal(animalType, name, age, gender);

                        Console.WriteLine(animal.ToString());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.InnerException.Message);
                    }

                }
            }
        }
    }
}
