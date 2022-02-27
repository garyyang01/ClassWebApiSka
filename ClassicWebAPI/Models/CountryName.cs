using Newtonsoft.Json;

namespace ClassicWebAPI.Models
{
    public class CountryName
    {
        [JsonProperty("common")]
        public string Common { get; set; }

        [JsonProperty("official")]
        public string Official { get; set; }
    }
}