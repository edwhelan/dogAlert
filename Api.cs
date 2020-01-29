using System;
using RestSharp;

namespace Weather_Test
{
    class Data
    {
        public string GetPayload()
        {
            //Set urlstring with secret.cs file exlcuded from .git
            var client = new RestClient("https://api.darksky.net/forecast/");
            //current set lat/long is for atlanta grant park area.
            var request = new RestRequest(Variables.WeatherApi + "/33.735284,-84.371662", Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var response = client.Execute(request);
            var payload = response.Content;
            //return the content of response to be used
            return payload;
        }

        //get next 10 hours of weather data.
        //time looks to be stored in UST
        
    }
}
