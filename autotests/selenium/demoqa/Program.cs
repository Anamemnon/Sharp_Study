using demoqa.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace demoqa
{
    class HelloSelenium
    {
        static void Main()
        {
            using IWebDriver driver = new FirefoxDriver();

            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl(Constant.TargetSite);

            var card = MainPage.GetCardElement(MainPage.Cards.ELEMENTS, driver);
            card.Click();

            Thread.Sleep(3000);
            //wait.Until(webDriver => webDriver.FindElement(By.CssSelector("h3")).Displayed);
            //IWebElement firstResult = driver.FindElement(By.CssSelector("h3"));
            //Console.WriteLine(firstResult.GetAttribute("textContent"));
        }
    }
}