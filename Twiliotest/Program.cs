using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;

namespace Twiliotest
{
    class Example
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Auth Token at twilio.com/user/account
            string AccountSid = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // your auth token
            string AuthToken = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // string to send message to
            string sendto = "+1111111111";
            // your Twilio Number 
            string sendfrom = "+1111111111";
            
            // create a new instance of the client
            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            // create a new message
            var message = twilio.SendMessage(sendfrom, sendto, "This is a sample text message!", "");

            // echo out the SID
            Console.WriteLine("SID:" + message.Sid);
            
            // handle exception
            if (message.RestException != null)
            {
                var error = message.RestException.Message;
                Console.WriteLine(error.ToString());
            }
        }
    }
}
