namespace P004_Strategy
{
    public interface ITravelStrategy
    {
        void Travel(string from, string to);
    }

    public class CarTravel : ITravelStrategy
    {
        public void Travel(string from, string to)
        {
            Console.WriteLine($"Traveling by car from {from} to {to}.");
        }
    }

    public class PlaneTravel : ITravelStrategy
    {
        public void Travel(string from, string to)
        {
            Console.WriteLine($"Traveling by plane from {from} to {to}.");
        }
    }

    public class TrainTravel : ITravelStrategy
    {
        public void Travel(string from, string to)
        {
            Console.WriteLine($"Traveling by train from {from} to {to}.");
        }
    }
}
