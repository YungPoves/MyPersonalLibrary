namespace Test.Concepts.Interfaces;

public class InterfaceUser
{
  public static void PrintSomething<TStagingRow>(TStagingRow stagingRow) where TStagingRow : IStagingRow
  {
    Console.WriteLine(stagingRow.Data);
  }
}
