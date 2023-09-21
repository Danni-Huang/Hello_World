using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Greetings
{
    [DataContract(Namespace = "http://conestogac.on.ca/schemas/2023/09/greetings")]
    public class GreetingRequest
    {
        // add an optional string prop called recipient
        [DataMember(IsRequired = false)]
        public string Recipient { get; set; } = null;

    }
}
