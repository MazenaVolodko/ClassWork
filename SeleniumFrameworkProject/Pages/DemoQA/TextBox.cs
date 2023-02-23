
namespace SeleniumFrameworkProject.Pages.DemoQA
{
    public class TextBox
    {
        public static void Open(string url)
        {
            Driver.OpenUrl(url);
        }

        public static void EnterCurrentAddress(string valueInputCurrentAddress)
        {
            Common.SendKeys(Locators.TextBox.inputCurrentAddress, valueInputCurrentAddress);
        }

        public static void EnterEmail(string valueInputEmail)
        {
            Common.SendKeys(Locators.TextBox.inputEmail, valueInputEmail);
        }

        public static void EnterFullName(string valueInputName)
        {
            Common.SendKeys(Locators.TextBox.inputFullName, valueInputName);
        }

        public static void EnterPermanentAddress(string valueInputPermanentAddress)
        {
            Common.SendKeys(Locators.TextBox.inputPermanentAddress, valueInputPermanentAddress);
        }

        public static void ClickSubmitButton()
        {
            Common.ScrollBy(0, 100);
            Common.ClickElement(Locators.TextBox.buttonSubmit);
        }

        public static string GetFullNameOutput()
        {
            return Common.GetElementText(Locators.TextBox.fullNameOutput);
        }

        public static string GetEmailOutput()
        {
            return Common.GetElementText(Locators.TextBox.emailOutput);

        }

        public static string GetCurrentAddressOutput()
        {
            return Common.GetElementText(Locators.TextBox.currentAddressOutput);

        }

        public static string GetPermanentAddressOutput()
        {
            return Common.GetElementText(Locators.TextBox.permanentAddressOutput);
        }
    }
}
