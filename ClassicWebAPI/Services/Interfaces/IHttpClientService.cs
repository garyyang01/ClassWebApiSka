using System.Net.Http;
using System.Threading.Tasks;

namespace ClassicWebAPI.Services.Interfaces
{
    public interface IHttpClientService
    {
        Task<HttpResponseMessage> GetAsync(string url);
    }
}