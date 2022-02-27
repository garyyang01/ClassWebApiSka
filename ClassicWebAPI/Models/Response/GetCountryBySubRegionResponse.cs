using System.Collections.Generic;

namespace ClassicWebAPI.Models.Response
{
    public class GetCountryBySubRegionResponse
    {
        public string SubRegion { get; set; }
        public List<string> Countries { get; set; }
    }
}