﻿namespace _DateModifier_
{
    using System;

    public class DateModifier
    {
        public static int CalculateDifference(string firstDate, string secondDate)
        {
            var diffedence = DateTime.Parse(firstDate) - DateTime.Parse(secondDate);
            return Math.Abs(diffedence.Days);
        }
    }
}
