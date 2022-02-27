using System.Collections.Generic;
using System.Threading.Tasks;
using ClassicWebAPI.Models;

namespace ClassicWebAPI.Services.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryInfo>> GetAll();
    }
}