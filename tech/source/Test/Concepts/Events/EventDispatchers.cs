namespace Test.Concepts;

[TestClass]
public class EventDispatchers
{
  [TestMethod]
  public void TestOnEvenAndOnOddEventDispatcher()
  {
    OnEvenNumber = PrintEven;
    OnOddNumber = PrintOdd;

    for (int i = Start; i <= End; i++)
    {
      switch (i % 2)
      {
        case 0:
          EventDispatcher(i, OnEvenNumber);
          break;

        default:
          EventDispatcher(i, OnOddNumber);
          break;
      }
    }
  }

  [TestMethod]
  public void TestOnMaximumReachedEventDispatcher()
  {
    OnMaximum = PrintMaximum;
    for (int i = Start; i <= End; ++i)
    {
      if (i == End)
        EventDispatcher(i, OnMaximum);
      else Console.WriteLine(i);
    }
  }

  // Event dispatchers
  private static void EventDispatcher(int num, Action<int> action)
  {
    Action<int>? handler = action;

    handler?.Invoke(num);
  }

  private void PrintEven(int num)
  {
    Console.WriteLine($"{num} is even.");
  }
  private void PrintOdd(int num)
  {
    Console.WriteLine($"{num} is odd.");
  }
  private void PrintMaximum(int num)
  {
    Console.WriteLine($"Maximum of {num} reached.");
  }

  private Action<int>? OnEvenNumber;
  private Action<int>? OnOddNumber;
  private Action<int>? OnMaximum;

  private const int Start = 1;
  private const int End = 100;
}
