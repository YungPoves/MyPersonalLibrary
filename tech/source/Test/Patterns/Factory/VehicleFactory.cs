using Test.Patterns.Factory;

namespace Test;

public class VehicleFactory
{
  public static Car CreateCar(int weight, int length)
  {
    return new Car(weight, length);
  }
  public static Truck CreateTruck(int weight, int length)
  {
    return new Truck(weight, length);
  }
}
