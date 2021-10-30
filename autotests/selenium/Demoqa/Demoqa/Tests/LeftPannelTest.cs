using Demoqa.Extensions;
using Demoqa.Factories;
using Demoqa.PageObjects;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Demoqa.Tests
{
    public class LeftPannelTest : Base
    {
        [Test]
        [TestCase(Card.ELEMENTS, "elements")]
        //[TestCase(Card.FORMS, "forms")]
        //[TestCase(Card.ALERTS_FRAME_WINDOWS, "alertsWindows")]
        //[TestCase(Card.WIDGETS, "widgets")]
        //[TestCase(Card.INTERACTIONS, "interaction")]
        //[TestCase(Card.BOOK_STORE_APPLICATION, "books")]
        public async Task Test_ClickByLeftPannelElementShouldOpenOrCloseListOfElementsAsync(Card card, string page)
        {
            await _driver.OpenAsync($"{Constant.TargetSite}{page}");
            LeftPannelObject.Close(card, _driver, _wait);
            LeftPannelObject.Open(card, _driver, _wait);

            LeftPannelObject.ShouldContainsAllItems(LeftPannelFactory.Create(card));
        }
    }
}
