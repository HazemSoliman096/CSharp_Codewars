namespace kata
{
  public class Convert_number_to_reversed_array_of_digits
  {
    public static long[] Digitize(long n)
    {
      return n.ToString().Reverse().Select(i => long.Parse(i.ToString())).ToArray();
    }
  }
}