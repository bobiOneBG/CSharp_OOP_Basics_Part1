namespace _06_FootballTeamGenerator_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var teams = new HashSet<Team>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var inline = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var command = inline[0];
                try
                {
                    switch (command)
                    {
                        case "Team":
                            Team.CreateTeam(inline[1], teams);
                            break;
                        case "Add":
                            var player = new Player(inline[2], int.Parse(inline[3]),
                        int.Parse(inline[4]), int.Parse(inline[5]),
                        int.Parse(inline[6]), int.Parse(inline[7]));

                            var teamName = inline[1];

                            Team.AddPlayer(teamName, player, teams);
                            break;
                        case "Remove":
                            teamName = inline[1];
                            var playerName = inline[2];
                            Team.RemovePlayer(teamName, playerName, teams);
                            break;
                        case "Rating":
                            Team team = teams.First(t => t.Name == inline[1]);
                            Console.WriteLine(team.ToString());
                            break;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine(elapsedMs);
            var sss = watch.ElapsedTicks;
            Console.WriteLine(sss);
        }
    }
}
