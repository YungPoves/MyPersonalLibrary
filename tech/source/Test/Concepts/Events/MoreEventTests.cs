namespace Test.Concepts;

[TestClass]
public class MoreEventTests
{
  [TestMethod]
  public void TestOnEvenAndOnOddEventDispatcher()
  {
    OnEvenNumber = PrintEven;
    OnOddNumber = PrintOdd;

    for(int i = Start; i <= End; i++)
    {
      switch(i % 2)
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

  // Event dispatcher
  private void EventDispatcher(int num)
  {
    Action<int>? handler = OnEvenNumber;

    handler?.Invoke(num);
  }
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

  private Action<int>? OnEvenNumber;
  private Action<int>? OnOddNumber;

  private const int Start = 1;
  private const int End = 100;
}
