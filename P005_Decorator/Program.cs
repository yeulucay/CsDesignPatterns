using P005_Decorator;

ICoffee coffee = new PlainCoffee();
Console.WriteLine($"Order: {coffee.GetDescription()}, Cost: {coffee.GetCost()}");

coffee = new MilkDecorator(coffee);
Console.WriteLine($"Order: {coffee.GetDescription()}, Cost: {coffee.GetCost()}");

coffee = new ChocolateDecorator(coffee);
Console.WriteLine($"Order: {coffee.GetDescription()}, Cost: {coffee.GetCost()}");

coffee = new CaramelDecorator(coffee);
Console.WriteLine($"Order: {coffee.GetDescription()}, Cost: {coffee.GetCost()}");