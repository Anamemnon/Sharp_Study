using Demoqa.Extensions;
using Demoqa.PageObjects;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Demoqa.Tests
{
    public class MainPageTest : Base
    {
        [SetUp]
        public void SetUp()
        {
            _driver.Open(Constant.TargetSite);
        }

        [Test]
        [TestCase(Card.ELEMENTS, "elements")]
        [TestCase(Card.FORMS, "forms")]
        [TestCase(Card.ALERTS_FRAME_WINDOWS, "alertsWindows")]
        [TestCase(Card.WIDGETS, "widgets")]
        [TestCase(Card.INTERACTIONS, "interaction")]
        [TestCase(Card.BOOK_STORE_APPLICATION, "books")]
        public async Task Test_ClickByCardShouldOpenRequiredPageAsync(Card card, string page)
        {
            var cardElement = await MainPageObject.GetCardElementAsync(card, _driver, _wait);
            await cardElement.TryClickAsync(_driver);

            var currentUrl = _driver.Url;
            Assert.AreEqual(Constant.TargetSite + page, currentUrl);
        }
    }
}