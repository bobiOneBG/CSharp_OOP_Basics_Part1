namespace _08_RawData_
{
    public class Tire
    {
        private double tirePresure;
        private int tireAge;

        public Tire(double tirePresure, int tireAge)
        {
            this.TirePresure = tirePresure;
            this.tireAge = tireAge;
        }

        public double TirePresure { get => this.tirePresure; set => this.tirePresure = value; }
    }
}
