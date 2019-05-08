namespace _04_ShoppingSpree_
{
    using System;

    public static class Validator
    {
        public static void Validatename(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be empty");
            }
        }
    }
}
