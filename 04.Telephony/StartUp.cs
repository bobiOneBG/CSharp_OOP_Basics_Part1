﻿namespace _04.Telephony
{
    using System;

    public class StartUp

    {
        public static void Main()
        {
            var smartphone = new Smartphone();

            var numbers = Console.ReadLine().Split();

            var sites = Console.ReadLine().Split();

            foreach (var number in numbers)
            {
                smartphone.Call(number);
            }

            foreach (var site in sites)
            {
                smartphone.Brows(site);
            }
        }
    }
}
