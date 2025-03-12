namespace Test.Concepts
{
    [TestClass]
    public class DelegateTests
    {
        [TestInitialize]
        public void Setup()
        {
        }

        [TestMethod]
        public void IntDelegateTest()
        {
            TestDelegate testDelegate = DelegateMethod;
            int x = 3;

            Assert.IsTrue(x == testDelegate(3));
        }
        [TestMethod]
        public void IntDelegateWithTwoMethodTest()
        {
            TestDelegate testDelegate = DelegateMethod;
            int x = 5;

            Assert.IsTrue(testDelegate(x) == 5);

            testDelegate = DelegateMultiply;

            Assert.IsTrue(testDelegate(x) == 25);
        }

        private delegate int TestDelegate(int a);
        public static int DelegateMethod(int x)
        {
            Console.WriteLine(x);
            return x;
        }
        public static int DelegateMultiply(int x)
        {
            return x * x;
        }
    }
}