using Demoqa.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Demoqa.PageObjects
{
    public class LeftPannel : BasePageObject
    {
        public static void Open(Card card, IWebDriver driver, WebDriverWait wait)
        {
            var child = card switch
            {
                Card.ELEMENTS => 1,
                Card.FORMS => 2,
                Card.ALERTS_FRAME_WINDOWS => 3,
                Card.WIDGETS => 4,
                Card.INTERACTIONS => 5,
                Card.BOOK_STORE_APPLICATION => 6,
                _ => throw new ArgumentException($"Left panel doesn't have such element: {nameof(card)}")

            };
            var element = driver.FindElement(By.CssSelector($".left-pannel .element-group:nth-child({child})"));
            element = wait.Until(condition: ExpectedConditions.ElementToBeClickable(element));
            element.TryClick(driver);
        }

        public static void Close(Card card, IWebDriver driver, WebDriverWait wait)
        {
            Open(card, driver, wait);
        }
    }
}
