namespace Test.Concepts.EventsAndDelegates
{
  [TestClass]
  public class EventAndDelegate
  {
    [TestInitialize]
    public void Setup()
    {
    }

    [TestMethod]
    public void TestDelegates()
    {
      for (int i = Begin; i <= End; i++)
      {
        switch (i % 2)
        {
          case (0):
            onNumberIncrementDelegate = PrintOnEven;
            onNumberIncrementDelegate?.Invoke(i);
          break;

          default:
            onNumberIncrementDelegate = PrintOnOdd;
            onNumberIncrementDelegate?.Invoke(i);
          break;
        }
      }
    }
    [TestMethod]
    public void TestEvents()
    {
      for (int i = Begin; i <= End; i++)
      {
        switch (i % 2)
        {
          case (0):
            OnNumberIncrementEvent = PrintOnEven;
            OnNumberIncrementEvent?.Invoke(this, i);
          break;

          default:
            OnNumberIncrementEvent = PrintOnOdd;
            OnNumberIncrementEvent?.Invoke(this, i);
          break;
        }
      }
    }
    
    #region Delegates
    private delegate void OnNumberIncrementDelegate(int num);
    private OnNumberIncrementDelegate? onNumberIncrementDelegate;
    #endregion

    #region Events
    private event EventHandler<int>? OnNumberIncrementEvent;
    #endregion

    #region Methods
    private void PrintOnEven(int num)
    {
      Console.WriteLine($"{num}: Even!");
    }
    private void PrintOnOdd(int num)
    {
      Console.WriteLine($"{num}: Odd!");
    }

    private void PrintOnEven(object? sender, int num)
    {
      Console.WriteLine($"{num}: Even!");
    }
    private void PrintOnOdd(object? sender, int num)
    {
      Console.WriteLine($"{num}: Odd!");
    }
    #endregion

    private const int Begin = 1;
    private const int End = 100;
  }
}