namespace kata {
  public class Array_diff {
    public static int[] ArrayDiff(int[] a, int[] b) {
      return a.Where(n => !b.Contains(n)).ToArray();
    }
  }
}