namespace _DateModifier_
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            Console.WriteLine(DateModifier.CalculateDifference(firstDate, secondDate));
        }
    }
}
