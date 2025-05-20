using Test.Patterns.Factory;

namespace Test;

public class Truck : IVehicle
{
  public Truck()
  {
  }
  public Truck(int weight, int length)
  {
    Weight = weight;
    Length = length;
  }

  public float Weight { get => weight; set => weight = value; }
  public float Length { get => length; set => length = value; }

  private float weight;
  private float length;

}
