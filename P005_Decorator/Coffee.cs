namespace P005_Decorator
{
    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }

    public class PlainCoffee : ICoffee
    {
        public double GetCost() => 2.5;

        public string GetDescription() => "Plain Coffee";
    }

    public abstract class  CoffeeDecorator : ICoffee
    {
        protected ICoffee coffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public virtual double GetCost()
        {
            return coffee.GetCost();
        }

        public virtual string GetDescription()
        {
            return coffee.GetDescription();
        }
    }

    public class MilkDecorator : CoffeeDecorator
    { 
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return $"{coffee.GetDescription()} + Milk";
        }

        public override double GetCost()
        {
            return coffee.GetCost() + 0.5;
        }
    }

    public class ChocolateDecorator : CoffeeDecorator
    {
        public ChocolateDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return $"{coffee.GetDescription()} + Chocolate";
        }

        public override double GetCost()
        {
            return coffee.GetCost() + 1.0;
        }
    }

    public class CaramelDecorator : CoffeeDecorator
    {
        public CaramelDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return $"{coffee.GetDescription()} + Caramel";
        }

        public override double GetCost()
        {
            return coffee.GetCost() + 0.7;
        }
    }
}
