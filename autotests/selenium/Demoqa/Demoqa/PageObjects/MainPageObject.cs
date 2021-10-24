using OpenQA.Selenium;

namespace Demoqa.PageObjects
{
    internal class MainPageObject
    {

        public static IWebElement GetCardElement(Card card, IWebDriver driver)
        {
            string text = card.GetLabel();

            return driver.FindElement(By.XPath($"//*[@class='card-body']/*[text()='{text}']"));
        }
    }
}
