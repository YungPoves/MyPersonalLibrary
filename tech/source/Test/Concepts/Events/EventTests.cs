namespace Test.Concepts
{
  [TestClass]
  public class EventTests
  {
    [TestInitialize]
    public void Setup()
    {
      OnEvenNumberFound += PrintEven;
      OnOddNumberFound += PrintOdd;
    }

    [TestMethod]
    public void TestEventHandlers()
    {
      for (int i = Begin; i <= End; i++)
      {
        switch (i % 2)
        {
          case 0:
            OnEvenNumberFound?.Invoke(this, i);
            break;

          default:
            OnOddNumberFound?.Invoke(this, i);
            break;
        }
      }
      Assert.IsTrue(1 == 1);
    }

    [TestMethod]
    public void TestWithOneEventHandler()
    {
      for (int i = Begin; i <= End; i++)
      {
        switch (i % 2)
        {
          case 0:
            OnNumberIncrement = PrintEven;
            OnNumberIncrement?.Invoke(this, i);
            break;

          default:
            OnNumberIncrement = PrintOdd;
            OnNumberIncrement?.Invoke(this, i);
            break;
        }
      }
      Assert.IsTrue(1 == 1);
    }

    //Events
    private event EventHandler<int>? OnEvenNumberFound;
    private event EventHandler<int>? OnOddNumberFound;
    private event EventHandler<int>? OnNumberIncrement;

    private void PrintEven(object? sender, int num)
    {
      Console.WriteLine($"{num}: Even!");
    }
    private void PrintOdd(object? sender, int num)
    {
      Console.WriteLine($"{num}: Odd!");
    }

    private const int Begin = 1;
    private const int End = 100;
  }
}