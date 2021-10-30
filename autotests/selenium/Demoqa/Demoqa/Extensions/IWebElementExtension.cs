using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading.Tasks;

namespace Demoqa.Extensions
{
    public static class IWebElementExtension
    {
        async public static Task TryClickAsync(this IWebElement webElement, IWebDriver driver)
        {
            try
            {
                await Task.Run(() => webElement.Click());
            }
            catch (ElementClickInterceptedException)
            {
                await Task.Run(() =>
                {
                    Actions actions = new(driver);
                    actions.MoveToElement(webElement);
                    actions.Perform();
                    webElement.Click();
                });
            }
        }
    }
}
