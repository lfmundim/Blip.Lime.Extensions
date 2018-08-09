using Blip.Lime.Extensions.Models;
using Lime.Messaging.Contents;
using Lime.Protocol;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blip.Lime.Extensions.Services
{
    interface ILimeExtensions
    {
        DocumentCollection CreateCarousel(List<DocumentSelect> cards);
        DocumentCollection CreateCarousel(DocumentSelect[] cards);
        DocumentCollection CreateCarousel(List<CarouselCard> cards);
        DocumentCollection CreateCarousel(CarouselCard[] cards);
        CarouselCard CreateCarouselCard(Dictionary<string, string> options, Uri imageUri, string cardText, string cardTitle = "");
        CarouselCard CreateCarouselCard(Dictionary<string, Uri> options, Uri imageUri, string cardText, string cardTitle = "");
        CarouselCard CreateCarouselCard(List<string> options, Uri imageUri, string cardText, string cardTitle = "");
    }
}
