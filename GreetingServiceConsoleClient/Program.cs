using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GreetingServiceConsoleClient.Greetings;

namespace GreetingServiceConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create our proxy object:
            GreetingServiceClient greetingServiceClient = new GreetingServiceClient();

            // call the Greet method on our proxy object which hides all the work of calling out to remote SOAP service
            GreetingResponse greetingResp = greetingServiceClient.Greet(new GreetingRequest() { Recipient = "Bart"});
            
            // write out response:
            Console.WriteLine($"The responses from the service was: {greetingResp.Greeting} (for time of day: {greetingResp.TimeOfDay})");

            greetingResp = greetingServiceClient.Greet(new GreetingRequest());
            Console.WriteLine($"The response from the service was: {greetingResp.Greeting} (for time of day: {greetingResp.TimeOfDay})");
        }
    }
}
