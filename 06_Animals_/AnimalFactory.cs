using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Animals_
{
    using System;

    public class AnimalFactory
    {
        public Animal CreateAnimal(string animal, string name, int age, string
            gender)
        {
            var animalType = Type.GetType("_06_Animals_.Models." + animal);

            var sss = new object[] { name, age, gender };

            return (Animal)Activator.CreateInstance(animalType, sss);
        }
    }
}
