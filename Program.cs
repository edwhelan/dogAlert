using System;
using RestSharp;

namespace Weather_Test
{

    class Program
    {
        static void Main()
        {
            //return the payload from api
            var data = new Data().GetPayload();
            Console.WriteLine(data); 
        }

        
    }

}