using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Demoqa.Extensions
{
    public static class IWebElementExtension
    {
        public static void TryClick(this IWebElement webElement, IWebDriver driver)
        {
            try
            {
                webElement.Click();
            }
            catch (OpenQA.Selenium.ElementClickInterceptedException)
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(webElement);
                actions.Perform();
                webElement.Click();
            }
        }
    }
}
