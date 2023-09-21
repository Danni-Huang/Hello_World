using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

using Greetings;

namespace GreetingServiceConsoleHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create and open an instance of our service type:
            using (ServiceHost host = new ServiceHost(typeof(GreetingServiceType)))
            {
                // open our host:
                host.Open();

                // and prompt user to enter any key to exit:
                Console.WriteLine("Service running - Press any key to exit");
                Console.ReadKey(true);

                host.Close();
            }
        }
    }
}
