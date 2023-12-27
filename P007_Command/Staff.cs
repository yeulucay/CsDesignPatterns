namespace P007_Command
{
    public class KitchenStaff
    {
        public void PrepareDish(string dishName) 
        {
            Console.WriteLine($"Preparing {dishName}");
        }
    }

    public class Waiter
    {
        private List<ICommand> orders = new();

        public void PlaceOrder(ICommand order) 
        { 
            orders.Add(order);
        }

        public void ServeOrders()
        {
            foreach(var order in orders) 
            {
                order.Execute();
            }

            orders.Clear();
        }
    }
}
