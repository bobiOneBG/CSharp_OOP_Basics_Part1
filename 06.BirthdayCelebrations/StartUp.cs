using System;

namespace _06.BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var birthdays = new List<IBirthday>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var data = input.Split();

                if (data[0] == "Citizen")
                {
                    birthdays.Add(new Citiizen(data[1], data[2], data[3], data[4]));
                }

                else if (data[0] == "Pet")
                {
                    birthdays.Add(new Pet(data[1], data[2]));
                }
            }

            var year = Console.ReadLine();

            bool hasBirthdaysInYear = false; ;

            foreach (var item in birthdays)
            {
                if (item.Birthday.Split('/')[2].EndsWith(year))
                {
                    hasBirthdaysInYear = true;
                    Console.WriteLine(item.Birthday);
                }               
            }

            if (hasBirthdaysInYear==false)
            {
                Console.WriteLine("<empty output>");
            }
        }
    }
}
