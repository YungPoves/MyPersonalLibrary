using System;

namespace Test.Concepts.Interfaces;

public class MIPaidclaims_IL : IStagingRow
{
  public MIPaidclaims_IL(string data)
  {
    Data = data;
  }
  public string Data { get; set; }
}
