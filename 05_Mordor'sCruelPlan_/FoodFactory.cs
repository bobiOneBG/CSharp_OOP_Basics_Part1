namespace _05_Mordor_sCruelPlan_
{
    using _05_Mordor_sCruelPlan_.Foods;
    using System;
    using System.Linq;
    public class FoodFactory
    {
        public Food CreateFood(string foodName)
        {

            foodName = foodName.First().ToString().ToUpper() + foodName.Substring(1);

            FoodNames food;
            if (Enum.TryParse(foodName, out food))
            {
                var foodType = Type.GetType("_05_Mordor_sCruelPlan_.Foods.FoodTypes." + food);

                var instance = (Food)Activator.CreateInstance(foodType);

                return instance;
            }

            return null;
        }
    }
}
