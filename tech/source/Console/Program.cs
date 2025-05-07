using Common.Events;

Counter c = new Counter(10);

c.ThresholdReached += c_ThresholdReached;

Console.WriteLine("press 'a' key to increase total");
while (Console.ReadKey(true).KeyChar == 'a')
{
  Console.WriteLine("adding one");
  c.Add(1);
}

static void c_ThresholdReached(object sender, EventArgs e)
{
  Console.WriteLine("Threshold reached.");
}