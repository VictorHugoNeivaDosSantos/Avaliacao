using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliaçãoTecnobyte.Models
{
    public class DistrictUF
    {
        [JsonProperty("nome")]
        public string Name { get; set; }
    }
}
