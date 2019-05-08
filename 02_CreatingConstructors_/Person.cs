namespace _02_CreatingConstructors_
{
    public class Person
    {
        private int age;
        private string name;

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age)
        {
            this.Age = age;
            this.Name = "No name";
        }

        public Person( string name, int age) 
        {
            this.Age = age;
            this.Name = name;
        }

        public int Age { get => this.age; set => this.age = value; }
        public string Name { get => this.name; set => this.name = value; }
    }
}
