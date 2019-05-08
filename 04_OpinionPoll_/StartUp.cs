namespace _04_OpinionPoll_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
       public static void Main()
        {
            List<Person> persons = new List<Person>();

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] personData = Console.ReadLine().Split();

                Person person = new Person(personData[0], int.Parse(personData[1]));

                persons.Add(person);
            }

            foreach (var person in persons.Where(p=>p.Age>30).OrderBy(p=>p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
