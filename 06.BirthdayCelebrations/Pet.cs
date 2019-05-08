namespace _06.BirthdayCelebrations
{
    public class Pet : IBirthday, INameable
    {
        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string Birthday { get; private set; }

        public string Name { get; private set; }
    }
}