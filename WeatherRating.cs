using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Weather_Test
{
    public class WeatherRating
    {
        //consume data to get rating on safety
        //of leaving your dog outside in backyard

        //MVP qualifiers (dog stays inside)
        // too cold for doggos ==========
        //weather average = < 35deg
        //weather average = < 45deg + rain
        //too hot for doggos ============
        //weather > 80deg
        //weather average > 85deg if raining? [source this]

        public void WeatherRatingPrint()
        {
            //return the payload from api
            var payload = new DataFetch().GetPayload();

            //initialize the payload for consumption
            ForecastResponse forecastResponse = JsonConvert.DeserializeObject<ForecastResponse>(payload);
            List<decimal> temperatureArray = new List<decimal>();
            List<double> precipArray = new List<double>();
            //get next 10 hours of weather data
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                temperatureArray.Add(forecastResponse.hourly.data[i].temperature);
                precipArray.Add(forecastResponse.hourly.data[i].precipProbability);
                Console.WriteLine(forecastResponse.hourly.data[i].summary);
                Console.WriteLine(forecastResponse.hourly.data[i].temperature);
                Console.WriteLine(forecastResponse.hourly.data[i].precipProbability);


            }
            Console.WriteLine("===========================");
            temperatureArray.ForEach(Console.WriteLine);



            //float total = 0;
            //foreach (float temp in temperatureArray)
            //{
            //    total = temp + total;
            //}
            decimal average = temperatureArray.Average();
            Console.WriteLine("This is your temperature average over the next 10 hours "+ average);
        }

        
    }
}
