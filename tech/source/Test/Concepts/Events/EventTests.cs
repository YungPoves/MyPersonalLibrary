namespace Test.Concepts
{
  [TestClass]
  public class EventTests
  {
    [TestInitialize]
    public void Setup()
    {
      OddNumberFound += PrintOdd;
    }

    [TestMethod]
    public void TestEventHandlers()
    {
      for (int i = Begin; i <= End; i++)
      {
        switch (i % 2)
        {
          case 0:
            // evenNumberFound?.Invoke();
            evenNumberFound2?.Invoke(i);
            break;

          default:
            OddNumberFound?.Invoke(this, i);
            break;
        }
      }
      Assert.IsTrue(1 == 1);
    }

    private const int Begin = 1;
    private const int End = 100;

    //Delegates
    public delegate void EvenNumberFound();
    private delegate void EvenNumberFound2(int x);
    private readonly EvenNumberFound evenNumberFound = PrintEven;
    private readonly EvenNumberFound2 evenNumberFound2 = PrintEven;

    //Events
    private event EventHandler<int>? OddNumberFound;

    private static void PrintEven()
    {
      Console.WriteLine("Even!");
    }
    private static void PrintEven(int num)
    {
      Console.WriteLine($"{num}: Even!");
    }
    private void PrintOdd(object? sender, int num)
    {
      Console.WriteLine($"{num}: Odd!");
    }
  }
}