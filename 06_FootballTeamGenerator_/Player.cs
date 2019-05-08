namespace _06_FootballTeamGenerator_
{
    using System;

    public class Player
    {
        private const int statMinLevel = 0;
        private const int statMaxLevel = 100;

        private string name;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        private double avrgeSkill;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("A name should not be empty.");
                this.name = value;
            }
        }

        private int Endurance
        {
            get { return this.endurance; }
            set
            {
                ValidateStats(value, nameof(this.Endurance));
                this.endurance = value;
            }
        }

        private int Dribble
        {
            get { return this.dribble; }
            set
            {
                ValidateStats(value, nameof(this.Dribble));
                this.dribble = value;
            }
        }

        private int Sprint
        {
            get { return this.sprint; }
            set
            {
                ValidateStats(value, nameof(this.Sprint));
                this.sprint = value;
            }
        }

        private int Passing
        {
            get { return this.passing; }
            set
            {
                ValidateStats(value, nameof(this.Passing));
                this.passing = value;
            }
        }

        private int Shooting
        {
            get { return this.shooting; }
            set
            {
                ValidateStats(value, nameof(this.Shooting));
                this.shooting = value;
            }
        }

        public double AvrgeSkill
        {
            get { return this.avrgeSkill; }
            private set { this.avrgeSkill = value; }
        }

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            this.CalculateAverageSkill();
        }

        private void CalculateAverageSkill()
        {
            this.AvrgeSkill = Math.Round((this.endurance + this.dribble + this.sprint + this.passing + this.shooting) / 5.0);
        }

        private static void ValidateStats(int value, string propName)
        {
            if (value < statMinLevel || value > statMaxLevel)
                throw new ArgumentException($" {propName} should be between {statMinLevel} and {statMaxLevel}.");
        }
    }
}
