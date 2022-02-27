using Newtonsoft.Json;

namespace ClassicWebAPI.Models.Request
{
    public class GetCountryBySubRegionRequest
    {
        [JsonProperty("SubRegion")]
        public string SubRegion { get; set; }
    }
}