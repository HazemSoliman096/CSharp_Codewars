using NUnit.Framework;

using kata;

namespace test
{
  [TestFixture]
  public class NextBiggerNumberTests
  {
    [Test]
    public void SmallNumbers()
    {
      Assert.AreEqual(21, nextBiggerNumberWithTheSameDigits.NextBiggerNumber(12));
      Assert.AreEqual(531, nextBiggerNumberWithTheSameDigits.NextBiggerNumber(513));
      Assert.AreEqual(2071, nextBiggerNumberWithTheSameDigits.NextBiggerNumber(2017));
      Assert.AreEqual(1143669007, nextBiggerNumberWithTheSameDigits.NextBiggerNumber(1143667900));
      Assert.AreEqual(1234567908, nextBiggerNumberWithTheSameDigits.NextBiggerNumber(1234567890));
    }
  }
}