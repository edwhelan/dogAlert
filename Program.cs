using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Weather_Test
{   
    class Program
    {
        static void Main()
        {
            //get and return weather status/rating for dogs
            WeatherRating weatherRating = new WeatherRating();

            MessagingAPI messagingApi = new MessagingAPI();

            messagingApi.SendMessage(weatherRating.WeatherRatingPrint());

            //weatherRating.WeatherRatingPrint();

        }
    }
}