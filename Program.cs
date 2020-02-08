using Weather_Test.API;

namespace Weather_Test
{   
    class Program
    {
        static void Main()
        {
            //Initialize : get and return weather status/rating for dogs
            //Then send sms message to user
            WeatherRating weatherRating = new WeatherRating();
            MessagingAPI messagingApi = new MessagingAPI();
            //Main execution
            messagingApi.SendMessage(weatherRating.WeatherRatingPrint());

            //weatherRating.WeatherRatingPrint();

        }
    }
}