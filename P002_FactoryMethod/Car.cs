namespace P002_FactoryMethod
{
    public abstract class Car
    {
        public abstract void Assemble();
    }

    public class BMWCar : Car 
    {
        public override void Assemble()
        {
            Console.WriteLine("Assembling a BMW car.");

            // add BMW-specific assembly logic here
        }
    }

    public abstract class CarFactory 
    {
        public abstract Car CreateCar();
    }

    public class BMWFactory : CarFactory 
    {
        public override Car CreateCar() 
        {
            return new BMWCar();
        }
    }    
}
