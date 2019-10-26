using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AML
{

    public class RootJsonObject
    {
        [JsonProperty("Date Generale")]

        public IList<Dictionary<string, dynamic>> GeneralItems { get; set; }
        //[JsonProperty("Asociaţi şi Administratori ce pot fi cu sau fără procentaj")]
        //public string[] Asoc { set; get; }

    }
}
