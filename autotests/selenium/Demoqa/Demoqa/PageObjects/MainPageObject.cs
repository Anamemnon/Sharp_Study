using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Demoqa.PageObjects
{
    public class MainPageObject : BaseObject
    {

        public static IWebElement GetCardElement(Card card, IWebDriver driver, WebDriverWait wait)
        {
            string text = card.GetLabel();
            //var element = driver.FindElement(By.XPath($"//*[@class='card-body']/*[text()='{text}']"));
            var element = driver.FindElement(By.XPath($"//*[text()='{text}']/../../.."));

            return wait.Until(condition: ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
