namespace _08_RawData_
{
    using System.Collections.Generic;

    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public string Model { get => this.model; set => this.model = value; }
        public Engine Engine { get => this.engine; set => this.engine = value; }
        public Cargo Cargo { get => this.cargo; set => this.cargo = value; }
        internal List<Tire> Tires { get => this.tires; set => this.tires = value; }
    }
}
