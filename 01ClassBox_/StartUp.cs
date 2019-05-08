namespace _01_ClassBox_
{
    using System;
    
    public class StartUp
    {
        public static void Main()
        {
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var box = new Box(lenght, width, height);

            box.CalculateArea();
            box.CalculateLateralArea();
            box.CalculateVolume();

            Console.WriteLine($"Surface Area - {box.CalculateArea():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.CalculateLateralArea():f2}");
            Console.WriteLine($"Volume - {box.CalculateVolume():f2}");
        }
    }
}
