using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading.Tasks;

namespace Demoqa.PageObjects
{
    public class MainPageObject : BasePageObject
    {

        async public static Task<IWebElement> GetCardElementAsync(Card card, IWebDriver driver, WebDriverWait wait)
        {
            string text = card.GetLabel();
            //var element = driver.FindElement(By.XPath($"//*[@class='card-body']/*[text()='{text}']"));
            var element = await Task.Run(() => driver.FindElement(By.XPath($"//*[text()='{text}']/../../.."))); ;

            return await Task.Run(() => wait.Until(condition: ExpectedConditions.ElementToBeClickable(element)));
        }
    }
}
