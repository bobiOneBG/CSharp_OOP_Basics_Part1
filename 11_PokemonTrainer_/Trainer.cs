namespace _11_PokemonTrainer_
{
    using System.Collections.Generic;
    using System.Linq;

    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public string Name { get => this.name; set => this.name = value; }
        public int NumberOfBadges { get => this.numberOfBadges; set => this.numberOfBadges = value; }
        public List<Pokemon> Pokemons { get => this.pokemons; set => this.pokemons = value; }

        public void PokemonLooseHealth(string command)
        {
            if (this.Pokemons.Any(p => p.Element.ToString() == command))
            {
                this.NumberOfBadges++;
            }
            else
            {
                foreach (Pokemon pkmn in this.Pokemons)
                {

                    pkmn.Health -= 10;

                    this.Pokemons = this.Pokemons.Where(p => p.Health > 0).ToList();
                }
            }
        }
    }
}
