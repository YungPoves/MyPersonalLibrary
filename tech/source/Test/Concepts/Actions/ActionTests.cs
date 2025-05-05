namespace Test.Concepts.Actions
{
  [TestClass]
  public class ActionTests
  {
    [TestInitialize]
    public void Setup()
    {
    }

    [TestCleanup]
    public void Cleanup()
    {
    }

    [TestMethod]
    public void TestAction()
    {
      myTestAction = SayHello;

      myTestAction?.Invoke("Steve");
      myTestAction?.Invoke("Poveroni");
    }
    [TestMethod]
    public void TestActionDispatcher()
    {
      myTestAction = SayHello;

      Dispatcher("Derparoni!", myTestAction);
    }

    private static void Dispatcher(string s, Action<string> e)
    {
      Action<string>? action = e;
      action?.Invoke(s);
    }
    private Action<string>? myTestAction;

    private void SayHello(string name)
    {
      Console.WriteLine($"Hello {name}!");
    }
  }
}