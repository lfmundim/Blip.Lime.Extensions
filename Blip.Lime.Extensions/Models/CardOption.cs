using Blip.Lime.Extensions.Extensions;
using Lime.Messaging.Contents;
using System;

namespace Blip.Lime.Extensions.Models
{
    public class CardOption : DocumentSelectOption
    {
        public CardOption(string text)
        {
            Label = text.ToDocumentContainer();
            Value = text.ToDocumentContainer();
        }

        public CardOption(string text, string payload)
        {
            Label = text.ToDocumentContainer();
            Value = payload.ToDocumentContainer();
        }

        public CardOption(string text, Uri uri)
        {
            Label = uri.ToDocumentContainer(text);
        }
    }
}