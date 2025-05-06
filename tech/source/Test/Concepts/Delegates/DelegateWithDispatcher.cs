namespace Test.Concepts.Delegates
{
  [TestClass]
  public class DelegateWithDispatcher
  {
    [TestMethod]
    public void TestSquareDispatcher()
    {
      int num = 6;
      int sqr;
      TestDelegate tst = Square;
      sqr = Dispatcher(tst, num);

      Assert.IsTrue(sqr == num * num);
    }

    private delegate int TestDelegate(int i);
    private int Dispatcher(TestDelegate testDelegate, int i)
    {
      return testDelegate.Invoke(i);
    }
    private int Square(int x)
    {
      return x * x;
    }
  }
}