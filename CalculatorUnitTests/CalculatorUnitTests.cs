﻿using NUnit.Framework;

namespace UnitsTests
{
    public class CalculatorUnitTests
    {
        [Test]
        public void Sum1And1()
        {
            int expectedResult = 2;

            int actualResult = Calculator.Calculator.SumInt(1, 1);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Sum2And2() 
        {
            Assert.AreEqual(4, Calculator.Calculator.SumInt(2, 2));
        }

        [Test]
        public void SumDouble01And01And01()
        { 
        double expectedResult = 0.3;

        double actualResult = Calculator.Calculator.SumDouble3(0.1, 0.1, 0.1);

        Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void SumDecimal01And01And01()
        {
            decimal expectedResult = 0.3m;

            decimal actualResult = Calculator.Calculator.SumDecimal3(0.1m, 0.1m, 0.1m);

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
