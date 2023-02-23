using OpenQA.Selenium;

namespace SeleniumFrameworkProject.Pages.DemoQA
{
    internal class Locators
    {
        internal class TextBox
        {
            internal static string inputEmail = "//*[@id='userEmail']";
            internal static string inputFullName = "//*[@id='userName']";
            internal static string inputCurrentAddress = "//*[@id='currentAddress']";
            internal static string inputPermanentAddress = "//*[@id='permanentAddress']";
            internal static string buttonSubmit = "//*[@id='submit']/..";

            internal static string fullNameOutput = "//*[@id='output']//*[@id='name']";
            internal static string emailOutput = "//*[@id='output']//*[@id='email']";
            internal static string currentAddressOutput = "//*[@id='output']//*[@id='currentAddress']";
            internal static string permanentAddressOutput = "//*[@id='output']//*[@id='permanentAddress']";
        }
    }
}
