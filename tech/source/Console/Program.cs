using Common.Events;

Counter c = new Counter(10);

c.ThresholdReached += c_ThresholdReached;

for (int i = 0; i <= 10; i++)
{
  Console.WriteLine("adding one");
  c.Add(1);
}

static void c_ThresholdReached(object? sender, ThresholdReachedEventArgs e)
{
  Console.WriteLine($"Threshold of {e.Threshold} reached at {e.TimeReached}.");
  Environment.Exit(0);
}