using Lime.Messaging.Contents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blip.Lime.Extensions.Models
{
    public class MediaCardBody : CardBody
    {
        public MediaCardBody(Uri uri, string text, string title = "")
        {
            Value = new MediaLink
            {
                AspectRatio = "1:1",
                Uri = uri,
                Title = title,
                Text = text
            };
        }

        public MediaCardBody(string text, string title = "")
        {
            Value = new MediaLink
            {
                AspectRatio = "1:1",
                Title = title,
                Text = text
            };
        }
    }
}
