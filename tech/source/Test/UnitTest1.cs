namespace Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.IsTrue(1 == 1);
    }
    [TestMethod]
    public void TestMethod2()
    {
        Assert.IsFalse(1 == 2);
    }    
    [TestMethod]
    public void TestMethod3()
    {
        Assert.IsTrue(1 + 1 == 2);
    }    
    [TestMethod]
    public void TestMethod4()
    {
        Assert.IsTrue(1 + 1 == 2);
    }    
    [TestMethod]
    public void TestMethod5()
    {
        Assert.IsTrue(1 + 1 != 3);
    }
}