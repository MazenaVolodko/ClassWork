using NUnit.Framework;
using SeleniumFrameworkProject;
using SeleniumFrameworkProject.Pages.DemoQA;
using System.Linq;

namespace SeleniumTestsProject.DemoQA
{
    internal class TextBoxTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            TextBox.Open("https://demoqa.com/text-box");
        }

        [Test]
        public void FillFormWithValidEmail()
        {
            string valueInputName = "My Name";
            string valueInputEmail = "email@email.com";
            string valueInputCurrentAddress = "My current address";
            string valueInputPermanentAddress = "My permanent address";

            TextBox.EnterFullName(valueInputName);
            TextBox.EnterEmail(valueInputEmail);
            TextBox.EnterCurrentAddress(valueInputCurrentAddress);
            TextBox.EnterPermanentAddress(valueInputPermanentAddress);

            TextBox.ClickSubmitButton();

            string actualFullName = TextBox.GetFullNameOutput();
            string actualEmail= TextBox.GetEmailOutput();
            string actualCurrentAddress = TextBox.GetCurrentAddressOutput();
            string actualPermanentAddress = TextBox.GetPermanentAddressOutput();

            Assert.IsTrue(actualFullName.Contains(valueInputName));
            Assert.IsTrue(actualEmail.Contains(valueInputEmail));
            Assert.IsTrue(actualCurrentAddress.Contains(valueInputCurrentAddress));
            Assert.IsTrue(actualPermanentAddress.Contains(valueInputPermanentAddress));

        }

        /*        [Test]
                public void FillFormWithInvalidEmail()
                {
                    string valueInputEmail = "invalidEmail";

                    IWebDriver driver = new ChromeDriver();
                    driver.Url = "https://demoqa.com/text-box";

                    IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
                    IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']/.."));


                    inputEmail.SendKeys(valueInputEmail);
                    buttonSubmit.Click();

                    // Patikriname, kad buvo uždėta papildoma klasė input elementui
                    Assert.IsTrue(inputEmail.GetAttribute("class").Contains("field-error"));

                    // Patikriname realią border spalvą
                    // Reikia palaukti, nes kitaip testas spėja nuskaityti seną spalvą ir failina
                    System.Threading.Thread.Sleep(500);
                    Assert.AreEqual("rgb(255, 0, 0)", inputEmail.GetCssValue("border-color"));

                    driver.Quit();
                }*/

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
