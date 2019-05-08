namespace _07_SpeedRacing_
{
    using System;

    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private double traveledDistance;

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.TraveledDistance = 0;
            this.FuelConsumption = fuelConsumption;
            this.FuelAmount = fuelAmount;
            this.Model = model;
        }

        public double TraveledDistance
        {
            get { return this.traveledDistance; }
            set { this.traveledDistance = value; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public void CalculateCanMove(double amountOfKm)
        {
            if (this.FuelConsumption * amountOfKm <= this.FuelAmount)
            {
                this.FuelAmount -= this.FuelConsumption * amountOfKm;
                this.traveledDistance += amountOfKm;
            }

            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.TraveledDistance}";
        }
    }
}
