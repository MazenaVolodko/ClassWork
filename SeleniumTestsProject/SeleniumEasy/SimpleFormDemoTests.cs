
using NUnit.Framework;
using SeleniumFrameworkProject;
using SeleniumFrameworkProject.Pages.SeleniumEasy;

namespace SeleniumTestsProject
{
    internal class SimpleFormDemoTests
    {
        [Test]
        public void SingleInputField()  
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://demo.seleniumeasy.com/basic-first-form-demo.html");

            string expectedResult = "Labas";

            SimpleFormDemo.EnterMessage(expectedResult);
            SimpleFormDemo.ClickShowMessageButton();
            string actualResult = SimpleFormDemo.GetSingleInputFieldMessage();

            Assert.AreEqual(expectedResult, actualResult);

            Driver.CloseDriver();
        }
    }
}
