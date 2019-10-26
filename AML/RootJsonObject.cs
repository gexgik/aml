using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AML
{
    [JsonObject(Title = "Date Generale")]

    public class RootJsonObject
    {
        [JsonProperty("nume")]
        public string Name { get; set; }



    }
}
