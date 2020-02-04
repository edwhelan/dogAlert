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

        private string LoadPayload()
        {
            //get the payload from api
            var payload = new DataFetch().GetPayload();

            //initialize the payload for consumption
            ForecastResponse forecastResponse = JsonConvert.DeserializeObject<ForecastResponse>(payload);
            return payload;
        }

        public string WeatherRatingPrint()
        {
            //get the payload from api
            var payload = new WeatherRating().LoadPayload();

            //initialize the payload for consumption
            ForecastResponse forecastResponse = JsonConvert.DeserializeObject<ForecastResponse>(payload);
            //create Lists for temp and precip
            List<decimal> temperatureArray = new List<decimal>();
            List<double> precipArray = new List<double>();

            //store next 10 hours of weather data
            // both temperature and precipitation probability
            for (int i = 0; i < 10; i++)
            {
                temperatureArray.Add(forecastResponse.hourly.data[i].temperature);
                precipArray.Add(forecastResponse.hourly.data[i].precipProbability);
                Console.WriteLine(UnixTimeStampToDateTime(forecastResponse.hourly.data[i].time));
                //Console.WriteLine(forecastResponse.hourly.data[i].temperature);
                //Console.WriteLine(forecastResponse.hourly.data[i].precipProbability);
            }
            Console.WriteLine("===========================");
            temperatureArray.ForEach(Console.WriteLine);
            Console.WriteLine("===========================");
            precipArray.ForEach(Console.WriteLine);
            Console.WriteLine("===========================");

            //Call average temperature ratin method
            decimal tempAverage = temperatureArray.Average();
            Console.WriteLine("This is your temperature average over the next 10 hours " + tempAverage);

            //Call average precip rating method
            double precipAverage = precipArray.Average();
            Console.WriteLine("This is your precipitation probability average over the next 10 hours " + precipAverage);

            Console.WriteLine(DogSafetyCheck(tempAverage, precipAverage));
            return DogSafetyCheck(tempAverage, precipAverage);
        }

        // too cold for doggos ==========
        //weather average = < 35deg
        //weather average = < 45deg + rain
        //too hot for doggos ============
        //weather > 80deg
        //weather average > 85deg if raining?
        public string DogSafetyCheck(decimal temperatureAverage, double precipAverage)
        {
            if ((temperatureAverage <= 35) || (precipAverage >= .5 && temperatureAverage <= 40))
            {
                Console.WriteLine("FTC : It is too cold to leave your dogs outside today.");
                return "It is too cold to leave your dogs outside today.";
            }
            else if (temperatureAverage >= 80)
            {
                Console.WriteLine("FTC: It is too hot to leave your dogs outside today!");
                return "It is too hot to leave your dogs outside today!";
            } 
            else
            {
                Console.WriteLine("FTC : Your dogs may be left outside today!");
                return "Your dogs may be left outside today!";
            }
        }

        //UTC time converter helper method
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}
