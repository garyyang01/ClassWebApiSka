using ClassicWebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ClassicWebAPI.Models.Request;
using ClassicWebAPI.Models.Response;

namespace ClassicWebAPI.Controllers
{
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public IActionResult Welcome()
        {
            return Ok("Welcome to ClassicWebAPI.");
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            return new JsonResult(await _countryService.GetAll());
        }

        [HttpGet]
        public async Task<IActionResult> Map(string country)
        {
            var mapUrl = await _countryService.GetMapByCountryName(country);
            if (mapUrl == null)
            {
                return Ok("Country Not Found");
            }

            return Redirect(mapUrl);
        }

        [HttpPost]
        public async Task<IActionResult> GetCountryBySubRegion([FromBody] GetCountryBySubRegionRequest request)
        {
            var countriesName = await _countryService.GetCountryBySubRegion(request.SubRegion);
            if (countriesName == null)
            {
                return Ok("Country Not Found");
            }

            return Ok(new GetCountryBySubRegionResponse
            {
                SubRegion = request.SubRegion,
                Countries = countriesName
            });
        }
    }
}