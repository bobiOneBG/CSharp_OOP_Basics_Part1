namespace _11_PokemonTrainer_
{
    public class Pokemon
    {
        private string name;

        private Element element;

        private int health;

        public Pokemon(string name, int health, Element element)
        {
            this.Name = name;
            this.Health = health;
            this.Element = element;
        }

        public string Name { get => this.name; set => this.name = value; }
        public int Health { get => this.health; set => this.health = value; }
        public Element Element { get => this.element; set => this.element = value; }
    }
}
