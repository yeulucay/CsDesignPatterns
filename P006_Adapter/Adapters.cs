namespace P006_Adapter
{
    public class EUToUKAdapter : IUKSocket
    {
        private readonly EuropeanCharger europeanCharger;

        public EUToUKAdapter(EuropeanCharger europeanCharger)
        {
            this.europeanCharger = europeanCharger;
        }

        public void PlugIntoUKSocket()
        {
            Console.WriteLine("Using adapter to plug into UK socket.");
            europeanCharger.PlugIntoEUSocket();
        }
    }

    public class EUToUSAdapter : IUSSocket
    {
        private readonly EuropeanCharger europeanCharger;

        public EUToUSAdapter(EuropeanCharger europeanCharger)
        {
            this.europeanCharger = europeanCharger;
        }

        public void PlugIntoUSSocket()
        {
            Console.WriteLine("Using adapter to plug into US socket.");
            europeanCharger.PlugIntoEUSocket();
        }
    }
}
