namespace _11_PokemonTrainer_
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var trainers = new List<Trainer>();

            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                var data = input.Split();

                var trainerName = data[0];
                var pokemonName = data[1];
                var pokemonElement = (Element)Enum.Parse(typeof(Element), data[2]);
                var pokemonHealth = int.Parse(data[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonHealth, pokemonElement);

                if (!trainers.Any(t => t.Name == trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }
                trainers.First(t => t.Name == trainerName).Pokemons.Add(pokemon);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                foreach (var tr in trainers)
                {
                    tr.PokemonLooseHealth(command);
                }
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count()}");
            }
        }
    }
}
