using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;

namespace SeleniumFrameworkProject.Pages
{
    internal class Common
    {
        public static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator)
        {
             GetElement(locator).Click();
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void ScrollBy(int x, int y)
        {
            Driver.GetDriver().ExecuteJavaScript($"window.scrollBy({x}, {y})");

        }

        internal static void SendKeys(string locator, string message)
        {
            GetElement(locator).SendKeys(message);
        }
    }
}
