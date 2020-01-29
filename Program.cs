using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Weather_Test
{
    class Hourly
    {

        //time	1580335200
        public DateTime time { get; set; }
        //summary	"Overcast"
        public string summary { get; set; }
        //icon	"cloudy"
        public string icon { get; set; }
        //precipIntensity	0.001
        public double precipIntensity { get; set; }
        //precipProbability	0.05
        public double precipProbability { get; set; }
        //precipType	"rain"
        public string precipType { get; set; }
        //temperature	50
        public float temperature { get; set; }
        //apparentTemperature	48.78
        public float apparentTemperature { get; set; }
        //dewPoint	35.97
        public float dewPoint { get; set; }
        //humidity	0.58
        public double humidity { get; set; }
        //pressure	1015.8
        public float pressure { get; set; }
        //windSpeed	4.12
        public float windSpeed { get; set; }
        //windGust	8.75
        public float windGust { get; set; }
        //windBearing	67
        public float windBearing { get; set; }
        //cloudCover	0.97
        public double cloudCover { get; set; }
        //uvIndex	0
        public float uvIndex { get; set; }
        //visibility	10
        public int visibility { get; set; }
        //ozone	318.1
        public float ozone { get; set; }
    }
    class ConverterSample
    {
        public List<Hourly> DeserializeData(string HourList)
        {

            return JsonSerializer.Deserialize<List<Hourly>>(HourList);
        }


    }
    class Program
    {
        static void Main()
        {
            //return the payload from api
            var data = new Data().GetPayload();

            ConverterSample obj = new ConverterSample();
            var objProduct = new Hourly();

            var productJson = data;
            Console.WriteLine(productJson);
            Console.ReadLine();
            var items = obj.DeserializeData(productJson);


            foreach (var item in items)
            {
                //Console.WriteLine($"{item");
            }
            Console.ReadLine();


            //WeatherForecast WeatherForecast = JsonSerializer.Deserialize<WeatherForecast>(data);
            //Console.WriteLine(WeatherForecast.hourly.ToString()); 
        }
    }

}