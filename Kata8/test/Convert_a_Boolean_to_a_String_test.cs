namespace  test {
  using NUnit.Framework;

  using kata;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void Convert_a_Boolean_to_a_String_test()
    {
      Assert.AreEqual("True", Convert_a_Boolean_to_a_String.boolean_to_string(true));
      Assert.AreEqual("False", Convert_a_Boolean_to_a_String.boolean_to_string(false));
    }
  }
}