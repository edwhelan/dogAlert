using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Weather_Test.API

{
    class MessagingAPI
    {
        //used to send messages through TWILIO api
        public void SendMessage(string dangerRatingMessage)
        {
            string accountSid = Variables.TwilioSID;
            string authToken = Variables.TwilioAuthToken;

            TwilioClient.Init(accountSid, authToken);
            // actual content of message. TO numer is hardcoded at the moment
            var newMessage = MessageResource.Create(
                body: dangerRatingMessage,
                from: new Twilio.Types.PhoneNumber(Variables.TwilioPhoneNumber),
                to: new Twilio.Types.PhoneNumber(Variables.MyPhoneNumber)
            );

            Console.WriteLine(newMessage.Sid);
        }
    }
}
