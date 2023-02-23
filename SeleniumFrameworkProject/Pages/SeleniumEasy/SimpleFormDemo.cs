
using OpenQA.Selenium;
using System;

namespace SeleniumFrameworkProject.Pages.SeleniumEasy
{
    public class SimpleFormDemo
    {
        public static void Open()
        {
            Driver.OpenUrl("https://demo.seleniumeasy.com/basic-first-form-demo.html");
        }

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

        public static void EnterInputA(string inputAValue)
        {
            string locator = "//*[@id=\"sum1\"]";
            Common.SendKeys(locator, inputAValue);
        }

        public static void EnterInputB(string inputBValue)
        {
            string locator = "//*[@id=\"sum2\"]";
            Common.SendKeys(locator, inputBValue);
        }

        public static void ClickGetTotalButton()
        {
            string locator = "//*[@id=\"gettotal\"]/button";
            Common.ClickElement(locator);
        }

        public static string GetTwoInputFieldsMessage()
        {
            string locator = "//*[@id=\"displayvalue\"]";
            return Common.GetElementText(locator);
        }
    }
}
