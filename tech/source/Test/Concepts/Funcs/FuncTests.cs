namespace Test.Concepts.Funcs
{
  [TestClass]
  public class FuncTests
  {
    [TestInitialize]
    public void Setup()
    {
    }

    [TestMethod]
    public void TestFunc()
    {
      func = Square;

      Assert.IsTrue(func(3) == 9);
    }

    private Func<int, int>? func;

    private int Square(int x)
    {
      return x * x;
    }
  }
}