
using OpenQA.Selenium;
using System;

namespace SeleniumFrameworkProject.Pages.SeleniumEasy
{
    public class SimpleFormDemo
    {
        public static void EnterMessage(string message)
        {
            string locator = "//*[@id=\"user-message\"]";
            Common.SendKeys(locator, message);
        }

        public static void ClickShowMessageButton()
        {
            string locator = "//*[@id='get-input']/button";
            Common.ClickElement(locator);
        }

        public static string GetSingleInputFieldMessage()
        {
            string locator = "//*[@id=\"display\"]";
            return Common.GetElementText(locator);

        }

    }
}
