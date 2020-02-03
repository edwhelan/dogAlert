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

            weatherRating.WeatherRatingPrint();

        }
    }
}