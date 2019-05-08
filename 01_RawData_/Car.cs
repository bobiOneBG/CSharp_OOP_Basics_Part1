namespace _01_RawData_
{
    using System.Collections.Generic;

    internal class Car
    {
        public string model;
        public string engineSpeed;
        public int enginePower;
        public string cargoWeight;
        public string cargoType;
        private KeyValuePair<double, int>[] tires;



        public Car(string model, string engineSpeed, int enginePower, string cargoWeight, string cargoType)
        {
            this.model = model;
            this.engineSpeed = engineSpeed;
            this.enginePower = enginePower;
            this.cargoWeight = cargoWeight;
            this.cargoType = cargoType;
            this.tires = new KeyValuePair<double, int>[4];
        }

        public KeyValuePair<double, int>[] Tires { get => this.tires; set => this.tires = value; }
    }
}
