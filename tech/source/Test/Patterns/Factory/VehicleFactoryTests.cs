namespace Test;

[TestClass]
public class VehicleFactoryTests
{
  [TestMethod]
  public void CreateCar()
  {
    Car myCar = VehicleFactory.CreateCar(2, 1);
    Truck myTruck = VehicleFactory.CreateTruck(10, 6);
  }
}
