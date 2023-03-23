using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PayAuto.Domain.Models
{
    public class StatesResponse
    {
        [Description("Results count")]
        [JsonPropertyName("totalResultsCount")]
        public int ResultsCount { get; set; }

        [Description("Geonames")]
        [JsonPropertyName("geonames")]
        public States StatesList { get; set; }
    }


    public class States
    {
        [Description("State Id")]
        [JsonPropertyName("geonameId")]
        public int Id { get; set; }

        [Description("State Name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    
    public class Uf
    {
        [Description("State Abreviation")]
        [JsonPropertyName("ISO3166_2")]
        public string Code { get; set; }
    }
}
