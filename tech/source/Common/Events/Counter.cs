namespace Common.Events;

public class Counter
{
  private int threshold;
  private int total;

  public Counter(int passedThreshold)
  {
    threshold = passedThreshold;
  }

  public event EventHandler<ThresholdReachedEventArgs>? ThresholdReached;
  public void Add(int x)
  {
    total += x;
    if (total >= threshold)
    {
      ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
      args.Threshold = threshold;
      args.TimeReached = DateTime.Now;
      OnThresholdReached(args);
    }
  }
  protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
  {
    EventHandler<ThresholdReachedEventArgs>? handler = ThresholdReached;
    if(handler != null)
    {
      handler?.Invoke(this, e);
    }
  }
}
