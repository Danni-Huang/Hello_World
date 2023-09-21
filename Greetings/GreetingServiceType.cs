using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
    // implements the IGreetingService interface
    public class GreetingServiceType: IGreetingService
    {
        public GreetingResponse Greet(GreetingRequest greatingRequest)
        {
            Console.WriteLine("In Greet operation on service");
            int currHour = DateTime.Now.Hour;
            string baseGreeting;
            string timeOfDay;

            if (currHour < 12)
            {
                baseGreeting = "Good morning";
                timeOfDay = "morning";
            }
            else if (currHour >= 12 && currHour < 18)
            {
                baseGreeting = "Good afternoon";
                timeOfDay = "afternoon";
            }
            else
            {
                baseGreeting = "Good evening";
                timeOfDay = "evening";
            }

            string greeting;
            if (greatingRequest != null && !string.IsNullOrEmpty(greatingRequest.Recipient))
                greeting = $"{baseGreeting} {greatingRequest.Recipient}";
            else
                greeting = $"Hey there, {baseGreeting.ToLower()}";

            return new GreetingResponse() { Greeting = greeting, TimeOfDay = timeOfDay };
        }
    }
}
