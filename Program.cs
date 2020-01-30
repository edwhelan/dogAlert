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

            ForecastResponse forecastResponse = JsonConvert.DeserializeObject<ForecastResponse>(payload);

            //WeatherForecast WeatherForecast = JsonSerializer.Deserialize<WeatherForecast>(data);
            Console.WriteLine(forecastResponse.hourly.data[0].summary);
        }
    }

}