namespace _03_OldestFamilyMember_
{
    using System.Collections.Generic;
    using System.Linq;

    public class Family
    {
        private List<Person> persons;

        public Family()
        {
            this.Persons = new List<Person>();
        }

        public List<Person> Persons { get => this.persons; set => this.persons = value; }

        public void AddMember(Person member)
        {
            this.Persons.Add(member);
        }

       public Person GetOldestMember()
        {
            return persons.OrderByDescending(p => p.Age).First();
        } 
    }
}
