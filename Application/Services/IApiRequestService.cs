using Application.Configurations;

namespace Application.Services;

public interface IApiRequestService
{
    Task<T?> Get<T>(ExternalApiConfiguration externalApiConfiguration, Dictionary<string, string> _params);
}