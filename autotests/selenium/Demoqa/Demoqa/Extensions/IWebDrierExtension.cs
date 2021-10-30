using OpenQA.Selenium;
using System.Threading.Tasks;

namespace Demoqa.Extensions
{
    public static class IWebDrierExtension
    {
        async public static Task OpenAsync(this IWebDriver driver, string url)
        {
            await Task.Run(() => driver.Navigate().GoToUrl(url));
        }

        public static void Open(this IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
