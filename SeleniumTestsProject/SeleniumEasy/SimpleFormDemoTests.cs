
using NUnit.Framework;
using SeleniumFrameworkProject;
using SeleniumFrameworkProject.Pages.SeleniumEasy;

namespace SeleniumTestsProject
{
    internal class SimpleFormDemoTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            SimpleFormDemo.Open();
        }

        [Test]
        public void SingleInputField()  
        {
            string expectedResult = "Labas";

            SimpleFormDemo.EnterMessage(expectedResult);
            SimpleFormDemo.ClickShowMessageButton();
            string actualResult = SimpleFormDemo.GetSingleInputFieldMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TwoInputField()
        {
            string inputAValue = "5";
            string inputBValue = "7";
            string expectedResult = "12";

            SimpleFormDemo.EnterInputA(inputAValue);
            SimpleFormDemo.EnterInputB(inputBValue);
            SimpleFormDemo.ClickGetTotalButton();
            string actualResult = SimpleFormDemo.GetTwoInputFieldsMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TearDown() 
        {
            Driver.CloseDriver();
        }
    }
}
