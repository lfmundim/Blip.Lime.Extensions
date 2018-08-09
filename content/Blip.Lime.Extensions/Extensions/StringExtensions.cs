using Lime.Messaging.Contents;
using Lime.Protocol;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blip.Lime.Extensions.Extensions
{
    public static class StringExtensions
    {
        public static PlainText ToPlainText(this string s) => PlainText.Parse(s);
        public static DocumentContainer ToDocumentContainer(this string s) => new DocumentContainer { Value = s };
    }
}
