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
    [TestMethod]
    public void TestLambdaExpression()
    {
      IEnumerable<int> squaredNumbers = numbers.Select(x => x * x);
      Console.WriteLine(string.Join(" ", squaredNumbers));
    }
    [TestMethod]
    public void TestLambdaAction()
    {
      IntFunc = (x, y) => x * y;
      int multipliedInts = IntFunc(5, 4);
      Assert.IsTrue(multipliedInts == 20);
    }

    Func<int, int, int>? IntFunc;
    readonly int[] numbers = [2, 3, 4, 5];
    readonly Func<int, int> sqaured = (x) => x * x;
    readonly Action<string> hello = (name) => Console.WriteLine($"Hello {name}!");
  }
}