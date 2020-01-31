using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Weather_Test
{
    public class WeatherRating
    {
        //consume data to get rating on safety
        //of leaving your dog outside in backyard

        //MVP qualifiers (dog stays inside)
        // too cold for doggos
        //weather average = < 35deg
        //weather average = < 45deg + rain
        //too hot for doggos
        //weather > 80deg
        //weather average > 85deg if raining? [source this]

        public void WeatherRatingPrint()
        {
            //return the payload from api
            var payload = new DataFetch().GetPayload();

            //initialize the payload for consumption
            ForecastResponse forecastResponse = JsonConvert.DeserializeObject<ForecastResponse>(payload);
            List<float> tempArray = new List<float>();
            //get next 10 hours of weather data
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                tempArray.Add(forecastResponse.hourly.data[i].temperature);
                Console.WriteLine(forecastResponse.hourly.data[i].summary);
                Console.WriteLine(forecastResponse.hourly.data[i].temperature);

            }
            Console.WriteLine(tempArray.ToString());
        }

        
    }
}
