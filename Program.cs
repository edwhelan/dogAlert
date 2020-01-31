using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Weather_Test
{

    
    class Program
    {
        static void Main()
        {
            //return the payload from api
            var payload = new DataFetch().GetPayload();

            //initialize the payload for consumption
            ForecastResponse forecastResponse = JsonConvert.DeserializeObject<ForecastResponse>(payload);

            //get next 10 hours of weather data
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(forecastResponse.hourly.data[i].summary);
            }

            //Console.WriteLine(forecastResponse.hourly.data[0].summary);
        }
    }

}