using NUnit.Framework;
using System;

namespace CalculatorUnitTests
{
    internal class Homework1
    {
        [Test]
        public void CheckReminder995DividedBy3()
        {
            int expectedResult = 0;

            int actualResult = 995 % 3;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TodayIsWednesday()
        {
            string expectedResult = "Wednesday";
            string actualResult = DateTime.Now.DayOfWeek.ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void NowIs13()
        {
            string expectedResult = "13";
            string actualResult = DateTime.Now.Hour.ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CheckIfThereAreEvenNumbers() 
        {
            int expectedResult = 4;
            int actualResult = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    actualResult++;
                }
            }
            Assert.AreEqual(expectedResult, actualResult);  
        }

    }
}
