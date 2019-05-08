namespace _10_CarSalesman_
{
    public class Car
    {
        private string model;
        private string carEngine;
        private string weight;
        private string color;
        private Engine engine;

        public Car(string model, string carEngine)
        {
            this.model = model;
            this.carEngine = carEngine;
            this.weight = "n/a";
            this.color = "n/a";
        }

        public string Weight { get => this.weight; set => this.weight = value; }
        public string Color { get => this.color; set => this.color = value; }
        public string Model { get => this.model; }
        public string CarEngine { get => this.carEngine; }
        internal Engine Engine { get => this.engine; set => this.engine = value; }
    }
}
