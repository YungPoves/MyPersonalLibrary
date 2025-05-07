namespace Common.Events;

public class Counter
{
  public event EventHandler ThresholdReached;

  protected virtual void OnThresholdReached(EventArgs e)
  {
    ThresholdReached?.Invoke(this, e);
  }

}
