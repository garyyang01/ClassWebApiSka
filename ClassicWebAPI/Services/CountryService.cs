using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ClassicWebAPI.Models;
using ClassicWebAPI.Services.Interfaces;
using Newtonsoft.Json;

namespace ClassicWebAPI.Services
{
    class CountryService : ICountryService
    {
        private IHttpClientService _httpClientService;

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