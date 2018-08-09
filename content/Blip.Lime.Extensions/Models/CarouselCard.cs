using Lime.Messaging.Contents;
using Lime.Protocol;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blip.Lime.Extensions.Models
{
    public class CarouselCard : Document
    {
        public static MediaType MEDIA_TYPE = DocumentSelect.MediaType;

        public CarouselCard(CardBody body, List<CardOption> options) : base(MEDIA_TYPE)
        {
            Body = body;
            Options = options;
        }

        public CardBody Body { get; set; }
        public List<CardOption> Options { get; set; }
    }
}
