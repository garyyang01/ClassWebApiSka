using Newtonsoft.Json;

namespace ClassicWebAPI.Models
{
    public class MapInfo
    {
        [JsonProperty("googleMaps")]
        public string GoogleMap { get; set; }

        [JsonProperty("openStreetMaps")]
        public string OpenStreetMap { get; set; }
    }
}