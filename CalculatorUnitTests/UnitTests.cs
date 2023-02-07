using NUnit.Framework;

namespace CalculatorUnitTests
{
    public class UnitTests
    {
        [Test]
        public void Sum1And1()
        {
            int expectedResult = 2;

            int actualResult = Calculator.Calculator.Sum(1, 1);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
