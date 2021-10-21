using OpenQA.Selenium;

namespace demoqa.PageObjects
{
    internal class MainPage
    {
        public enum Cards
        {
            ELEMENTS,
            FORMS,
            ALERTS_FRAME_WINDOWS,
            WIDGETS,
            INTERACTIONS,
            BOOK_STORE_APPLICATION
        }

        public static IWebElement GetCardElement(Cards cardName, IWebDriver driver)
        {
            string text = cardName switch
            {
                Cards.ELEMENTS => "Elements",
                Cards.FORMS => "Forms",
                Cards.BOOK_STORE_APPLICATION => "Book Store Application",
                Cards.ALERTS_FRAME_WINDOWS => "Alerts, Frame & Windows",
                Cards.WIDGETS => "Widgets",
                Cards.INTERACTIONS => "Interactions",
                _ => throw new ArgumentException($"There is no such card name: {nameof(cardName)}")
            };

            return driver.FindElement(By.XPath($"//*[@class='card-body']/*[text()='{text}']"));
        }
    }
}
