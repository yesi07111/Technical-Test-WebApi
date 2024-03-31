using System.Net.Http.Json;
using Application.Configurations;
using Application.Services;

namespace Infraestructure.Services;

public class ApiRequestService : IApiRequestService
{
    public async Task<T?> Get<T>(ExternalApiConfiguration externalApiConfiguration, Dictionary<string, string> _params)
    {
        var client = new HttpClient();
        var url = $"{externalApiConfiguration.BaseUrl}?key={externalApiConfiguration.ApiKey}";

        foreach (var elem in _params)
        {
            url += $"&{elem.Key}={elem.Value}";
        }

        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            var data = await response.Content.ReadFromJsonAsync<T>();
            return data;
        }

        return default;
    }
}