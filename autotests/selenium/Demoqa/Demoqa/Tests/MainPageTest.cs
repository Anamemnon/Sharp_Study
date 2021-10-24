using Demoqa.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;

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
        public void Test_ClickByCardShouldOpenRequiredPage(Card card, string cardPath)
        {
            WebDriverWait wait = new(_driver, TimeSpan.FromSeconds(10));
            _driver.Navigate().GoToUrl(Constant.TargetSite);

            //var cardElement = MainPageObject.GetCardElement(card, _driver);
            var cardElement = wait.Until((driver) => MainPageObject.GetCardElement(card, driver));

            cardElement.Click();

            var currentUrl = _driver.Url;
            Assert.AreEqual(Constant.TargetSite + cardPath, currentUrl);
        }
    }
}