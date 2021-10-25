using Demoqa.Extensions;
using Demoqa.PageObjects;
using NUnit.Framework;
using System.Threading;

namespace Demoqa.Tests
{
    public class LeftPannelTest : Base
    {
        [Test]
        [TestCase(Card.ELEMENTS, "elements")]
        [TestCase(Card.FORMS, "forms")]
        [TestCase(Card.ALERTS_FRAME_WINDOWS, "alertsWindows")]
        [TestCase(Card.WIDGETS, "widgets")]
        [TestCase(Card.INTERACTIONS, "interaction")]
        [TestCase(Card.BOOK_STORE_APPLICATION, "books")]
        public void Test_ClickByLeftPannelElementShouldOpenOrCloseListOfElements(Card card, string page)
        {
            _driver.Open($"{Constant.TargetSite}{page}");
            LeftPannel.Close(card, _driver, _wait);
            LeftPannel.Open(card, _driver, _wait);

            Thread.Sleep(1000);
        }
    }
}
