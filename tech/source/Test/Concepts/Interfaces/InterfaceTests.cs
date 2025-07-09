namespace Test.Concepts.Interfaces
{
  [TestClass]
  public class InterfaceTests
  {
    [TestInitialize]
    public void Setup()
    {
    }

    [TestMethod]
    public void InterfaceTest()
    {
      IStagingRow paidClaimsRow = new MIPaidclaims_IL("paid");
      IStagingRow registeredClaimsRow = new MIRegisteredclaims_IL("registered");
      rows.Add(paidClaimsRow);
      rows.Add(registeredClaimsRow);

      foreach (IStagingRow row in rows)
      {
        InterfaceUser.PrintSomething(row);
      }

      Assert.IsTrue(rows.Count == 2);
    }

    private readonly IList<IStagingRow> rows = [];
  }
}