using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
    [DataContract(Namespace ="http://conestogac.on.ca/schemas/2023/09/greetings")]
    public class GreetingResponse
    {
        // add an required greeting string prop 
        [DataMember(IsRequired = true)]

        public string Greeting { get; set; }

        // add an required TimeOfDay string prop 
        [DataMember(IsRequired = true)]

        public string TimeOfDay { get; set; }
    }
}
