using Demoqa.Extensions;
using Demoqa.PageObjects;
using NUnit.Framework;

namespace Demoqa.Tests
{
    public class MainPageTest : Base
    {
        [Test]
        [TestCase(Card.ELEMENTS, "elements")]
        [TestCase(Card.FORMS, "forms")]
        [TestCase(Card.ALERTS_FRAME_WINDOWS, "alertsWindows")]
        [TestCase(Card.WIDGETS, "widgets")]
        [TestCase(Card.INTERACTIONS, "interaction")]
        [TestCase(Card.BOOK_STORE_APPLICATION, "books")]
        public void Test_ClickByCardShouldOpenRequiredPage(Card card, string page)
        {
            _driver.Navigate().GoToUrl(Constant.TargetSite);

            var cardElement = MainPageObject.GetCardElement(card, _driver, _wait);
            cardElement.TryClick(_driver);

            var currentUrl = _driver.Url;
            Assert.AreEqual(Constant.TargetSite + page, currentUrl);
        }
    }
}