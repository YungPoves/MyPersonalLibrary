namespace Test.Concepts.Lambdas
{
  [TestClass]
  public class LambdaTests
  {
    [TestInitialize]
    public void Setup()
    {
    }

    [TestMethod]
    public void TestSquaredLambda()
    {
      Assert.IsTrue(sqaured(5) == 25);
    }
    [TestMethod]
    public void TestHelloLambda()
    {
      hello("Steve");
    }

    readonly Func<int, int> sqaured = (x) => x * x;
    readonly Action<string> hello = (name) => Console.WriteLine($"Hello {name}!");
  }
}