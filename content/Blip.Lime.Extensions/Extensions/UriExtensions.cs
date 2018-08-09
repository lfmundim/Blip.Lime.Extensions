using Lime.Messaging.Contents;
using Lime.Protocol;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blip.Lime.Extensions.Extensions
{
    public static class UriExtensions
    {
        public static DocumentContainer ToDocumentContainer(this Uri uri, string label) => new DocumentContainer { Value = new WebLink { Uri = uri, Text = label } };
    }
}
