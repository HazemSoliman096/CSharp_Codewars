namespace kata
{
  public class DigPow
  {
    public static long digPow(int n, int p)
    {
      long total = (long)n.ToString()
                          .Select((v, i) => Math.Pow(v, (p + double.Parse(i.ToString()))))
                          .ToArray()
                          .Aggregate((acc, x) => acc + x);

      return total % n == 0 ? total / n : -1;
    }
  }
}