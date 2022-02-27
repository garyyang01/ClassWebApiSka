using Newtonsoft.Json;
using System.Collections.Generic;

namespace ClassicWebAPI.Models
{
    public class CountryInfo
    {
        [JsonProperty("name")]
        public CountryName CountryName { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("subregion")]
        public string SubRegion { get; set; }

        [JsonProperty("translations")]
        public Dictionary<string, CountryName> Translations { get; set; }

        [JsonProperty("latlng")]
        public List<double> LatLong { get; set; }

        [JsonProperty("maps")]
        public MapInfo Map { get; set; }

        [JsonProperty("timezones")]
        public List<string> Timezones { get; set; }

        [JsonProperty("flags")]
        public FlagInfo Flag { get; set; }

        [JsonProperty("startOfWeek")]
        public string StartOfWeek { get; set; }
    }
}