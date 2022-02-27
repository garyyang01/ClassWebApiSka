using Newtonsoft.Json;

namespace ClassicWebAPI.Models
{
    public class FlagInfo
    {
        [JsonProperty("png")]
        public string Png { get; set; }
        [JsonProperty("svg")]
        public string Svg { get; set; }
    }
}