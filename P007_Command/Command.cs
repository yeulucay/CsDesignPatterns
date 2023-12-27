namespace P007_Command
{
    public interface ICommand
    {
        void Execute();
    }

    public class OrderCommand : ICommand 
    {
        private string dishName;
        private KitchenStaff kitchenStaff;

        public OrderCommand(KitchenStaff kitchenStaff, string dishName) 
        {
            this.kitchenStaff = kitchenStaff;
            this.dishName = dishName;
        }

        public void Execute()
        {
            kitchenStaff.PrepareDish(dishName);
        }
    }
}
