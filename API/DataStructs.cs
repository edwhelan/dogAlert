﻿using System;
using System.Collections.Generic;

namespace Weather_Test
{
    //getters/setters for api response listed below.
    class ForecastResponse
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string timezone { get; set; }
        public float offset { get; set; }
        public Hourly hourly { get; set; }

    }

    class Hourly
    {
        public string summary { get; set; }
        public string icon { get; set; }
        public List<HourlyForecast> data { get; set; }
    }

    class HourlyForecast
    {
        //time	1580335200
        public long time { get; set; }
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
        public decimal temperature { get; set; }
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
        public float visibility { get; set; }
        //ozone	318.1
        public float ozone { get; set; }
    }
}
