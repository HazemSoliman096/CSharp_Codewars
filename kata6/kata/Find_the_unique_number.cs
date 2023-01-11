namespace kata
{
  public class FindTheUniqueNumber
  {
    public static int GetUnique(IEnumerable<int> numbers)
    {
      return numbers.GroupBy(i => i).Where(g => g.Count() == 1).Select(x => x.Key).FirstOrDefault();
    }
  }
}