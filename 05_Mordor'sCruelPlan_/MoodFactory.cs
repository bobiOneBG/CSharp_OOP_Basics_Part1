namespace _05_Mordor_sCruelPlan_
{
    using _05_Mordor_sCruelPlan_.Moods;
    using System;

    public class MoodFactory
    {
        public Mood CreateMood(string mood)
        {
            Type moodType = Type.GetType("_05_Mordor_sCruelPlan_.Moods." + mood);

            return (Mood)Activator.CreateInstance(moodType);
        }
    }
}
