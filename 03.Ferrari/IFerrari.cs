namespace _03.Ferrari
{
    public interface IFerrari
    {
        string Driver { get; }
        string Model { get; }

        string Brake();
        string PushGas();
    }
}