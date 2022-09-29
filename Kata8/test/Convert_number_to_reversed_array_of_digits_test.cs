using NUnit.Framework;

using kata;

namespace test
{
  [TestFixture]
  public class Convert_number_to_reversed_array_of_digits_test
  {
    [Test]
    public void MyTest()
    {
      Assert.AreEqual(new long[] { 1, 3, 2, 5, 3 }, Convert_number_to_reversed_array_of_digits.Digitize(35231));
      Assert.AreEqual(new long[] { 0 }, Convert_number_to_reversed_array_of_digits.Digitize(0));
    }
  }
}