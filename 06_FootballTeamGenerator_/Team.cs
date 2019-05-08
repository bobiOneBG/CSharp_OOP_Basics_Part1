namespace _06_FootballTeamGenerator_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private readonly HashSet<Player> players;

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public Team(string name, HashSet<Player> players)
        {
            this.Name = name;
            this.players = new HashSet<Player>();
        }
        public static void CreateTeam(string name, HashSet<Team> teams)
        {
            Team team = new Team(name, new HashSet<Player>());
            teams.Add(team);
        }

        public static void AddPlayer(string teamName, Player player, HashSet<Team> teams)
        {
            Team team = teams.FirstOrDefault(t => t.Name == teamName);

            if (team == null)
            {
                throw new ArgumentException($"Team {teamName} does not exist.");
            }
            else
            {
                team.players.Add(player);
            }
        }

        public static void RemovePlayer(string teamName, string playerName, HashSet<Team> teams)
        {
            Team team = teams.FirstOrDefault(t => t.Name == teamName);

            if (team.players.Any(p => p.Name == playerName))
            {
                team.players.RemoveWhere(p => p.Name == playerName);
            }
            else
            {
                throw new ArgumentException($"Player {playerName} is not in {teamName} team.");
            }
        }

        public override string ToString()
        {
            if (this.players.Count == 0)
            {
                return $"{this.Name} – 0";
            }
            else
            {
                return $"{this.Name} – {this.players.Average(p => p.AvrgeSkill)}";
            }
        }
    }
}
