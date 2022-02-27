using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ClassicWebAPI.Models;
using ClassicWebAPI.Services.Interfaces;
using Newtonsoft.Json;

namespace ClassicWebAPI.Services
{
    public class CountryService : ICountryService
    {
        private readonly IHttpClientService _httpClientService;

        public CountryService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<IEnumerable<CountryInfo>> GetAll()
        {
            
            var httpResponseMessage = await _httpClientService.GetAsync("https://restcountries.com/v3.1/all");
            if (!httpResponseMessage.IsSuccessStatusCode) return null;
            var data = await httpResponseMessage.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<CountryInfo>>(data);
        }

        public async Task<string> GetMapByCountryName(string countryName)
        {
            var httpResponseMessage = await _httpClientService.GetAsync($"https://restcountries.com/v3.1/name/{countryName}");
            if (!httpResponseMessage.IsSuccessStatusCode) return null;
            var result= await httpResponseMessage.Content.ReadAsStringAsync();
            var countryInfos = JsonConvert.DeserializeObject<IEnumerable<CountryInfo>>(result);
            return countryInfos?.FirstOrDefault()?.Map.GoogleMap;
        }
    }

    public interface IHttpClientService
    {
        Task<HttpResponseMessage> GetAsync(string url);
    }

    class HttpClientService : IHttpClientService
    {
        private readonly HttpClient _httpClient;

        public HttpClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            return await _httpClient.GetAsync(url);
        }
    }
}