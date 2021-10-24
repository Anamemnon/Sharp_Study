using Demoqa.PageObjects;
using System;

namespace Demoqa
{
    public static class CardExtension
    {
        public static string GetLabel(this Card cardName)
        {
            return cardName switch
            {
                Card.ELEMENTS => "Elements",
                Card.FORMS => "Forms",
                Card.BOOK_STORE_APPLICATION => "Book Store Application",
                Card.ALERTS_FRAME_WINDOWS => "Alerts, Frame & Windows",
                Card.WIDGETS => "Widgets",
                Card.INTERACTIONS => "Interactions",
                _ => throw new ArgumentException($"There is no such card name: {nameof(cardName)}")
            };
        }
    }
}
