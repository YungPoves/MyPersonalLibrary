using Test.Patterns.Factory;

namespace Test;

public class VehicleFactory
{
  public IVehicle CreateCar(int weight, int length)
  {
    return new Car(weight, length);
  }
  public IVehicle CreateTruck(int weight, int length)
  {
    return new Truck(weight, length);
  }
}
