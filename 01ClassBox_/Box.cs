namespace _01_ClassBox_
{
    public class Box
    {
        // length, width and height
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double CalculateArea()
        {
            return 2 * this.Length * this.Height + 2 * this.Height * this.Width + 2 * this.Length * this.Width;
        }

        public double CalculateVolume()
        {
            return this.Length * this.Width * this.Height;
        }

        public double CalculateLateralArea()
        {
            return 2 * this.Height * this.Width + 2 * this.Length * this.Height;
        }
    }


}
