using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using ClassicWebAPI.Services.Interfaces;

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

    }
}
