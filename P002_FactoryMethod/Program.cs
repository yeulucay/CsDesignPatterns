using P002_FactoryMethod;

CarFactory dealership = new BMWFactory();

Car customerCar = dealership.CreateCar();
customerCar.Assemble();