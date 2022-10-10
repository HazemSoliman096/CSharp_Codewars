namespace kata
{
  public class nextBiggerNumberWithTheSameDigits
  {
    public static long NextBiggerNumber(long n)
    {
      int[] digits = n.ToString().Select(x => Int32.Parse(x.ToString())).ToArray();
      int index = digits.Length - 1;

      if (!(digits.All(v => v == digits[0])) && (!(digits.Length == 1)))
      {
        while (index > 0)
        {
          if (digits[index] > digits[index - 1])
          {
            int[] arr = digits.Skip(index - 1).ToArray();
            digits = digits.Take(index-1).ToArray();
            int[] num1 = arr.Where(x => x > arr[0]).Min().ToString().Select(o=> Int32.Parse(o.ToString())).ToArray();
            arr = arr.Where((n, i) => i != Array.IndexOf(arr, num1[0])).ToArray();
            Array.Sort(arr);
            return long.Parse(String.Join("", digits.Concat(num1).Concat(arr).ToArray()));
          }
          index -= 1;
        }
      }
      return -1;
    }
  }
}