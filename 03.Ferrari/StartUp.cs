﻿namespace _03.Ferrari
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string driverName = Console.ReadLine();

            IFerrari ferrari = new Ferrari(driverName);

            Console.WriteLine($"{ferrari.Model}/{ferrari.Brake()}/{ferrari.PushGas()}/{ferrari.Driver}");
        }
    }
}
