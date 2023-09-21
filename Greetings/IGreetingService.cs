using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
    [ServiceContract()]
    internal interface IGreetingService
    {
        // one method that does not take any args ad returns a string:
        [OperationContract()]
        GreetingResponse Greet(GreetingRequest greatingRequest);
    }
}
