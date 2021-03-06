﻿namespace _06.BirthdayCelebrations
{
    public class Citiizen : IId, INameable, IBirthday
    {
        public Citiizen(string name, string age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
        }

        public string Name { get; private set; }

        public string Age { get; private set; }

        public string Id { get; private set; }

        public string Birthday { get; private set; }
    }
}