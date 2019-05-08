namespace _07.FoodShortage
{
    public interface IBuyer
    {
        int Food { get; }

        string Name { get; }

        string Age { get; }

        void BuyFood();
    }
}