using Blip.Lime.Extensions.Models;
using Lime.Messaging.Contents;
using Lime.Protocol;
using System;
using System.Collections.Generic;

namespace Blip.Lime.Extensions.Services
{
    public class LimeExtensions : ILimeExtensions
    {
        #region Carousel
        /// <summary>
        /// Creates a Carousel from a List of DocumentSelect
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public DocumentCollection CreateCarousel(List<DocumentSelect> cards)
        {
            var cardArray = cards.ToArray();
            return CreateCarousel(cardArray);
        }

        /// <summary>
        /// Creates a Carousel from an Array of DocumentSelect
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public DocumentCollection CreateCarousel(DocumentSelect[] cards)
        {
            return new DocumentCollection
            {
                Items = cards,
                ItemType = DocumentSelect.MediaType,
                Total = cards.Length
            };
        }

        /// <summary>
        /// Creates a Carousel from a List of CarouselCard
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public DocumentCollection CreateCarousel(List<CarouselCard> cards)
        {
            var cardArray = cards.ToArray();
            return CreateCarousel(cardArray);
        }

        /// <summary>
        /// Creates a Carousel from an Array of CarouselCard
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public DocumentCollection CreateCarousel(CarouselCard[] cards)
        {
            return new DocumentCollection
            {
                Items = cards,
                ItemType = DocumentSelect.MediaType,
                Total = cards.Length
            };
        }
        #endregion

        #region Carousel Card
        /// <summary>
        /// Creates a carousel card with an image and payload-enabled options (up to 3 options)
        /// </summary>
        /// <param name="options"></param>
        /// <param name="imageUri"></param>
        /// <param name="cardText"></param>
        /// <param name="cardTitle"></param>
        /// <returns></returns>
        public CarouselCard CreateCarouselCard(Dictionary<string, string> options, Uri imageUri, string cardText, string cardTitle = "") //TODO change to generics
        {
            var body = GenerateBody(imageUri, cardText, cardTitle);
            var cardOptions = new List<CardOption>();
            foreach (var option in options)
            {
                var item = new CardOption(option.Key, option.Value);
                cardOptions.Add(item);
            }
            return new CarouselCard(body, cardOptions);
        }
        /// <summary>
        /// Creates a carousel card with an image and Uri options (up to 3 options)
        /// </summary>
        /// <param name="options"></param>
        /// <param name="imageUri"></param>
        /// <param name="cardText"></param>
        /// <param name="cardTitle"></param>
        /// <returns></returns>
        public CarouselCard CreateCarouselCard(Dictionary<string, Uri> options, Uri imageUri, string cardText, string cardTitle = "") //TODO change to generics
        {
            var body = GenerateBody(imageUri, cardText, cardTitle);
            var cardOptions = new List<CardOption>();
            foreach (var option in options)
            {
                var item = new CardOption(option.Key, option.Value);
                cardOptions.Add(item);
            }
            return new CarouselCard(body, cardOptions);
        }

        /// <summary>
        /// Creates a carousel card with an image and simple options (up to 3 options)
        /// </summary>
        /// <param name="options"></param>
        /// <param name="imageUri"></param>
        /// <param name="cardText"></param>
        /// <param name="cardTitle"></param>
        /// <returns></returns>
        public CarouselCard CreateCarouselCard(List<string> options, Uri imageUri, string cardText, string cardTitle = "")
        {
            var body = GenerateBody(imageUri, cardText, cardTitle);
            var cardOptions = new List<CardOption>();
            foreach (var option in options)
            {
                var item = new CardOption(option);
                cardOptions.Add(item);
            }
            return new CarouselCard(body, cardOptions);
        }

        private static MediaCardBody GenerateBody(Uri imageUri, string cardText, string cardTitle)
        {
            MediaCardBody body;
            if (imageUri.ToString().IsNullOrEmpty())
            {
                body = new MediaCardBody(cardText, cardTitle);
            }
            else
            {
                body = new MediaCardBody(imageUri, cardText, cardTitle);
            }

            return body;
        }
        #endregion
    }
}
