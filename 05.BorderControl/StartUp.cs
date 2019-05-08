using System;

namespace _05.BorderControl
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var inhabitants = new List<IId>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var data = input.Split();
                if (data.Length == 3)
                {
                    inhabitants.Add(new Citiizen(data[0], data[1], data[2]));
                }

                else if (data.Length == 2)
                {
                    inhabitants.Add(new Robot(data[0], data[1]));
                }
            }

            string fakeId = Console.ReadLine();

            foreach (var inhabitant in inhabitants)
            {
                if (inhabitant.Id.EndsWith(fakeId))
                {
                    Console.WriteLine(inhabitant.Id);
                }
            }
        }
    }
}
