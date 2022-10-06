using NUnit.Framework;
using kata;

namespace test
{
    [TestFixture]
    public class Vectors_Tests
    {
        [Test]
        [TestCase(0, 2, 0, ExpectedResult = 2)]
        [TestCase(1, 2, 2, ExpectedResult = 3)]
        public static double FixedTest(double x, double y, double z)
        {
            return new Vectors()
            {
                X = x,
                Y = y,
                Z = z
            }.Length;
        }
    }
}