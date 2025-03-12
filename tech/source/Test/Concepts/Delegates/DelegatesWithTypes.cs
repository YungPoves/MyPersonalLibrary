namespace Test.Concepts.Delegates
{
    [TestClass]
    public class DelegatesWithTypes
    {
        [TestMethod]
        public void DelegateTypeTest()
        {
            TestDelegate<int> intDelegate = IntDelegate;
            TestDelegate<string> strDelegate = StrDelegate;

            intDelegate(5);
            strDelegate("Hello!");
        }

        private delegate void TestDelegate<T>(T x); 

        public static void IntDelegate<T>(T x)
        {
            Console.WriteLine(x);
        }

        public static void StrDelegate<T>(T x)
        {
            Console.WriteLine(x);
        }
    }
}