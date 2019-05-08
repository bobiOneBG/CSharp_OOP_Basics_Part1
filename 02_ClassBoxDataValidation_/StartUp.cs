﻿namespace _02_ClassBoxDataValidation_
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, height);

                Console.WriteLine($"Surface Area – {box.CalcSurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area – {box.CalcLateralSurfaceArea():f2}");
                Console.WriteLine($"Volume – {box.CalcVolume():f2}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
