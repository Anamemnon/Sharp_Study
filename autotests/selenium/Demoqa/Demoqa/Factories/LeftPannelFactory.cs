using Demoqa.PageObjects;
using Demoqa.PageObjects.LeftPannel;
using System;

namespace Demoqa.Factories
{
    public class LeftPannelFactory
    {
        public static ILeftPannelVerifier Create(Card card)
        {
            return card switch
            {
                Card.ELEMENTS => new Elements(),
                Card.FORMS => new Forms(),
                Card.BOOK_STORE_APPLICATION => new BookStoreApp(),
                Card.ALERTS_FRAME_WINDOWS => new AlertsFrameWindows(),
                Card.WIDGETS => new Widgets(),
                Card.INTERACTIONS => new Interactions(),
                _ => throw new ArgumentException($"There is no such LeftPannel item: {nameof(card)}")
            };
        }
    }
}
