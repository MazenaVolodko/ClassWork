
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFrameworkProject
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void SetupDriver()
        {
             driver = new ChromeDriver();
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void OpenUrl(string url)
        {
            // Su refresh
            driver.Url = url;

            // Be refresh 
            // driver.Navigate().GoToUrl(url);
        }

        public static void CloseDriver()
        {
            driver.Quit();
        }

    }
}
