namespace _05.BorderControl
{
    public class Citiizen : IId
    {
        public Citiizen(string name, string age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Name { get; private set; }

        public string Age { get; private set; }

        public string Id { get; private set; }
    }
}