namespace _03_OldestFamilyMember_
{
    using System;

   public class StartUp
    {
       public static void Main()
        {
            Family family = new Family();

            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                Person person = new Person(personInfo[0], int.Parse(personInfo[1]));
                family.AddMember(person);
            }

            var oldestMember=family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
