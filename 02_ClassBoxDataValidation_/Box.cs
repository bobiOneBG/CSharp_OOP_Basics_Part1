namespace _02_ClassBoxDataValidation_
{
    using System;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get => this.length;
            set
            {
                IsValidDimension(value, "Length");

                this.length = value;
            }
        }



        public double Width
        {
            get => this.width;
            set
            {
                IsValidDimension(value, "Width");

                this.width = value;
            }
        }
        public double Height
        {
            get => this.height;
            set
            {
                IsValidDimension(value, "Height");

                this.height = value;
            }
        }

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        private static void IsValidDimension(double value, string dimension)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{dimension} cannot be zero or negative.");
            }
        }
        public double CalcVolume()
        {
            return this.Length * this.Width * this.Height;
        }

        public double CalcSurfaceArea()
        {
            return 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }

        public double CalcLateralSurfaceArea()
        {
            return 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }
    }
}
