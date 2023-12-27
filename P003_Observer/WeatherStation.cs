namespace P003_Observer
{
    public interface IWeatherStation
    {
        void AddObserver(IObserver observer);
        void NotifyObservers();
    }

    public class TheWeatherChannel : IWeatherStation
    {
        private List<IObserver> observerList = [];
        private string currentWeather = "";

        public void AddObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observerList)
            {
                observer.Update(currentWeather);
            }
        }

        public void SetNewWeather(string weatherUpdate) 
        {
            currentWeather = weatherUpdate;
            NotifyObservers();
        }
    } 
}
