using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PayAuto.Domain.Models
{
    public class States
    {
        [Description("State Id")]
        [JsonPropertyName("geonameId")]
        public int Id { get; set; }

        [Description("State Name")]
        [JsonPropertyName("adminCodes1")]
        public List<Uf> Name { get; set; }
    }
    public class Uf
    {
        [Description("State Abreviation")]
        [JsonPropertyName("ISO3166_2")]
        public string Code { get; set; }
    }
}
