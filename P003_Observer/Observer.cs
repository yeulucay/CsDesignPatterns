namespace P003_Observer
{
    public interface IObserver
    {
        void Update(string update);
    }

    public class OutdoorDisplay : IObserver
    {
        public void Update(string update)
        {
            Console.WriteLine($"OutdoorDisplay Received: {update}");
        }
    }

    public class MobileApp : IObserver
    {
        public void Update(string update)
        {
            Console.WriteLine($"MobileApp Received: {update}");
        }
    }
}
