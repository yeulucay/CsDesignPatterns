namespace P004_Strategy
{
    public class TravelPlanner
    {
        private readonly ITravelStrategy travelStrategy;

        public TravelPlanner(ITravelStrategy travelStrategy)
        {
            this.travelStrategy = travelStrategy;
        }

        public void DoPlan(string from, string to) 
        {
            travelStrategy.Travel(from, to);
        }
    }
}
