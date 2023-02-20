using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Net.WebRequestMethods;

namespace Homework2
{
    public class Homework2
    {
        [Test]
        public void FourInputFields()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            string inputFullNameValue = "Vardenis Pavardenis";
            string inputEmailValue = "vardenis@pavardenis.lt";
            string inputCurrentAddressValue = "Laisves pr.1";
            string inputPermanentAddressValue = "Ulonu g.5";

            IWebElement inputFullName = driver.FindElement(By.XPath("//*[@id='userName']"));
            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement inputCurrentAddress = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            IWebElement inputPermanentAddress = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']"));

            inputFullName.SendKeys(inputFullNameValue);
            inputEmail.SendKeys(inputEmailValue);
            inputCurrentAddress.SendKeys(inputCurrentAddressValue);
            inputPermanentAddress.SendKeys(inputPermanentAddressValue);
            buttonSubmit.Click();

            IWebElement messageFullName = driver.FindElement(By.XPath("//*[@id='name']"));
            IWebElement messageEmail = driver.FindElement(By.XPath("//*[@id='email']"));
            IWebElement messageCurrentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[@id='currentAddress']"));
            IWebElement messagePermanentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[@id='permanentAddress']"));

            Assert.IsTrue(messageFullName.Text.Contains(inputFullNameValue), $"actual: {messageFullName.Text}, expected: {inputFullNameValue}");
            Assert.IsTrue(messageEmail.Text.Contains(inputEmailValue), $"actual: {messageEmail.Text}, expected: {inputEmailValue}");
            Assert.IsTrue(messageCurrentAddress.Text.Contains(inputCurrentAddressValue), $"actual: {messageCurrentAddress.Text}, expected: {inputCurrentAddressValue}");
            Assert.IsTrue(messagePermanentAddress.Text.Contains(inputPermanentAddressValue), $"actual: {messagePermanentAddress.Text}, expected: {inputPermanentAddressValue}");

            driver.Quit();
        }

        [Test]
        public void testEmailError()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            string inputEmailValue = "vardenispavardenis.lt";

            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']"));

            inputEmail.SendKeys(inputEmailValue);
            buttonSubmit.Click();

            Assert.IsTrue(inputEmail.GetAttribute("class").Contains("field-error"));

            driver.Quit();
        }
    }
}
