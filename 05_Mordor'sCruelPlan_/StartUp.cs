using System;

namespace _05_Mordor_sCruelPlan_
{
    using _05_Mordor_sCruelPlan_.Foods;
    using _05_Mordor_sCruelPlan_.Moods;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            FoodFactory foodFactory = new FoodFactory();
            MoodFactory moodFactory = new MoodFactory();

            List<Food> foods = new List<Food>();

            string[] foodArgs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int noFood = 0;
            foreach (string foodName in foodArgs)
            {
                Food food = foodFactory.CreateFood(foodName);

                if (food!=null)
                {
                    foods.Add(food);
                }

                else
                {
                    noFood++;
                }
            }

            int happiness = foods.Sum(f => f.Hapiness)-noFood;

            string moodName;

            if (happiness < -5)
            {
                moodName = "Angry";
            }

            else if (happiness >= -5 && happiness <= 0)
            {
                moodName = "Sad";
            }

            else if (happiness >= 1 && happiness <= 15)
            {
                moodName = "Happy";
            }

            else
            {
                moodName = "JavaScript";
            }

            Mood moodType = moodFactory.CreateMood(moodName);

            Console.WriteLine(happiness);

            Console.WriteLine(moodType.GetType().Name);            
        }
    }
}
