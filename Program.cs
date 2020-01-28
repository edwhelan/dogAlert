using System.Configuration;
using System.Collections.Specialized;
using System;
using RestSharp;
using RestSharp.Authenticators;


namespace HttpClientSample
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var client = new RestClient("https://api.darksky.net/forecast/");
            //client.Authenticator = new HttpBasicAuthenticator("username", "password");

            var request = new RestRequest(Variables.WeatherApi + "/33.735284,-84.371662", Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var response = client.Execute(request);
            Console.WriteLine(response.Content); 
        }

        
    }

}