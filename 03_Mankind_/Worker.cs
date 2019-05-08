namespace _03_Mankind_
{
    using System;
    using System.Text;
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;


        public Worker(string firstName, string lastName, decimal weekSalary, int workHours)
            : base(firstName, lastName)
        {
            this.WorkHoursPerDay = workHours;
            this.WeekSalary = weekSalary;
        }
        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            private set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursPerDay = value;
            }
        }


        public decimal CalculateSalaryPerHour()
        {
            return this.weekSalary / 5 / this.workHoursPerDay;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"Week Salary: {this.weekSalary:f2}")
                .AppendLine($"Hours per day: {this.workHoursPerDay:f2}")
                .AppendLine($"Salary per hour: {this.CalculateSalaryPerHour():f2}");
            return sb.ToString();
        }
    }
}
