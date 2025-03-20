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

      myTestAction();
    }

    private Action? myTestAction;

    private void SayHello()
    {
      Console.WriteLine("Hello!");
    }
  }
}