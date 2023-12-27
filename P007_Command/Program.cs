using P007_Command;

KitchenStaff kitchen = new KitchenStaff();

Waiter waiter = new Waiter();

ICommand order1 = new OrderCommand(kitchen, "Spaghetti");
ICommand order2 = new OrderCommand(kitchen, "Grilled Salmon");
ICommand order3 = new OrderCommand(kitchen, "Tiramisu");

waiter.PlaceOrder(order1);
waiter.PlaceOrder(order2);
waiter.PlaceOrder(order3);

waiter.ServeOrders();