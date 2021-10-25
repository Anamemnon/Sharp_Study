using OpenQA.Selenium;

namespace Demoqa.Extensions
{
    public static class IWebDrierExtension
    {
        public static void Open(this IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
