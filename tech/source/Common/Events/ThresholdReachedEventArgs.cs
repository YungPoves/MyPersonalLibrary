namespace Common.Events;

public class ThresholdReachedEventArgs : EventArgs
{
  public int? Threshold { get; set; }
  public DateTime TimeReached { get; set; }
}
