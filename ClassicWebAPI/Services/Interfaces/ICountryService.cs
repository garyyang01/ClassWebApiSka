using ClassicWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassicWebAPI.Services.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryInfo>> GetAll();

        Task<string> GetMapByCountryName(string countryName);

        Task<List<string>> GetCountryBySubRegion(string subRegion);
    }
}