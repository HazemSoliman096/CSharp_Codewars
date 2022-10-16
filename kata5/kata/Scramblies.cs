namespace kata
{
  public class Scramblies
  {
    public static bool Scramble(string str1, string str2)
    {
     List<char> str = str1.ToCharArray().ToList();
     List<char> array = str2.ToCharArray().ToList();

      for (int i = 0; i < array.Count; i++)
      {
        if (!str.Contains(array[i])) {
          return false;
        } else {
          str.Remove(array[i]);
        }
      }
      return true;
    }
  }
}