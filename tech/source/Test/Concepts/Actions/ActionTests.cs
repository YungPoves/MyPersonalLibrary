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

    private Action<string>? myTestAction;

    private void SayHello(string name)
    {
      Console.WriteLine($"Hello {name}!");
    }
  }
}